// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetMineWorkspaceResponseBody extends TeaModel {
    @NameInMap("workspace")
    public GetMineWorkspaceResponseBodyWorkspace workspace;

    public static GetMineWorkspaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMineWorkspaceResponseBody self = new GetMineWorkspaceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMineWorkspaceResponseBody setWorkspace(GetMineWorkspaceResponseBodyWorkspace workspace) {
        this.workspace = workspace;
        return this;
    }
    public GetMineWorkspaceResponseBodyWorkspace getWorkspace() {
        return this.workspace;
    }

    public static class GetMineWorkspaceResponseBodyWorkspaceIcon extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public String value;

        public static GetMineWorkspaceResponseBodyWorkspaceIcon build(java.util.Map<String, ?> map) throws Exception {
            GetMineWorkspaceResponseBodyWorkspaceIcon self = new GetMineWorkspaceResponseBodyWorkspaceIcon();
            return TeaModel.build(map, self);
        }

        public GetMineWorkspaceResponseBodyWorkspaceIcon setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetMineWorkspaceResponseBodyWorkspaceIcon setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetMineWorkspaceResponseBodyWorkspace extends TeaModel {
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
        public GetMineWorkspaceResponseBodyWorkspaceIcon icon;

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

        public static GetMineWorkspaceResponseBodyWorkspace build(java.util.Map<String, ?> map) throws Exception {
            GetMineWorkspaceResponseBodyWorkspace self = new GetMineWorkspaceResponseBodyWorkspace();
            return TeaModel.build(map, self);
        }

        public GetMineWorkspaceResponseBodyWorkspace setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetMineWorkspaceResponseBodyWorkspace setCover(String cover) {
            this.cover = cover;
            return this;
        }
        public String getCover() {
            return this.cover;
        }

        public GetMineWorkspaceResponseBodyWorkspace setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetMineWorkspaceResponseBodyWorkspace setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetMineWorkspaceResponseBodyWorkspace setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetMineWorkspaceResponseBodyWorkspace setIcon(GetMineWorkspaceResponseBodyWorkspaceIcon icon) {
            this.icon = icon;
            return this;
        }
        public GetMineWorkspaceResponseBodyWorkspaceIcon getIcon() {
            return this.icon;
        }

        public GetMineWorkspaceResponseBodyWorkspace setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetMineWorkspaceResponseBodyWorkspace setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public GetMineWorkspaceResponseBodyWorkspace setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetMineWorkspaceResponseBodyWorkspace setPermissionRole(String permissionRole) {
            this.permissionRole = permissionRole;
            return this;
        }
        public String getPermissionRole() {
            return this.permissionRole;
        }

        public GetMineWorkspaceResponseBodyWorkspace setRootNodeId(String rootNodeId) {
            this.rootNodeId = rootNodeId;
            return this;
        }
        public String getRootNodeId() {
            return this.rootNodeId;
        }

        public GetMineWorkspaceResponseBodyWorkspace setTeamId(String teamId) {
            this.teamId = teamId;
            return this;
        }
        public String getTeamId() {
            return this.teamId;
        }

        public GetMineWorkspaceResponseBodyWorkspace setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetMineWorkspaceResponseBodyWorkspace setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetMineWorkspaceResponseBodyWorkspace setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

}
