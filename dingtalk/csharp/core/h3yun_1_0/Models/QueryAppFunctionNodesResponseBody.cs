// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class QueryAppFunctionNodesResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryAppFunctionNodesResponseBodyData> Data { get; set; }
        public class QueryAppFunctionNodesResponseBodyData : TeaModel {
            /// <summary>
            /// 节点编码。如果nodeType=FormModule,则为表单编码
            /// </summary>
            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

            /// <summary>
            /// 节点所属的应用编码
            /// </summary>
            [NameInMap("appCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            /// <summary>
            /// 父节点的编码
            /// </summary>
            [NameInMap("parentCode")]
            [Validation(Required=false)]
            public string ParentCode { get; set; }

            /// <summary>
            /// 显示名称
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// 菜单可见类型。 Inactive=未指定 AllVisible=全部可见 PcVisible=仅pc可见 MobileVisible=仅移动端可见 InVisible=全部不可见
            /// </summary>
            [NameInMap("nodeVisibleType")]
            [Validation(Required=false)]
            public string NodeVisibleType { get; set; }

            /// <summary>
            /// 菜单节点类型。 AppPackage=应用程序 FormModule=列表模块(不能发起流程)、 WorkflowModule=流程列表模块(可以发起流程) ReportModule=报表模块 GroupModule=节点分组
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// 菜单状态。 Inactive=未激活 Active=激活
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// 排序编号
            /// </summary>
            [NameInMap("sortKey")]
            [Validation(Required=false)]
            public long? SortKey { get; set; }

            /// <summary>
            /// 是否是系统节点，如果是则无法删除
            /// </summary>
            [NameInMap("isSystem")]
            [Validation(Required=false)]
            public bool? IsSystem { get; set; }

        }

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
