// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListApplicationResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListApplicationResponseBodyData> Data { get; set; }
        public class ListApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;ODIN_TOPIC_ID&quot;:&quot;2560649&quot;,&quot;APPPROVIDER&quot;:&quot;vigo&quot;,&quot;NEEDAYALYSIS&quot;:&quot;n&quot;,&quot;NAVTYPE&quot;:&quot;top_side&quot;,&quot;SHOWICON&quot;:&quot;n&quot;,&quot;REPORT_SUPPORT_META_3&quot;:&quot;y&quot;,&quot;ALLOW_EXTERNAL_ADDRESS_BOOK&quot;:&quot;y&quot;,&quot;REPORTVERSION&quot;:&quot;V5&quot;,&quot;FORM_SCHEMA_VERSION&quot;:&quot;V5&quot;,&quot;EXCEL_SOURCE&quot;:&quot;LOCAL&quot;,&quot;DEVICETYPE&quot;:&quot;web,mobile&quot;,&quot;ENABLE_CSRF_SWITCH&quot;:&quot;y&quot;,&quot;NEW_ALLOW_EXTERNAL_ADDRESS_BOOK&quot;:&quot;y&quot;,&quot;COLOUR&quot;:&quot;blue&quot;,&quot;DINGTALK_CID&quot;:&quot;LOCAL&quot;,&quot;APPMODE&quot;:&quot;normal&quot;,&quot;NAVLAYOUT&quot;:&quot;auto&quot;,&quot;SHOWNAV&quot;:&quot;y&quot;,&quot;SHOWCRUMB&quot;:&quot;y&quot;,&quot;SUPPORT_META_3&quot;:&quot;y&quot;,&quot;SUPPORT_META_2&quot;:&quot;y&quot;,&quot;SYSTEMLINK&quot;:&quot;<a href="https://www.aliwork.com/APP_LDYQVBGT167NAON5KB1X/workbench%22,%22DATA_QUERY_VERSION%22:%22V1%22,%22DB_SOURCE_TYPE%22:%22TDDL_MYSQL%22,%22ISTODINGAPPCENTER%22:%22n%22,%22REVERSION%22:%225.9.16%22,%22EDS_DB_INDEX%22:%2224%22,%22NAVIGATION%22:%22TODO,DONE,SUBMIT%22,%22APPTYPE%22:%22single%22%7D">https://www.aliwork.com/APP_LDYQVBGT167NAON5KB1X/workbench&quot;,&quot;DATA_QUERY_VERSION&quot;:&quot;V1&quot;,&quot;DB_SOURCE_TYPE&quot;:&quot;TDDL_MYSQL&quot;,&quot;ISTODINGAPPCENTER&quot;:&quot;n&quot;,&quot;REVERSION&quot;:&quot;5.9.16&quot;,&quot;EDS_DB_INDEX&quot;:&quot;24&quot;,&quot;NAVIGATION&quot;:&quot;TODO,DONE,SUBMIT&quot;,&quot;APPTYPE&quot;:&quot;single&quot;}</a></para>
            /// </summary>
            [NameInMap("appConfig")]
            [Validation(Required=false)]
            public string AppConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>APP_XCE0EVXS6DYG3YDYC5RD</para>
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>上线:ONLINE，下线:OFFLINE</para>
            /// </summary>
            [NameInMap("applicationStatus")]
            [Validation(Required=false)]
            public string ApplicationStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding5d17e3add038d44535c2f4657eb6378e</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding12345</para>
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>步凡创建的宜搭应用</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>appdiqiu%%#0089FF</para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>已删除:y，未删除:n</para>
            /// </summary>
            [NameInMap("inexistence")]
            [Validation(Required=false)]
            public string Inexistence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试应用</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>离线:offline,在线：online</para>
            /// </summary>
            [NameInMap("releaseToDingStatus")]
            [Validation(Required=false)]
            public string ReleaseToDingStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding8eaadfkksj45343wksff334</para>
            /// </summary>
            [NameInMap("subCorpId")]
            [Validation(Required=false)]
            public string SubCorpId { get; set; }

            [NameInMap("systemToken")]
            [Validation(Required=false)]
            public string SystemToken { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
