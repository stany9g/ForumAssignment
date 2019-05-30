## Dìdiènost, polymorfismus, objektový návrh
### Popis systému
- Blog reprezentuje jednoduchou webovou stránku, která umožòuje sdílet èlánky, které se týkají urèitého tématu.
- Pro použití blogu je nutné si nejprve vytvoøit uživatelský úèet, uživatelský úèet mùže být dvou druhù: Uživatelský a Administrátorský. Uživatelský úèet má právo na prohlížení seznamu témat, ètení a komentování èlánkù, Uživatelský úèet navíc mùže být zablokován (v pøípadì nevhodného chování).
- Administrátorský úèet mùže zobrazovat a vytváøet témata, èíst, vytváøet a komentovat èlánky.
- Pøed možností provádìt výše uvedené akce s úèty je nutné se k aplikaci pøihlásit pomocí svého uživatelského jména a hesla.
- Téma má svùj název a struèný popis, pod téma je možné registrovat libovolný poèet èlánkù.
- Èlánek má svùj název, obsah, autora, datum poslední zmìny, stav a seznam Témat, pod která byl zaøazen.
- Stavy Èlánku jsou následující: rozpracovaný, publikovaný, neaktuální. Èlánky lze mezi stavy pøesouvat, zobrazit si lze pouze publikované èlánky.
- Blog má dùležitou èást Dashboard, který slouží pro zobrazování komponent uživateli. Zobrazovat jdou témata a èlánky. Pro zobrazení na Dashboardu musí komponenty splòovat urèité rozhraní.
- Další èástí je Editor, který slouží k úpravì komponenty. Upravovat jdou pouze èlánky. Pro úpravu v Editoru musí komponenty splòovat urèité rozhraní.

### Implementujte následující èást systému
- Vytváøení uživatelských úètù: aplikace umožní vytváøet uživatelské a administrátorské úèty.
- Pøihlašování se k uživatelským úètùm: do aplikace bude možné se pøihlásit pomocí uživatelského jména a hesla.
- Vytváøení nových témat: administrátor mùže vytváøet nová témata.
- Vytváøení nových èlánkù: administrátor mùže vytváøet nové èlánky.
- Èlánky lze registrovat pod témata.
- Uživatel si mùže pøeèíst blog: všechen obsah / podle zvoleného tématu. Vždy pouze aktuální èlánky. Pro zobrazení èlánku je tøeba použít již pøipravenou tøídu Dashboard.
- Implementujte unit testy pro tuto èást systému.

Jako usecase používání Blogu mùžete využít pøedpøipravenou tøídu Main.

##### Hint: Doporuèuji vytvoøit tyto soubory
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

