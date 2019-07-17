# PallesGavebod


--The Task--

DEL 1:
Palles gavebod, skal have et nyt website (MVC) i aspnet core, hvor det er muligt for hans kunder at se det udvalg af gaver som han tilbyder. <br>
En gave (Gift object) består af følgende elementer:  <br>
• GiftNumber – Fortæller hvilket nummer gaven har (Id).  <br>
• Title – Et sigende navn/titel for hvad det er for en gave. (F.eks. ’Kaffekande’).  <br>
• Description – En kort beskrivelse af hvad gaven er for en. (F.eks. ’Den store blå som
ikke løber tør’).  <br>
• CreationDate – En DateTime som indikere hvornår gaven er blevet tilføjet til
systemet.  <br>
• BoyGift – En indikator for om gaven anses for at være velegnet at give til en dreng.  <br>
• GirlGift – En indikator for om gaven anses for at være velegnet at give til en pige.  <br>
Webløsningen skal tilbyde følgende 3 skærmbilleder/websider  <br>
• Side 1: En præsentation (oversigt) af alle gaver  <br>
• Side 2: En side hvor Palle har mulighed for at tilføje nye gaver til sortimentet.  <br>
• Side 3: En præsentation (oversigt) af alle gaver mærket velegnet at give til en pige og
kun disse  <br>
Websitet skal benytte sig af et web api som tilbyder følgende metoder:  <br>
1. En metode, der kan give en oversigt over alle gave objekter.  <br>
2. En metode, der kan returnere et bestemt gaveobjekt angivet med GiftNumber  <br>
3. En metode, der kan returnere gaver til henholdsvis pige eller dreng  <br>
4. En metode, der opretter et nyt gaveobjekt med angivelse de nødvendige data (Title,
Description etc.)
