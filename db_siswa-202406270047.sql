PGDMP     :    /                 |            db_siswa    14.12    14.12     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16395    db_siswa    DATABASE     l   CREATE DATABASE db_siswa WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
    DROP DATABASE db_siswa;
                postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                postgres    false            �           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   postgres    false    3            �            1259    16396    siswa_id_seq    SEQUENCE     u   CREATE SEQUENCE public.siswa_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.siswa_id_seq;
       public          postgres    false    3            �            1259    16397    siswa    TABLE     �   CREATE TABLE public.siswa (
    id integer DEFAULT nextval('public.siswa_id_seq'::regclass) NOT NULL,
    nama character varying(100) NOT NULL,
    umur integer NOT NULL,
    kelas character varying(50) NOT NULL
);
    DROP TABLE public.siswa;
       public         heap    postgres    false    209    3            �          0    16397    siswa 
   TABLE DATA           6   COPY public.siswa (id, nama, umur, kelas) FROM stdin;
    public          postgres    false    210   �	       �           0    0    siswa_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.siswa_id_seq', 9, true);
          public          postgres    false    209            ^           2606    16402    siswa siswa_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.siswa
    ADD CONSTRAINT siswa_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.siswa DROP CONSTRAINT siswa_pkey;
       public            postgres    false    210            �   N   x�3�L-�K�44�4t�2��̈́��8���s�ĢJ��gvfAN~%��	�kə������P�����u����� ��     