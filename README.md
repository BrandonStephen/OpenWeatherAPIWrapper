# Open-Weather API Wrapper Testing Tool

This API wrapper makes testing the open-weather API extremely easy. It does this by extracting all the information from the returned JSON file and storing them in  a methodically prepared sub class system which allows **YOU!** to easily extract information without the hassle of finding it **Yourself**.


# Getting Started

The first thing you will have to do is navigate to the App.settings file and update the 

# Dependencies

- RestSharp
- NUnit
- NUnit3Adapter

# What is already being tested? 

Currently, there are four main objectives that are being tested, however, due to the simplicity of the API Wrapper, we are able to test every data entry within the JSON file returned. 

Here is a little list of exactly what is being tested

- Checking if the data returned matches a predefined selection
- Checks if the data type is correct
- Checks if the status code is 200
- Checks that there isnt any API key validation errors
- Checks if the city queried is the one returned. 

As mentioned before, one of the dependencies is NUnit. Which means this API Wrapper is heavily dependent on **Assert**. 

Here is an example:

`Assert.AreEquals(Value1, Value2);`

Every test is currently performed with this framework. However, you are not restricted to just using this Framework since the Wrapper is not dependent on it. 

# Things that need to be Added

1. Ability to access the headers information with the same simplicity
