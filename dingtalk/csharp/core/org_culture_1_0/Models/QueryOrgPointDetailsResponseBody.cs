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
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1655450960000</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2323232134455667</para>
                /// </summary>
                [NameInMap("outId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                [NameInMap("pointOperateFeatureResponseDTO")]
                [Validation(Required=false)]
                public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO PointOperateFeatureResponseDTO { get; set; }
                public class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO : TeaModel {
                    [NameInMap("accountSource")]
                    [Validation(Required=false)]
                    public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource AccountSource { get; set; }
                    public class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ORG</para>
                        /// </summary>
                        [NameInMap("accountType")]
                        [Validation(Required=false)]
                        public string AccountType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>张三</para>
                        /// </summary>
                        [NameInMap("empName")]
                        [Validation(Required=false)]
                        public string EmpName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>01274411491620908910</para>
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    [NameInMap("accountTarget")]
                    [Validation(Required=false)]
                    public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget AccountTarget { get; set; }
                    public class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>EMP</para>
                        /// </summary>
                        [NameInMap("accountType")]
                        [Validation(Required=false)]
                        public string AccountType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>李四</para>
                        /// </summary>
                        [NameInMap("empName")]
                        [Validation(Required=false)]
                        public string EmpName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>01274411491620908910</para>
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>表现优秀，特此奖励</para>
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>三方系统管理员发放额度</para>
                    /// </summary>
                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>credit</para>
                /// </summary>
                [NameInMap("sourceBizCode")]
                [Validation(Required=false)]
                public string SourceBizCode { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
