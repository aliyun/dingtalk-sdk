// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QuerySignTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QuerySignTaskResponseBodyResult Result { get; set; }
        public class QuerySignTaskResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public QuerySignTaskResponseBodyResultData Data { get; set; }
            public class QuerySignTaskResponseBodyResultData : TeaModel {
                [NameInMap("bizFlowId")]
                [Validation(Required=false)]
                public string BizFlowId { get; set; }

                [NameInMap("signFlowId")]
                [Validation(Required=false)]
                public string SignFlowId { get; set; }

                [NameInMap("signFlowStatus")]
                [Validation(Required=false)]
                public string SignFlowStatus { get; set; }

                [NameInMap("signTasks")]
                [Validation(Required=false)]
                public List<QuerySignTaskResponseBodyResultDataSignTasks> SignTasks { get; set; }
                public class QuerySignTaskResponseBodyResultDataSignTasks : TeaModel {
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
                    public QuerySignTaskResponseBodyResultDataSignTasksOrgInfo OrgInfo { get; set; }
                    public class QuerySignTaskResponseBodyResultDataSignTasksOrgInfo : TeaModel {
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
                    public QuerySignTaskResponseBodyResultDataSignTasksSignerInfo SignerInfo { get; set; }
                    public class QuerySignTaskResponseBodyResultDataSignTasksSignerInfo : TeaModel {
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
