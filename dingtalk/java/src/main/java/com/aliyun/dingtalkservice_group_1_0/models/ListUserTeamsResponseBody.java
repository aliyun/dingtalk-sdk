// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ListUserTeamsResponseBody extends TeaModel {
    // teams
    @NameInMap("teams")
    public java.util.List<ListUserTeamsResponseBodyTeams> teams;

    public static ListUserTeamsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListUserTeamsResponseBody self = new ListUserTeamsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListUserTeamsResponseBody setTeams(java.util.List<ListUserTeamsResponseBodyTeams> teams) {
        this.teams = teams;
        return this;
    }
    public java.util.List<ListUserTeamsResponseBodyTeams> getTeams() {
        return this.teams;
    }

    public static class ListUserTeamsResponseBodyTeams extends TeaModel {
        // 开放团队ID
        @NameInMap("openTeamId")
        public String openTeamId;

        // 团队名称
        @NameInMap("teamName")
        public String teamName;

        public static ListUserTeamsResponseBodyTeams build(java.util.Map<String, ?> map) throws Exception {
            ListUserTeamsResponseBodyTeams self = new ListUserTeamsResponseBodyTeams();
            return TeaModel.build(map, self);
        }

        public ListUserTeamsResponseBodyTeams setOpenTeamId(String openTeamId) {
            this.openTeamId = openTeamId;
            return this;
        }
        public String getOpenTeamId() {
            return this.openTeamId;
        }

        public ListUserTeamsResponseBodyTeams setTeamName(String teamName) {
            this.teamName = teamName;
            return this;
        }
        public String getTeamName() {
            return this.teamName;
        }

    }

}
