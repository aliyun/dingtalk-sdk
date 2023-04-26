// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateWorkspaceMembersRequest extends TeaModel {
    @NameInMap("members")
    public java.util.List<UpdateWorkspaceMembersRequestMembers> members;

    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateWorkspaceMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateWorkspaceMembersRequest self = new UpdateWorkspaceMembersRequest();
        return TeaModel.build(map, self);
    }

    public UpdateWorkspaceMembersRequest setMembers(java.util.List<UpdateWorkspaceMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<UpdateWorkspaceMembersRequestMembers> getMembers() {
        return this.members;
    }

    public UpdateWorkspaceMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class UpdateWorkspaceMembersRequestMembers extends TeaModel {
        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberType")
        public String memberType;

        @NameInMap("roleType")
        public String roleType;

        public static UpdateWorkspaceMembersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            UpdateWorkspaceMembersRequestMembers self = new UpdateWorkspaceMembersRequestMembers();
            return TeaModel.build(map, self);
        }

        public UpdateWorkspaceMembersRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public UpdateWorkspaceMembersRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public UpdateWorkspaceMembersRequestMembers setRoleType(String roleType) {
            this.roleType = roleType;
            return this;
        }
        public String getRoleType() {
            return this.roleType;
        }

    }

}
