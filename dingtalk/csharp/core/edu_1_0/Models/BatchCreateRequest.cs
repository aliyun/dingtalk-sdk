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
            [NameInMap("canReissueCard")]
            [Validation(Required=false)]
            public bool? CanReissueCard { get; set; }
            [NameInMap("cardCycle")]
            [Validation(Required=false)]
            public int? CardCycle { get; set; }
            [NameInMap("cardFrequency")]
            [Validation(Required=false)]
            public List<string> CardFrequency { get; set; }
            [NameInMap("cardRuleItemParamList")]
            [Validation(Required=false)]
            public List<BatchCreateRequestDataCardRuleItemParamList> CardRuleItemParamList { get; set; }
            public class BatchCreateRequestDataCardRuleItemParamList : TeaModel {
                public string CardTaskCode { get; set; }
                public string RelationId { get; set; }
                public string CardRuleAttr { get; set; }
                public int? DailyDubbing { get; set; }
                public string RelationTitle { get; set; }
                public string RelationUrl { get; set; }
            }
            [NameInMap("classIds")]
            [Validation(Required=false)]
            public List<string> ClassIds { get; set; }
            [NameInMap("classNames")]
            [Validation(Required=false)]
            public List<string> ClassNames { get; set; }
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("effectDate")]
            [Validation(Required=false)]
            public long? EffectDate { get; set; }
            [NameInMap("medias")]
            [Validation(Required=false)]
            public string Medias { get; set; }
            [NameInMap("needMetering")]
            [Validation(Required=false)]
            public string NeedMetering { get; set; }
            [NameInMap("orgClassStudentGroupList")]
            [Validation(Required=false)]
            public List<BatchCreateRequestDataOrgClassStudentGroupList> OrgClassStudentGroupList { get; set; }
            public class BatchCreateRequestDataOrgClassStudentGroupList : TeaModel {
                public string CorpId { get; set; }
                public List<BatchCreateRequestDataOrgClassStudentGroupListClassList> ClassList { get; set; }
                public class BatchCreateRequestDataOrgClassStudentGroupListClassList : TeaModel {
                    public long? ClassId { get; set; }
                    public string ClassName { get; set; }
                    public List<BatchCreateRequestDataOrgClassStudentGroupListClassListStudents> Students { get; set; }
                    public class BatchCreateRequestDataOrgClassStudentGroupListClassListStudents : TeaModel {
                        public string Name { get; set; }
                        public string StaffId { get; set; }
                    }
                }
            }
            [NameInMap("remindHour")]
            [Validation(Required=false)]
            public int? RemindHour { get; set; }
            [NameInMap("remindMinute")]
            [Validation(Required=false)]
            public int? RemindMinute { get; set; }
            [NameInMap("targetRole")]
            [Validation(Required=false)]
            public string TargetRole { get; set; }
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("unitOfMeasurement")]
            [Validation(Required=false)]
            public string UnitOfMeasurement { get; set; }
        };

        /// <summary>
        /// 老师corpId
        /// </summary>
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

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
