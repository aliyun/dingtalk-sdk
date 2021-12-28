// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormComponent : TeaModel {
        /// <summary>
        /// 子控件集合
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<FormComponent> Children { get; set; }

        /// <summary>
        /// 控件类型
        /// </summary>
        [NameInMap("componentType")]
        [Validation(Required=false)]
        public string ComponentType { get; set; }

        /// <summary>
        /// 控件属性
        /// </summary>
        [NameInMap("props")]
        [Validation(Required=false)]
        public FormComponentProps Props { get; set; }

    }

}
