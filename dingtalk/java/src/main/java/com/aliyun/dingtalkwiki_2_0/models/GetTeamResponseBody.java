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
        @NameInMap("type")
        public String type;

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
        public GetTeamResponseBodyTeamIcon icon;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("modifierId")
        public String modifierId;

        @NameInMap("name")
        public String name;

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
