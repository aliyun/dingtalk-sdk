// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class ListWorkspacesResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("workspaces")
    public java.util.List<ListWorkspacesResponseBodyWorkspaces> workspaces;

    public static ListWorkspacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListWorkspacesResponseBody self = new ListWorkspacesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListWorkspacesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListWorkspacesResponseBody setWorkspaces(java.util.List<ListWorkspacesResponseBodyWorkspaces> workspaces) {
        this.workspaces = workspaces;
        return this;
    }
    public java.util.List<ListWorkspacesResponseBodyWorkspaces> getWorkspaces() {
        return this.workspaces;
    }

    public static class ListWorkspacesResponseBodyWorkspacesIcon extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public String value;

        public static ListWorkspacesResponseBodyWorkspacesIcon build(java.util.Map<String, ?> map) throws Exception {
            ListWorkspacesResponseBodyWorkspacesIcon self = new ListWorkspacesResponseBodyWorkspacesIcon();
            return TeaModel.build(map, self);
        }

        public ListWorkspacesResponseBodyWorkspacesIcon setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListWorkspacesResponseBodyWorkspacesIcon setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListWorkspacesResponseBodyWorkspaces extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("cover")
        public String cover;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("description")
        public String description;

        @NameInMap("icon")
        public ListWorkspacesResponseBodyWorkspacesIcon icon;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("modifierId")
        public String modifierId;

        @NameInMap("name")
        public String name;

        @NameInMap("permissionRole")
        public String permissionRole;

        @NameInMap("rootNodeId")
        public String rootNodeId;

        @NameInMap("teamId")
        public String teamId;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        @NameInMap("workspaceId")
        public String workspaceId;

        public static ListWorkspacesResponseBodyWorkspaces build(java.util.Map<String, ?> map) throws Exception {
            ListWorkspacesResponseBodyWorkspaces self = new ListWorkspacesResponseBodyWorkspaces();
            return TeaModel.build(map, self);
        }

        public ListWorkspacesResponseBodyWorkspaces setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListWorkspacesResponseBodyWorkspaces setCover(String cover) {
            this.cover = cover;
            return this;
        }
        public String getCover() {
            return this.cover;
        }

        public ListWorkspacesResponseBodyWorkspaces setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListWorkspacesResponseBodyWorkspaces setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public ListWorkspacesResponseBodyWorkspaces setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListWorkspacesResponseBodyWorkspaces setIcon(ListWorkspacesResponseBodyWorkspacesIcon icon) {
            this.icon = icon;
            return this;
        }
        public ListWorkspacesResponseBodyWorkspacesIcon getIcon() {
            return this.icon;
        }

        public ListWorkspacesResponseBodyWorkspaces setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public ListWorkspacesResponseBodyWorkspaces setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public ListWorkspacesResponseBodyWorkspaces setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListWorkspacesResponseBodyWorkspaces setPermissionRole(String permissionRole) {
            this.permissionRole = permissionRole;
            return this;
        }
        public String getPermissionRole() {
            return this.permissionRole;
        }

        public ListWorkspacesResponseBodyWorkspaces setRootNodeId(String rootNodeId) {
            this.rootNodeId = rootNodeId;
            return this;
        }
        public String getRootNodeId() {
            return this.rootNodeId;
        }

        public ListWorkspacesResponseBodyWorkspaces setTeamId(String teamId) {
            this.teamId = teamId;
            return this;
        }
        public String getTeamId() {
            return this.teamId;
        }

        public ListWorkspacesResponseBodyWorkspaces setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListWorkspacesResponseBodyWorkspaces setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public ListWorkspacesResponseBodyWorkspaces setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

}
