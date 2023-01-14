CREATE OR REPLACE FUNCTION "pansiyonKayitSchemas".upperpersonel_eklerken()
returns TRIGGER
as
$function$ 
BEGIN 
NEW."Ad"=UPPER(NEW."Ad");
NEW."Soyad"=UPPER(NEW."Soyad");
return NEW;
end;
$function$
language "plpgsql";
create TRIGGER musteri_eklerken_kontrol
before insert or update on "pansiyonKayitSchemas"."tblPersonel1" 
for each row 
execute procedure "pansiyonKayitSchemas".uppermusteri_eklerken();
