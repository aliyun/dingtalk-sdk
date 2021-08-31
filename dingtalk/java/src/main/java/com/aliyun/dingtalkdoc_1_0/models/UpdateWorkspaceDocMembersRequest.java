// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateWorkspaceDocMembersRequest extends TeaModel {
    // 发起操作者unionId
    @NameInMap("operatorId")
    public String operatorId;

    // 被操作用户组
    @NameInMap("members")
    public java.util.List<UpdateWorkspaceDocMembersRequestMembers> members;

    public static UpdateWorkspaceDocMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateWorkspaceDocMembersRequest self = new UpdateWorkspaceDocMembersRequest();
        return TeaModel.build(map, self);
    }

    public UpdateWorkspaceDocMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public UpdateWorkspaceDocMembersRequest setMembers(java.util.List<UpdateWorkspaceDocMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<UpdateWorkspaceDocMembersRequestMembers> getMembers() {
        return this.members;
    }

    public static class UpdateWorkspaceDocMembersRequestMembers extends TeaModel {
        // 被操作用户unionId
        @NameInMap("memberId")
        public String memberId;

        // 用户类型
        @NameInMap("memberType")
        public String memberType;

        // 用户权限
        @NameInMap("roleType")
        public String roleType;

        public static UpdateWorkspaceDocMembersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            UpdateWorkspaceDocMembersRequestMembers self = new UpdateWorkspaceDocMembersRequestMembers();
            return TeaModel.build(map, self);
        }

        public UpdateWorkspaceDocMembersRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public UpdateWorkspaceDocMembersRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public UpdateWorkspaceDocMembersRequestMembers setRoleType(String roleType) {
            this.roleType = roleType;
            return this;
        }
        public String getRoleType() {
            return this.roleType;
        }

    }

}
