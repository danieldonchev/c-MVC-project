$(document).ready(function () {
    $("#movie-search").on('input', function (event) {
        console.log(event);
        $.ajax({
            url: 'http://www.omdbapi.com/?s=' + event.target.value + '*',
            dataType: 'json'
        }).done(function (result) {
            if (result.Search)
            {
                
                var suggestions = result.Search.map(function (obj) {
                    var poster = obj.Poster == "N/A" ? "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" : obj.Poster;
                    return {
                        title: obj.Title,
                        poster: poster,
                        id: obj.imdbID
                    };
                });
                console.log(suggestions);
                var movies = new Bloodhound({
                    datumTokenizer: function (datum) {
                        return Bloodhound.tokenizers.whitespace(datum.title);
                    },
                    queryTokenizer: Bloodhound.tokenizers.whitespace,
                    local: suggestions,
                    limit: 10
                });
                movies.initialize();
                $('#movie-search').typeahead('destroy');
                $('#movie-search').typeahead({
                    hint: true,
                    highlight: false,
                    minLength: 1
                },
                {
                    name: 'suggestions',
                    source: movies.ttAdapter(),
                    displayKey: 'title',
                    templates: {
                        empty: [
                            '<div class="empty-message">',
                                'unable to find any Best Picture winners that match the current query',
                             '</div>'
                        ].join('\n'),
                        suggestion: function (data) {
                            console.log(data);
                            return '<div class="suggestion-item clearfix"><a href="/Movies/Movies/' + data.id + '"><div class="col-xs-3"><img class="movie-thumbnail" src="' + data.poster + '"></div><div class="col-xs-9"><p>' + data.title + '</p></div></a></div>';
                        }
                    }
                });
                $('#movie-search').focus();
            }
       })
    })
})