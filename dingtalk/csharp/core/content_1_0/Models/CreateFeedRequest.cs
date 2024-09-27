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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("lectorUserInfo")]
            [Validation(Required=false)]
            public CreateFeedRequestCourseInfoLectorUserInfo LectorUserInfo { get; set; }
            public class CreateFeedRequestCourseInfoLectorUserInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://static.dingtalk.com/media/lA****************p_169_169.png_60x60q90.jpg?bizType=avatar">https://static.dingtalk.com/media/lA****************p_169_169.png_60x60q90.jpg?bizType=avatar</a></para>
                /// </summary>
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>用户名</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16621*******284773</para>
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
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("csUserInfo")]
                [Validation(Required=false)]
                public CreateFeedRequestCourseInfoPayInfoCsUserInfo CsUserInfo { get; set; }
                public class CreateFeedRequestCourseInfoPayInfoCsUserInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://static.dingtalk.com/media/lA****************p_169_169.png_60x60q90.jpg?bizType=avatar">https://static.dingtalk.com/media/lA****************p_169_169.png_60x60q90.jpg?bizType=avatar</a></para>
                    /// </summary>
                    [NameInMap("avatar")]
                    [Validation(Required=false)]
                    public string Avatar { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>用户名</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16621*******284773</para>
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
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1624507431777</para>
                    /// </summary>
                    [NameInMap("endTimeMillis")]
                    [Validation(Required=false)]
                    public long? EndTimeMillis { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1624507431777</para>
                    /// </summary>
                    [NameInMap("startTimeMillis")]
                    [Validation(Required=false)]
                    public long? StartTimeMillis { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx学习群</para>
            /// </summary>
            [NameInMap("studyGroupName")]
            [Validation(Required=false)]
            public string StudyGroupName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16621*******284773</para>
        /// </summary>
        [NameInMap("createUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("feedInfo")]
        [Validation(Required=false)]
        public CreateFeedRequestFeedInfo FeedInfo { get; set; }
        public class CreateFeedRequestFeedInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("belongsTo")]
            [Validation(Required=false)]
            public int? BelongsTo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200000257</para>
            /// </summary>
            [NameInMap("feedCategory")]
            [Validation(Required=false)]
            public long? FeedCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c497****-8a89-****-bc9b-*****48610d3</para>
            /// </summary>
            [NameInMap("feedId")]
            [Validation(Required=false)]
            public string FeedId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>标签</para>
            /// </summary>
            [NameInMap("feedTag")]
            [Validation(Required=false)]
            public string FeedTag { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("feedType")]
            [Validation(Required=false)]
            public int? FeedType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("industryId")]
            [Validation(Required=false)]
            public long? IndustryId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://static.dingtalk.com/media/**************NAlg_600_337.jpg">https://static.dingtalk.com/media/**************NAlg_600_337.jpg</a></para>
            /// </summary>
            [NameInMap("introductionPicUrl")]
            [Validation(Required=false)]
            public string IntroductionPicUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50730********40554</para>
            /// </summary>
            [NameInMap("mcnId")]
            [Validation(Required=false)]
            public string McnId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("mediaContents")]
            [Validation(Required=false)]
            public List<CreateFeedRequestFeedInfoMediaContents> MediaContents { get; set; }
            public class CreateFeedRequestFeedInfoMediaContents : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>378a1a0154b34**********86313948e</para>
                /// </summary>
                [NameInMap("mediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>媒体标题</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
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
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c497****-8a89-****-bc9b-*****48610d3</para>
                /// </summary>
                [NameInMap("objectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://static.dingtalk.com/media/**************NAlg_600_337.jpg">https://static.dingtalk.com/media/**************NAlg_600_337.jpg</a></para>
            /// </summary>
            [NameInMap("thumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>课程标题</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
