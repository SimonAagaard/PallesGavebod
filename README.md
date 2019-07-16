# PallesGavebod
Finished it. Took about 29 minutes

--The Task--

DEL 1:
Palles gavebod, skal have et nyt website (MVC) i aspnet core, hvor det er muligt for hans
kunder at se det udvalg af gaver som han tilbyder.
En gave (Gift object) består af følgende elementer:
• GiftNumber – Fortæller hvilket nummer gaven har (Id).
• Title – Et sigende navn/titel for hvad det er for en gave. (F.eks. ’Kaffekande’).
• Description – En kort beskrivelse af hvad gaven er for en. (F.eks. ’Den store blå som
ikke løber tør’).
• CreationDate – En DateTime som indikere hvornår gaven er blevet tilføjet til
systemet.
• BoyGift – En indikator for om gaven anses for at være velegnet at give til en dreng.
• GirlGift – En indikator for om gaven anses for at være velegnet at give til en pige.
Webløsningen skal tilbyde følgende 3 skærmbilleder/websider
• Side 1: En præsentation (oversigt) af alle gaver
• Side 2: En side hvor Palle har mulighed for at tilføje nye gaver til sortimentet.
• Side 3: En præsentation (oversigt) af alle gaver mærket velegnet at give til en pige og
kun disse
Websitet skal benytte sig af et web api som tilbyder følgende metoder:
1. En metode, der kan give en oversigt over alle gave objekter.
2. En metode, der kan returnere et bestemt gaveobjekt angivet med GiftNumber
3. En metode, der kan returnere gaver til henholdsvis pige eller dreng
4. En metode, der opretter et nyt gaveobjekt med angivelse de nødvendige data (Title,
Description etc.)
