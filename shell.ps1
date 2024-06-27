function Get-MoviesFromCsv {
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$true)]
        [string]$CsvFilePath,

        [Parameter(Mandatory=$false)]
        [int]$Year
    )

    $movies = Import-Csv -Path $CsvFilePath

    if ($Year) {
        $movies = $movies | Where-Object { $_.Year -eq $Year }
    }

    foreach ($movie in $movies) {
        Write-Output "$($movie.Film) ($($movie.Year))"
    }
}