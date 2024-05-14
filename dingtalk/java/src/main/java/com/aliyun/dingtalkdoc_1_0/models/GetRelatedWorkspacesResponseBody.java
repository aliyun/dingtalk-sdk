// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedWorkspacesResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
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
        @NameInMap("lastEditTime")
        public Long lastEditTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("nodeId")
        public String nodeId;

        /**
         * <p>This parameter is required.</p>
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
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deleted")
        public Boolean deleted;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("owner")
        public String owner;

        @NameInMap("recentList")
        public java.util.List<GetRelatedWorkspacesResponseBodyWorkspacesRecentList> recentList;

        @NameInMap("role")
        public String role;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <p>This parameter is required.</p>
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
