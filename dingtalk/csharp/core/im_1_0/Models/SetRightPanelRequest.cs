// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SetRightPanelRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ciddjxhgdDXSAAXXXXX</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("rightPanelClosePermitted")]
        [Validation(Required=false)]
        public bool? RightPanelClosePermitted { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("rightPanelOpenStatus")]
        [Validation(Required=false)]
        public int? RightPanelOpenStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>侧边栏标题</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("webWndParams")]
        [Validation(Required=false)]
        public SetRightPanelRequestWebWndParams WebWndParams { get; set; }
        public class SetRightPanelRequestWebWndParams : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.dingtalk.com/">https://www.dingtalk.com/</a></para>
            /// </summary>
            [NameInMap("targetURL")]
            [Validation(Required=false)]
            public string TargetURL { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
