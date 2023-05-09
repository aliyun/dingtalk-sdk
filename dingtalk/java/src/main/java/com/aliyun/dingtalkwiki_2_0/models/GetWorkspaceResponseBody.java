// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetWorkspaceResponseBody extends TeaModel {
    @NameInMap("workspace")
    public GetWorkspaceResponseBodyWorkspace workspace;

    public static GetWorkspaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWorkspaceResponseBody self = new GetWorkspaceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWorkspaceResponseBody setWorkspace(GetWorkspaceResponseBodyWorkspace workspace) {
        this.workspace = workspace;
        return this;
    }
    public GetWorkspaceResponseBodyWorkspace getWorkspace() {
        return this.workspace;
    }

    public static class GetWorkspaceResponseBodyWorkspaceIcon extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public String value;

        public static GetWorkspaceResponseBodyWorkspaceIcon build(java.util.Map<String, ?> map) throws Exception {
            GetWorkspaceResponseBodyWorkspaceIcon self = new GetWorkspaceResponseBodyWorkspaceIcon();
            return TeaModel.build(map, self);
        }

        public GetWorkspaceResponseBodyWorkspaceIcon setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetWorkspaceResponseBodyWorkspaceIcon setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetWorkspaceResponseBodyWorkspace extends TeaModel {
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
        public GetWorkspaceResponseBodyWorkspaceIcon icon;

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

        public static GetWorkspaceResponseBodyWorkspace build(java.util.Map<String, ?> map) throws Exception {
            GetWorkspaceResponseBodyWorkspace self = new GetWorkspaceResponseBodyWorkspace();
            return TeaModel.build(map, self);
        }

        public GetWorkspaceResponseBodyWorkspace setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetWorkspaceResponseBodyWorkspace setCover(String cover) {
            this.cover = cover;
            return this;
        }
        public String getCover() {
            return this.cover;
        }

        public GetWorkspaceResponseBodyWorkspace setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetWorkspaceResponseBodyWorkspace setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetWorkspaceResponseBodyWorkspace setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetWorkspaceResponseBodyWorkspace setIcon(GetWorkspaceResponseBodyWorkspaceIcon icon) {
            this.icon = icon;
            return this;
        }
        public GetWorkspaceResponseBodyWorkspaceIcon getIcon() {
            return this.icon;
        }

        public GetWorkspaceResponseBodyWorkspace setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetWorkspaceResponseBodyWorkspace setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public GetWorkspaceResponseBodyWorkspace setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetWorkspaceResponseBodyWorkspace setPermissionRole(String permissionRole) {
            this.permissionRole = permissionRole;
            return this;
        }
        public String getPermissionRole() {
            return this.permissionRole;
        }

        public GetWorkspaceResponseBodyWorkspace setRootNodeId(String rootNodeId) {
            this.rootNodeId = rootNodeId;
            return this;
        }
        public String getRootNodeId() {
            return this.rootNodeId;
        }

        public GetWorkspaceResponseBodyWorkspace setTeamId(String teamId) {
            this.teamId = teamId;
            return this;
        }
        public String getTeamId() {
            return this.teamId;
        }

        public GetWorkspaceResponseBodyWorkspace setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetWorkspaceResponseBodyWorkspace setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetWorkspaceResponseBodyWorkspace setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

}
