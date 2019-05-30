## D�di�nost, polymorfismus, objektov� n�vrh
### Popis syst�mu
- Blog reprezentuje jednoduchou webovou str�nku, kter� umo��uje sd�let �l�nky, kter� se t�kaj� ur�it�ho t�matu.
- Pro pou�it� blogu je nutn� si nejprve vytvo�it u�ivatelsk� ��et, u�ivatelsk� ��et m��e b�t dvou druh�: U�ivatelsk� a Administr�torsk�. U�ivatelsk� ��et m� pr�vo na prohl�en� seznamu t�mat, �ten� a komentov�n� �l�nk�, U�ivatelsk� ��et nav�c m��e b�t zablokov�n (v p��pad� nevhodn�ho chov�n�).
- Administr�torsk� ��et m��e zobrazovat a vytv��et t�mata, ��st, vytv��et a komentovat �l�nky.
- P�ed mo�nost� prov�d�t v��e uveden� akce s ��ty je nutn� se k aplikaci p�ihl�sit pomoc� sv�ho u�ivatelsk�ho jm�na a hesla.
- T�ma m� sv�j n�zev a stru�n� popis, pod t�ma je mo�n� registrovat libovoln� po�et �l�nk�.
- �l�nek m� sv�j n�zev, obsah, autora, datum posledn� zm�ny, stav a seznam T�mat, pod kter� byl za�azen.
- Stavy �l�nku jsou n�sleduj�c�: rozpracovan�, publikovan�, neaktu�ln�. �l�nky lze mezi stavy p�esouvat, zobrazit si lze pouze publikovan� �l�nky.
- Blog m� d�le�itou ��st Dashboard, kter� slou�� pro zobrazov�n� komponent u�ivateli. Zobrazovat jdou t�mata a �l�nky. Pro zobrazen� na Dashboardu mus� komponenty spl�ovat ur�it� rozhran�.
- Dal�� ��st� je Editor, kter� slou�� k �prav� komponenty. Upravovat jdou pouze �l�nky. Pro �pravu v Editoru mus� komponenty spl�ovat ur�it� rozhran�.

### Implementujte n�sleduj�c� ��st syst�mu
- Vytv��en� u�ivatelsk�ch ��t�: aplikace umo�n� vytv��et u�ivatelsk� a administr�torsk� ��ty.
- P�ihla�ov�n� se k u�ivatelsk�m ��t�m: do aplikace bude mo�n� se p�ihl�sit pomoc� u�ivatelsk�ho jm�na a hesla.
- Vytv��en� nov�ch t�mat: administr�tor m��e vytv��et nov� t�mata.
- Vytv��en� nov�ch �l�nk�: administr�tor m��e vytv��et nov� �l�nky.
- �l�nky lze registrovat pod t�mata.
- U�ivatel si m��e p�e��st blog: v�echen obsah / podle zvolen�ho t�matu. V�dy pouze aktu�ln� �l�nky. Pro zobrazen� �l�nku je t�eba pou��t ji� p�ipravenou t��du Dashboard.
- Implementujte unit testy pro tuto ��st syst�mu.

Jako usecase pou��v�n� Blogu m��ete vyu��t p�edp�ipravenou t��du Main.

##### Hint: Doporu�uji vytvo�it tyto soubory
- BlogAccountBase
- AdminAccount
- UserAccount
- IBlog
- Blog
- Comment
- IEditableComponent
- Editor
- Post
- enum PostState
- Topic
- "Warning"

