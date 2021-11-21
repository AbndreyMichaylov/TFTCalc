let btn = document.getElementsByClassName("send")[0];
console.log(btn);

btn.addEventListener('click', event => {
    fetch('Send')
        .then((response) => {
            return response.json();
        })
        .then((data) => {
            console.log(data);
        });
});