/**
 * Given an array arr and a function fn, return a sorted array sortedArr. You can assume fn only returns numbers and those numbers determine the sort order of sortedArr. sortedArray must be sorted in ascending order by fn output.

You may assume that fn will never duplicate numbers for a given array.

 

Example 1:

Input: arr = [5, 4, 1, 2, 3], fn = (x) => x
Output: [1, 2, 3, 4, 5]
Explanation: fn simply returns the number passed to it so the array is sorted in ascending order.

Example 2:

Input: arr = [{"x": 1}, {"x": 0}, {"x": -1}], fn = (d) => d.x
Output: [{"x": -1}, {"x": 0}, {"x": 1}]
Explanation: fn returns the value for the "x" key. So the array is sorted based on that value.

Example 3:

Input: arr = [[3, 4], [5, 2], [10, 1]], fn = (x) => x[1]
Output: [[10, 1], [5, 2], [3, 4]]
Explanation: arr is sorted in ascending order by number at index=1. 

 

Constraints:

    arr is a valid JSON array
    fn is a function that returns a number
    1 <= arr.length <= 5 * 105


 * @param {Array} arr
 * @param {Function} fn
 * @return {Array}
 */
var sortBy = function(arr, fn) {
    let mp = new Map();

    for(let i = 0; i< arr.length; i++){
        mp.set(fn(arr[i]), arr[i]);
    } 

    let array = [...mp].sort((a, b) => a[0] - b[0]);

    //console.log(array);

    let newMap = new Map(array);

   // console.log(newMap);

    return [...newMap.values()];
};

//best solution. Apply the function when compare in the sorting
var sortBy = function(arr, fn) {
    arr.sort((a, b) => {
        return fn(a) - fn(b)
    })
    return arr;
};