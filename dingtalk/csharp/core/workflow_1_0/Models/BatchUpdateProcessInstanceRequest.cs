// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class BatchUpdateProcessInstanceRequest : TeaModel {
        [NameInMap("updateProcessInstanceRequests")]
        [Validation(Required=false)]
        public List<BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests> UpdateProcessInstanceRequests { get; set; }
        public class BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests : TeaModel {
            [NameInMap("notifiers")]
            [Validation(Required=false)]
            public List<BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers> Notifiers { get; set; }
            public class BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>manager001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agree</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
