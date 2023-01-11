// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedWorkspacesResponseBody extends TeaModel {
    /**
     * <p>知识库结果集。</p>
     */
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
        /**
         * <p>文档最后编辑时间</p>
         */
        @NameInMap("lastEditTime")
        public Long lastEditTime;

        /**
         * <p>文档名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>文档id</p>
         */
        @NameInMap("nodeId")
        public String nodeId;

        /**
         * <p>文档打开url</p>
         */
        @NameInMap("url")
        public String url;

        public static GetRelatedWorkspacesResponseBodyWorkspacesRecentList build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedWorkspacesResponseBodyWorkspacesRecentList self = new GetRelatedWorkspacesResponseBodyWorkspacesRecentList();
            return TeaModel.build(map, self);
        }

        public GetRelatedWorkspacesResponseBodyWorkspacesRecentList setLastEditTime(Long lastEditTime) {
            this.lastEditTime = lastEditTime;
            return this;
        }
        public Long getLastEditTime() {
            return this.lastEditTime;
        }

        public GetRelatedWorkspacesResponseBodyWorkspacesRecentList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetRelatedWorkspacesResponseBodyWorkspacesRecentList setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
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
        /**
         * <p>知识库创建时间。</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>知识库是否被删除。</p>
         */
        @NameInMap("deleted")
        public Boolean deleted;

        /**
         * <p>知识库名称。</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("owner")
        public String owner;

        /**
         * <p>知识库最近访问文档列表。</p>
         */
        @NameInMap("recentList")
        public java.util.List<GetRelatedWorkspacesResponseBodyWorkspacesRecentList> recentList;

        /**
         * <p>用户的角色</p>
         */
        @NameInMap("role")
        public String role;

        /**
         * <p>知识库打开url。</p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <p>知识库id。</p>
         */
        @NameInMap("workspaceId")
        public String workspaceId;

        public static GetRelatedWorkspacesResponseBodyWorkspaces build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedWorkspacesResponseBodyWorkspaces self = new GetRelatedWorkspacesResponseBodyWorkspaces();
            return TeaModel.build(map, self);
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setDeleted(Boolean deleted) {
            this.deleted = deleted;
            return this;
        }
        public Boolean getDeleted() {
            return this.deleted;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setOwner(String owner) {
            this.owner = owner;
            return this;
        }
        public String getOwner() {
            return this.owner;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setRecentList(java.util.List<GetRelatedWorkspacesResponseBodyWorkspacesRecentList> recentList) {
            this.recentList = recentList;
            return this;
        }
        public java.util.List<GetRelatedWorkspacesResponseBodyWorkspacesRecentList> getRecentList() {
            return this.recentList;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetRelatedWorkspacesResponseBodyWorkspaces setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

}
