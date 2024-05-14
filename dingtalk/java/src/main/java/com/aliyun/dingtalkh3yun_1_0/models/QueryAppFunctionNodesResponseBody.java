// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryAppFunctionNodesResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public java.util.List<QueryAppFunctionNodesResponseBodyData> data;

    /**
     * <p>This parameter is required.</p>
     */
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
        @NameInMap("appCode")
        public String appCode;

        @NameInMap("displayName")
        public String displayName;

        @NameInMap("isSystem")
        public Boolean isSystem;

        @NameInMap("nodeType")
        public String nodeType;

        @NameInMap("nodeVisibleType")
        public String nodeVisibleType;

        @NameInMap("parentCode")
        public String parentCode;

        @NameInMap("schemaCode")
        public String schemaCode;

        @NameInMap("sortKey")
        public Long sortKey;

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
