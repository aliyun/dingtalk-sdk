// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListByPluginIdsResponseBody : TeaModel {
        [NameInMap("pluginInfoList")]
        [Validation(Required=false)]
        public List<ListByPluginIdsResponseBodyPluginInfoList> PluginInfoList { get; set; }
        public class ListByPluginIdsResponseBodyPluginInfoList : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("createAt")]
            [Validation(Required=false)]
            public long? CreateAt { get; set; }

            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("icons")]
            [Validation(Required=false)]
            public string Icons { get; set; }

            [NameInMap("modifiedAt")]
            [Validation(Required=false)]
            public long? ModifiedAt { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

            [NameInMap("pluginId")]
            [Validation(Required=false)]
            public string PluginId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
