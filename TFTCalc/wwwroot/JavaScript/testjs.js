let btn = document.getElementsByClassName("send")[0];
console.log(btn);

btn.addEventListener('click', event => {
    btn.textContent = `Click count: ${event.detail}`;
});