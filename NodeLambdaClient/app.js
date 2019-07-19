const odata = require('odata-client');

exports.handler = function (event, context) {
    var q = odata({ service: 'http://localhost:5000', resources: 'Users' });

    q.top(2).get()
        .then(function (response) {
            context.done(JSON.parse(response.body).value);

            // Keep command window from closing.
            require('readline').createInterface(process.stdin, process.stdout).question("Press [Enter] to exit...", function () { process.exit(); });
        });
};
