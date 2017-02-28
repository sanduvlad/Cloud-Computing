var chat;
chat = $.connection.ChatHub;
$.connection.hub.start();
$.extend(chat.client, {
    ReceiveMessage: function (message) {
        var para = "<p>" + message + "</p>";
        $('#messagesBox').append(para);

        $('#messagesBox').scrollTop(document.getElementById('messagesBox').scrollHeight);
    }
});




function SendMessage() {
    var mess = $('#messageTextBox').val();

    

    chat.server.sendMessage(mess);
}

document.getElementById("buttonSend").addEventListener("click", SendMessage, false);