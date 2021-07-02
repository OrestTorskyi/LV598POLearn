Feature: Tests

@mytag
 Scenario: Searching product search
        Given Website is opened
        When Click on search field
        When The product is typed in search field{t}
        When The searching button is clicked
        Then Error must be No results were found for your search "{t}"