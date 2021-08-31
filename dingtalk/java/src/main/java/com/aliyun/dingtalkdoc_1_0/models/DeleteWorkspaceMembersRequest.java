// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteWorkspaceMembersRequest extends TeaModel {
    // 发起操作者unionId
    @NameInMap("operatorId")
    public String operatorId;

    // 被操作用户组
    @NameInMap("members")
    public java.util.List<DeleteWorkspaceMembersRequestMembers> members;

    public static DeleteWorkspaceMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteWorkspaceMembersRequest self = new DeleteWorkspaceMembersRequest();
        return TeaModel.build(map, self);
    }

    public DeleteWorkspaceMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public DeleteWorkspaceMembersRequest setMembers(java.util.List<DeleteWorkspaceMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<DeleteWorkspaceMembersRequestMembers> getMembers() {
        return this.members;
    }

    public static class DeleteWorkspaceMembersRequestMembers extends TeaModel {
        // 被操作用户unionId
        @NameInMap("memberId")
        public String memberId;

        // 用户类型
        @NameInMap("memberType")
        public String memberType;

        public static DeleteWorkspaceMembersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            DeleteWorkspaceMembersRequestMembers self = new DeleteWorkspaceMembersRequestMembers();
            return TeaModel.build(map, self);
        }

        public DeleteWorkspaceMembersRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public DeleteWorkspaceMembersRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

}
