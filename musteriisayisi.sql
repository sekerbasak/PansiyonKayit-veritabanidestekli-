CREATE OR REPLACE FUNCTION "pansiyonKayitSchemas".musterisayisi()
RETURNS integer
LANGUAGE plpgsql
AS $function$
DECLARE 
 musteri_sayi integer;
BEGIN
 SELECT count("KisiID") into musteri_sayi from "pansiyonKayitSchemas"."tblMusteri1";
 RETURN musteri_sayi;
END; 
$function$