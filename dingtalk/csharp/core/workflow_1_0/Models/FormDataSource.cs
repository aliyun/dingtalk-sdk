// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormDataSource : TeaModel {
        /// <summary>
        /// 关联表单信息
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public FormDataSourceTarget Target { get; set; }
        public class FormDataSourceTarget : TeaModel {
            [NameInMap("appType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }
            [NameInMap("appUuid")]
            [Validation(Required=false)]
            public string AppUuid { get; set; }
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }
        };

        /// <summary>
        /// 关联类型，form关联表单
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
