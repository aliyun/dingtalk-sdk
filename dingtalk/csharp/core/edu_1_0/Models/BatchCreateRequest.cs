// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class BatchCreateRequest : TeaModel {
        /// <summary>
        /// 卡片业务类型，打卡写死：industry_center
        /// </summary>
        [NameInMap("cardBizCode")]
        [Validation(Required=false)]
        public string CardBizCode { get; set; }

        /// <summary>
        /// 卡片详细数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchCreateRequestData Data { get; set; }
        public class BatchCreateRequestData : TeaModel {
            /// <summary>
            /// 是否可以补卡
            /// </summary>
            [NameInMap("canReissueCard")]
            [Validation(Required=false)]
            public bool? CanReissueCard { get; set; }

            /// <summary>
            /// 打卡周期,单位为天
            /// </summary>
            [NameInMap("cardCycle")]
            [Validation(Required=false)]
            public int? CardCycle { get; set; }

            /// <summary>
            /// 打卡的频次设置："cardFrequency":[             1,//周天             2,//周一             3,//周二             4,//周三             5,//周四             6,//周五             7//周六         ]
            /// </summary>
            [NameInMap("cardFrequency")]
            [Validation(Required=false)]
            public List<int?> CardFrequency { get; set; }

            [NameInMap("cardRuleItemParamList")]
            [Validation(Required=false)]
            public List<BatchCreateRequestDataCardRuleItemParamList> CardRuleItemParamList { get; set; }
            public class BatchCreateRequestDataCardRuleItemParamList : TeaModel {
                /// <summary>
                /// 扩展属性，存放配音难度、每日配音视频的url等
                /// </summary>
                [NameInMap("cardRuleAttr")]
                [Validation(Required=false)]
                public string CardRuleAttr { get; set; }

                /// <summary>
                /// 卡片taskCode
                /// </summary>
                [NameInMap("cardTaskCode")]
                [Validation(Required=false)]
                public string CardTaskCode { get; set; }

                /// <summary>
                /// 每日配音数
                /// </summary>
                [NameInMap("dailyDubbing")]
                [Validation(Required=false)]
                public int? DailyDubbing { get; set; }

                /// <summary>
                /// 关联的外部Id
                /// </summary>
                [NameInMap("relationId")]
                [Validation(Required=false)]
                public string RelationId { get; set; }

                /// <summary>
                /// 关联内容标题（会在打卡详页页展示）
                /// </summary>
                [NameInMap("relationTitle")]
                [Validation(Required=false)]
                public string RelationTitle { get; set; }

                /// <summary>
                /// relationUrl（点击打卡内容后跳转的链接）（点击卡片内容后跳转的链接）
                /// </summary>
                [NameInMap("relationUrl")]
                [Validation(Required=false)]
                public string RelationUrl { get; set; }

            }

            /// <summary>
            /// 班级列表
            /// </summary>
            [NameInMap("classIds")]
            [Validation(Required=false)]
            public List<string> ClassIds { get; set; }

            /// <summary>
            /// 班级名称列表
            /// </summary>
            [NameInMap("classNames")]
            [Validation(Required=false)]
            public List<string> ClassNames { get; set; }

            /// <summary>
            /// 打卡的内容
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 卡片生效时间
            /// </summary>
            [NameInMap("effectDate")]
            [Validation(Required=false)]
            public long? EffectDate { get; set; }

            /// <summary>
            /// 上传相册，图片，录音，盯盘的信息
            /// </summary>
            [NameInMap("medias")]
            [Validation(Required=false)]
            public string Medias { get; set; }

            /// <summary>
            /// 计量开启
            /// </summary>
            [NameInMap("needMetering")]
            [Validation(Required=false)]
            public string NeedMetering { get; set; }

            [NameInMap("orgClassStudentGroupList")]
            [Validation(Required=false)]
            public List<BatchCreateRequestDataOrgClassStudentGroupList> OrgClassStudentGroupList { get; set; }
            public class BatchCreateRequestDataOrgClassStudentGroupList : TeaModel {
                /// <summary>
                /// 班级列表
                /// </summary>
                [NameInMap("classList")]
                [Validation(Required=false)]
                public List<BatchCreateRequestDataOrgClassStudentGroupListClassList> ClassList { get; set; }
                public class BatchCreateRequestDataOrgClassStudentGroupListClassList : TeaModel {
                    /// <summary>
                    /// 班级id
                    /// </summary>
                    [NameInMap("classId")]
                    [Validation(Required=false)]
                    public long? ClassId { get; set; }

                    /// <summary>
                    /// 班级名称
                    /// </summary>
                    [NameInMap("className")]
                    [Validation(Required=false)]
                    public string ClassName { get; set; }

                    /// <summary>
                    /// 班级学生
                    /// </summary>
                    [NameInMap("students")]
                    [Validation(Required=false)]
                    public List<BatchCreateRequestDataOrgClassStudentGroupListClassListStudents> Students { get; set; }
                    public class BatchCreateRequestDataOrgClassStudentGroupListClassListStudents : TeaModel {
                        /// <summary>
                        /// 学生名称
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// 学生id
                        /// </summary>
                        [NameInMap("staffId")]
                        [Validation(Required=false)]
                        public string StaffId { get; set; }

                    }

                }

                /// <summary>
                /// 组织id
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

            }

            /// <summary>
            /// 提醒时间（小时）
            /// </summary>
            [NameInMap("remindHour")]
            [Validation(Required=false)]
            public int? RemindHour { get; set; }

            /// <summary>
            /// 提醒时间（分钟）
            /// </summary>
            [NameInMap("remindMinute")]
            [Validation(Required=false)]
            public int? RemindMinute { get; set; }

            /// <summary>
            /// 默认：student_guardian
            /// </summary>
            [NameInMap("targetRole")]
            [Validation(Required=false)]
            public string TargetRole { get; set; }

            /// <summary>
            /// 打卡模板id
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// 卡片标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 计量单位
            /// </summary>
            [NameInMap("unitOfMeasurement")]
            [Validation(Required=false)]
            public string UnitOfMeasurement { get; set; }

        }

        /// <summary>
        /// 卡片幂等唯一键
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [NameInMap("jsVersion")]
        [Validation(Required=false)]
        public int? JsVersion { get; set; }

        /// <summary>
        /// isv业务类型
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// 老师用户id
        /// </summary>
        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
