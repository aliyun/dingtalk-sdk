// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class DentryVO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>alidoc</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1663918630284</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public DentryVOCreator Creator { get; set; }
        public class DentryVOCreator : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YEp3JcM******UIbhwiE</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YRBd*****KGDA</para>
        /// </summary>
        [NameInMap("dentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("dentryType")]
        [Validation(Required=false)]
        public string DentryType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6or0dp8Z****XWa91xzy3</para>
        /// </summary>
        [NameInMap("dentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v1GXn****KqD4</para>
        /// </summary>
        [NameInMap("docKey")]
        [Validation(Required=false)]
        public string DocKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alidoc</para>
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasChildren")]
        [Validation(Required=false)]
        public bool? HasChildren { get; set; }

        [NameInMap("linkSourceInfo")]
        [Validation(Required=false)]
        public LinkSourceInfo LinkSourceInfo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>钉钉文档</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试组织/测试知识库/abc</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("space")]
        [Validation(Required=false)]
        public SpaceModel Space { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YGv0****0xXAr</para>
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1663918630284</para>
        /// </summary>
        [NameInMap("updatedTime")]
        [Validation(Required=false)]
        public long? UpdatedTime { get; set; }

        [NameInMap("updater")]
        [Validation(Required=false)]
        public DentryVOUpdater Updater { get; set; }
        public class DentryVOUpdater : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YEp3JcM******UIbhwiE</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxx.yy">https://xxx.yy</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("visitorInfo")]
        [Validation(Required=false)]
        public DentryVOVisitorInfo VisitorInfo { get; set; }
        public class DentryVOVisitorInfo : TeaModel {
            [NameInMap("dentryActions")]
            [Validation(Required=false)]
            public List<string> DentryActions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

            [NameInMap("spaceActions")]
            [Validation(Required=false)]
            public List<string> SpaceActions { get; set; }

        }

    }

}
