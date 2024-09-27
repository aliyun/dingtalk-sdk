// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class CreateBizObjectResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateBizObjectResponseBodyData Data { get; set; }
        public class CreateBizObjectResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>50599800-af82-487e-9386-0a7278cab69f</para>
            /// </summary>
            [NameInMap("bizObjectId")]
            [Validation(Required=false)]
            public string BizObjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DataList</para>
            /// </summary>
            [NameInMap("formUsageType")]
            [Validation(Required=false)]
            public string FormUsageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3b5451bc-9fd3-4d0c-ba47-191f8bff95ab</para>
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>D0001839bbbbe346bbf496498bb76c44c7eb972</para>
            /// </summary>
            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Code</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
