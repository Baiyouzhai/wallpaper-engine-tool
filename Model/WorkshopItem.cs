using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Wallpaper.Model {

    public class WorkshopItem {

        protected long publishedFileId;
        protected string workshopItemTitle;
        protected string url;
        protected BrowseItem borwse;
        protected FileDetails details;

        public long PublishedFileId { get => publishedFileId; set => publishedFileId = value; }
        public string WorkshopItemTitle { get => workshopItemTitle; set => workshopItemTitle = value; }
        public string Url { get => url; set => url = value; }
        public BrowseItem Borwse { get => borwse; set => borwse = value; }
        public FileDetails Details { get => details; set => details = value; }

    }

    public static class WorkshopItemExtend {

        public static FileDetailsPage ToFileDetailsPage(this WorkshopItem item) {
            FileDetailsPage page = new FileDetailsPage {
                PublishedFileId = item.PublishedFileId,
                WorkshopItemTitle = item.WorkshopItemTitle,
                Url = item.Url
            };
            if (null != item.Borwse) {
                page.WorkshopItemPreviewImage = item.Borwse.WorkshopItemPreviewImage;
                page.WorkshopItemAuthorName = item.Borwse.WorkshopItemAuthorName;
                page.Description = item.Borwse.Description;
                page.FileRating = item.Borwse.FileRating;
            }
            if (null != item.Details) {
                page.VisibilityNotificationPrivate = item.Details.VisibilityNotificationPrivate;
                page.VisibilityNotificationFriendsOnly = item.Details.VisibilityNotificationFriendsOnly;
                page.NumRatings = item.Details.NumRatings;
                page.Size = item.Details.Size;
                page.CreateTime = item.Details.CreateTime;
                page.Miscellaneous = item.Details.Miscellaneous;
                page.Type = item.Details.Type;
                page.AgeRating = item.Details.AgeRating;
                page.Genre = item.Details.Genre;
                page.Resolution = item.Details.Resolution;
                page.Category = item.Details.Category;
                page.UniqueVisitors = item.Details.UniqueVisitors;
                page.CurrentSubscribers = item.Details.CurrentSubscribers;
                page.CurrentFavorites = item.Details.CurrentFavorites;
            }
            return page;
        }

    }

}
