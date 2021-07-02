Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecTests/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
 Scenario: test
        
        //Given Open browser
        Given Website is opened
        When Click on search field
        When The product is typed in search field{t}
        When The searching button is clicked
        Then Error must be No results were found for your search "{t}"