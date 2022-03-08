// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class CreateFeedRequest : TeaModel {
        /// <summary>
        /// 课程相关信息
        /// </summary>
        [NameInMap("courseInfo")]
        [Validation(Required=false)]
        public CreateFeedRequestCourseInfo CourseInfo { get; set; }
        public class CreateFeedRequestCourseInfo : TeaModel {
            [NameInMap("lectorUserInfo")]
            [Validation(Required=false)]
            public CreateFeedRequestCourseInfoLectorUserInfo LectorUserInfo { get; set; }
            public class CreateFeedRequestCourseInfoLectorUserInfo : TeaModel {
                /// <summary>
                /// 讲师头像链接
                /// </summary>
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// 讲师用户名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 讲师用户Id
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
                /// 客服身份信息
                /// </summary>
                [NameInMap("csUserInfo")]
                [Validation(Required=false)]
                public CreateFeedRequestCourseInfoPayInfoCsUserInfo CsUserInfo { get; set; }
                public class CreateFeedRequestCourseInfoPayInfoCsUserInfo : TeaModel {
                    [NameInMap("avatar")]
                    [Validation(Required=false)]
                    public string Avatar { get; set; }
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }
                };

                /// <summary>
                /// 课程打折信息
                /// </summary>
                [NameInMap("discountInfo")]
                [Validation(Required=false)]
                public CreateFeedRequestCourseInfoPayInfoDiscountInfo DiscountInfo { get; set; }
                public class CreateFeedRequestCourseInfoPayInfoDiscountInfo : TeaModel {
                    [NameInMap("endTimeMillis")]
                    [Validation(Required=false)]
                    public long? EndTimeMillis { get; set; }
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }
                    [NameInMap("startTimeMillis")]
                    [Validation(Required=false)]
                    public long? StartTimeMillis { get; set; }
                };

                /// <summary>
                /// 商品的默认情况下非打折时的价格，单位为分
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

            }
            [NameInMap("studyGroupName")]
            [Validation(Required=false)]
            public string StudyGroupName { get; set; }
        };

        /// <summary>
        /// 发布者的用户Id
        /// </summary>
        [NameInMap("createUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 内容相关信息
        /// </summary>
        [NameInMap("feedInfo")]
        [Validation(Required=false)]
        public CreateFeedRequestFeedInfo FeedInfo { get; set; }
        public class CreateFeedRequestFeedInfo : TeaModel {
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }
            [NameInMap("belongsTo")]
            [Validation(Required=false)]
            public int? BelongsTo { get; set; }
            [NameInMap("feedCategory")]
            [Validation(Required=false)]
            public long? FeedCategory { get; set; }
            [NameInMap("feedId")]
            [Validation(Required=false)]
            public string FeedId { get; set; }
            [NameInMap("feedTag")]
            [Validation(Required=false)]
            public string FeedTag { get; set; }
            [NameInMap("feedType")]
            [Validation(Required=false)]
            public int? FeedType { get; set; }
            [NameInMap("industryId")]
            [Validation(Required=false)]
            public long? IndustryId { get; set; }
            [NameInMap("introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }
            [NameInMap("introductionPicUrl")]
            [Validation(Required=false)]
            public string IntroductionPicUrl { get; set; }
            [NameInMap("mcnId")]
            [Validation(Required=false)]
            public string McnId { get; set; }
            [NameInMap("mediaContents")]
            [Validation(Required=false)]
            public List<CreateFeedRequestFeedInfoMediaContents> MediaContents { get; set; }
            public class CreateFeedRequestFeedInfoMediaContents : TeaModel {
                public string MediaId { get; set; }
                public string Title { get; set; }
                public int? Type { get; set; }
            }
            [NameInMap("recommends")]
            [Validation(Required=false)]
            public List<CreateFeedRequestFeedInfoRecommends> Recommends { get; set; }
            public class CreateFeedRequestFeedInfoRecommends : TeaModel {
                public string ObjectId { get; set; }
                public int? Type { get; set; }
            }
            [NameInMap("thumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }
        };

    }

}
