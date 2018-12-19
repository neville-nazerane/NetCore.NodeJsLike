# NetCore.NodeJsLike
use node js syntax on .net core

Following is test code within the sample App:

    var http = require(_http_);
    var url = require(_url_);

    http.createServer((req, res) => {
        var path = url.parse(req.url, true);

        console.log("url found");
        console.log("host", path.host);
        console.log("path", path.pathname);
        console.log("search", path.search);

        if (path.pathname == "/")
        {
            res.writeHead(404);
            res.write("Try /test");
            res.end();
        }
        if (path.pathname == "/test")
        {
            res.writeHead(200);
            res.write("Hello world");
            res.end();
        }
    }).listen(8080);
