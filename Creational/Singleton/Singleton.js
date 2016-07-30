//
//  Singleton implementation in JavaScript / ECMAScript 6
//                By Matheus Avellar and Milena Veríssimo
//                                         July 29th 2016

"use strict";

class Player {
    constructor() {
        //  Player properties go here. Ex:
        //  this.name = "Mario";
        let _instance = null;
    }
  
    get Instance() {
        if (this._instance == null) {
            this._instance = new Player();
        }
        return this._instance;
    }
}

//  Called by declaring a variable as "new Player();". Ex:
//  let mario = new Player();
