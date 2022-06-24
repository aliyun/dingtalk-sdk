// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryOrgPointDetailsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryOrgPointDetailsResponseBodyResult Result { get; set; }
        public class QueryOrgPointDetailsResponseBodyResult : TeaModel {
            [NameInMap("details")]
            [Validation(Required=false)]
            public List<QueryOrgPointDetailsResponseBodyResultDetails> Details { get; set; }
            public class QueryOrgPointDetailsResponseBodyResultDetails : TeaModel {
                public long? Amount { get; set; }
                public long? GmtCreate { get; set; }
                public string OutId { get; set; }
                public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO PointOperateFeatureResponseDTO { get; set; }
                public class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO : TeaModel {
                    /// <summary>
                    /// 如果是扣减操作明细，为被扣减账户
                    /// 如果是发放操作明细，为操作发放账户
                    /// 如果是个人积分明细，为来源账户
                    /// </summary>
                    [NameInMap("accountSource")]
                    [Validation(Required=false)]
                    public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource AccountSource { get; set; }
                    public class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource : TeaModel {
                        [NameInMap("accountType")]
                        [Validation(Required=false)]
                        public string AccountType { get; set; }
                        [NameInMap("empName")]
                        [Validation(Required=false)]
                        public string EmpName { get; set; }
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }
                    };

                    /// <summary>
                    /// 如果是扣减操作明细，为操作扣减账户
                    /// 如果是发放操作明细，为被发放账户
                    /// 如果是个人积分明细，为目标账户
                    /// </summary>
                    [NameInMap("accountTarget")]
                    [Validation(Required=false)]
                    public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget AccountTarget { get; set; }
                    public class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget : TeaModel {
                        [NameInMap("accountType")]
                        [Validation(Required=false)]
                        public string AccountType { get; set; }
                        [NameInMap("empName")]
                        [Validation(Required=false)]
                        public string EmpName { get; set; }
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }
                    };

                    /// <summary>
                    /// 备注信息，在明细中展示
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// 来源/用途 一般是系统固定的场景
                    /// </summary>
                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }
                public string SourceBizCode { get; set; }
            }
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
        };

    }

}
