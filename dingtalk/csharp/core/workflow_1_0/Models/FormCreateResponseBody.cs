// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormCreateResponseBody : TeaModel {
        /// <summary>
        /// 表单模板信息
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public FormCreateResponseBodyResult Result { get; set; }
        public class FormCreateResponseBodyResult : TeaModel {
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }
        };

    }

}
