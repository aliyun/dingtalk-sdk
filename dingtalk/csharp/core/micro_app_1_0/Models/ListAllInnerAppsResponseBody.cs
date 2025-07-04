// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class ListAllInnerAppsResponseBody : TeaModel {
        [NameInMap("appList")]
        [Validation(Required=false)]
        public List<ListAllInnerAppsResponseBodyAppList> AppList { get; set; }
        public class ListAllInnerAppsResponseBodyAppList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("appStatus")]
            [Validation(Required=false)]
            public int? AppStatus { get; set; }

            [NameInMap("coolAppInfo")]
            [Validation(Required=false)]
            public List<ListAllInnerAppsResponseBodyAppListCoolAppInfo> CoolAppInfo { get; set; }
            public class ListAllInnerAppsResponseBodyAppListCoolAppInfo : TeaModel {
                [NameInMap("coolAppCode")]
                [Validation(Required=false)]
                public string CoolAppCode { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("developType")]
            [Validation(Required=false)]
            public int? DevelopType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("homepageLink")]
            [Validation(Required=false)]
            public string HomepageLink { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>icon</para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("ompLink")]
            [Validation(Required=false)]
            public string OmpLink { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("pcHomepageLink")]
            [Validation(Required=false)]
            public string PcHomepageLink { get; set; }

            [NameInMap("robotInfo")]
            [Validation(Required=false)]
            public ListAllInnerAppsResponseBodyAppListRobotInfo RobotInfo { get; set; }
            public class ListAllInnerAppsResponseBodyAppListRobotInfo : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("robotCode")]
                [Validation(Required=false)]
                public string RobotCode { get; set; }

            }

        }

    }

}
