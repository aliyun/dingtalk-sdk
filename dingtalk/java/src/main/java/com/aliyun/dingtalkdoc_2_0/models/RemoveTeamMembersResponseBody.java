// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RemoveTeamMembersResponseBody extends TeaModel {
    @NameInMap("notInOrgMembers")
    public java.util.List<RemoveTeamMembersResponseBodyNotInOrgMembers> notInOrgMembers;

    @NameInMap("saveSuccess")
    public Boolean saveSuccess;

    public static RemoveTeamMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveTeamMembersResponseBody self = new RemoveTeamMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveTeamMembersResponseBody setNotInOrgMembers(java.util.List<RemoveTeamMembersResponseBodyNotInOrgMembers> notInOrgMembers) {
        this.notInOrgMembers = notInOrgMembers;
        return this;
    }
    public java.util.List<RemoveTeamMembersResponseBodyNotInOrgMembers> getNotInOrgMembers() {
        return this.notInOrgMembers;
    }

    public RemoveTeamMembersResponseBody setSaveSuccess(Boolean saveSuccess) {
        this.saveSuccess = saveSuccess;
        return this;
    }
    public Boolean getSaveSuccess() {
        return this.saveSuccess;
    }

    public static class RemoveTeamMembersResponseBodyNotInOrgMembers extends TeaModel {
        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberType")
        public Integer memberType;

        @NameInMap("name")
        public String name;

        @NameInMap("roleCode")
        public String roleCode;

        public static RemoveTeamMembersResponseBodyNotInOrgMembers build(java.util.Map<String, ?> map) throws Exception {
            RemoveTeamMembersResponseBodyNotInOrgMembers self = new RemoveTeamMembersResponseBodyNotInOrgMembers();
            return TeaModel.build(map, self);
        }

        public RemoveTeamMembersResponseBodyNotInOrgMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public RemoveTeamMembersResponseBodyNotInOrgMembers setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public RemoveTeamMembersResponseBodyNotInOrgMembers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public RemoveTeamMembersResponseBodyNotInOrgMembers setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
