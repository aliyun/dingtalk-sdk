// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddLibraryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>测试库描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("openTeamIds")]
        [Validation(Required=false)]
        public List<string> OpenTeamIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CCM</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CCM-123</para>
        /// </summary>
        [NameInMap("sourcePrimaryKey")]
        [Validation(Required=false)]
        public string SourcePrimaryKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试库</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EXTERNAL</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
