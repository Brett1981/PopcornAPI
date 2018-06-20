﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PopcornApi.Database;
using System;

namespace PopcornApi.Migrations
{
    [DbContext(typeof(PopcornContext))]
    [Migration("20180214103035_LanguagesIds")]
    partial class LanguagesIds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PopcornApi.Database.Cast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CharacterName");

                    b.Property<string>("ImdbCode");

                    b.Property<int?>("MovieId");

                    b.Property<string>("Name");

                    b.Property<string>("SmallImage");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("CastSet");
                });

            modelBuilder.Entity("PopcornApi.Database.EpisodeShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("DateBased");

                    b.Property<int>("EpisodeNumber");

                    b.Property<long>("FirstAired");

                    b.Property<string>("Overview");

                    b.Property<int>("Season");

                    b.Property<int?>("ShowId");

                    b.Property<string>("Title");

                    b.Property<int?>("TorrentsId");

                    b.Property<int?>("TvdbId");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.HasIndex("TorrentsId");

                    b.ToTable("EpisodeShowSet");
                });

            modelBuilder.Entity("PopcornApi.Database.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MovieId");

                    b.Property<string>("Name");

                    b.Property<int?>("ShowId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("ShowId");

                    b.ToTable("GenreSet");
                });

            modelBuilder.Entity("PopcornApi.Database.ImageShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Banner");

                    b.Property<string>("Poster");

                    b.HasKey("Id");

                    b.ToTable("ImageShowSet");
                });

            modelBuilder.Entity("PopcornApi.Database.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Iso639");

                    b.Property<string>("LanguageName");

                    b.Property<string>("SubLanguageId");

                    b.HasKey("Id");

                    b.ToTable("LanguageSet");
                });

            modelBuilder.Entity("PopcornApi.Database.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BackgroundImage");

                    b.Property<string>("DateUploaded");

                    b.Property<int>("DateUploadedUnix");

                    b.Property<string>("DescriptionFull");

                    b.Property<string>("DescriptionIntro");

                    b.Property<int>("DownloadCount");

                    b.Property<string>("GenreNames");

                    b.Property<string>("ImdbCode");

                    b.Property<string>("Language");

                    b.Property<int>("LikeCount");

                    b.Property<string>("MpaRating");

                    b.Property<string>("PosterImage");

                    b.Property<double>("Rating");

                    b.Property<int>("Runtime");

                    b.Property<string>("Slug");

                    b.Property<string>("Title");

                    b.Property<string>("TitleLong");

                    b.Property<string>("Url");

                    b.Property<int>("Year");

                    b.Property<string>("YtTrailerCode");

                    b.HasKey("Id");

                    b.ToTable("MovieSet");
                });

            modelBuilder.Entity("PopcornApi.Database.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Hated");

                    b.Property<int>("Loved");

                    b.Property<int>("Percentage");

                    b.Property<int>("Votes");

                    b.Property<int>("Watching");

                    b.HasKey("Id");

                    b.ToTable("RatingSet");
                });

            modelBuilder.Entity("PopcornApi.Database.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AirDay");

                    b.Property<string>("AirTime");

                    b.Property<string>("Country");

                    b.Property<string>("GenreNames");

                    b.Property<int?>("ImagesId");

                    b.Property<string>("ImdbId");

                    b.Property<long>("LastUpdated");

                    b.Property<string>("Network");

                    b.Property<int>("NumSeasons");

                    b.Property<int?>("RatingId");

                    b.Property<string>("Runtime");

                    b.Property<string>("Slug");

                    b.Property<string>("Status");

                    b.Property<string>("Synopsis");

                    b.Property<string>("Title");

                    b.Property<string>("TvdbId");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("ImagesId");

                    b.HasIndex("RatingId");

                    b.ToTable("ShowSet");
                });

            modelBuilder.Entity("PopcornApi.Database.Similar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MovieId");

                    b.Property<int?>("ShowId");

                    b.Property<string>("TmdbId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("ShowId");

                    b.ToTable("Similar");
                });

            modelBuilder.Entity("PopcornApi.Database.Subtitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Bad");

                    b.Property<string>("ImdbId");

                    b.Property<string>("Iso639");

                    b.Property<string>("LanguageId");

                    b.Property<string>("LanguageName");

                    b.Property<int?>("MovieId");

                    b.Property<string>("OsdbSubtitleId");

                    b.Property<double>("Rating");

                    b.Property<int?>("ShowId");

                    b.Property<string>("SubtitleDownloadLink");

                    b.Property<string>("SubtitleFileName");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("ShowId");

                    b.ToTable("Subtitle");
                });

            modelBuilder.Entity("PopcornApi.Database.Torrent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Peers");

                    b.Property<string>("Provider");

                    b.Property<int?>("Seeds");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("TorrentSet");
                });

            modelBuilder.Entity("PopcornApi.Database.TorrentMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateUploaded");

                    b.Property<int>("DateUploadedUnix");

                    b.Property<string>("Hash");

                    b.Property<int>("MovieId");

                    b.Property<int>("Peers");

                    b.Property<string>("Quality");

                    b.Property<int>("Seeds");

                    b.Property<string>("Size");

                    b.Property<long?>("SizeBytes");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("TorrentMovieSet");
                });

            modelBuilder.Entity("PopcornApi.Database.TorrentNode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Torrent0Id");

                    b.Property<int?>("Torrent1080pId");

                    b.Property<int?>("Torrent480pId");

                    b.Property<int?>("Torrent720pId");

                    b.HasKey("Id");

                    b.HasIndex("Torrent0Id");

                    b.HasIndex("Torrent1080pId");

                    b.HasIndex("Torrent480pId");

                    b.HasIndex("Torrent720pId");

                    b.ToTable("TorrentNodeSet");
                });

            modelBuilder.Entity("PopcornApi.Database.Cast", b =>
                {
                    b.HasOne("PopcornApi.Database.Movie")
                        .WithMany("Cast")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("PopcornApi.Database.EpisodeShow", b =>
                {
                    b.HasOne("PopcornApi.Database.Show")
                        .WithMany("Episodes")
                        .HasForeignKey("ShowId");

                    b.HasOne("PopcornApi.Database.TorrentNode", "Torrents")
                        .WithMany()
                        .HasForeignKey("TorrentsId");
                });

            modelBuilder.Entity("PopcornApi.Database.Genre", b =>
                {
                    b.HasOne("PopcornApi.Database.Movie")
                        .WithMany("Genres")
                        .HasForeignKey("MovieId");

                    b.HasOne("PopcornApi.Database.Show")
                        .WithMany("Genres")
                        .HasForeignKey("ShowId");
                });

            modelBuilder.Entity("PopcornApi.Database.Show", b =>
                {
                    b.HasOne("PopcornApi.Database.ImageShow", "Images")
                        .WithMany()
                        .HasForeignKey("ImagesId");

                    b.HasOne("PopcornApi.Database.Rating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingId");
                });

            modelBuilder.Entity("PopcornApi.Database.Similar", b =>
                {
                    b.HasOne("PopcornApi.Database.Movie")
                        .WithMany("Similars")
                        .HasForeignKey("MovieId");

                    b.HasOne("PopcornApi.Database.Show")
                        .WithMany("Similars")
                        .HasForeignKey("ShowId");
                });

            modelBuilder.Entity("PopcornApi.Database.Subtitle", b =>
                {
                    b.HasOne("PopcornApi.Database.Movie")
                        .WithMany("Subtitles")
                        .HasForeignKey("MovieId");

                    b.HasOne("PopcornApi.Database.Show")
                        .WithMany("Subtitles")
                        .HasForeignKey("ShowId");
                });

            modelBuilder.Entity("PopcornApi.Database.TorrentMovie", b =>
                {
                    b.HasOne("PopcornApi.Database.Movie")
                        .WithMany("Torrents")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PopcornApi.Database.TorrentNode", b =>
                {
                    b.HasOne("PopcornApi.Database.Torrent", "Torrent0")
                        .WithMany()
                        .HasForeignKey("Torrent0Id");

                    b.HasOne("PopcornApi.Database.Torrent", "Torrent1080p")
                        .WithMany()
                        .HasForeignKey("Torrent1080pId");

                    b.HasOne("PopcornApi.Database.Torrent", "Torrent480p")
                        .WithMany()
                        .HasForeignKey("Torrent480pId");

                    b.HasOne("PopcornApi.Database.Torrent", "Torrent720p")
                        .WithMany()
                        .HasForeignKey("Torrent720pId");
                });
#pragma warning restore 612, 618
        }
    }
}
