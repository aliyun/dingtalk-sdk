// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListTeamMembersResponseBody extends TeaModel {
    @NameInMap("members")
    public java.util.List<ListTeamMembersResponseBodyMembers> members;

    @NameInMap("teamName")
    public String teamName;

    public static ListTeamMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListTeamMembersResponseBody self = new ListTeamMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListTeamMembersResponseBody setMembers(java.util.List<ListTeamMembersResponseBodyMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<ListTeamMembersResponseBodyMembers> getMembers() {
        return this.members;
    }

    public ListTeamMembersResponseBody setTeamName(String teamName) {
        this.teamName = teamName;
        return this;
    }
    public String getTeamName() {
        return this.teamName;
    }

    public static class ListTeamMembersResponseBodyMembers extends TeaModel {
        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberType")
        public Integer memberType;

        @NameInMap("name")
        public String name;

        @NameInMap("roleCode")
        public String roleCode;

        public static ListTeamMembersResponseBodyMembers build(java.util.Map<String, ?> map) throws Exception {
            ListTeamMembersResponseBodyMembers self = new ListTeamMembersResponseBodyMembers();
            return TeaModel.build(map, self);
        }

        public ListTeamMembersResponseBodyMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public ListTeamMembersResponseBodyMembers setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public ListTeamMembersResponseBodyMembers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListTeamMembersResponseBodyMembers setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
