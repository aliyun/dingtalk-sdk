// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SetBorderRequest : TeaModel {
        [NameInMap("color")]
        [Validation(Required=false)]
        public string Color { get; set; }

        [NameInMap("style")]
        [Validation(Required=false)]
        public string Style { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public SetBorderRequestType Type { get; set; }
        public class SetBorderRequestType : TeaModel {
            [NameInMap("bottom")]
            [Validation(Required=false)]
            public bool? Bottom { get; set; }

            [NameInMap("horizontal")]
            [Validation(Required=false)]
            public bool? Horizontal { get; set; }

            [NameInMap("left")]
            [Validation(Required=false)]
            public bool? Left { get; set; }

            [NameInMap("right")]
            [Validation(Required=false)]
            public bool? Right { get; set; }

            [NameInMap("top")]
            [Validation(Required=false)]
            public bool? Top { get; set; }

            [NameInMap("vertical")]
            [Validation(Required=false)]
            public bool? Vertical { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ppgAQuHfOoNVpJiStDwWCEgiEiE</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
