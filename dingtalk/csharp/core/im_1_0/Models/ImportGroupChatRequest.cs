// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class ImportGroupChatRequest : TeaModel {
        [NameInMap("adminIds")]
        [Validation(Required=false)]
        public List<string> AdminIds { get; set; }

        [NameInMap("createAt")]
        [Validation(Required=false)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>@lADOADma*****QKA</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>axcf*-<em><b><b>-</b></b></em>-23da*</para>
        /// </summary>
        [NameInMap("importUuid")]
        [Validation(Required=false)]
        public string ImportUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1107****2120</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c354***-<em><b>-</b></em>-b4ea-6f1ab***65</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例群名称</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userList")]
        [Validation(Required=false)]
        public Dictionary<string, UserListValue> UserList { get; set; }

    }

}
