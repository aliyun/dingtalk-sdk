// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchGetWorkspacesResponseBody extends TeaModel {
    // workspace信息
    @NameInMap("workspaces")
    public java.util.List<BatchGetWorkspacesResponseBodyWorkspaces> workspaces;

    public static BatchGetWorkspacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchGetWorkspacesResponseBody self = new BatchGetWorkspacesResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchGetWorkspacesResponseBody setWorkspaces(java.util.List<BatchGetWorkspacesResponseBodyWorkspaces> workspaces) {
        this.workspaces = workspaces;
        return this;
    }
    public java.util.List<BatchGetWorkspacesResponseBodyWorkspaces> getWorkspaces() {
        return this.workspaces;
    }

    public static class BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList extends TeaModel {
        // 最近编辑时间
        @NameInMap("lastEditTime")
        public String lastEditTime;

        // 文档名称
        @NameInMap("name")
        public String name;

        // 文档Id
        @NameInMap("nodeId")
        public String nodeId;

        // 文档打开url
        @NameInMap("url")
        public String url;

        public static BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList build(java.util.Map<String, ?> map) throws Exception {
            BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList self = new BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList();
            return TeaModel.build(map, self);
        }

        public BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList setLastEditTime(String lastEditTime) {
            this.lastEditTime = lastEditTime;
            return this;
        }
        public String getLastEditTime() {
            return this.lastEditTime;
        }

        public BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class BatchGetWorkspacesResponseBodyWorkspacesWorkspace extends TeaModel {
        // 知识库创建时间。
        @NameInMap("createTime")
        public Long createTime;

        // 知识库名称。
        @NameInMap("name")
        public String name;

        // 是否全员公开
        @NameInMap("orgPublished")
        public Boolean orgPublished;

        // 最近访问列表
        @NameInMap("recentList")
        public java.util.List<BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList> recentList;

        // 知识库打开url。
        @NameInMap("url")
        public String url;

        // 知识库id。
        @NameInMap("workspaceId")
        public String workspaceId;

        public static BatchGetWorkspacesResponseBodyWorkspacesWorkspace build(java.util.Map<String, ?> map) throws Exception {
            BatchGetWorkspacesResponseBodyWorkspacesWorkspace self = new BatchGetWorkspacesResponseBodyWorkspacesWorkspace();
            return TeaModel.build(map, self);
        }

        public BatchGetWorkspacesResponseBodyWorkspacesWorkspace setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public BatchGetWorkspacesResponseBodyWorkspacesWorkspace setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchGetWorkspacesResponseBodyWorkspacesWorkspace setOrgPublished(Boolean orgPublished) {
            this.orgPublished = orgPublished;
            return this;
        }
        public Boolean getOrgPublished() {
            return this.orgPublished;
        }

        public BatchGetWorkspacesResponseBodyWorkspacesWorkspace setRecentList(java.util.List<BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList> recentList) {
            this.recentList = recentList;
            return this;
        }
        public java.util.List<BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList> getRecentList() {
            return this.recentList;
        }

        public BatchGetWorkspacesResponseBodyWorkspacesWorkspace setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public BatchGetWorkspacesResponseBodyWorkspacesWorkspace setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

    public static class BatchGetWorkspacesResponseBodyWorkspaces extends TeaModel {
        // 是否有访问知识库权限。
        @NameInMap("hasPermission")
        public Boolean hasPermission;

        // 知识库信息。
        @NameInMap("workspace")
        public BatchGetWorkspacesResponseBodyWorkspacesWorkspace workspace;

        public static BatchGetWorkspacesResponseBodyWorkspaces build(java.util.Map<String, ?> map) throws Exception {
            BatchGetWorkspacesResponseBodyWorkspaces self = new BatchGetWorkspacesResponseBodyWorkspaces();
            return TeaModel.build(map, self);
        }

        public BatchGetWorkspacesResponseBodyWorkspaces setHasPermission(Boolean hasPermission) {
            this.hasPermission = hasPermission;
            return this;
        }
        public Boolean getHasPermission() {
            return this.hasPermission;
        }

        public BatchGetWorkspacesResponseBodyWorkspaces setWorkspace(BatchGetWorkspacesResponseBodyWorkspacesWorkspace workspace) {
            this.workspace = workspace;
            return this;
        }
        public BatchGetWorkspacesResponseBodyWorkspacesWorkspace getWorkspace() {
            return this.workspace;
        }

    }

}
