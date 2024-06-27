Describe "Get-MoviesFromCsv" {
    Context "When CSV file path is provided" {
        It "Should return all movies from the CSV file" {
            # Arrange
            $csvFilePath = "C:\path\to\movies.csv"

            # Act
            $result = Get-MoviesFromCsv -CsvFilePath $csvFilePath

            # Assert
            $result | Should -Contain "Movie 1 (2021)"
            $result | Should -Contain "Movie 2 (2022)"
            $result | Should -Contain "Movie 3 (2023)"
        }
    }

    Context "When CSV file path and year are provided" {
        It "Should return movies from the specified year" {
            # Arrange
            $csvFilePath = "C:\path\to\movies.csv"
            $year = 2022

            # Act
            $result = Get-MoviesFromCsv -CsvFilePath $csvFilePath -Year $year

            # Assert
            $result | Should -Contain "Movie 2 (2022)"
        }
    }
}

Describe "Get-MoviesFromCsv" {
    Context "When CsvFilePath is provided" {
        It "Should return movies from the CSV file" {
            # Arrange
            $csvFilePath = "C:\path\to\movies.csv"

            # Act
            $result = Get-MoviesFromCsv -CsvFilePath $csvFilePath

            # Assert
            $result | Should -Contain "Movie 1 (2021)"
            $result | Should -Contain "Movie 2 (2022)"
            # Add more assertions for other movies in the CSV file
        }
    }

    Context "When CsvFilePath and Year are provided" {
        It "Should return movies from the CSV file that match the specified year" {
            # Arrange
            $csvFilePath = "C:\path\to\movies.csv"
            $year = 2021

            # Act
            $result = Get-MoviesFromCsv -CsvFilePath $csvFilePath -Year $year

            # Assert
            $result | Should -Contain "Movie 1 (2021)"
            # Add more assertions for other movies in the CSV file that match the specified year
        }
    }
}