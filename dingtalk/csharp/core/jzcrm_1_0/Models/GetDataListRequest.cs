// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class GetDataListRequest : TeaModel {
        /// <summary>
        /// 数据类型，参考数据类型ID对照表
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public string Datatype { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// 分页条数
        /// </summary>
        [NameInMap("pagesize")]
        [Validation(Required=false)]
        public long? Pagesize { get; set; }

    }

}
