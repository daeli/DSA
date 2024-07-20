
const findMaxProfit = (prices) => {
    let maxProfit = 0;
    let buy = prices[0];
    for(let i = 1; i < prices.length; i++){
        const sell = prices[i];
        if(sell > buy){
            const profit = sell - buy;
            if(profit > maxProfit){
                maxProfit = profit;
            }
        }else{
            buy = prices[i];
        }
    }
    return maxProfit;
};


const test1 = findMaxProfit([7, 1, 5, 3, 6, 4]);
console.log('test1', test1);


const test2 = findMaxProfit([7, 6, 4, 3, 1]);
console.log('test2', test2);