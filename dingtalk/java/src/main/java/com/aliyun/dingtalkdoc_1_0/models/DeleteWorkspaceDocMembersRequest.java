// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteWorkspaceDocMembersRequest extends TeaModel {
    // 发起操作者unionId
    @NameInMap("operatorId")
    public String operatorId;

    // 被操作用户组
    @NameInMap("members")
    public java.util.List<DeleteWorkspaceDocMembersRequestMembers> members;

    public static DeleteWorkspaceDocMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteWorkspaceDocMembersRequest self = new DeleteWorkspaceDocMembersRequest();
        return TeaModel.build(map, self);
    }

    public DeleteWorkspaceDocMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public DeleteWorkspaceDocMembersRequest setMembers(java.util.List<DeleteWorkspaceDocMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<DeleteWorkspaceDocMembersRequestMembers> getMembers() {
        return this.members;
    }

    public static class DeleteWorkspaceDocMembersRequestMembers extends TeaModel {
        // 被操作用户unionId
        @NameInMap("memberId")
        public String memberId;

        // 用户类型
        @NameInMap("memberType")
        public String memberType;

        public static DeleteWorkspaceDocMembersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            DeleteWorkspaceDocMembersRequestMembers self = new DeleteWorkspaceDocMembersRequestMembers();
            return TeaModel.build(map, self);
        }

        public DeleteWorkspaceDocMembersRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public DeleteWorkspaceDocMembersRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

}
