// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchAddPermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchAddPermissionResponseBodyData Data { get; set; }
        public class BatchAddPermissionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("hasInvalidUser")]
            [Validation(Required=false)]
            public bool? HasInvalidUser { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("permissionTree")]
            [Validation(Required=false)]
            public BatchAddPermissionResponseBodyDataPermissionTree PermissionTree { get; set; }
            public class BatchAddPermissionResponseBodyDataPermissionTree : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("policyList")]
                [Validation(Required=false)]
                public List<BatchAddPermissionResponseBodyDataPermissionTreePolicyList> PolicyList { get; set; }
                public class BatchAddPermissionResponseBodyDataPermissionTreePolicyList : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("memberList")]
                    [Validation(Required=false)]
                    public List<BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList> MemberList { get; set; }
                    public class BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("nickname")]
                        [Validation(Required=false)]
                        public string Nickname { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public long? Type { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("privacy")]
                [Validation(Required=false)]
                public string Privacy { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>period</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
