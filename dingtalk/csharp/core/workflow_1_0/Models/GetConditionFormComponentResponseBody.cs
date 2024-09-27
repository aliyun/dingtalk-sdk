// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetConditionFormComponentResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetConditionFormComponentResponseBodyResult> Result { get; set; }
        public class GetConditionFormComponentResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TextField</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>输入框</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

        }

    }

}
