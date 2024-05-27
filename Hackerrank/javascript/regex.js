'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

function getLetter(s) {
    let letter;
    // Write your code here
    let firstLetter = s.charAt(0);
    
    if(/^[aeiou]+$/.test(firstLetter)){
        letter = 'A';
    }else if(/^[bcdfg]+$/.test(firstLetter)){
        letter = 'B';
    }else if(/^[hjklm]+$/.test(firstLetter)){
        letter = 'C';
    }else if(/^[npqrstvwxyz]+$/.test(firstLetter)){
        letter = 'D';
    }

    return letter;
}


function main() {
    const s = readLine();
    
    console.log(getLetter(s));
}