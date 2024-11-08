CREATE TABLE kategori (
id SERIAL PRIMARY KEY,
nama_kategori VARCHAR(100) NOT NULL
);

CREATE TABLE buku (
id SERIAL PRIMARY KEY,
judul VARCHAR(100) NOT NULL,
pengarang VARCHAR(100) UNIQUE NOT NULL,
tahun INT NOT NULL,
id_kategori INT NOT NULL,
FOREIGN KEY (id_kategori) REFERENCES kategori(id) ON DELETE CASCADE
);

INSERT INTO kategori (nama_kategori) VALUES
('Fiksi'),
('Non-Fiksi');

INSERT INTO buku (judul, pengarang, tahun, id_kategori) VALUES
('Laut Bercerita', 'Gatau lupa', 2010, 1),
('Naruto', 'Masashi Kishimoto', 2009, 1),
('Algoritma untuk Machine Learning', 'Prof Rudy', 2024, 2);