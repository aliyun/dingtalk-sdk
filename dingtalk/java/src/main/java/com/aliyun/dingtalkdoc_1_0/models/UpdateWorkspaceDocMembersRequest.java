// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateWorkspaceDocMembersRequest extends TeaModel {
    /**
     * <p>被操作用户组</p>
     */
    @NameInMap("members")
    public java.util.List<UpdateWorkspaceDocMembersRequestMembers> members;

    /**
     * <p>发起操作者unionId</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateWorkspaceDocMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateWorkspaceDocMembersRequest self = new UpdateWorkspaceDocMembersRequest();
        return TeaModel.build(map, self);
    }

    public UpdateWorkspaceDocMembersRequest setMembers(java.util.List<UpdateWorkspaceDocMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<UpdateWorkspaceDocMembersRequestMembers> getMembers() {
        return this.members;
    }

    public UpdateWorkspaceDocMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class UpdateWorkspaceDocMembersRequestMembers extends TeaModel {
        /**
         * <p>被操作用户unionId</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>用户类型</p>
         */
        @NameInMap("memberType")
        public String memberType;

        /**
         * <p>用户权限</p>
         */
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
