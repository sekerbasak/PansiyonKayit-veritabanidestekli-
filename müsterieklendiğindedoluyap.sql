CREATE OR REPLACE FUNCTION "pansiyonKayitSchemas".musteri_eklendiginde_dolu_yap()
RETURNS trigger
LANGUAGE plpgsql
AS $function$
DECLARE 
 odano int;
BEGIN
odano=NEW.OdaNo ;
UPDATE tblOdaDurumu set OdaDurumu='Dolu' WHERE 
 OdaNo=odano;
return NEW;
END; 
$function$;
CREATE TRIGGER musteri_eklendiginde_dolu_yap
after insert or update
ON "pansiyonKayitSchemas"."tblMusteri1"
for EACH row
execute PROCEDURE "pansiyonKayitSchemas".musteri_eklendiginde_dolu_yap();
