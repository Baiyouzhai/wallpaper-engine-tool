using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.Model {

    public class BrowseItem {

        protected string workshopItemPreviewImage;
        protected string workshopItemAuthorName;
        protected string description;
        protected int fileRating;

        public string WorkshopItemPreviewImage { get => workshopItemPreviewImage; set => workshopItemPreviewImage = value; }
        public string WorkshopItemAuthorName { get => workshopItemAuthorName; set => workshopItemAuthorName = value; }
        public string Description { get => description; set => description = value; }
        public int FileRating { get => fileRating; set => fileRating = value; }

    }

    public class BrowseItemPage {

        protected long publishedFileId;
        protected string workshopItemTitle;
        protected string url;
        protected string workshopItemPreviewImage;
        protected string workshopItemAuthorName;
        protected string description;
        protected int fileRating;

        public long PublishedFileId { get => publishedFileId; set => publishedFileId = value; }
        public string WorkshopItemTitle { get => workshopItemTitle; set => workshopItemTitle = value; }
        public string Url { get => url; set => url = value; }
        public string WorkshopItemPreviewImage { get => workshopItemPreviewImage; set => workshopItemPreviewImage = value; }
        public string WorkshopItemAuthorName { get => workshopItemAuthorName; set => workshopItemAuthorName = value; }
        public string Description { get => description; set => description = value; }
        public int FileRating { get => fileRating; set => fileRating = value; }

    }

    public static class BrowseItemPageExtend {

        public static BrowseItem ToBrowseItem(this BrowseItemPage page) {
            return new BrowseItem {
                WorkshopItemPreviewImage = page.WorkshopItemPreviewImage,
                WorkshopItemAuthorName = page.WorkshopItemAuthorName,
                Description = page.Description,
                FileRating = page.FileRating
            };
        }

    }

}
