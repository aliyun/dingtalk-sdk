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
            /// <summary>
            /// 讲师身份信息
            /// </summary>
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

            /// <summary>
            /// 支付信息
            /// </summary>
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
                    /// <summary>
                    /// 客服头像链接
                    /// </summary>
                    [NameInMap("avatar")]
                    [Validation(Required=false)]
                    public string Avatar { get; set; }

                    /// <summary>
                    /// 客服用户名称
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 客服用户Id
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// 课程打折信息
                /// </summary>
                [NameInMap("discountInfo")]
                [Validation(Required=false)]
                public CreateFeedRequestCourseInfoPayInfoDiscountInfo DiscountInfo { get; set; }
                public class CreateFeedRequestCourseInfoPayInfoDiscountInfo : TeaModel {
                    /// <summary>
                    /// 打折结束的时间，时间戳精确到毫秒，时间为东八区时间
                    /// </summary>
                    [NameInMap("endTimeMillis")]
                    [Validation(Required=false)]
                    public long? EndTimeMillis { get; set; }

                    /// <summary>
                    /// 打折时商品的价格，单位为分
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                    /// <summary>
                    /// 打折开始的时间，时间戳精确到毫秒，时间为东八区时间
                    /// </summary>
                    [NameInMap("startTimeMillis")]
                    [Validation(Required=false)]
                    public long? StartTimeMillis { get; set; }

                }

                /// <summary>
                /// 商品的默认情况下非打折时的价格，单位为分
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

            }

            /// <summary>
            /// 创建一个和该课程绑定的学习群和圈子
            /// </summary>
            [NameInMap("studyGroupName")]
            [Validation(Required=false)]
            public string StudyGroupName { get; set; }

        }

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
            /// <summary>
            /// 请求的行为，是保存还是发布,1为save，2为publish，是修改还是新建取决于feedId是否为空
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            /// <summary>
            /// 版权所属:1：自有， 2.代理， 3.钉钉
            /// </summary>
            [NameInMap("belongsTo")]
            [Validation(Required=false)]
            public int? BelongsTo { get; set; }

            /// <summary>
            /// 内容分类，课程分类列表详情请见附录中的列表
            /// </summary>
            [NameInMap("feedCategory")]
            [Validation(Required=false)]
            public long? FeedCategory { get; set; }

            /// <summary>
            /// 可选参数，当feedId不为null时，表示对当前课程进行修改，否则为新建一个课程
            /// </summary>
            [NameInMap("feedId")]
            [Validation(Required=false)]
            public string FeedId { get; set; }

            /// <summary>
            /// 课程的文字标签
            /// </summary>
            [NameInMap("feedTag")]
            [Validation(Required=false)]
            public string FeedTag { get; set; }

            /// <summary>
            /// 内容类别,限制只能使用4种类型：0：免费 4：平价 5：专栏 6：训练营
            /// </summary>
            [NameInMap("feedType")]
            [Validation(Required=false)]
            public int? FeedType { get; set; }

            /// <summary>
            /// 行业划分，决定了展示的页面的不同，例如学习中心下的职场、教育、商学院的划分,目前支持的行业id有：10001：职场学堂，10008：K12教育，10023：新职业，10024：钉钉培训
            /// </summary>
            [NameInMap("industryId")]
            [Validation(Required=false)]
            public long? IndustryId { get; set; }

            /// <summary>
            /// 课程的描述
            /// </summary>
            [NameInMap("introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            /// <summary>
            /// 课程简介用的图片
            /// </summary>
            [NameInMap("introductionPicUrl")]
            [Validation(Required=false)]
            public string IntroductionPicUrl { get; set; }

            /// <summary>
            /// 入驻账号Id(请联系钉钉接口同学获取)
            /// </summary>
            [NameInMap("mcnId")]
            [Validation(Required=false)]
            public string McnId { get; set; }

            /// <summary>
            /// 一个课程下可以有多个视频或音频教程
            /// </summary>
            [NameInMap("mediaContents")]
            [Validation(Required=false)]
            public List<CreateFeedRequestFeedInfoMediaContents> MediaContents { get; set; }
            public class CreateFeedRequestFeedInfoMediaContents : TeaModel {
                /// <summary>
                /// 媒体的mediaId，唯一对应oss中的一个视频或者音频
                /// </summary>
                [NameInMap("mediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// 媒体的标题
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// 媒体的类型，当前该接口只支持video和audio,2:视频,3:音频
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// 推荐内容集合
            /// </summary>
            [NameInMap("recommends")]
            [Validation(Required=false)]
            public List<CreateFeedRequestFeedInfoRecommends> Recommends { get; set; }
            public class CreateFeedRequestFeedInfoRecommends : TeaModel {
                /// <summary>
                /// 推荐物品的id，可以时feedId或者是微应用Id
                /// </summary>
                [NameInMap("objectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// 推荐物品的类别,0:课程,1:微应用
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// 课程的封面Url
            /// </summary>
            [NameInMap("thumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// 内容的标题（标题不能重复）
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
