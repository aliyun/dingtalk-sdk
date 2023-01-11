// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetWorkspaceNodeResponseBody extends TeaModel {
    /**
     * <p>是否有权限</p>
     */
    @NameInMap("hasPermission")
    public Boolean hasPermission;

    /**
     * <p>节点信息</p>
     */
    @NameInMap("nodeBO")
    public GetWorkspaceNodeResponseBodyNodeBO nodeBO;

    /**
     * <p>节点所属知识库信息。</p>
     */
    @NameInMap("workspaceBO")
    public GetWorkspaceNodeResponseBodyWorkspaceBO workspaceBO;

    public static GetWorkspaceNodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWorkspaceNodeResponseBody self = new GetWorkspaceNodeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWorkspaceNodeResponseBody setHasPermission(Boolean hasPermission) {
        this.hasPermission = hasPermission;
        return this;
    }
    public Boolean getHasPermission() {
        return this.hasPermission;
    }

    public GetWorkspaceNodeResponseBody setNodeBO(GetWorkspaceNodeResponseBodyNodeBO nodeBO) {
        this.nodeBO = nodeBO;
        return this;
    }
    public GetWorkspaceNodeResponseBodyNodeBO getNodeBO() {
        return this.nodeBO;
    }

    public GetWorkspaceNodeResponseBody setWorkspaceBO(GetWorkspaceNodeResponseBodyWorkspaceBO workspaceBO) {
        this.workspaceBO = workspaceBO;
        return this;
    }
    public GetWorkspaceNodeResponseBodyWorkspaceBO getWorkspaceBO() {
        return this.workspaceBO;
    }

    public static class GetWorkspaceNodeResponseBodyNodeBO extends TeaModel {
        /**
         * <p>节点类型</p>
         */
        @NameInMap("docType")
        public String docType;

        /**
         * <p>最后编辑时间</p>
         */
        @NameInMap("lastEditTime")
        public Long lastEditTime;

        /**
         * <p>节点名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>节点Id</p>
         */
        @NameInMap("nodeId")
        public String nodeId;

        /**
         * <p>节点打开url</p>
         */
        @NameInMap("url")
        public String url;

        public static GetWorkspaceNodeResponseBodyNodeBO build(java.util.Map<String, ?> map) throws Exception {
            GetWorkspaceNodeResponseBodyNodeBO self = new GetWorkspaceNodeResponseBodyNodeBO();
            return TeaModel.build(map, self);
        }

        public GetWorkspaceNodeResponseBodyNodeBO setDocType(String docType) {
            this.docType = docType;
            return this;
        }
        public String getDocType() {
            return this.docType;
        }

        public GetWorkspaceNodeResponseBodyNodeBO setLastEditTime(Long lastEditTime) {
            this.lastEditTime = lastEditTime;
            return this;
        }
        public Long getLastEditTime() {
            return this.lastEditTime;
        }

        public GetWorkspaceNodeResponseBodyNodeBO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetWorkspaceNodeResponseBodyNodeBO setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public GetWorkspaceNodeResponseBodyNodeBO setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetWorkspaceNodeResponseBodyWorkspaceBO extends TeaModel {
        /**
         * <p>知识库名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>知识库id。</p>
         */
        @NameInMap("workspaceId")
        public String workspaceId;

        public static GetWorkspaceNodeResponseBodyWorkspaceBO build(java.util.Map<String, ?> map) throws Exception {
            GetWorkspaceNodeResponseBodyWorkspaceBO self = new GetWorkspaceNodeResponseBodyWorkspaceBO();
            return TeaModel.build(map, self);
        }

        public GetWorkspaceNodeResponseBodyWorkspaceBO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetWorkspaceNodeResponseBodyWorkspaceBO setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

}
