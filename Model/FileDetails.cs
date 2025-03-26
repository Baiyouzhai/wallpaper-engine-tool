using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.Model {

    public class FileDetails {

        protected string visibilityNotificationPrivate;
        protected string visibilityNotificationFriendsOnly;
        protected int numRatings;
        protected string size;
        protected string createTime;
        protected string miscellaneous;
        protected string type;
        protected string ageRating;
        protected string genre;
        protected string resolution;
        protected string category;
        protected int uniqueVisitors;
        protected int currentSubscribers;
        protected int currentFavorites;

        public string VisibilityNotificationPrivate { get => visibilityNotificationPrivate; set => visibilityNotificationPrivate = value; }
        public string VisibilityNotificationFriendsOnly { get => visibilityNotificationFriendsOnly; set => visibilityNotificationFriendsOnly = value; }
        public int NumRatings { get => numRatings; set => numRatings = value; }
        public string Size { get => size; set => size = value; }
        public string CreateTime { get => createTime; set => createTime = value; }
        public string Miscellaneous { get => miscellaneous; set => miscellaneous = value; }
        public string Type { get => type; set => type = value; }
        public string AgeRating { get => ageRating; set => ageRating = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Resolution { get => resolution; set => resolution = value; }
        public string Category { get => category; set => category = value; }
        public int UniqueVisitors { get => uniqueVisitors; set => uniqueVisitors = value; }
        public int CurrentSubscribers { get => currentSubscribers; set => currentSubscribers = value; }
        public int CurrentFavorites { get => currentFavorites; set => currentFavorites = value; }
        
    }

    public class FileDetailsPage {

        protected long publishedFileId;
        protected string workshopItemTitle;
        protected string url;
        protected string workshopItemPreviewImage;
        protected string workshopItemAuthorName;
        protected string description;
        protected int fileRating;
        protected string visibilityNotificationPrivate;
        protected string visibilityNotificationFriendsOnly;
        protected int numRatings;
        protected string size;
        protected string createTime;
        protected string miscellaneous;
        protected string type;
        protected string ageRating;
        protected string genre;
        protected string resolution;
        protected string category;
        protected int uniqueVisitors;
        protected int currentSubscribers;
        protected int currentFavorites;

        public long PublishedFileId { get => publishedFileId; set => publishedFileId = value; }
        public string WorkshopItemTitle { get => workshopItemTitle; set => workshopItemTitle = value; }
        public string Url { get => url; set => url = value; }
        public string WorkshopItemPreviewImage { get => workshopItemPreviewImage; set => workshopItemPreviewImage = value; }
        public string WorkshopItemAuthorName { get => workshopItemAuthorName; set => workshopItemAuthorName = value; }
        public string Description { get => description; set => description = value; }
        public int FileRating { get => fileRating; set => fileRating = value; }
        public string VisibilityNotificationPrivate { get => visibilityNotificationPrivate; set => visibilityNotificationPrivate = value; }
        public string VisibilityNotificationFriendsOnly { get => visibilityNotificationFriendsOnly; set => visibilityNotificationFriendsOnly = value; }
        public int NumRatings { get => numRatings; set => numRatings = value; }
        public string Size { get => size; set => size = value; }
        public string CreateTime { get => createTime; set => createTime = value; }
        public string Miscellaneous { get => miscellaneous; set => miscellaneous = value; }
        public string Type { get => type; set => type = value; }
        public string AgeRating { get => ageRating; set => ageRating = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Resolution { get => resolution; set => resolution = value; }
        public string Category { get => category; set => category = value; }
        public int UniqueVisitors { get => uniqueVisitors; set => uniqueVisitors = value; }
        public int CurrentSubscribers { get => currentSubscribers; set => currentSubscribers = value; }
        public int CurrentFavorites { get => currentFavorites; set => currentFavorites = value; }

        public void Set(string key, string value) {
            switch (key) {
                case "Miscellaneous": Miscellaneous = value; break;
                case "Type": Type = value; break;
                case "Age Rating": AgeRating = value; break;
                case "Genre": Genre = value; break;
                case "Resolution": Resolution = value; break;
                case "Category": Category = value; break;
                default: break;
            }
        }

    }

    public static class FileDetailsPageExtend {

        public static FileDetails ToFileDetail(this FileDetailsPage page) {
            return new FileDetails {
                VisibilityNotificationPrivate = page.VisibilityNotificationPrivate,
                VisibilityNotificationFriendsOnly = page.VisibilityNotificationFriendsOnly,
                NumRatings = page.NumRatings,
                Size = page.Size,
                CreateTime = page.CreateTime,
                Miscellaneous = page.Miscellaneous,
                Type = page.Type,
                AgeRating = page.AgeRating,
                Genre = page.Genre,
                Resolution = page.Resolution,
                Category = page.Category,
                UniqueVisitors = page.UniqueVisitors,
                CurrentSubscribers = page.CurrentSubscribers,
                CurrentFavorites = page.CurrentFavorites
            };
        }

    }

}
