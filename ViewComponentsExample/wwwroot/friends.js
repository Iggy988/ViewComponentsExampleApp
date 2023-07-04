document.querySelector("#load-friends-button").addEventListener("click", async function () {
    // mora parametar da se slaze sa route name
    // opciono mozemo ubaciti tip requesta (GET)
    var response = await fetch("friends-list", { method: "GET" });
    var responseBody = await response.text();

    document.querySelector("#list").innerHTML = responseBody;
});