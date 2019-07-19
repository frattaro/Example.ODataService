var app = require('./app');

var context = {
    done: function (output) {
        console.log(JSON.stringify(output));
        console.log("Lambda Function Complete");
    }
};

app.handler({}, context);