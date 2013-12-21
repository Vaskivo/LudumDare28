var isQuit = false;
var isCredits = false;

function OnMouseEnter() {
    //change text color
    renderer.material.color = Color.red;
}

function OnMouseExit() {
    //change text color
    renderer.material.color = Color.white;
}

function OnMouseUp() {
    //is this quit
    if (isQuit == true) {
        //quit the game
        Application.Quit();
    }
    else if (isCredits) {
        Application.LoadLevel("Credits");
    }else{
        //load level
        Application.LoadLevel("protogame");
    }
}

function Update() {
    //quit game if escape key is pressed
    if (Input.GetKey(KeyCode.Escape)) {
        Application.Quit();
    }
}