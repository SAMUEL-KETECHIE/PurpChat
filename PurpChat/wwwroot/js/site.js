let createGroupBtn = document.getElementById('create-group');
let createPrivateBtn = document.getElementById('create-private');

let createChatModal = document.getElementById('create-chat-modal');
let createPrivateModal = document.getElementById('create-private-modal');

createGroupBtn.addEventListener("click", function() {
    createChatModal.classList.add('mod-active');
});

var closeModal = function (event) {
    event.preventDefault();
    createChatModal.classList.remove('mod-active');
    createPrivateModal.classList.remove('mod-active');
};

createPrivateBtn.addEventListener("click", function () {
    createPrivateModal.classList.add('mod-active');
});

//close-modal-btn