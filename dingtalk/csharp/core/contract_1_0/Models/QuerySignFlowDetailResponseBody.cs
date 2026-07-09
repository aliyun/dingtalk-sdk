// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QuerySignFlowDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QuerySignFlowDetailResponseBodyResult Result { get; set; }
        public class QuerySignFlowDetailResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public QuerySignFlowDetailResponseBodyResultData Data { get; set; }
            public class QuerySignFlowDetailResponseBodyResultData : TeaModel {
                [NameInMap("bizFlowId")]
                [Validation(Required=false)]
                public string BizFlowId { get; set; }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                [NameInMap("initiateUrl")]
                [Validation(Required=false)]
                public string InitiateUrl { get; set; }

                [NameInMap("signDocs")]
                [Validation(Required=false)]
                public List<QuerySignFlowDetailResponseBodyResultDataSignDocs> SignDocs { get; set; }
                public class QuerySignFlowDetailResponseBodyResultDataSignDocs : TeaModel {
                    [NameInMap("fileId")]
                    [Validation(Required=false)]
                    public string FileId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileSize")]
                    [Validation(Required=false)]
                    public long? FileSize { get; set; }

                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    [NameInMap("spaceId")]
                    [Validation(Required=false)]
                    public long? SpaceId { get; set; }

                }

                [NameInMap("signFlowConfig")]
                [Validation(Required=false)]
                public QuerySignFlowDetailResponseBodyResultDataSignFlowConfig SignFlowConfig { get; set; }
                public class QuerySignFlowDetailResponseBodyResultDataSignFlowConfig : TeaModel {
                    [NameInMap("autoStart")]
                    [Validation(Required=false)]
                    public bool? AutoStart { get; set; }

                    [NameInMap("isOrderedSign")]
                    [Validation(Required=false)]
                    public bool? IsOrderedSign { get; set; }

                    [NameInMap("signFlowName")]
                    [Validation(Required=false)]
                    public string SignFlowName { get; set; }

                }

                [NameInMap("signFlowId")]
                [Validation(Required=false)]
                public string SignFlowId { get; set; }

                [NameInMap("signFlowInitiator")]
                [Validation(Required=false)]
                public QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator SignFlowInitiator { get; set; }
                public class QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator : TeaModel {
                    [NameInMap("companyId")]
                    [Validation(Required=false)]
                    public string CompanyId { get; set; }

                    [NameInMap("orgName")]
                    [Validation(Required=false)]
                    public string OrgName { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("signFlowStatus")]
                [Validation(Required=false)]
                public string SignFlowStatus { get; set; }

                [NameInMap("signTasks")]
                [Validation(Required=false)]
                public List<QuerySignFlowDetailResponseBodyResultDataSignTasks> SignTasks { get; set; }
                public class QuerySignFlowDetailResponseBodyResultDataSignTasks : TeaModel {
                    [NameInMap("activateTime")]
                    [Validation(Required=false)]
                    public long? ActivateTime { get; set; }

                    [NameInMap("actualOrgSealType")]
                    [Validation(Required=false)]
                    public string ActualOrgSealType { get; set; }

                    [NameInMap("actualPsnSealType")]
                    [Validation(Required=false)]
                    public string ActualPsnSealType { get; set; }

                    [NameInMap("bizTaskId")]
                    [Validation(Required=false)]
                    public string BizTaskId { get; set; }

                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("finishTime")]
                    [Validation(Required=false)]
                    public long? FinishTime { get; set; }

                    [NameInMap("orgInfo")]
                    [Validation(Required=false)]
                    public QuerySignFlowDetailResponseBodyResultDataSignTasksOrgInfo OrgInfo { get; set; }
                    public class QuerySignFlowDetailResponseBodyResultDataSignTasksOrgInfo : TeaModel {
                        [NameInMap("companyId")]
                        [Validation(Required=false)]
                        public string CompanyId { get; set; }

                        [NameInMap("orgName")]
                        [Validation(Required=false)]
                        public string OrgName { get; set; }

                    }

                    [NameInMap("signOrder")]
                    [Validation(Required=false)]
                    public int? SignOrder { get; set; }

                    [NameInMap("signTaskId")]
                    [Validation(Required=false)]
                    public string SignTaskId { get; set; }

                    [NameInMap("signUrl")]
                    [Validation(Required=false)]
                    public string SignUrl { get; set; }

                    [NameInMap("signerInfo")]
                    [Validation(Required=false)]
                    public QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo SignerInfo { get; set; }
                    public class QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo : TeaModel {
                        [NameInMap("psnMobile")]
                        [Validation(Required=false)]
                        public string PsnMobile { get; set; }

                        [NameInMap("psnName")]
                        [Validation(Required=false)]
                        public string PsnName { get; set; }

                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    [NameInMap("signerType")]
                    [Validation(Required=false)]
                    public string SignerType { get; set; }

                    [NameInMap("taskStatus")]
                    [Validation(Required=false)]
                    public string TaskStatus { get; set; }

                }

                [NameInMap("signers")]
                [Validation(Required=false)]
                public List<QuerySignFlowDetailResponseBodyResultDataSigners> Signers { get; set; }
                public class QuerySignFlowDetailResponseBodyResultDataSigners : TeaModel {
                    [NameInMap("bizTaskId")]
                    [Validation(Required=false)]
                    public string BizTaskId { get; set; }

                    [NameInMap("orgInfo")]
                    [Validation(Required=false)]
                    public QuerySignFlowDetailResponseBodyResultDataSignersOrgInfo OrgInfo { get; set; }
                    public class QuerySignFlowDetailResponseBodyResultDataSignersOrgInfo : TeaModel {
                        [NameInMap("companyId")]
                        [Validation(Required=false)]
                        public string CompanyId { get; set; }

                        [NameInMap("orgName")]
                        [Validation(Required=false)]
                        public string OrgName { get; set; }

                    }

                    [NameInMap("signComponentConfig")]
                    [Validation(Required=false)]
                    public List<QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfig> SignComponentConfig { get; set; }
                    public class QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfig : TeaModel {
                        [NameInMap("fileId")]
                        [Validation(Required=false)]
                        public string FileId { get; set; }

                        [NameInMap("signFieldComponentConfig")]
                        [Validation(Required=false)]
                        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig SignFieldComponentConfig { get; set; }
                        public class QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig : TeaModel {
                            [NameInMap("availableOrgSealTypes")]
                            [Validation(Required=false)]
                            public List<string> AvailableOrgSealTypes { get; set; }

                            [NameInMap("availablePsnSealTypes")]
                            [Validation(Required=false)]
                            public List<string> AvailablePsnSealTypes { get; set; }

                            [NameInMap("crossPageType")]
                            [Validation(Required=false)]
                            public string CrossPageType { get; set; }

                            [NameInMap("signDateConfig")]
                            [Validation(Required=false)]
                            public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignDateConfig SignDateConfig { get; set; }
                            public class QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignDateConfig : TeaModel {
                                [NameInMap("dateFormat")]
                                [Validation(Required=false)]
                                public string DateFormat { get; set; }

                                [NameInMap("showSignDate")]
                                [Validation(Required=false)]
                                public bool? ShowSignDate { get; set; }

                            }

                            [NameInMap("signPositionConfig")]
                            [Validation(Required=false)]
                            public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig SignPositionConfig { get; set; }
                            public class QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig : TeaModel {
                                [NameInMap("positionPage")]
                                [Validation(Required=false)]
                                public long? PositionPage { get; set; }

                                [NameInMap("positionX")]
                                [Validation(Required=false)]
                                public double? PositionX { get; set; }

                                [NameInMap("positionY")]
                                [Validation(Required=false)]
                                public double? PositionY { get; set; }

                            }

                        }

                    }

                    [NameInMap("signConfig")]
                    [Validation(Required=false)]
                    public QuerySignFlowDetailResponseBodyResultDataSignersSignConfig SignConfig { get; set; }
                    public class QuerySignFlowDetailResponseBodyResultDataSignersSignConfig : TeaModel {
                        [NameInMap("signOrder")]
                        [Validation(Required=false)]
                        public long? SignOrder { get; set; }

                    }

                    [NameInMap("signerInfo")]
                    [Validation(Required=false)]
                    public QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo SignerInfo { get; set; }
                    public class QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo : TeaModel {
                        [NameInMap("psnMobile")]
                        [Validation(Required=false)]
                        public string PsnMobile { get; set; }

                        [NameInMap("psnName")]
                        [Validation(Required=false)]
                        public string PsnName { get; set; }

                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    [NameInMap("signerType")]
                    [Validation(Required=false)]
                    public string SignerType { get; set; }

                }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
