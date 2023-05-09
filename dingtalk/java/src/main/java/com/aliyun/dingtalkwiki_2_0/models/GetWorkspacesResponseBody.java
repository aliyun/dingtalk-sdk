// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetWorkspacesResponseBody extends TeaModel {
    @NameInMap("workspaces")
    public java.util.List<GetWorkspacesResponseBodyWorkspaces> workspaces;

    public static GetWorkspacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWorkspacesResponseBody self = new GetWorkspacesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWorkspacesResponseBody setWorkspaces(java.util.List<GetWorkspacesResponseBodyWorkspaces> workspaces) {
        this.workspaces = workspaces;
        return this;
    }
    public java.util.List<GetWorkspacesResponseBodyWorkspaces> getWorkspaces() {
        return this.workspaces;
    }

    public static class GetWorkspacesResponseBodyWorkspacesIcon extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public String value;

        public static GetWorkspacesResponseBodyWorkspacesIcon build(java.util.Map<String, ?> map) throws Exception {
            GetWorkspacesResponseBodyWorkspacesIcon self = new GetWorkspacesResponseBodyWorkspacesIcon();
            return TeaModel.build(map, self);
        }

        public GetWorkspacesResponseBodyWorkspacesIcon setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetWorkspacesResponseBodyWorkspacesIcon setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetWorkspacesResponseBodyWorkspaces extends TeaModel {
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
        public GetWorkspacesResponseBodyWorkspacesIcon icon;

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

        public static GetWorkspacesResponseBodyWorkspaces build(java.util.Map<String, ?> map) throws Exception {
            GetWorkspacesResponseBodyWorkspaces self = new GetWorkspacesResponseBodyWorkspaces();
            return TeaModel.build(map, self);
        }

        public GetWorkspacesResponseBodyWorkspaces setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetWorkspacesResponseBodyWorkspaces setCover(String cover) {
            this.cover = cover;
            return this;
        }
        public String getCover() {
            return this.cover;
        }

        public GetWorkspacesResponseBodyWorkspaces setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetWorkspacesResponseBodyWorkspaces setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetWorkspacesResponseBodyWorkspaces setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetWorkspacesResponseBodyWorkspaces setIcon(GetWorkspacesResponseBodyWorkspacesIcon icon) {
            this.icon = icon;
            return this;
        }
        public GetWorkspacesResponseBodyWorkspacesIcon getIcon() {
            return this.icon;
        }

        public GetWorkspacesResponseBodyWorkspaces setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetWorkspacesResponseBodyWorkspaces setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public GetWorkspacesResponseBodyWorkspaces setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetWorkspacesResponseBodyWorkspaces setPermissionRole(String permissionRole) {
            this.permissionRole = permissionRole;
            return this;
        }
        public String getPermissionRole() {
            return this.permissionRole;
        }

        public GetWorkspacesResponseBodyWorkspaces setRootNodeId(String rootNodeId) {
            this.rootNodeId = rootNodeId;
            return this;
        }
        public String getRootNodeId() {
            return this.rootNodeId;
        }

        public GetWorkspacesResponseBodyWorkspaces setTeamId(String teamId) {
            this.teamId = teamId;
            return this;
        }
        public String getTeamId() {
            return this.teamId;
        }

        public GetWorkspacesResponseBodyWorkspaces setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetWorkspacesResponseBodyWorkspaces setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetWorkspacesResponseBodyWorkspaces setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

}
