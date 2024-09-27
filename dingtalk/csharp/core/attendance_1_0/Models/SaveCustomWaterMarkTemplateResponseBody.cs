// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class SaveCustomWaterMarkTemplateResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SaveCustomWaterMarkTemplateResponseBodyResult Result { get; set; }
        public class SaveCustomWaterMarkTemplateResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>PROC-292988B1-5064-4A42-9389-A76B97xxxxx</para>
            /// </summary>
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROC-292988B1-5064-4A42-9389-A76B97xxxxx</para>
            /// </summary>
            [NameInMap("waterMarkId")]
            [Validation(Required=false)]
            public string WaterMarkId { get; set; }

        }

    }

}
