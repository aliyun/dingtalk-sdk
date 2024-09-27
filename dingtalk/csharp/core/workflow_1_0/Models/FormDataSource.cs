// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormDataSource : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public FormDataSourceTarget Target { get; set; }
        public class FormDataSourceTarget : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SWAPP-abcd</para>
            /// </summary>
            [NameInMap("appUuid")]
            [Validation(Required=false)]
            public string AppUuid { get; set; }

            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>form</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
