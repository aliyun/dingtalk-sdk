// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class ListTeamsResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("teams")
    public java.util.List<ListTeamsResponseBodyTeams> teams;

    public static ListTeamsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListTeamsResponseBody self = new ListTeamsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListTeamsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListTeamsResponseBody setTeams(java.util.List<ListTeamsResponseBodyTeams> teams) {
        this.teams = teams;
        return this;
    }
    public java.util.List<ListTeamsResponseBodyTeams> getTeams() {
        return this.teams;
    }

    public static class ListTeamsResponseBodyTeamsIcon extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public String value;

        public static ListTeamsResponseBodyTeamsIcon build(java.util.Map<String, ?> map) throws Exception {
            ListTeamsResponseBodyTeamsIcon self = new ListTeamsResponseBodyTeamsIcon();
            return TeaModel.build(map, self);
        }

        public ListTeamsResponseBodyTeamsIcon setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListTeamsResponseBodyTeamsIcon setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListTeamsResponseBodyTeams extends TeaModel {
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
        public ListTeamsResponseBodyTeamsIcon icon;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("modifierId")
        public String modifierId;

        @NameInMap("name")
        public String name;

        @NameInMap("teamId")
        public String teamId;

        public static ListTeamsResponseBodyTeams build(java.util.Map<String, ?> map) throws Exception {
            ListTeamsResponseBodyTeams self = new ListTeamsResponseBodyTeams();
            return TeaModel.build(map, self);
        }

        public ListTeamsResponseBodyTeams setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListTeamsResponseBodyTeams setCover(String cover) {
            this.cover = cover;
            return this;
        }
        public String getCover() {
            return this.cover;
        }

        public ListTeamsResponseBodyTeams setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListTeamsResponseBodyTeams setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public ListTeamsResponseBodyTeams setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListTeamsResponseBodyTeams setIcon(ListTeamsResponseBodyTeamsIcon icon) {
            this.icon = icon;
            return this;
        }
        public ListTeamsResponseBodyTeamsIcon getIcon() {
            return this.icon;
        }

        public ListTeamsResponseBodyTeams setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public ListTeamsResponseBodyTeams setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public ListTeamsResponseBodyTeams setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListTeamsResponseBodyTeams setTeamId(String teamId) {
            this.teamId = teamId;
            return this;
        }
        public String getTeamId() {
            return this.teamId;
        }

    }

}
