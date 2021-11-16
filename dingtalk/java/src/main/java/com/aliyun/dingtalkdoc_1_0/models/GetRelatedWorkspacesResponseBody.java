// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedWorkspacesResponseBody extends TeaModel {
    // 团队空间结果集
    @NameInMap("workspaces")
    public java.util.List<GetRelatedWorkspacesResponseBodyWorkspaces> workspaces;

    public static GetRelatedWorkspacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRelatedWorkspacesResponseBody self = new GetRelatedWorkspacesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRelatedWorkspacesResponseBody setWorkspaces(java.util.List<GetRelatedWorkspacesResponseBodyWorkspaces> workspaces) {
        this.workspaces = workspaces;
        return this;
    }
    public java.util.List<GetRelatedWorkspacesResponseBodyWorkspaces> getWorkspaces() {
        return this.workspaces;
    }

    public static class GetRelatedWorkspacesResponseBodyWorkspacesRecentList extends TeaModel {
        // 文档id
        @NameInMap("nodeId")
        public String nodeId;

        // 文档名称
        @NameInMap("name")
        public String name;

        // 文档打开url
        @NameInMap("url")
        public String url;

        public static GetRelatedWorkspacesResponseBodyWorkspacesRecentList build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedWorkspacesResponseBodyWorkspacesRecentList self = new GetRelatedWorkspacesResponseBodyWorkspacesRecentList();
            return TeaModel.build(map, self);
        }

        public GetRelatedWorkspacesResponseBodyWorkspacesRecentList setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public GetRelatedWorkspacesResponseBodyWorkspacesRecentList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetRelatedWorkspacesResponseBodyWorkspacesRecentList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetRelatedWorkspacesResponseBodyWorkspaces extends TeaModel {
        // 团队空间Id
        @NameInMap("workspaceId")
        public String workspaceId;

        // 团队空间打开url
        @NameInMap("url")
        public String url;

        // 团队空间是否被删除
        @NameInMap("deleted")
        public Boolean deleted;

        @NameInMap("owner")
        public String owner;

        // 团队空间名称
        @NameInMap("name")
        public String name;

        // 团队空间最近访问文档列表
        @NameInMap("recentList")
        public java.util.List<GetRelatedWorkspacesResponseBodyWorkspacesRecentList> recentList;

        public static GetRelatedWorkspacesResponseBodyWorkspaces build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedWorkspacesResponseBodyWorkspaces self = new GetRelatedWorkspacesResponseBodyWorkspaces();
            return TeaModel.build(map, self);
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setDeleted(Boolean deleted) {
            this.deleted = deleted;
            return this;
        }
        public Boolean getDeleted() {
            return this.deleted;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setOwner(String owner) {
            this.owner = owner;
            return this;
        }
        public String getOwner() {
            return this.owner;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setRecentList(java.util.List<GetRelatedWorkspacesResponseBodyWorkspacesRecentList> recentList) {
            this.recentList = recentList;
            return this;
        }
        public java.util.List<GetRelatedWorkspacesResponseBodyWorkspacesRecentList> getRecentList() {
            return this.recentList;
        }

    }

}
