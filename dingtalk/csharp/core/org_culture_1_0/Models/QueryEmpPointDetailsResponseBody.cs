// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryEmpPointDetailsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryEmpPointDetailsResponseBodyResult Result { get; set; }
        public class QueryEmpPointDetailsResponseBodyResult : TeaModel {
            /// <summary>
            /// 个人积分明细列表
            /// </summary>
            [NameInMap("details")]
            [Validation(Required=false)]
            public List<QueryEmpPointDetailsResponseBodyResultDetails> Details { get; set; }
            public class QueryEmpPointDetailsResponseBodyResultDetails : TeaModel {
                /// <summary>
                /// 积分数量 发放时为负。 扣减时为正
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                /// <summary>
                /// 创建时间
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// 积分交易单号
                /// 
                /// </summary>
                [NameInMap("outId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                [NameInMap("pointOperateFeatureResponseDTO")]
                [Validation(Required=false)]
                public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO PointOperateFeatureResponseDTO { get; set; }
                public class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO : TeaModel {
                    /// <summary>
                    /// 来源账户
                    /// </summary>
                    [NameInMap("accountSource")]
                    [Validation(Required=false)]
                    public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource AccountSource { get; set; }
                    public class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource : TeaModel {
                        /// <summary>
                        /// 积分账号的类型
                        /// 企业账号：ORG, 员工账号：EMP
                        /// </summary>
                        [NameInMap("accountType")]
                        [Validation(Required=false)]
                        public string AccountType { get; set; }

                        /// <summary>
                        /// 企业内名字
                        /// </summary>
                        [NameInMap("empName")]
                        [Validation(Required=false)]
                        public string EmpName { get; set; }

                        /// <summary>
                        /// 用户userId
                        /// 
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// 目标账户
                    /// 
                    /// </summary>
                    [NameInMap("accountTarget")]
                    [Validation(Required=false)]
                    public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget AccountTarget { get; set; }
                    public class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget : TeaModel {
                        /// <summary>
                        /// 积分账号的类型
                        /// 企业账号：ORG, 员工账号：EMP
                        /// </summary>
                        [NameInMap("accountType")]
                        [Validation(Required=false)]
                        public string AccountType { get; set; }

                        /// <summary>
                        /// 企业内名字
                        /// </summary>
                        [NameInMap("empName")]
                        [Validation(Required=false)]
                        public string EmpName { get; set; }

                        /// <summary>
                        /// 用户useId
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// 备注信息，在明细中展示
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// 来源/用途，一般是系统固定的场景
                    /// </summary>
                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }

                /// <summary>
                /// 源账户积分bizCode.
                /// 个人可用积分:personal
                /// 额度:credit
                /// </summary>
                [NameInMap("sourceBizCode")]
                [Validation(Required=false)]
                public string SourceBizCode { get; set; }

            }

            /// <summary>
            /// 是否有下一页
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

        }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
