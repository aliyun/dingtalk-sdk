// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class BatchCreateRequest : TeaModel {
        [NameInMap("cardBizCode")]
        [Validation(Required=false)]
        public string CardBizCode { get; set; }

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
            public List<int?> CardFrequency { get; set; }

            [NameInMap("cardRuleItemParamList")]
            [Validation(Required=false)]
            public List<BatchCreateRequestDataCardRuleItemParamList> CardRuleItemParamList { get; set; }
            public class BatchCreateRequestDataCardRuleItemParamList : TeaModel {
                [NameInMap("cardRuleAttr")]
                [Validation(Required=false)]
                public string CardRuleAttr { get; set; }

                [NameInMap("cardTaskCode")]
                [Validation(Required=false)]
                public string CardTaskCode { get; set; }

                [NameInMap("dailyDubbing")]
                [Validation(Required=false)]
                public int? DailyDubbing { get; set; }

                [NameInMap("relationId")]
                [Validation(Required=false)]
                public string RelationId { get; set; }

                [NameInMap("relationTitle")]
                [Validation(Required=false)]
                public string RelationTitle { get; set; }

                [NameInMap("relationUrl")]
                [Validation(Required=false)]
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
                [NameInMap("classList")]
                [Validation(Required=false)]
                public List<BatchCreateRequestDataOrgClassStudentGroupListClassList> ClassList { get; set; }
                public class BatchCreateRequestDataOrgClassStudentGroupListClassList : TeaModel {
                    [NameInMap("classId")]
                    [Validation(Required=false)]
                    public long? ClassId { get; set; }

                    [NameInMap("className")]
                    [Validation(Required=false)]
                    public string ClassName { get; set; }

                    [NameInMap("students")]
                    [Validation(Required=false)]
                    public List<BatchCreateRequestDataOrgClassStudentGroupListClassListStudents> Students { get; set; }
                    public class BatchCreateRequestDataOrgClassStudentGroupListClassListStudents : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("staffId")]
                        [Validation(Required=false)]
                        public string StaffId { get; set; }

                    }

                }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

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

        }

        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("jsVersion")]
        [Validation(Required=false)]
        public int? JsVersion { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
