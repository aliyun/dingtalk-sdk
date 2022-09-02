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
            /// <summary>
            /// 积分明细列表
            /// </summary>
            [NameInMap("details")]
            [Validation(Required=false)]
            public List<QueryOrgPointDetailsResponseBodyResultDetails> Details { get; set; }
            public class QueryOrgPointDetailsResponseBodyResultDetails : TeaModel {
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
                /// </summary>
                [NameInMap("outId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                /// <summary>
                /// 账户信息
                /// </summary>
                [NameInMap("pointOperateFeatureResponseDTO")]
                [Validation(Required=false)]
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
                        /// 用户id
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// 如果是扣减操作明细，为操作扣减账户
                    /// 如果是发放操作明细，为被发放账户
                    /// 如果是个人积分明细，为目标账户
                    /// </summary>
                    [NameInMap("accountTarget")]
                    [Validation(Required=false)]
                    public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget AccountTarget { get; set; }
                    public class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget : TeaModel {
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
                        /// 用户id
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
                    /// 来源/用途 一般是系统固定的场景
                    /// </summary>
                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }

                /// <summary>
                /// 源账户积分bizCode。
                /// 个人可用积分:personal
                /// 额度:credit
                /// </summary>
                [NameInMap("sourceBizCode")]
                [Validation(Required=false)]
                public string SourceBizCode { get; set; }

            }

            /// <summary>
            /// 分页使用，表示是否还有下一页
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// 调用是否成功
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
