// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumGetInstFieldSettingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<PremiumGetInstFieldSettingResponseBodyResult> Result { get; set; }
        public class PremiumGetInstFieldSettingResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>TextField</para>
            /// </summary>
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>READONLY</para>
            /// </summary>
            [NameInMap("fieldBehavior")]
            [Validation(Required=false)]
            public string FieldBehavior { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TextField-abcd</para>
            /// </summary>
            [NameInMap("fieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

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
