# TaxCalulator

1. To add the DB server please go to DataRepository folder then sql then TaxDbContext
2. Controllers has 2 files (HomeController and Report Controller) to send the data to the view to display the data captured.
3. The Model has 2 folders (DbModel used with Entity Framework Core 
(EF Core) to work with the database where  & the View Models contains more than one model data required for a particular view)
4. Views folder has 2 Razor pages view File the home and Report.
5. The DataService folder is where all the calculation are done
    . The tax Calculation are done in the data service folder under TaxCalculator folder as follow
        - FlatRateTaxCalculator a class to Calculate the Flat Rate based on the user input
        - FlatValueTaxCalculator a class to Calculate the Falt Value based on the user input
        - ITaxCalculator this an interface that is extended by all 3 other classes
        - ProgressiveTaxCalculator a class to Calculate the Progressive Tax
    . The model folder has a class named CalculationResponse whih return all reponse after calculation
6. The script containing the database table to be used is included and located under the main folder.

