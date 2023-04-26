// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormComponent : TeaModel {
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<FormComponent> Children { get; set; }

        [NameInMap("componentType")]
        [Validation(Required=false)]
        public string ComponentType { get; set; }

        [NameInMap("props")]
        [Validation(Required=false)]
        public FormComponentProps Props { get; set; }

    }

}
