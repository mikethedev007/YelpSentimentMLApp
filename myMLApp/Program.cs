
using MyMLApp;

//add input data
var sampleData = new SentimentModel.ModelInput()
{
    Col0 = "This Restaurant was wonderful."
};

//Load model and Predict output of sample data
var result = SentimentModel.Predict(sampleData);

//If the Prediction is 1 then Positive; otherwise Prediction is Negative
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";

Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
