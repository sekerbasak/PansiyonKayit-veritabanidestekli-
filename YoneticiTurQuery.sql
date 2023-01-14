select 
"YoneticiID",
"pansiyonKayitSchemas"."tblYoneticiTur"."Vasfi",
"Maas"
from "pansiyonKayitSchemas"."tblYoneticiler"
inner join "pansiyonKayitSchemas"."tblYoneticiTur" on  "pansiyonKayitSchemas"."tblYoneticiler"."YoneticiID"="pansiyonKayitSchemas"."tblYoneticiTur"."YoneticiTurID" 
ORDER BY "YoneticiID" ASC; 