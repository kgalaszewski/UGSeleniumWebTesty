Aplikacja napisana przy pomocy C# / Selenium Web Driver / NUnit

Aby uruchomić aplikację należy uprzednio zainstalować google chrome i w aplikacji podmienić ścieżkę od chrome driver'a na właściwą

Aplikacja zawiera testy do 4 stron internetowych :

*** portal wzr.ug (2 testy) :

1 - Test sprawdzający czy na stronie działa zmiana języka z Polskiego na Angielski

2 - Test sprawdzający czy dropdown lista wybierania grupy studenckiej dziala
  
*** oficjalna strona league of legends (5 test case'ow => 3 testy) :

1 - Test sprawdzający czy formularz logowania na konto działa (2 inputy oraz submit button)

2 - Test sprawdzający czy formularz dziala w poprawny sposób (różne test case'y np gdy haslo wpisane ale brak nazwy uzytkownike, przycisk do submita powinien być nieaktywny)

3 - Test sprawdzający czy wiadomość o błędnie wpisanych danych działa poprawnie
  
*** strona pogodainteria (2 testy) :

1 - Test sprawdzający czy po wejściu w pogodę przycisk do powrócenia na stronę główną działa

2 - Test sprawdzający czy po wejściu w pogodę temperatura na dzien dzisiejszy jest w odpowiednich jednostkach

*** oficjalna strona discord (2 testy) :

1 - Test sprawdzający czy w wyszukiwarce tematów po wpisaniu konkretnej frazy jako wynik przekazane są >0 rezultatów

2 - Test sprawdzający czy alert o Corona-Virusie można bezproblemowo zamknąć :)

