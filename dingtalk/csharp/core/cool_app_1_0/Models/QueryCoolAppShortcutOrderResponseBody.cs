// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcool_app_1_0.Models
{
    public class QueryCoolAppShortcutOrderResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryCoolAppShortcutOrderResponseBodyResult Result { get; set; }
        public class QueryCoolAppShortcutOrderResponseBodyResult : TeaModel {
            [NameInMap("forbiddenPluginList")]
            [Validation(Required=false)]
            public List<QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList> ForbiddenPluginList { get; set; }
            public class QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList : TeaModel {
                [NameInMap("appCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("myPluginList")]
            [Validation(Required=false)]
            public List<QueryCoolAppShortcutOrderResponseBodyResultMyPluginList> MyPluginList { get; set; }
            public class QueryCoolAppShortcutOrderResponseBodyResultMyPluginList : TeaModel {
                [NameInMap("appCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("otherPluginList")]
            [Validation(Required=false)]
            public List<QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList> OtherPluginList { get; set; }
            public class QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList : TeaModel {
                [NameInMap("appCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
