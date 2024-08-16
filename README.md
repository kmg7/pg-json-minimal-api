# postgres json studies

Postgres veri tabanının imkan verdiği json binary yapılarının dinamik şemalar ile kullanılması üzerine yapılan çalışma.

> JSONB ile ilgili kaynaklara [resmi dökümandan](https://www.postgresql.org/docs/current/datatype-json.html) ulaşabilirsiniz.

### Çalışmada kullanmak üzere bir postgres konteyneri oluşturalım.

```
docker run --name pg-json-lab -e POSTGRES_USER=demouser -e POSTGRES_PASSWORD=demopassword -e POSTGRES_DB=demodb -p 5432:5432 -d postgres:16.4

```

Bu çalışmayı yaparken npgsql entity framework kütüphanesi kullanıldı. Npgsql jsonb tipindeki verileri System.Text.Json apilerini kullanarak işlerken utf8 binary işleme yaptığı için oldukça performanslı olduğunu iddia etmekte.

Çalışmada PresentationContent tablosunda slides kolonunun dinamik olduğu senaryo üzerine çalışıldı. Slides kolonunu bir çok şekilde düzenlemek için JsonPatch dili kullanıldı.

Örnekler için çalışmanın yoğunlaşıldığı slides uç noktasına bakarken open api dokümanından faydalanabilirsiniz.

> [JSON Patch](https://datatracker.ietf.org/doc/html/rfc6902), Json dökümanlarını düzenlemeye imkan veren yine Json dökümanı olarak belirtilen bir dildir. Kullanılan kütüphaneye [bu adresten](https://docs.json-everything.net/patch/basics/) ulaşabilirsiniz. JSON'ın gücü adına!

Bu dinamik yapının validasyon işini ise yine başka bir spesifikasyon olan [JsonSchema](http://json-schema.org/) kullanarak yapmak düşüncesi akla gelmekte. Tartışalım!
