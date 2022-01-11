// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetWorkspaceNodeResponseBody extends TeaModel {
    // 是否有权限
    @NameInMap("hasPermission")
    public Boolean hasPermission;

    // 节点信息
    @NameInMap("nodeBO")
    public GetWorkspaceNodeResponseBodyNodeBO nodeBO;

    // 节点所属团队空间信息
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
        // 节点名称
        @NameInMap("name")
        public String name;

        // 节点Id
        @NameInMap("nodeId")
        public String nodeId;

        // 节点打开url
        @NameInMap("url")
        public String url;

        public static GetWorkspaceNodeResponseBodyNodeBO build(java.util.Map<String, ?> map) throws Exception {
            GetWorkspaceNodeResponseBodyNodeBO self = new GetWorkspaceNodeResponseBodyNodeBO();
            return TeaModel.build(map, self);
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
        // 团队空间名称
        @NameInMap("name")
        public String name;

        // 团队空间Id
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
