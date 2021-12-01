using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using mozgva.Models;

#nullable disable

namespace mozgva.Data
{
    public partial class ApplicationContext : IdentityDbContext<AspNetUser>
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Achievment> Achievments { get; set; }
        public virtual DbSet<AchievmentType> AchievmentTypes { get; set; }
        public virtual DbSet<ArInternalMetadatum> ArInternalMetadata { get; set; }
        //public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        //public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        //public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        //public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        //public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        //public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<AviaparkRegistration> AviaparkRegistrations { get; set; }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<CategoryFeedback> CategoryFeedbacks { get; set; }
        public virtual DbSet<Challenge> Challenges { get; set; }
        public virtual DbSet<ChampionsLeague> ChampionsLeagues { get; set; }
        public virtual DbSet<ChampionsRegistration> ChampionsRegistrations { get; set; }
        public virtual DbSet<ChampionshipBeginnerRegistration> ChampionshipBeginnerRegistrations { get; set; }
        public virtual DbSet<ChampionshipRegistration> ChampionshipRegistrations { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CkeditorAsset> CkeditorAssets { get; set; }
        public virtual DbSet<ConfirmationCode> ConfirmationCodes { get; set; }
        public virtual DbSet<ConfirmationReg> ConfirmationRegs { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<FranchiseComment> FranchiseComments { get; set; }
        public virtual DbSet<FranchiseStaticPage> FranchiseStaticPages { get; set; }
        public virtual DbSet<FreeOrder> FreeOrders { get; set; }
        public virtual DbSet<FriendlyIdSlug> FriendlyIdSlugs { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameIngosAnswer> GameIngosAnswers { get; set; }
        public virtual DbSet<GameIngosCallback> GameIngosCallbacks { get; set; }
        public virtual DbSet<GameIngosDefaultSetting> GameIngosDefaultSettings { get; set; }
        public virtual DbSet<GameIngosGameInstance> GameIngosGameInstances { get; set; }
        public virtual DbSet<GameIngosOffice> GameIngosOffices { get; set; }
        public virtual DbSet<GameIngosQuestion> GameIngosQuestions { get; set; }
        public virtual DbSet<GameIngosReconciliation> GameIngosReconciliations { get; set; }
        public virtual DbSet<GameIngosTour> GameIngosTours { get; set; }
        public virtual DbSet<GameRegistration> GameRegistrations { get; set; }
        public virtual DbSet<GameRegistrationPromocode> GameRegistrationPromocodes { get; set; }
        public virtual DbSet<GameRegistrationSert> GameRegistrationSerts { get; set; }
        public virtual DbSet<GameTabImage> GameTabImages { get; set; }
        public virtual DbSet<GameTrialFeedback> GameTrialFeedbacks { get; set; }
        public virtual DbSet<GameTrialQuestion> GameTrialQuestions { get; set; }
        public virtual DbSet<GameTrialReconciliation> GameTrialReconciliations { get; set; }
        public virtual DbSet<GameTrialTour> GameTrialTours { get; set; }
        public virtual DbSet<GameUnregistration> GameUnregistrations { get; set; }
        public virtual DbSet<Gameset> Gamesets { get; set; }
        public virtual DbSet<GamesetCity> GamesetCities { get; set; }
        public virtual DbSet<HashTag> HashTags { get; set; }
        public virtual DbSet<Invitation> Invitations { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<LeroymerlinReg> LeroymerlinRegs { get; set; }
        public virtual DbSet<Lightning> Lightnings { get; set; }
        public virtual DbSet<LoyaltyCard> LoyaltyCards { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Omnilink> Omnilinks { get; set; }
        public virtual DbSet<OnlineSert> OnlineSerts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ParlayExpress> ParlayExpresses { get; set; }
        public virtual DbSet<ParlayPassFinal> ParlayPassFinals { get; set; }
        public virtual DbSet<ParlayWhoWin> ParlayWhoWins { get; set; }
        public virtual DbSet<ParlayWinner> ParlayWinners { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPromocode> ProductPromocodes { get; set; }
        public virtual DbSet<Promocode> Promocodes { get; set; }
        public virtual DbSet<QdAttachment> QdAttachments { get; set; }
        public virtual DbSet<QdCategoriesQuestion> QdCategoriesQuestions { get; set; }
        public virtual DbSet<QdCategory> QdCategories { get; set; }
        public virtual DbSet<QdCategoryGroup> QdCategoryGroups { get; set; }
        public virtual DbSet<QdQuestion> QdQuestions { get; set; }
        public virtual DbSet<QdQuestionTag> QdQuestionTags { get; set; }
        public virtual DbSet<QdTag> QdTags { get; set; }
        public virtual DbSet<QuickRegistration> QuickRegistrations { get; set; }
        public virtual DbSet<QuizAnswer> QuizAnswers { get; set; }
        public virtual DbSet<QuizGame> QuizGames { get; set; }
        public virtual DbSet<QuizGameInstance> QuizGameInstances { get; set; }
        public virtual DbSet<QuizHint> QuizHints { get; set; }
        public virtual DbSet<QuizQuestion> QuizQuestions { get; set; }
        public virtual DbSet<QuizTour> QuizTours { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<RatiosGame> RatiosGames { get; set; }
        public virtual DbSet<RecordedGameAnswer> RecordedGameAnswers { get; set; }
        public virtual DbSet<RecordedGameGame> RecordedGameGames { get; set; }
        public virtual DbSet<RecordedGameGameInstance> RecordedGameGameInstances { get; set; }
        public virtual DbSet<RecordedGameModeration> RecordedGameModerations { get; set; }
        public virtual DbSet<RecordedGameQuestion> RecordedGameQuestions { get; set; }
        public virtual DbSet<RecordedGameRegistration> RecordedGameRegistrations { get; set; }
        public virtual DbSet<RecordedGameTour> RecordedGameTours { get; set; }
        public virtual DbSet<RegistrationStatistic> RegistrationStatistics { get; set; }
        public virtual DbSet<RelationshipWinnersExpress> RelationshipWinnersExpresses { get; set; }
        public virtual DbSet<RelationshipWinsExpress> RelationshipWinsExpresses { get; set; }
        public virtual DbSet<RequestInvitation> RequestInvitations { get; set; }
        //public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; }
        public virtual DbSet<Scoring> Scorings { get; set; }
        public virtual DbSet<Sert> Serts { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<SpecialGame> SpecialGames { get; set; }
        public virtual DbSet<SpecialGameAnswer> SpecialGameAnswers { get; set; }
        public virtual DbSet<SpecialRegistration> SpecialRegistrations { get; set; }
        public virtual DbSet<Standby> Standbies { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamHashTag> TeamHashTags { get; set; }
        public virtual DbSet<TeamRating> TeamRatings { get; set; }
        public virtual DbSet<TestAnswer> TestAnswers { get; set; }
        public virtual DbSet<TestModeration> TestModerations { get; set; }
        public virtual DbSet<TestRating> TestRatings { get; set; }
        public virtual DbSet<TestRelationship> TestRelationships { get; set; }
        public virtual DbSet<TestTest> TestTests { get; set; }
        public virtual DbSet<TestTour> TestTours { get; set; }
        public virtual DbSet<ThematicRating> ThematicRatings { get; set; }
        public virtual DbSet<ThematicRatingCity> ThematicRatingCities { get; set; }
        public virtual DbSet<User> Userss { get; set; }
        public virtual DbSet<UsersRole> UsersRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Database=mozgva_staging;Port=5432;User Id=postgres;Password=ihesop69;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Achievment>(entity =>
            {
                entity.ToTable("achievments");

                entity.HasIndex(e => e.AchievmentTypeId, "index_achievments_on_achievment_type_id");

                entity.HasIndex(e => e.TeamId, "index_achievments_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AchievmentTypeId).HasColumnName("achievment_type_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.AchievmentType)
                    .WithMany(p => p.Achievments)
                    .HasForeignKey(d => d.AchievmentTypeId)
                    .HasConstraintName("fk_rails_8d60c7a117");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Achievments)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_rails_7735a15bc6");
            });

            modelBuilder.Entity<AchievmentType>(entity =>
            {
                entity.ToTable("achievment_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.About).HasColumnName("about");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ImageContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("image_content_type");

                entity.Property(e => e.ImageFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("image_file_name");

                entity.Property(e => e.ImageFileSize).HasColumnName("image_file_size");

                entity.Property(e => e.ImageUpdatedAt).HasColumnName("image_updated_at");

                entity.Property(e => e.Key)
                    .HasColumnType("character varying")
                    .HasColumnName("key");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("1000");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ArInternalMetadatum>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("ar_internal_metadata_pkey");

                entity.ToTable("ar_internal_metadata");

                entity.Property(e => e.Key)
                    .HasColumnType("character varying")
                    .HasColumnName("key");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasColumnType("character varying")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEnd).HasColumnType("timestamp with time zone");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });
            modelBuilder.Entity<AspNetUserClaim>(entity =>
                        {
                            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                            entity.Property(e => e.UserId).IsRequired();

                            entity.HasOne(d => d.User)
                                .WithMany(p => p.AspNetUserClaims)
                                .HasForeignKey(d => d.UserId);
                        });
            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("attachments");

                entity.HasIndex(e => e.CityId, "index_attachments_on_city_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DownloadFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("download_file_name");

                entity.Property(e => e.FileContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("file_content_type");

                entity.Property(e => e.FileFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("file_file_name");

                entity.Property(e => e.FileFileSize).HasColumnName("file_file_size");

                entity.Property(e => e.FileUpdatedAt).HasColumnName("file_updated_at");

                entity.Property(e => e.ForceDownload).HasColumnName("force_download");

                entity.Property(e => e.Key)
                    .HasColumnType("character varying")
                    .HasColumnName("key");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("fk_rails_cf650dad64");
            });

            modelBuilder.Entity<AviaparkRegistration>(entity =>
            {
                entity.ToTable("aviapark_registrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.PeopleNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("people_number");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.TeamName)
                    .HasColumnType("character varying")
                    .HasColumnName("team_name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.ToTable("banners");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ImageContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("image_content_type");

                entity.Property(e => e.ImageFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("image_file_name");

                entity.Property(e => e.ImageFileSize).HasColumnName("image_file_size");

                entity.Property(e => e.ImageUpdatedAt).HasColumnName("image_updated_at");

                entity.Property(e => e.Link)
                    .HasColumnType("character varying")
                    .HasColumnName("link");

                entity.Property(e => e.ShowType)
                    .HasColumnType("character varying")
                    .HasColumnName("show_type")
                    .HasDefaultValueSql("'all_cities'::character varying");

                entity.Property(e => e.SizeType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("size_type");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<CategoryFeedback>(entity =>
            {
                entity.ToTable("category_feedbacks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Key)
                    .HasColumnType("character varying")
                    .HasColumnName("key");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Challenge>(entity =>
            {
                entity.ToTable("challenges");

                entity.HasIndex(e => e.GameRegistrationId, "index_challenges_on_game_registration_id");

                entity.HasIndex(e => e.TeamId, "index_challenges_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameRegistrationId).HasColumnName("game_registration_id");

                entity.Property(e => e.Status)
                    .HasColumnType("character varying")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'waiting'::character varying");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.GameRegistration)
                    .WithMany(p => p.Challenges)
                    .HasForeignKey(d => d.GameRegistrationId)
                    .HasConstraintName("fk_rails_85aeef917d");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Challenges)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_rails_098f0e3b85");
            });

            modelBuilder.Entity<ChampionsLeague>(entity =>
            {
                entity.ToTable("champions_leagues");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.MaxTeamsNumber).HasColumnName("max_teams_number");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'checking'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ChampionsRegistration>(entity =>
            {
                entity.ToTable("champions_registrations");

                entity.HasIndex(e => e.ChampionsLeagueId, "index_champions_registrations_on_champions_league_id");

                entity.HasIndex(e => e.TeamId, "index_champions_registrations_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChampionsLeagueId).HasColumnName("champions_league_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Final).HasColumnName("final");

                entity.Property(e => e.QuarterFinal).HasColumnName("quarter_final");

                entity.Property(e => e.SemiFinal).HasColumnName("semi_final");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.ChampionsLeague)
                    .WithMany(p => p.ChampionsRegistrations)
                    .HasForeignKey(d => d.ChampionsLeagueId)
                    .HasConstraintName("fk_rails_770af72110");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.ChampionsRegistrations)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_rails_8bf280cd59");
            });

            modelBuilder.Entity<ChampionshipBeginnerRegistration>(entity =>
            {
                entity.ToTable("championship_beginner_registrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.TeamName)
                    .HasColumnType("character varying")
                    .HasColumnName("team_name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.When).HasColumnName("when");
            });

            modelBuilder.Entity<ChampionshipRegistration>(entity =>
            {
                entity.ToTable("championship_registrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.TeamName)
                    .HasColumnType("character varying")
                    .HasColumnName("team_name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.When).HasColumnName("when");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("cities");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.EmailFranchise)
                    .HasColumnType("character varying")
                    .HasColumnName("email_franchise");

                entity.Property(e => e.EmailKorporat)
                    .HasColumnType("character varying")
                    .HasColumnName("email_korporat");

                entity.Property(e => e.EmailPartners)
                    .HasColumnType("character varying")
                    .HasColumnName("email_partners");

                entity.Property(e => e.EmailRegStatistic)
                    .HasColumnType("character varying")
                    .HasColumnName("email_reg_statistic");

                entity.Property(e => e.EmailTeamReg)
                    .HasColumnType("character varying")
                    .HasColumnName("email_team_reg");

                entity.Property(e => e.FbLink)
                    .HasColumnType("character varying")
                    .HasColumnName("fb_link");

                entity.Property(e => e.Info)
                    .HasColumnType("jsonb")
                    .HasColumnName("info")
                    .HasDefaultValueSql("'{}'::jsonb");

                entity.Property(e => e.InstLink)
                    .HasColumnType("character varying")
                    .HasColumnName("inst_link");

                entity.Property(e => e.Key)
                    .HasColumnType("character varying")
                    .HasColumnName("key");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.VkLink)
                    .HasColumnType("character varying")
                    .HasColumnName("vk_link");
            });

            modelBuilder.Entity<CkeditorAsset>(entity =>
            {
                entity.ToTable("ckeditor_assets");

                entity.HasIndex(e => e.Type, "index_ckeditor_assets_on_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DataContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("data_content_type");

                entity.Property(e => e.DataFileName)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("data_file_name");

                entity.Property(e => e.DataFileSize).HasColumnName("data_file_size");

                entity.Property(e => e.DataFingerprint)
                    .HasColumnType("character varying")
                    .HasColumnName("data_fingerprint");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<ConfirmationCode>(entity =>
            {
                entity.ToTable("confirmation_codes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnType("character varying")
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ConfirmationReg>(entity =>
            {
                entity.ToTable("confirmation_regs");

                entity.HasIndex(e => e.GameId, "index_confirmation_regs_on_game_id");

                entity.HasIndex(e => e.GameRegistrationId, "index_confirmation_regs_on_game_registration_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnType("character varying")
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.GameRegistrationId).HasColumnName("game_registration_id");

                entity.Property(e => e.Status)
                    .HasColumnType("character varying")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'no_mailing'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.ToTable("counters");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("feedbacks");

                entity.HasIndex(e => e.CategoryFeedbackId, "index_feedbacks_on_category_feedback_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryFeedbackId).HasColumnName("category_feedback_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.Question).HasColumnName("question");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.CategoryFeedback)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.CategoryFeedbackId)
                    .HasConstraintName("fk_rails_acd8088ec2");
            });

            modelBuilder.Entity<FranchiseComment>(entity =>
            {
                entity.ToTable("franchise_comments");

                entity.HasIndex(e => e.TeamId, "index_franchise_comments_on_team_id");

                entity.HasIndex(e => e.UserId, "index_franchise_comments_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<FranchiseStaticPage>(entity =>
            {
                entity.ToTable("franchise_static_pages");

                entity.HasIndex(e => e.Slug, "index_franchise_static_pages_on_slug")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.NameUrl)
                    .HasColumnType("character varying")
                    .HasColumnName("name_url");

                entity.Property(e => e.Slug)
                    .HasColumnType("character varying")
                    .HasColumnName("slug");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<FreeOrder>(entity =>
            {
                entity.ToTable("free_orders");

                entity.HasIndex(e => e.ProductId, "index_free_orders_on_product_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.Fio)
                    .HasColumnType("character varying")
                    .HasColumnName("fio");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.SecretCode)
                    .HasColumnType("character varying")
                    .HasColumnName("secret_code");

                entity.Property(e => e.SendFirstEmail)
                    .HasColumnName("send_first_email")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SendSecondEmail)
                    .HasColumnName("send_second_email")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<FriendlyIdSlug>(entity =>
            {
                entity.ToTable("friendly_id_slugs");

                entity.HasIndex(e => new { e.Slug, e.SluggableType }, "index_friendly_id_slugs_on_slug_and_sluggable_type");

                entity.HasIndex(e => new { e.Slug, e.SluggableType, e.Scope }, "index_friendly_id_slugs_on_slug_and_sluggable_type_and_scope")
                    .IsUnique();

                entity.HasIndex(e => e.SluggableId, "index_friendly_id_slugs_on_sluggable_id");

                entity.HasIndex(e => e.SluggableType, "index_friendly_id_slugs_on_sluggable_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Scope)
                    .HasColumnType("character varying")
                    .HasColumnName("scope");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("slug");

                entity.Property(e => e.SluggableId).HasColumnName("sluggable_id");

                entity.Property(e => e.SluggableType)
                    .HasMaxLength(50)
                    .HasColumnName("sluggable_type");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("games");

                entity.HasIndex(e => e.GameTabImageId, "index_games_on_game_tab_image_id");

                entity.HasIndex(e => e.GamesetId, "index_games_on_gameset_id");

                entity.HasIndex(e => e.LeagueId, "index_games_on_league_id");

                entity.HasIndex(e => e.PlaceId, "index_games_on_place_id");

                entity.HasIndex(e => e.ThematicRatingId, "index_games_on_thematic_rating_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColorLabel)
                    .HasColumnType("character varying")
                    .HasColumnName("color_label");

                entity.Property(e => e.ColorLabelRight)
                    .HasColumnType("character varying")
                    .HasColumnName("color_label_right");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GameBeginner)
                    .HasColumnName("game_beginner")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.GameFootball)
                    .HasColumnName("game_football")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.GameKids)
                    .HasColumnName("game_kids")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.GameStudent)
                    .HasColumnName("game_student")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.GameTabImageId).HasColumnName("game_tab_image_id");

                entity.Property(e => e.GamesetId).HasColumnName("gameset_id");

                entity.Property(e => e.ImportStatus)
                    .IsRequired()
                    .HasColumnType("jsonb")
                    .HasColumnName("import_status")
                    .HasDefaultValueSql("'{}'::jsonb");

                entity.Property(e => e.Label)
                    .HasColumnType("character varying")
                    .HasColumnName("label");

                entity.Property(e => e.LeagueId).HasColumnName("league_id");

                entity.Property(e => e.Main)
                    .IsRequired()
                    .HasColumnName("main")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MainCalendar)
                    .HasColumnName("main_calendar")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.MaxPeopleNumber).HasColumnName("max_people_number");

                entity.Property(e => e.MaxScores)
                    .HasColumnName("max_scores")
                    .HasDefaultValueSql("99999");

                entity.Property(e => e.MaxTeamsNumber).HasColumnName("max_teams_number");

                entity.Property(e => e.MinScores)
                    .HasColumnName("min_scores")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.NoRating)
                    .HasColumnName("no_rating")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PhotosCount).HasColumnName("photos_count");

                entity.Property(e => e.PlaceId).HasColumnName("place_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.QuickRegistrationAvailable)
                    .IsRequired()
                    .HasColumnName("quick_registration_available")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.RegistrationStandbies)
                    .HasColumnName("registration_standbies")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ShowReport)
                    .HasColumnName("show_report")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'checking'::character varying");

                entity.Property(e => e.ThematicRatingId)
                    .HasColumnName("thematic_rating_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.When).HasColumnName("when");

                entity.HasOne(d => d.GameTabImage)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.GameTabImageId)
                    .HasConstraintName("fk_rails_91c517a9cd");

                entity.HasOne(d => d.League)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.LeagueId)
                    .HasConstraintName("fk_rails_c7a04448a4");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.PlaceId)
                    .HasConstraintName("fk_rails_7a31cf7bf9");
            });

            modelBuilder.Entity<GameIngosAnswer>(entity =>
            {
                entity.ToTable("game_ingos_answers");

                entity.HasIndex(e => e.QuestionId, "index_game_ingos_answers_on_question_id");

                entity.HasIndex(e => e.TeamId, "index_game_ingos_answers_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdditionalScore).HasColumnName("additional_score");

                entity.Property(e => e.Answer)
                    .HasColumnType("character varying")
                    .HasColumnName("answer");

                entity.Property(e => e.Correct).HasColumnName("correct");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.PlusPoints).HasColumnName("plus_points");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.Uncorrect).HasColumnName("uncorrect");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.GameIngosAnswers)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_rails_3ac4ec815c");
            });

            modelBuilder.Entity<GameIngosCallback>(entity =>
            {
                entity.ToTable("game_ingos_callbacks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<GameIngosDefaultSetting>(entity =>
            {
                entity.ToTable("game_ingos_default_settings");

                entity.HasIndex(e => e.GameId, "index_game_ingos_default_settings_on_game_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BreakTime)
                    .HasColumnType("time without time zone")
                    .HasColumnName("break_time");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Emails).HasColumnName("emails");

                entity.Property(e => e.FinalVideoUrl)
                    .HasColumnType("character varying")
                    .HasColumnName("final_video_url");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.ReloadTableTime)
                    .HasColumnType("time without time zone")
                    .HasColumnName("reload_table_time");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameIngosDefaultSettings)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("fk_rails_4bea797dc4");
            });

            modelBuilder.Entity<GameIngosGameInstance>(entity =>
            {
                entity.ToTable("game_ingos_game_instances");

                entity.HasIndex(e => e.GameId, "index_game_ingos_game_instances_on_game_id");

                entity.HasIndex(e => e.TeamId, "index_game_ingos_game_instances_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.IntermediateTable).HasColumnName("intermediate_table");

                entity.Property(e => e.LastQuestion)
                    .HasColumnName("last_question")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastTour)
                    .HasColumnName("last_tour")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<GameIngosOffice>(entity =>
            {
                entity.ToTable("game_ingos_offices");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<GameIngosQuestion>(entity =>
            {
                entity.ToTable("game_ingos_questions");

                entity.HasIndex(e => e.TourId, "index_game_ingos_questions_on_tour_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DelayTime)
                    .HasColumnName("delay_time")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.TourId).HasColumnName("tour_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.VideoUrl)
                    .HasColumnType("character varying")
                    .HasColumnName("video_url");
            });

            modelBuilder.Entity<GameIngosReconciliation>(entity =>
            {
                entity.ToTable("game_ingos_reconciliations");

                entity.HasIndex(e => e.TourId, "index_game_ingos_reconciliations_on_tour_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnType("character varying")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DelayTime)
                    .HasColumnName("delay_time")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TourId).HasColumnName("tour_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<GameIngosTour>(entity =>
            {
                entity.ToTable("game_ingos_tours");

                entity.HasIndex(e => e.GameId, "index_game_ingos_tours_on_game_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Plus2).HasColumnName("plus_2");

                entity.Property(e => e.Plus3).HasColumnName("plus_3");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<GameRegistration>(entity =>
            {
                entity.ToTable("game_registrations");

                entity.HasIndex(e => e.GameId, "index_game_registrations_on_game_id");

                entity.HasIndex(e => e.TeamId, "index_game_registrations_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.ContactEmail)
                    .HasColumnType("character varying")
                    .HasColumnName("contact_email");

                entity.Property(e => e.ContactName)
                    .HasColumnType("character varying")
                    .HasColumnName("contact_name");

                entity.Property(e => e.ContactPhone)
                    .HasColumnType("character varying")
                    .HasColumnName("contact_phone");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.HideStatus)
                    .HasColumnName("hide_status")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PeopleNumber).HasColumnName("people_number");

                entity.Property(e => e.Referer)
                    .HasColumnType("character varying")
                    .HasColumnName("referer");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.TrafficSource)
                    .HasColumnType("character varying")
                    .HasColumnName("traffic_source");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UtmActionpay)
                    .HasColumnType("character varying")
                    .HasColumnName("utm_actionpay");

                entity.Property(e => e.UtmCampaign)
                    .HasColumnType("character varying")
                    .HasColumnName("utm_campaign");

                entity.Property(e => e.UtmContent)
                    .HasColumnType("character varying")
                    .HasColumnName("utm_content");

                entity.Property(e => e.UtmMedium)
                    .HasColumnType("character varying")
                    .HasColumnName("utm_medium");

                entity.Property(e => e.UtmSource)
                    .HasColumnType("character varying")
                    .HasColumnName("utm_source");

                entity.Property(e => e.UtmTerm)
                    .HasColumnType("character varying")
                    .HasColumnName("utm_term");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameRegistrations)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("fk_rails_b12334da74");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.GameRegistrations)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_rails_a6555982ac");
            });

            modelBuilder.Entity<GameRegistrationPromocode>(entity =>
            {
                entity.ToTable("game_registration_promocodes");

                entity.HasIndex(e => e.GameRegistrationId, "index_game_registration_promocodes_on_game_registration_id");

                entity.HasIndex(e => e.PromocodeId, "index_game_registration_promocodes_on_promocode_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameRegistrationId).HasColumnName("game_registration_id");

                entity.Property(e => e.PromocodeId).HasColumnName("promocode_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<GameRegistrationSert>(entity =>
            {
                entity.ToTable("game_registration_serts");

                entity.HasIndex(e => e.GameRegistrationId, "index_game_registration_serts_on_game_registration_id");

                entity.HasIndex(e => e.SertId, "index_game_registration_serts_on_sert_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameRegistrationId).HasColumnName("game_registration_id");

                entity.Property(e => e.SertId).HasColumnName("sert_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.GameRegistration)
                    .WithMany(p => p.GameRegistrationSerts)
                    .HasForeignKey(d => d.GameRegistrationId)
                    .HasConstraintName("fk_rails_bf23707537");

                entity.HasOne(d => d.Sert)
                    .WithMany(p => p.GameRegistrationSerts)
                    .HasForeignKey(d => d.SertId)
                    .HasConstraintName("fk_rails_f155fc46be");
            });

            modelBuilder.Entity<GameTabImage>(entity =>
            {
                entity.ToTable("game_tab_images");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ImageContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("image_content_type");

                entity.Property(e => e.ImageFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("image_file_name");

                entity.Property(e => e.ImageFileSize).HasColumnName("image_file_size");

                entity.Property(e => e.ImageUpdatedAt).HasColumnName("image_updated_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<GameTrialFeedback>(entity =>
            {
                entity.ToTable("game_trial_feedbacks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<GameTrialQuestion>(entity =>
            {
                entity.ToTable("game_trial_questions");

                entity.HasIndex(e => e.TourId, "index_game_trial_questions_on_tour_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DelayTime)
                    .HasColumnName("delay_time")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.TourId).HasColumnName("tour_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.VideoUrl)
                    .HasColumnType("character varying")
                    .HasColumnName("video_url");
            });

            modelBuilder.Entity<GameTrialReconciliation>(entity =>
            {
                entity.ToTable("game_trial_reconciliations");

                entity.HasIndex(e => e.TourId, "index_game_trial_reconciliations_on_tour_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DelayTime)
                    .HasColumnName("delay_time")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TourId).HasColumnName("tour_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<GameTrialTour>(entity =>
            {
                entity.ToTable("game_trial_tours");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<GameUnregistration>(entity =>
            {
                entity.ToTable("game_unregistrations");

                entity.HasIndex(e => e.GameId, "index_game_unregistrations_on_game_id");

                entity.HasIndex(e => e.TeamId, "index_game_unregistrations_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameUnregistrations)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("fk_rails_f9c594f819");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.GameUnregistrations)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_rails_872858d7bf");
            });

            modelBuilder.Entity<Gameset>(entity =>
            {
                entity.ToTable("gamesets");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.LinkQuestions)
                    .HasColumnType("character varying")
                    .HasColumnName("link_questions");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Number)
                    .HasColumnType("character varying")
                    .HasColumnName("number");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<GamesetCity>(entity =>
            {
                entity.ToTable("gameset_cities");

                entity.HasIndex(e => e.CityId, "index_gameset_cities_on_city_id");

                entity.HasIndex(e => e.GamesetId, "index_gameset_cities_on_gameset_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GamesetId).HasColumnName("gameset_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<HashTag>(entity =>
            {
                entity.ToTable("hash_tags");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Invitation>(entity =>
            {
                entity.ToTable("invitations");

                entity.HasIndex(e => e.TeamId, "index_invitations_on_team_id");

                entity.HasIndex(e => e.UserId, "index_invitations_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.InviterId).HasColumnName("inviter_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'waiting'::character varying");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Inviter)
                    .WithMany(p => p.InvitationInviters)
                    .HasForeignKey(d => d.InviterId)
                    .HasConstraintName("fk_rails_7480156672");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Invitations)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_rails_37fb5b9295");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InvitationUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_7eae413fe6");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("languages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<League>(entity =>
            {
                entity.ToTable("leagues");

                entity.HasIndex(e => e.Name, "index_leagues_on_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<LeroymerlinReg>(entity =>
            {
                entity.ToTable("leroymerlin_regs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.RegCount).HasColumnName("reg_count");

                entity.Property(e => e.Specialty)
                    .HasColumnType("character varying")
                    .HasColumnName("specialty");

                entity.Property(e => e.SurName)
                    .HasColumnType("character varying")
                    .HasColumnName("sur_name");

                entity.Property(e => e.TeamName)
                    .HasColumnType("character varying")
                    .HasColumnName("team_name");

                entity.Property(e => e.Univercity)
                    .HasColumnType("character varying")
                    .HasColumnName("univercity");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Lightning>(entity =>
            {
                entity.ToTable("lightnings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Link)
                    .HasColumnType("character varying")
                    .HasColumnName("link");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<LoyaltyCard>(entity =>
            {
                entity.ToTable("loyalty_cards");

                entity.HasIndex(e => e.UserId, "index_loyalty_cards_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.FreeEntry)
                    .HasColumnName("free_entry")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FullName)
                    .HasColumnType("character varying")
                    .HasColumnName("full_name");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("members");

                entity.HasIndex(e => e.TeamId, "index_members_on_team_id");

                entity.HasIndex(e => e.UserId, "index_members_on_user_id");

                entity.HasIndex(e => new { e.UserId, e.TeamId }, "index_members_on_user_id_and_team_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvatarContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("avatar_content_type");

                entity.Property(e => e.AvatarFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("avatar_file_name");

                entity.Property(e => e.AvatarFileSize).HasColumnName("avatar_file_size");

                entity.Property(e => e.AvatarUpdatedAt).HasColumnName("avatar_updated_at");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.SearchTeam)
                    .HasColumnName("search_team")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.TeamRole)
                    .HasColumnType("character varying")
                    .HasColumnName("team_role");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_rails_e330ef0ccc");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_2e88fb7ce9");
            });

            modelBuilder.Entity<Omnilink>(entity =>
            {
                entity.ToTable("omnilinks");

                entity.HasIndex(e => e.UserId, "index_omnilinks_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Omniauth)
                    .HasColumnType("jsonb")
                    .HasColumnName("omniauth");

                entity.Property(e => e.Provider)
                    .HasColumnType("character varying")
                    .HasColumnName("provider");

                entity.Property(e => e.Uid)
                    .HasColumnType("character varying")
                    .HasColumnName("uid");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Omnilinks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_3e5c8f468a");
            });

            modelBuilder.Entity<OnlineSert>(entity =>
            {
                entity.ToTable("online_serts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ImageContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("image_content_type");

                entity.Property(e => e.ImageFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("image_file_name");

                entity.Property(e => e.ImageFileSize).HasColumnName("image_file_size");

                entity.Property(e => e.ImageUpdatedAt).HasColumnName("image_updated_at");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("number");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Used).HasColumnName("used");

                entity.Property(e => e.ValidityOff).HasColumnName("validity_off");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.HasIndex(e => e.OnlineSertId, "index_orders_on_online_sert_id");

                entity.HasIndex(e => e.ProductId, "index_orders_on_product_id");

                entity.HasIndex(e => e.ProductPromocodeId, "index_orders_on_product_promocode_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.Fio)
                    .HasColumnType("character varying")
                    .HasColumnName("fio");

                entity.Property(e => e.OnlineSertId).HasColumnName("online_sert_id");

                entity.Property(e => e.OrderId)
                    .HasColumnType("character varying")
                    .HasColumnName("orderId");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("order_number");

                entity.Property(e => e.PeopleCount)
                    .HasColumnName("people_count")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductPromocodeId).HasColumnName("product_promocode_id");

                entity.Property(e => e.SendFirstEmail)
                    .HasColumnName("send_first_email")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SendSecondEmail)
                    .HasColumnName("send_second_email")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Status)
                    .HasColumnType("character varying")
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ParlayExpress>(entity =>
            {
                entity.ToTable("parlay_expresses");

                entity.HasIndex(e => e.GameId, "index_parlay_expresses_on_game_id");

                entity.HasIndex(e => e.UserId, "index_parlay_expresses_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccurateArray)
                    .HasColumnType("character varying[]")
                    .HasColumnName("accurate_array")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.Closed)
                    .HasColumnName("closed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ForaArray)
                    .HasColumnType("character varying[]")
                    .HasColumnName("fora_array")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.Parlay).HasColumnName("parlay");

                entity.Property(e => e.RangeArray)
                    .HasColumnType("character varying[]")
                    .HasColumnName("range_array")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<ParlayPassFinal>(entity =>
            {
                entity.ToTable("parlay_pass_finals");

                entity.HasIndex(e => e.GameId, "index_parlay_pass_finals_on_game_id");

                entity.HasIndex(e => e.TeamId, "index_parlay_pass_finals_on_team_id");

                entity.HasIndex(e => e.UserId, "index_parlay_pass_finals_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Closed)
                    .HasColumnName("closed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.Parlay).HasColumnName("parlay");

                entity.Property(e => e.Ratio).HasColumnName("ratio");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<ParlayWhoWin>(entity =>
            {
                entity.ToTable("parlay_who_wins");

                entity.HasIndex(e => e.GameId, "index_parlay_who_wins_on_game_id");

                entity.HasIndex(e => e.TeamId, "index_parlay_who_wins_on_team_id");

                entity.HasIndex(e => e.UserId, "index_parlay_who_wins_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Closed)
                    .HasColumnName("closed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.Parlay).HasColumnName("parlay");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Ratio).HasColumnName("ratio");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.TokenId)
                    .HasColumnType("character varying")
                    .HasColumnName("token_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<ParlayWinner>(entity =>
            {
                entity.ToTable("parlay_winners");

                entity.HasIndex(e => e.GameId, "index_parlay_winners_on_game_id");

                entity.HasIndex(e => e.UserId, "index_parlay_winners_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Closed)
                    .HasColumnName("closed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.ParlayAccurateScore).HasColumnName("parlay_accurate_score");

                entity.Property(e => e.ParlayFora).HasColumnName("parlay_fora");

                entity.Property(e => e.ParlayRangeScores).HasColumnName("parlay_range_scores");

                entity.Property(e => e.RatioFora).HasColumnName("ratio_fora");

                entity.Property(e => e.TokenId)
                    .HasColumnType("character varying")
                    .HasColumnName("token_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.ValueAccurateScore).HasColumnName("value_accurate_score");

                entity.Property(e => e.ValueFora).HasColumnName("value_fora");

                entity.Property(e => e.ValueRangeScores).HasColumnName("value_range_scores");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.ToTable("partners");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Link)
                    .HasColumnType("character varying")
                    .HasColumnName("link");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.PhotoContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("photo_content_type");

                entity.Property(e => e.PhotoFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("photo_file_name");

                entity.Property(e => e.PhotoFileSize).HasColumnName("photo_file_size");

                entity.Property(e => e.PhotoUpdatedAt).HasColumnName("photo_updated_at");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("1000");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.ToTable("photos");

                entity.HasIndex(e => e.GameId, "index_photos_on_game_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Caption)
                    .HasColumnType("character varying")
                    .HasColumnName("caption");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.ImageContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("image_content_type");

                entity.Property(e => e.ImageFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("image_file_name");

                entity.Property(e => e.ImageFileSize).HasColumnName("image_file_size");

                entity.Property(e => e.ImageUpdatedAt).HasColumnName("image_updated_at");

                entity.Property(e => e.MainPhoto)
                    .HasColumnName("main_photo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.ToTable("places");

                entity.HasIndex(e => e.CityId, "index_places_on_city_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnType("character varying")
                    .HasColumnName("address");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GoogleQuery).HasColumnName("google_query");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Site)
                    .HasColumnType("character varying")
                    .HasColumnName("site");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Places)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("fk_rails_93de4496b8");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.HasIndex(e => e.PlaceId, "index_products_on_place_id");

                entity.HasIndex(e => e.RecordedGameId, "index_products_on_recorded_game_id");

                entity.HasIndex(e => e.SpecialGameId, "index_products_on_special_game_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardImageContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("card_image_content_type");

                entity.Property(e => e.CardImageFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("card_image_file_name");

                entity.Property(e => e.CardImageFileSize).HasColumnName("card_image_file_size");

                entity.Property(e => e.CardImageUpdatedAt).HasColumnName("card_image_updated_at");

                entity.Property(e => e.Category)
                    .HasColumnType("character varying")
                    .HasColumnName("category");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("character varying")
                    .HasColumnName("description");

                entity.Property(e => e.DisableRegBtn)
                    .HasColumnName("disable_reg_btn")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.FileContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("file_content_type");

                entity.Property(e => e.FileFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("file_file_name");

                entity.Property(e => e.FileFileSize).HasColumnName("file_file_size");

                entity.Property(e => e.FileUpdatedAt).HasColumnName("file_updated_at");

                entity.Property(e => e.Free)
                    .HasColumnName("free")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.GameWhen).HasColumnName("game_when");

                entity.Property(e => e.Hide)
                    .HasColumnName("hide")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.MaxTeamMemberCount)
                    .HasColumnName("max_team_member_count")
                    .HasDefaultValueSql("9");

                entity.Property(e => e.MinDescription)
                    .HasColumnType("character varying")
                    .HasColumnName("min_description");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.OrderCount)
                    .HasColumnName("order_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlaceId).HasColumnName("place_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.QuizHref)
                    .HasColumnType("character varying")
                    .HasColumnName("quiz_href");

                entity.Property(e => e.RecordedGameId).HasColumnName("recorded_game_id");

                entity.Property(e => e.SoldOut)
                    .HasColumnName("sold_out")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SpecialGameId).HasColumnName("special_game_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProductPromocode>(entity =>
            {
                entity.ToTable("product_promocodes");

                entity.HasIndex(e => e.ProductId, "index_product_promocodes_on_product_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("number");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UsedCount)
                    .HasColumnName("used_count")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Promocode>(entity =>
            {
                entity.ToTable("promocodes");

                entity.HasIndex(e => e.SpecialGameId, "index_promocodes_on_special_game_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Issued)
                    .HasColumnName("issued")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IssuedDate).HasColumnName("issued_date");

                entity.Property(e => e.Issuer)
                    .HasColumnType("character varying")
                    .HasColumnName("issuer");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("number");

                entity.Property(e => e.PersonCount).HasColumnName("person_count");

                entity.Property(e => e.SpecialGameId).HasColumnName("special_game_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UsedCount)
                    .HasColumnName("used_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValidityOff).HasColumnName("validity_off");

                entity.Property(e => e.ValidityType)
                    .HasColumnType("character varying")
                    .HasColumnName("validity_type");

                entity.HasOne(d => d.SpecialGame)
                    .WithMany(p => p.Promocodes)
                    .HasForeignKey(d => d.SpecialGameId)
                    .HasConstraintName("fk_rails_fb0bee6deb");
            });

            modelBuilder.Entity<QdAttachment>(entity =>
            {
                entity.ToTable("qd_attachments");

                entity.HasIndex(e => e.QdQuestionId, "index_qd_attachments_on_qd_question_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.FileContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("file_content_type");

                entity.Property(e => e.FileFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("file_file_name");

                entity.Property(e => e.FileFileSize).HasColumnName("file_file_size");

                entity.Property(e => e.FileType)
                    .HasColumnType("character varying")
                    .HasColumnName("file_type");

                entity.Property(e => e.FileUpdatedAt).HasColumnName("file_updated_at");

                entity.Property(e => e.Purpose)
                    .HasColumnType("character varying")
                    .HasColumnName("purpose");

                entity.Property(e => e.QdQuestionId).HasColumnName("qd_question_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.QdQuestion)
                    .WithMany(p => p.QdAttachments)
                    .HasForeignKey(d => d.QdQuestionId)
                    .HasConstraintName("fk_rails_0b236317e2");
            });

            modelBuilder.Entity<QdCategoriesQuestion>(entity =>
            {
                entity.ToTable("qd_categories_questions");

                entity.HasIndex(e => e.QdCategoryId, "index_qd_categories_questions_on_qd_category_id");

                entity.HasIndex(e => e.QdQuestionId, "index_qd_categories_questions_on_qd_question_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.QdCategoryId).HasColumnName("qd_category_id");

                entity.Property(e => e.QdQuestionId).HasColumnName("qd_question_id");

                entity.HasOne(d => d.QdCategory)
                    .WithMany(p => p.QdCategoriesQuestions)
                    .HasForeignKey(d => d.QdCategoryId)
                    .HasConstraintName("fk_rails_297cf435c9");

                entity.HasOne(d => d.QdQuestion)
                    .WithMany(p => p.QdCategoriesQuestions)
                    .HasForeignKey(d => d.QdQuestionId)
                    .HasConstraintName("fk_rails_34235049e0");
            });

            modelBuilder.Entity<QdCategory>(entity =>
            {
                entity.ToTable("qd_categories");

                entity.HasIndex(e => e.QdCategoryGroupId, "index_qd_categories_on_qd_category_group_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.QdCategoryGroupId).HasColumnName("qd_category_group_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.QdCategoryGroup)
                    .WithMany(p => p.QdCategories)
                    .HasForeignKey(d => d.QdCategoryGroupId)
                    .HasConstraintName("fk_rails_92aebac39c");
            });

            modelBuilder.Entity<QdCategoryGroup>(entity =>
            {
                entity.ToTable("qd_category_groups");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<QdQuestion>(entity =>
            {
                entity.ToTable("qd_questions");

                entity.HasIndex(e => e.GamesetId, "index_qd_questions_on_gameset_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdapterComment).HasColumnName("adapter_comment");

                entity.Property(e => e.AnswerOptions)
                    .HasColumnType("character varying[]")
                    .HasColumnName("answer_options")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.AnswerOptions2)
                    .HasColumnType("character varying[]")
                    .HasColumnName("answer_options_2")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.Complexity).HasColumnName("complexity");

                entity.Property(e => e.CorrectAnswer).HasColumnName("correct_answer");

                entity.Property(e => e.CorrectAnswerVariants)
                    .HasColumnType("character varying[]")
                    .HasColumnName("correct_answer_variants")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DelayTime)
                    .HasColumnName("delay_time")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.GamesetId).HasColumnName("gameset_id");

                entity.Property(e => e.Hint).HasColumnName("hint");

                entity.Property(e => e.Hint1).HasColumnName("hint_1");

                entity.Property(e => e.Hint2).HasColumnName("hint_2");

                entity.Property(e => e.IncludeTest)
                    .HasColumnName("include_test")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IncorrectAnswerVariants)
                    .HasColumnType("character varying[]")
                    .HasColumnName("incorrect_answer_variants")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.InfoLink)
                    .HasColumnType("character varying")
                    .HasColumnName("info_link");

                entity.Property(e => e.InterestingFact).HasColumnName("interesting_fact");

                entity.Property(e => e.MediaLinkToHint1).HasColumnName("media_link_to_hint_1");

                entity.Property(e => e.MediaLinkToHint2).HasColumnName("media_link_to_hint_2");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.OriginalRecord).HasColumnName("original_record");

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.VideoUrl)
                    .HasColumnType("character varying")
                    .HasColumnName("video_url");

                entity.HasOne(d => d.Gameset)
                    .WithMany(p => p.QdQuestions)
                    .HasForeignKey(d => d.GamesetId)
                    .HasConstraintName("fk_rails_9ecfa55ecf");
            });

            modelBuilder.Entity<QdQuestionTag>(entity =>
            {
                entity.ToTable("qd_question_tags");

                entity.HasIndex(e => e.QdQuestionId, "index_qd_question_tags_on_qd_question_id");

                entity.HasIndex(e => e.QdTagId, "index_qd_question_tags_on_qd_tag_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.QdQuestionId).HasColumnName("qd_question_id");

                entity.Property(e => e.QdTagId).HasColumnName("qd_tag_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<QdTag>(entity =>
            {
                entity.ToTable("qd_tags");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<QuickRegistration>(entity =>
            {
                entity.ToTable("quick_registrations");

                entity.HasIndex(e => e.GameRegistrationId, "index_quick_registrations_on_game_registration_id");

                entity.HasIndex(e => e.StandbyId, "index_quick_registrations_on_standby_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CaptainName)
                    .HasColumnType("character varying")
                    .HasColumnName("captain_name");

                entity.Property(e => e.CaptainPhone)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("captain_phone");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameRegistrationId).HasColumnName("game_registration_id");

                entity.Property(e => e.StandbyId).HasColumnName("standby_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserAgreement)
                    .HasColumnName("user_agreement")
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<QuizAnswer>(entity =>
            {
                entity.ToTable("quiz_answers");

                entity.HasIndex(e => e.QuestionId, "index_quiz_answers_on_question_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer)
                    .HasColumnType("character varying")
                    .HasColumnName("answer");

                entity.Property(e => e.Correct).HasColumnName("correct");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameInstanceId).HasColumnName("game_instance_id");

                entity.Property(e => e.Multiplier)
                    .HasColumnName("multiplier")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<QuizGame>(entity =>
            {
                entity.ToTable("quiz_games");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<QuizGameInstance>(entity =>
            {
                entity.ToTable("quiz_game_instances");

                entity.HasIndex(e => e.GameId, "index_quiz_game_instances_on_game_id");

                entity.HasIndex(e => e.UserId, "index_quiz_game_instances_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'in_process'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.QuizGameInstances)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_27a8f1ec37");
            });

            modelBuilder.Entity<QuizHint>(entity =>
            {
                entity.ToTable("quiz_hints");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<QuizQuestion>(entity =>
            {
                entity.ToTable("quiz_questions");

                entity.HasIndex(e => e.TourId, "index_quiz_questions_on_tour_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CorrectAnswer).HasColumnName("correct_answer");

                entity.Property(e => e.CorrectAnswerVariants)
                    .HasColumnType("character varying[]")
                    .HasColumnName("correct_answer_variants")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.InterestingFact).HasColumnName("interesting_fact");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Question).HasColumnName("question");

                entity.Property(e => e.TourId).HasColumnName("tour_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<QuizTour>(entity =>
            {
                entity.ToTable("quiz_tours");

                entity.HasIndex(e => e.GameId, "index_quiz_tours_on_game_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("ratings");

                entity.HasIndex(e => e.CityId, "index_ratings_on_city_id");

                entity.HasIndex(e => e.CurrentGameId, "index_ratings_on_current_game_id");

                entity.HasIndex(e => e.PrevGameId, "index_ratings_on_prev_game_id");

                entity.HasIndex(e => e.TeamId, "index_ratings_on_team_id");

                entity.HasIndex(e => e.ThematicRatingId, "index_ratings_on_thematic_rating_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AllTeamRatingsCount).HasColumnName("all_team_ratings_count");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CurrentGameId).HasColumnName("current_game_id");

                entity.Property(e => e.FirstOfficialGame)
                    .HasColumnName("first_official_game")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.GamesCount)
                    .HasColumnName("games_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastAttendedGameWhen).HasColumnName("last_attended_game_when");

                entity.Property(e => e.LastRegDate).HasColumnName("last_reg_date");

                entity.Property(e => e.Percent)
                    .HasColumnName("percent")
                    .HasDefaultValueSql("0.0");

                entity.Property(e => e.PrevGameId).HasColumnName("prev_game_id");

                entity.Property(e => e.PrevPercent)
                    .HasColumnName("prev_percent")
                    .HasDefaultValueSql("0.0");

                entity.Property(e => e.PrevScores)
                    .HasColumnName("prev_scores")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Scores)
                    .HasColumnName("scores")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.ThematicRatingId).HasColumnName("thematic_rating_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.CurrentGame)
                    .WithMany(p => p.RatingCurrentGames)
                    .HasForeignKey(d => d.CurrentGameId)
                    .HasConstraintName("fk_rails_590537e177");

                entity.HasOne(d => d.PrevGame)
                    .WithMany(p => p.RatingPrevGames)
                    .HasForeignKey(d => d.PrevGameId)
                    .HasConstraintName("fk_rails_c6d84c86c2");
            });

            modelBuilder.Entity<RatiosGame>(entity =>
            {
                entity.ToTable("ratios_games");

                entity.HasIndex(e => e.GameId, "index_ratios_games_on_game_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccurateScore).HasColumnName("accurate_score");

                entity.Property(e => e.ActiveExpress)
                    .HasColumnName("active_express")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ActivePassFinal)
                    .HasColumnName("active_pass_final")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ActiveWhoWin)
                    .HasColumnName("active_who_win")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ActiveWinner)
                    .HasColumnName("active_winner")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CloseParlay).HasColumnName("close_parlay");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Fora).HasColumnName("fora");

                entity.Property(e => e.Fora0).HasColumnName("fora_0");

                entity.Property(e => e.Fora2).HasColumnName("fora_2");

                entity.Property(e => e.Fora3).HasColumnName("fora_3");

                entity.Property(e => e.Fora4).HasColumnName("fora_4");

                entity.Property(e => e.Fora5).HasColumnName("fora_5");

                entity.Property(e => e.Fora6).HasColumnName("fora_6");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.RangeScores).HasColumnName("range_scores");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<RecordedGameAnswer>(entity =>
            {
                entity.ToTable("recorded_game_answers");

                entity.HasIndex(e => e.GameId, "index_recorded_game_answers_on_game_id");

                entity.HasIndex(e => e.RegistrationId, "index_recorded_game_answers_on_registration_id");

                entity.HasIndex(e => e.TourId, "index_recorded_game_answers_on_tour_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer)
                    .HasColumnType("character varying")
                    .HasColumnName("answer");

                entity.Property(e => e.Correct)
                    .HasColumnName("correct")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.Incorrect)
                    .HasColumnName("incorrect")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PlusThree)
                    .HasColumnName("plus_three")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PlusTwo)
                    .HasColumnName("plus_two")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.QuestionNumber).HasColumnName("question_number");

                entity.Property(e => e.RegistrationId).HasColumnName("registration_id");

                entity.Property(e => e.TourId).HasColumnName("tour_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<RecordedGameGame>(entity =>
            {
                entity.ToTable("recorded_game_games");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.MaxResetCount)
                    .HasColumnName("max_reset_count")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.MaxTour)
                    .HasColumnName("max_tour")
                    .HasDefaultValueSql("7");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.SecretCodes)
                    .HasColumnType("character varying[]")
                    .HasColumnName("secret_codes")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<RecordedGameGameInstance>(entity =>
            {
                entity.ToTable("recorded_game_game_instances");

                entity.HasIndex(e => e.GameId, "index_recorded_game_game_instances_on_game_id");

                entity.HasIndex(e => e.RegistrationId, "registration_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CurrentTourNumber)
                    .HasColumnName("current_tour_number")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.RegistrationId).HasColumnName("registration_id");

                entity.Property(e => e.ResetCount)
                    .HasColumnName("reset_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<RecordedGameModeration>(entity =>
            {
                entity.ToTable("recorded_game_moderations");

                entity.HasIndex(e => e.AnswerId, "index_recorded_game_moderations_on_answer_id");

                entity.HasIndex(e => e.QuestionId, "index_recorded_game_moderations_on_question_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnswerId).HasColumnName("answer_id");

                entity.Property(e => e.Correct)
                    .HasColumnName("correct")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Incorrect)
                    .HasColumnName("incorrect")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.TeamAnswer)
                    .HasColumnType("character varying")
                    .HasColumnName("team_answer");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<RecordedGameQuestion>(entity =>
            {
                entity.ToTable("recorded_game_questions");

                entity.HasIndex(e => e.TourId, "index_recorded_game_questions_on_tour_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CorrectAnswerVariants)
                    .HasColumnType("character varying[]")
                    .HasColumnName("correct_answer_variants")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.IncorrectAnswerVariants)
                    .HasColumnType("character varying[]")
                    .HasColumnName("incorrect_answer_variants")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.TourId).HasColumnName("tour_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<RecordedGameRegistration>(entity =>
            {
                entity.ToTable("recorded_game_registrations");

                entity.HasIndex(e => e.GameId, "index_recorded_game_registrations_on_game_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.RoundFive)
                    .HasColumnName("round_five")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundFour)
                    .HasColumnName("round_four")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundOne)
                    .HasColumnName("round_one")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundSeven)
                    .HasColumnName("round_seven")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundSix)
                    .HasColumnName("round_six")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundThree)
                    .HasColumnName("round_three")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundTwo)
                    .HasColumnName("round_two")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SecretCode)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("secret_code");

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("team_name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<RecordedGameTour>(entity =>
            {
                entity.ToTable("recorded_game_tours");

                entity.HasIndex(e => e.GameId, "index_recorded_game_tours_on_game_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DisableAnswerTime)
                    .HasColumnName("disable_answer_time")
                    .HasDefaultValueSql("120");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PlusThree)
                    .HasColumnName("plus_three")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PlusTwo)
                    .HasColumnName("plus_two")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.QuestionCount)
                    .HasColumnName("question_count")
                    .HasDefaultValueSql("7");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.VideoUrl)
                    .HasColumnType("character varying")
                    .HasColumnName("video_url");
            });

            modelBuilder.Entity<RegistrationStatistic>(entity =>
            {
                entity.ToTable("registration_statistics");

                entity.HasIndex(e => e.TeamId, "index_registration_statistics_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DifferenceReg).HasColumnName("difference_reg");

                entity.Property(e => e.ExpectedReg).HasColumnName("expected_reg");

                entity.Property(e => e.LastReg).HasColumnName("last_reg");

                entity.Property(e => e.SendTime).HasColumnName("send_time");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<RelationshipWinnersExpress>(entity =>
            {
                entity.ToTable("relationship_winners_expresses");

                entity.HasIndex(e => e.ParlayExpressId, "index_relationship_winners_expresses_on_parlay_express_id");

                entity.HasIndex(e => e.ParlayWinnerId, "index_relationship_winners_expresses_on_parlay_winner_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ParlayExpressId).HasColumnName("parlay_express_id");

                entity.Property(e => e.ParlayWinnerId).HasColumnName("parlay_winner_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<RelationshipWinsExpress>(entity =>
            {
                entity.ToTable("relationship_wins_expresses");

                entity.HasIndex(e => e.ParlayExpressId, "index_relationship_wins_expresses_on_parlay_express_id");

                entity.HasIndex(e => e.ParlayWhoWinId, "index_relationship_wins_expresses_on_parlay_who_win_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ParlayExpressId).HasColumnName("parlay_express_id");

                entity.Property(e => e.ParlayWhoWinId).HasColumnName("parlay_who_win_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<RequestInvitation>(entity =>
            {
                entity.ToTable("request_invitations");

                entity.HasIndex(e => e.MemberId, "index_request_invitations_on_member_id");

                entity.HasIndex(e => e.TeamId, "index_request_invitations_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.MemberId).HasColumnName("member_id");

                entity.Property(e => e.Status)
                    .HasColumnType("character varying")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'waiting'::character varying");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.RequestInvitations)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_rails_44db3ebcbf");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.HasIndex(e => new { e.Name, e.ResourceType, e.ResourceId }, "index_roles_on_name_and_resource_type_and_resource_id");

                entity.HasIndex(e => new { e.ResourceType, e.ResourceId }, "index_roles_on_resource_type_and_resource_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.ResourceId).HasColumnName("resource_id");

                entity.Property(e => e.ResourceType)
                    .HasColumnType("character varying")
                    .HasColumnName("resource_type");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<SchemaMigration>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("schema_migrations_pkey");

                entity.ToTable("schema_migrations");

                entity.Property(e => e.Version)
                    .HasColumnType("character varying")
                    .HasColumnName("version");
            });

            modelBuilder.Entity<Scoring>(entity =>
            {
                entity.ToTable("scorings");

                entity.HasIndex(e => e.TeamId, "index_scorings_on_team_id");

                entity.HasIndex(e => e.UserId, "index_scorings_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Key)
                    .HasColumnType("character varying")
                    .HasColumnName("key");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Scorings)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_rails_9875de4fec");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Scorings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_5c72292e23");
            });

            modelBuilder.Entity<Sert>(entity =>
            {
                entity.ToTable("serts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActivationDate).HasColumnName("activation_date");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Electronic)
                    .HasColumnName("electronic")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.ImageContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("image_content_type");

                entity.Property(e => e.ImageFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("image_file_name");

                entity.Property(e => e.ImageFileSize).HasColumnName("image_file_size");

                entity.Property(e => e.ImageUpdatedAt).HasColumnName("image_updated_at");

                entity.Property(e => e.Issued)
                    .HasColumnName("issued")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IssuedAdminDate).HasColumnName("issued_admin_date");

                entity.Property(e => e.Issuer)
                    .HasColumnType("character varying")
                    .HasColumnName("issuer");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Number)
                    .HasColumnType("character varying")
                    .HasColumnName("number");

                entity.Property(e => e.PersonCount).HasColumnName("person_count");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.SertType)
                    .HasColumnType("character varying")
                    .HasColumnName("sert_type")
                    .HasDefaultValueSql("'beginner'::character varying");

                entity.Property(e => e.Take)
                    .HasColumnType("character varying")
                    .HasColumnName("take");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Used)
                    .HasColumnName("used")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ValidityOff).HasColumnName("validity_off");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("sessions");

                entity.HasIndex(e => e.SessionId, "index_sessions_on_session_id")
                    .IsUnique();

                entity.HasIndex(e => e.UpdatedAt, "index_sessions_on_updated_at");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("session_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<SpecialGame>(entity =>
            {
                entity.ToTable("special_games");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActiveTour)
                    .HasColumnType("character varying")
                    .HasColumnName("active_tour");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EmbedUrl)
                    .HasColumnType("character varying")
                    .HasColumnName("embed_url");

                entity.Property(e => e.GameStatus)
                    .HasColumnType("character varying")
                    .HasColumnName("game_status");

                entity.Property(e => e.GoogleFormUrl)
                    .HasColumnType("character varying")
                    .HasColumnName("google_form_url");

                entity.Property(e => e.MaxTeamsCount)
                    .HasColumnName("max_teams_count")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.MaxTour)
                    .HasColumnName("max_tour")
                    .HasDefaultValueSql("7");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Organizator)
                    .HasColumnType("character varying")
                    .HasColumnName("organizator")
                    .HasDefaultValueSql("'mozgva'::character varying");

                entity.Property(e => e.QuestionCount)
                    .HasColumnType("character varying[]")
                    .HasColumnName("question_count")
                    .HasDefaultValueSql("'{6,6,6,3,6,6,6}'::character varying[]");

                entity.Property(e => e.SecretCodes)
                    .HasColumnType("character varying[]")
                    .HasColumnName("secret_codes")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.SpreadsheetKey)
                    .HasColumnType("character varying")
                    .HasColumnName("spreadsheet_key");

                entity.Property(e => e.TourPriority)
                    .HasColumnType("character varying")
                    .HasColumnName("tour_priority")
                    .HasDefaultValueSql("'7, 4, 6, 1, 2, 3, 5'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.When).HasColumnName("when");
            });

            modelBuilder.Entity<SpecialGameAnswer>(entity =>
            {
                entity.ToTable("special_game_answers");

                entity.HasIndex(e => e.SpecialGameId, "index_special_game_answers_on_special_game_id");

                entity.HasIndex(e => e.SpecialRegistrationId, "index_special_game_answers_on_special_registration_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer)
                    .HasColumnType("character varying")
                    .HasColumnName("answer");

                entity.Property(e => e.Correct).HasColumnName("correct");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.QuestionNumber).HasColumnName("question_number");

                entity.Property(e => e.SpecialGameId).HasColumnName("special_game_id");

                entity.Property(e => e.SpecialRegistrationId).HasColumnName("special_registration_id");

                entity.Property(e => e.TourNumber).HasColumnName("tour_number");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<SpecialRegistration>(entity =>
            {
                entity.ToTable("special_registrations");

                entity.HasIndex(e => e.SpecialGameId, "index_special_registrations_on_special_game_id");

                entity.HasIndex(e => e.UserId, "index_special_registrations_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Banned)
                    .HasColumnName("banned")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CityName)
                    .HasColumnType("character varying")
                    .HasColumnName("city_name");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.RoundFive)
                    .HasColumnName("round_five")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundFour)
                    .HasColumnName("round_four")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundOne)
                    .HasColumnName("round_one")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundSeven)
                    .HasColumnName("round_seven")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundSix)
                    .HasColumnName("round_six")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundThree)
                    .HasColumnName("round_three")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundTwo)
                    .HasColumnName("round_two")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SecretCode)
                    .HasColumnType("character varying")
                    .HasColumnName("secret_code");

                entity.Property(e => e.SpecialGameId).HasColumnName("special_game_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserConnections)
                    .HasColumnType("character varying[]")
                    .HasColumnName("user_connections")
                    .HasDefaultValueSql("'{}'::character varying[]");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.SpecialGame)
                    .WithMany(p => p.SpecialRegistrations)
                    .HasForeignKey(d => d.SpecialGameId)
                    .HasConstraintName("fk_rails_52658b77e1");
            });

            modelBuilder.Entity<Standby>(entity =>
            {
                entity.ToTable("standbies");

                entity.HasIndex(e => e.GameId, "index_standbies_on_game_id");

                entity.HasIndex(e => e.TeamId, "index_standbies_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.GameSet).HasColumnName("game_set");

                entity.Property(e => e.PeopleNumber).HasColumnName("people_number");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Standbies)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("fk_rails_116e1b7b15");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Standbies)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_rails_da6c2ced04");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("teams");

                entity.HasIndex(e => e.Invite, "index_teams_on_invite")
                    .IsUnique();

                entity.HasIndex(e => e.LeagueId, "index_teams_on_league_id");

                entity.HasIndex(e => e.Name, "index_teams_on_name");

                entity.HasIndex(e => e.RegistrationCityId, "index_teams_on_registration_city_id");

                entity.HasIndex(e => e.SpecialCityId, "index_teams_on_special_city_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AfterGameTeamEmail)
                    .HasColumnName("after_game_team_email")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AfterGrTeamEmail)
                    .HasColumnName("after_gr_team_email")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllPhones)
                    .HasColumnType("character varying")
                    .HasColumnName("all_phones");

                entity.Property(e => e.BackPhotoContentType)
                    .HasColumnType("character varying")
                    .HasColumnName("back_photo_content_type");

                entity.Property(e => e.BackPhotoFileName)
                    .HasColumnType("character varying")
                    .HasColumnName("back_photo_file_name");

                entity.Property(e => e.BackPhotoFileSize).HasColumnName("back_photo_file_size");

                entity.Property(e => e.BackPhotoUpdatedAt).HasColumnName("back_photo_updated_at");

                entity.Property(e => e.BackupPhone)
                    .HasColumnType("character varying")
                    .HasColumnName("backup_phone");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Creator)
                    .HasColumnType("character varying")
                    .HasColumnName("creator");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.Invite)
                    .HasColumnType("character varying")
                    .HasColumnName("invite");

                entity.Property(e => e.LeagueId).HasColumnName("league_id");

                entity.Property(e => e.Loyalty)
                    .HasColumnType("character varying")
                    .HasColumnName("loyalty");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.Ratio).HasColumnName("ratio");

                entity.Property(e => e.RegistrationCityId).HasColumnName("registration_city_id");

                entity.Property(e => e.RelatedTeamIds)
                    .HasColumnName("related_team_ids")
                    .HasDefaultValueSql("'{}'::integer[]");

                entity.Property(e => e.Secret)
                    .HasColumnType("character varying")
                    .HasColumnName("secret");

                entity.Property(e => e.SpecialCityId).HasColumnName("special_city_id");

                entity.Property(e => e.Status)
                    .HasColumnType("character varying")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'status_active'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.League)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.LeagueId)
                    .HasConstraintName("fk_rails_99e3bbb19c");

                entity.HasOne(d => d.RegistrationCity)
                    .WithMany(p => p.TeamRegistrationCities)
                    .HasForeignKey(d => d.RegistrationCityId)
                    .HasConstraintName("fk_rails_42689334ef");

                entity.HasOne(d => d.SpecialCity)
                    .WithMany(p => p.TeamSpecialCities)
                    .HasForeignKey(d => d.SpecialCityId)
                    .HasConstraintName("fk_rails_a8f01bbd4a");
            });

            modelBuilder.Entity<TeamHashTag>(entity =>
            {
                entity.ToTable("team_hash_tags");

                entity.HasIndex(e => e.HashTagId, "index_team_hash_tags_on_hash_tag_id");

                entity.HasIndex(e => e.TeamId, "index_team_hash_tags_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.HashTagId).HasColumnName("hash_tag_id");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<TeamRating>(entity =>
            {
                entity.ToTable("team_ratings");

                entity.HasIndex(e => e.GameId, "index_team_ratings_on_game_id");

                entity.HasIndex(e => e.TeamId, "index_team_ratings_on_team_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attended).HasColumnName("attended");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.MaxScore).HasColumnName("max_score");

                entity.Property(e => e.RoundFive)
                    .HasColumnName("round_five")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundFour)
                    .HasColumnName("round_four")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundOne)
                    .HasColumnName("round_one")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundSeven)
                    .HasColumnName("round_seven")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundSix)
                    .HasColumnName("round_six")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundThree)
                    .HasColumnName("round_three")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoundTwo)
                    .HasColumnName("round_two")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<TestAnswer>(entity =>
            {
                entity.ToTable("test_answers");

                entity.HasIndex(e => e.QuestionId, "index_test_answers_on_question_id");

                entity.HasIndex(e => e.UserId, "index_test_answers_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer)
                    .HasColumnType("character varying")
                    .HasColumnName("answer");

                entity.Property(e => e.Correct)
                    .HasColumnName("correct")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Incorrect)
                    .HasColumnName("incorrect")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TestModeration>(entity =>
            {
                entity.ToTable("test_moderations");

                entity.HasIndex(e => e.AnswerId, "index_test_moderations_on_answer_id");

                entity.HasIndex(e => e.QuestionId, "index_test_moderations_on_question_id");

                entity.HasIndex(e => e.UserId, "index_test_moderations_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnswerId).HasColumnName("answer_id");

                entity.Property(e => e.Correct)
                    .HasColumnName("correct")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Incorrect)
                    .HasColumnName("incorrect")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TestRating>(entity =>
            {
                entity.ToTable("test_ratings");

                entity.HasIndex(e => e.UserId, "index_test_ratings_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.TestCount).HasColumnName("test_count");

                entity.Property(e => e.Tour1).HasColumnName("tour_1");

                entity.Property(e => e.Tour2).HasColumnName("tour_2");

                entity.Property(e => e.Tour3).HasColumnName("tour_3");

                entity.Property(e => e.Tour4).HasColumnName("tour_4");

                entity.Property(e => e.Tour5).HasColumnName("tour_5");

                entity.Property(e => e.Tour6).HasColumnName("tour_6");

                entity.Property(e => e.Tour7).HasColumnName("tour_7");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TestRelationship>(entity =>
            {
                entity.ToTable("test_relationships");

                entity.HasIndex(e => e.QuestionId, "index_test_relationships_on_question_id");

                entity.HasIndex(e => e.TourId, "index_test_relationships_on_tour_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.TourId).HasColumnName("tour_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<TestTest>(entity =>
            {
                entity.ToTable("test_tests");

                entity.HasIndex(e => e.UserId, "index_test_tests_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EndPage)
                    .HasColumnName("end_page")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.LastQuestion)
                    .HasColumnName("last_question")
                    .HasDefaultValueSql("'-1'::integer");

                entity.Property(e => e.LastTour)
                    .HasColumnName("last_tour")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TestTour>(entity =>
            {
                entity.ToTable("test_tours");

                entity.HasIndex(e => e.TestId, "index_test_tours_on_test_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.TestId).HasColumnName("test_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ThematicRating>(entity =>
            {
                entity.ToTable("thematic_ratings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ThematicRatingCity>(entity =>
            {
                entity.ToTable("thematic_rating_cities");

                entity.HasIndex(e => e.CityId, "index_thematic_rating_cities_on_city_id");

                entity.HasIndex(e => e.ThematicRatingId, "index_thematic_rating_cities_on_thematic_rating_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.ThematicRatingId).HasColumnName("thematic_rating_id");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.CityFranchiseId, "index_users_on_city_franchise_id");

                entity.HasIndex(e => e.CityId, "index_users_on_city_id");

                entity.HasIndex(e => e.CurrentMemberId, "index_users_on_current_member_id");

                entity.HasIndex(e => e.Email, "index_users_on_email")
                    .IsUnique();

                entity.HasIndex(e => e.ResetPasswordToken, "index_users_on_reset_password_token")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityFranchiseId).HasColumnName("city_franchise_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.ConfirmationCode)
                    .HasColumnType("character varying")
                    .HasColumnName("confirmation_code");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CurrentMemberId).HasColumnName("current_member_id");

                entity.Property(e => e.CurrentSignInAt).HasColumnName("current_sign_in_at");

                entity.Property(e => e.CurrentSignInIp).HasColumnName("current_sign_in_ip");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("email")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.EncryptedPassword)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("encrypted_password")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Fb)
                    .HasColumnType("character varying")
                    .HasColumnName("fb")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Inst)
                    .HasColumnType("character varying")
                    .HasColumnName("inst")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.LastSignInAt).HasColumnName("last_sign_in_at");

                entity.Property(e => e.LastSignInIp).HasColumnName("last_sign_in_ip");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneConfirmedAt).HasColumnName("phone_confirmed_at");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.RememberCreatedAt).HasColumnName("remember_created_at");

                entity.Property(e => e.ResetPasswordSentAt).HasColumnName("reset_password_sent_at");

                entity.Property(e => e.ResetPasswordToken)
                    .HasColumnType("character varying")
                    .HasColumnName("reset_password_token");

                entity.Property(e => e.SignInCount).HasColumnName("sign_in_count");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Vk)
                    .HasColumnType("character varying")
                    .HasColumnName("vk")
                    .HasDefaultValueSql("''::character varying");

                entity.HasOne(d => d.CityFranchise)
                    .WithMany(p => p.UserCityFranchises)
                    .HasForeignKey(d => d.CityFranchiseId)
                    .HasConstraintName("fk_rails_c4899cfc9e");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.UserCities)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("fk_rails_9c7442481a");
            });

            modelBuilder.Entity<UsersRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("users_roles");

                entity.HasIndex(e => e.RoleId, "index_users_roles_on_role_id");

                entity.HasIndex(e => e.UserId, "index_users_roles_on_user_id");

                entity.HasIndex(e => new { e.UserId, e.RoleId }, "index_users_roles_on_user_id_and_role_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            OnModelCreatingPartial(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
