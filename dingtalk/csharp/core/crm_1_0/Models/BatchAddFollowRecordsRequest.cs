// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchAddFollowRecordsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("instanceList")]
        [Validation(Required=false)]
        public List<BatchAddFollowRecordsRequestInstanceList> InstanceList { get; set; }
        public class BatchAddFollowRecordsRequestInstanceList : TeaModel {
            [NameInMap("bizExtMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> BizExtMap { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dataArray")]
            [Validation(Required=false)]
            public List<BatchAddFollowRecordsRequestInstanceListDataArray> DataArray { get; set; }
            public class BatchAddFollowRecordsRequestInstanceListDataArray : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("extendValue")]
                [Validation(Required=false)]
                public string ExtendValue { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TextField_71U51A</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XX有限公司</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager021a</para>
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

    }

}
