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
        /**
         * <strong>example:</strong>
         * <p>URL</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>icon_url</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>corp_id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>workspace_cover</p>
         */
        @NameInMap("cover")
        public String cover;

        /**
         * <strong>example:</strong>
         * <p>workspace_create_time</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>workspace_creator_id</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>workspace_description</p>
         */
        @NameInMap("description")
        public String description;

        @NameInMap("icon")
        public GetMineWorkspaceResponseBodyWorkspaceIcon icon;

        /**
         * <strong>example:</strong>
         * <p>workspace_modified_time</p>
         */
        @NameInMap("modifiedTime")
        public String modifiedTime;

        /**
         * <strong>example:</strong>
         * <p>workspace_modifier_id</p>
         */
        @NameInMap("modifierId")
        public String modifierId;

        /**
         * <strong>example:</strong>
         * <p>workspace_name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>READER</p>
         */
        @NameInMap("permissionRole")
        public String permissionRole;

        /**
         * <strong>example:</strong>
         * <p>root_node_uuid</p>
         */
        @NameInMap("rootNodeId")
        public String rootNodeId;

        /**
         * <strong>example:</strong>
         * <p>team_id</p>
         */
        @NameInMap("teamId")
        public String teamId;

        /**
         * <strong>example:</strong>
         * <p>TEAM</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>workspace_url</p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <strong>example:</strong>
         * <p>workspace_id</p>
         */
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
