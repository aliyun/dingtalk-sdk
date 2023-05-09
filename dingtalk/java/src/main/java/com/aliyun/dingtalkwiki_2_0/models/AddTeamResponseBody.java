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
        @NameInMap("type")
        public String type;

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
        public AddTeamResponseBodyTeamIcon icon;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("modifierId")
        public String modifierId;

        @NameInMap("name")
        public String name;

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
