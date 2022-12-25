
Create Table OduncAlma(
IslemId number generated always as IDENTITY,
UyeId number(4),
KitapId number(4),
OduncTarihi Date,
IadeTarihi Date,
CONSTRAINT PK_islem PRIMARY KEY(IslemId),
CONSTRAINT fk_UyeId FOREIGN KEY (UyeId) REFERENCES Uyeler(UyeId),
CONSTRAINT fk_KitapId FOREIGN KEY (KitapId) REFERENCES Kitaplar(KitapId)
);
