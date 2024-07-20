

const TestRun = ()=>{

    var testSting = '((SomeLetters))';
    var i = testSting.indexOf('(');

    var j = testSting.lastIndexOf('(');
    
    var x = testSting.indexOf(')');
    
    console.log("Index of (",i);

    console.log("Last index of (",j);
    
    console.log("Last index of )",x);

    let newString = testSting.substring(j+1, x-1);

    // for(let i = 0; i < testSting.length; i++){
    //     console.log(i);
    //     console.log(testSting[i]);
    //     if(testSting[i] !== '(' && testSting[i] !== ')'){            
    //         newString += testSting[i];
    //     }
    // }
    console.log('newString', newString);
}

TestRun();