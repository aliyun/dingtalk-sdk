// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteWorkspaceMembersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("members")
    public java.util.List<DeleteWorkspaceMembersRequestMembers> members;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteWorkspaceMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteWorkspaceMembersRequest self = new DeleteWorkspaceMembersRequest();
        return TeaModel.build(map, self);
    }

    public DeleteWorkspaceMembersRequest setMembers(java.util.List<DeleteWorkspaceMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<DeleteWorkspaceMembersRequestMembers> getMembers() {
        return this.members;
    }

    public DeleteWorkspaceMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class DeleteWorkspaceMembersRequestMembers extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>This parameter is required.</p>
         */
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
