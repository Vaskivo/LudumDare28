var isRestart = false;

function OnMouseEnter() {
    //change text color
    renderer.material.color = Color.red;
}

function OnMouseExit() {
    //change text color
    renderer.material.color = Color.white;
}

function OnMouseUp() {
    if (isRestart == true) {
        Application.LoadLevel("protogame");
    } else {
        Application.LoadLevel("MainMenu");
    }
}