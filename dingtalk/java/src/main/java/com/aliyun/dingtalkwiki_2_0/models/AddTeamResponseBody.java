// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class AddTeamResponseBody extends TeaModel {
    @NameInMap("team")
    public AddTeamResponseBodyTeam team;

    public static AddTeamResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddTeamResponseBody self = new AddTeamResponseBody();
        return TeaModel.build(map, self);
    }

    public AddTeamResponseBody setTeam(AddTeamResponseBodyTeam team) {
        this.team = team;
        return this;
    }
    public AddTeamResponseBodyTeam getTeam() {
        return this.team;
    }

    public static class AddTeamResponseBodyTeamIcon extends TeaModel {
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

        public static AddTeamResponseBodyTeamIcon build(java.util.Map<String, ?> map) throws Exception {
            AddTeamResponseBodyTeamIcon self = new AddTeamResponseBodyTeamIcon();
            return TeaModel.build(map, self);
        }

        public AddTeamResponseBodyTeamIcon setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public AddTeamResponseBodyTeamIcon setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AddTeamResponseBodyTeam extends TeaModel {
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
        public AddTeamResponseBodyTeamIcon icon;

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

        public static AddTeamResponseBodyTeam build(java.util.Map<String, ?> map) throws Exception {
            AddTeamResponseBodyTeam self = new AddTeamResponseBodyTeam();
            return TeaModel.build(map, self);
        }

        public AddTeamResponseBodyTeam setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public AddTeamResponseBodyTeam setCover(String cover) {
            this.cover = cover;
            return this;
        }
        public String getCover() {
            return this.cover;
        }

        public AddTeamResponseBodyTeam setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public AddTeamResponseBodyTeam setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public AddTeamResponseBodyTeam setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public AddTeamResponseBodyTeam setIcon(AddTeamResponseBodyTeamIcon icon) {
            this.icon = icon;
            return this;
        }
        public AddTeamResponseBodyTeamIcon getIcon() {
            return this.icon;
        }

        public AddTeamResponseBodyTeam setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public AddTeamResponseBodyTeam setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public AddTeamResponseBodyTeam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AddTeamResponseBodyTeam setTeamId(String teamId) {
            this.teamId = teamId;
            return this;
        }
        public String getTeamId() {
            return this.teamId;
        }

    }

}
