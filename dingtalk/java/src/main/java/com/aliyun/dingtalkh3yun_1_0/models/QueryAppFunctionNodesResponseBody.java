// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryAppFunctionNodesResponseBody extends TeaModel {
    // 状态码
    @NameInMap("code")
    public String code;

    // 返回结果
    @NameInMap("data")
    public java.util.List<QueryAppFunctionNodesResponseBodyData> data;

    // 提示信息
    @NameInMap("message")
    public String message;

    public static QueryAppFunctionNodesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAppFunctionNodesResponseBody self = new QueryAppFunctionNodesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAppFunctionNodesResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public QueryAppFunctionNodesResponseBody setData(java.util.List<QueryAppFunctionNodesResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<QueryAppFunctionNodesResponseBodyData> getData() {
        return this.data;
    }

    public QueryAppFunctionNodesResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class QueryAppFunctionNodesResponseBodyData extends TeaModel {
        // 节点所属的应用编码
        @NameInMap("appCode")
        public String appCode;

        // 显示名称
        @NameInMap("displayName")
        public String displayName;

        // 是否是系统节点，如果是则无法删除
        @NameInMap("isSystem")
        public Boolean isSystem;

        // 菜单节点类型。 AppPackage=应用程序 FormModule=列表模块(不能发起流程)、 WorkflowModule=流程列表模块(可以发起流程) ReportModule=报表模块 GroupModule=节点分组
        @NameInMap("nodeType")
        public String nodeType;

        // 菜单可见类型。 Inactive=未指定 AllVisible=全部可见 PcVisible=仅pc可见 MobileVisible=仅移动端可见 InVisible=全部不可见
        @NameInMap("nodeVisibleType")
        public String nodeVisibleType;

        // 父节点的编码
        @NameInMap("parentCode")
        public String parentCode;

        // 节点编码。如果nodeType=FormModule,则为表单编码
        @NameInMap("schemaCode")
        public String schemaCode;

        // 排序编号
        @NameInMap("sortKey")
        public Long sortKey;

        // 菜单状态。 Inactive=未激活 Active=激活
        @NameInMap("state")
        public String state;

        public static QueryAppFunctionNodesResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            QueryAppFunctionNodesResponseBodyData self = new QueryAppFunctionNodesResponseBodyData();
            return TeaModel.build(map, self);
        }

        public QueryAppFunctionNodesResponseBodyData setAppCode(String appCode) {
            this.appCode = appCode;
            return this;
        }
        public String getAppCode() {
            return this.appCode;
        }

        public QueryAppFunctionNodesResponseBodyData setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public QueryAppFunctionNodesResponseBodyData setIsSystem(Boolean isSystem) {
            this.isSystem = isSystem;
            return this;
        }
        public Boolean getIsSystem() {
            return this.isSystem;
        }

        public QueryAppFunctionNodesResponseBodyData setNodeType(String nodeType) {
            this.nodeType = nodeType;
            return this;
        }
        public String getNodeType() {
            return this.nodeType;
        }

        public QueryAppFunctionNodesResponseBodyData setNodeVisibleType(String nodeVisibleType) {
            this.nodeVisibleType = nodeVisibleType;
            return this;
        }
        public String getNodeVisibleType() {
            return this.nodeVisibleType;
        }

        public QueryAppFunctionNodesResponseBodyData setParentCode(String parentCode) {
            this.parentCode = parentCode;
            return this;
        }
        public String getParentCode() {
            return this.parentCode;
        }

        public QueryAppFunctionNodesResponseBodyData setSchemaCode(String schemaCode) {
            this.schemaCode = schemaCode;
            return this;
        }
        public String getSchemaCode() {
            return this.schemaCode;
        }

        public QueryAppFunctionNodesResponseBodyData setSortKey(Long sortKey) {
            this.sortKey = sortKey;
            return this;
        }
        public Long getSortKey() {
            return this.sortKey;
        }

        public QueryAppFunctionNodesResponseBodyData setState(String state) {
            this.state = state;
            return this;
        }
        public String getState() {
            return this.state;
        }

    }

}
