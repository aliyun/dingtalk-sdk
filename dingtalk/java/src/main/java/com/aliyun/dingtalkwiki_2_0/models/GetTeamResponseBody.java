// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetTeamResponseBody extends TeaModel {
    @NameInMap("team")
    public GetTeamResponseBodyTeam team;

    public static GetTeamResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTeamResponseBody self = new GetTeamResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTeamResponseBody setTeam(GetTeamResponseBodyTeam team) {
        this.team = team;
        return this;
    }
    public GetTeamResponseBodyTeam getTeam() {
        return this.team;
    }

    public static class GetTeamResponseBodyTeamIcon extends TeaModel {
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

        public static GetTeamResponseBodyTeamIcon build(java.util.Map<String, ?> map) throws Exception {
            GetTeamResponseBodyTeamIcon self = new GetTeamResponseBodyTeamIcon();
            return TeaModel.build(map, self);
        }

        public GetTeamResponseBodyTeamIcon setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetTeamResponseBodyTeamIcon setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetTeamResponseBodyTeam extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>corp_id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>team_cover</p>
         */
        @NameInMap("cover")
        public String cover;

        /**
         * <strong>example:</strong>
         * <p>team_create_time</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>team_creator_id</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>team_description</p>
         */
        @NameInMap("description")
        public String description;

        @NameInMap("icon")
        public GetTeamResponseBodyTeamIcon icon;

        /**
         * <strong>example:</strong>
         * <p>team_modified_time</p>
         */
        @NameInMap("modifiedTime")
        public String modifiedTime;

        /**
         * <strong>example:</strong>
         * <p>team_modifier_id</p>
         */
        @NameInMap("modifierId")
        public String modifierId;

        /**
         * <strong>example:</strong>
         * <p>team_name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>team_id</p>
         */
        @NameInMap("teamId")
        public String teamId;

        public static GetTeamResponseBodyTeam build(java.util.Map<String, ?> map) throws Exception {
            GetTeamResponseBodyTeam self = new GetTeamResponseBodyTeam();
            return TeaModel.build(map, self);
        }

        public GetTeamResponseBodyTeam setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetTeamResponseBodyTeam setCover(String cover) {
            this.cover = cover;
            return this;
        }
        public String getCover() {
            return this.cover;
        }

        public GetTeamResponseBodyTeam setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetTeamResponseBodyTeam setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetTeamResponseBodyTeam setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetTeamResponseBodyTeam setIcon(GetTeamResponseBodyTeamIcon icon) {
            this.icon = icon;
            return this;
        }
        public GetTeamResponseBodyTeamIcon getIcon() {
            return this.icon;
        }

        public GetTeamResponseBodyTeam setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetTeamResponseBodyTeam setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public GetTeamResponseBodyTeam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTeamResponseBodyTeam setTeamId(String teamId) {
            this.teamId = teamId;
            return this;
        }
        public String getTeamId() {
            return this.teamId;
        }

    }

}
