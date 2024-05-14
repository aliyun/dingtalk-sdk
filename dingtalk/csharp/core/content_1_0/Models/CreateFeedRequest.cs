// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class CreateFeedRequest : TeaModel {
        [NameInMap("courseInfo")]
        [Validation(Required=false)]
        public CreateFeedRequestCourseInfo CourseInfo { get; set; }
        public class CreateFeedRequestCourseInfo : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("lectorUserInfo")]
            [Validation(Required=false)]
            public CreateFeedRequestCourseInfoLectorUserInfo LectorUserInfo { get; set; }
            public class CreateFeedRequestCourseInfoLectorUserInfo : TeaModel {
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("payInfo")]
            [Validation(Required=false)]
            public CreateFeedRequestCourseInfoPayInfo PayInfo { get; set; }
            public class CreateFeedRequestCourseInfoPayInfo : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("csUserInfo")]
                [Validation(Required=false)]
                public CreateFeedRequestCourseInfoPayInfoCsUserInfo CsUserInfo { get; set; }
                public class CreateFeedRequestCourseInfoPayInfoCsUserInfo : TeaModel {
                    [NameInMap("avatar")]
                    [Validation(Required=false)]
                    public string Avatar { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("discountInfo")]
                [Validation(Required=false)]
                public CreateFeedRequestCourseInfoPayInfoDiscountInfo DiscountInfo { get; set; }
                public class CreateFeedRequestCourseInfoPayInfoDiscountInfo : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("endTimeMillis")]
                    [Validation(Required=false)]
                    public long? EndTimeMillis { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("startTimeMillis")]
                    [Validation(Required=false)]
                    public long? StartTimeMillis { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

            }

            [NameInMap("studyGroupName")]
            [Validation(Required=false)]
            public string StudyGroupName { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("createUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("feedInfo")]
        [Validation(Required=false)]
        public CreateFeedRequestFeedInfo FeedInfo { get; set; }
        public class CreateFeedRequestFeedInfo : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("belongsTo")]
            [Validation(Required=false)]
            public int? BelongsTo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("feedCategory")]
            [Validation(Required=false)]
            public long? FeedCategory { get; set; }

            [NameInMap("feedId")]
            [Validation(Required=false)]
            public string FeedId { get; set; }

            [NameInMap("feedTag")]
            [Validation(Required=false)]
            public string FeedTag { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("feedType")]
            [Validation(Required=false)]
            public int? FeedType { get; set; }

            [NameInMap("industryId")]
            [Validation(Required=false)]
            public long? IndustryId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            [NameInMap("introductionPicUrl")]
            [Validation(Required=false)]
            public string IntroductionPicUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("mcnId")]
            [Validation(Required=false)]
            public string McnId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("mediaContents")]
            [Validation(Required=false)]
            public List<CreateFeedRequestFeedInfoMediaContents> MediaContents { get; set; }
            public class CreateFeedRequestFeedInfoMediaContents : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("mediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("recommends")]
            [Validation(Required=false)]
            public List<CreateFeedRequestFeedInfoRecommends> Recommends { get; set; }
            public class CreateFeedRequestFeedInfoRecommends : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("objectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("thumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
