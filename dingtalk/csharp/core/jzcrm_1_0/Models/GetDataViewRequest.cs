// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class GetDataViewRequest : TeaModel {
        /// <summary>
        /// 数据类型，参考数据类型ID对照表
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public string Datatype { get; set; }

        /// <summary>
        /// 数据id
        /// </summary>
        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

    }

}
