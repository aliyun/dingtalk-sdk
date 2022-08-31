// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class GetTotalNumberOfDentriesRequest : TeaModel {
        /// <summary>
        /// 是否包含文件夹。默认包含。
        /// </summary>
        [NameInMap("includeFolder")]
        [Validation(Required=false)]
        public bool? IncludeFolder { get; set; }

        /// <summary>
        /// 操作用户unionId。
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 统计指定的知识库类型。0-我的文档；1-知识库。如果不传，则会统计全部数据。
        /// </summary>
        [NameInMap("spaceTypes")]
        [Validation(Required=false)]
        public string SpaceTypes { get; set; }

    }

}
