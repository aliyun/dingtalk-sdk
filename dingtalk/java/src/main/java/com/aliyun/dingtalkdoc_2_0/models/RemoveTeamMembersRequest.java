// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RemoveTeamMembersRequest extends TeaModel {
    @NameInMap("members")
    public java.util.List<RemoveTeamMembersRequestMembers> members;

    @NameInMap("notify")
    public Boolean notify;

    @NameInMap("operatorId")
    public String operatorId;

    public static RemoveTeamMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveTeamMembersRequest self = new RemoveTeamMembersRequest();
        return TeaModel.build(map, self);
    }

    public RemoveTeamMembersRequest setMembers(java.util.List<RemoveTeamMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<RemoveTeamMembersRequestMembers> getMembers() {
        return this.members;
    }

    public RemoveTeamMembersRequest setNotify(Boolean notify) {
        this.notify = notify;
        return this;
    }
    public Boolean getNotify() {
        return this.notify;
    }

    public RemoveTeamMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class RemoveTeamMembersRequestMembers extends TeaModel {
        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberType")
        public Integer memberType;

        @NameInMap("roleCode")
        public String roleCode;

        public static RemoveTeamMembersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            RemoveTeamMembersRequestMembers self = new RemoveTeamMembersRequestMembers();
            return TeaModel.build(map, self);
        }

        public RemoveTeamMembersRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public RemoveTeamMembersRequestMembers setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public RemoveTeamMembersRequestMembers setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
