
/**
 * event for API call to the server
 * @param {any} url
 * @param {any} method
 * @param {any} dataType
 * @param {any} contentType
 * @param {any} callBackParameter
 * @param {any} callBack
 */
var doAPIRequest = function (url, method, dataType, contentType, callBackParameter, callBack) {
    //function will be called on button click having id btnsave
    $.ajax({
        url: url,
        type: type,
        data: data,
        dataType: dataType
    })
        .done(function (data) {
            return callback(data, callBackParameter);
        })
        .fail(function (xhr, textStatus, errorThrown) {
            console.log("xhr object: ", xhr);
            console.log(textStatus);
            console.log(errorThrown);
            let data = { err: errorThrown, textStatus: textStatus, xhr: xhr };
            return callback(data);
        });
};