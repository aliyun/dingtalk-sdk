// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AddWorkspaceDocMembersRequest extends TeaModel {
    /**
     * <p>被操作用户组</p>
     */
    @NameInMap("members")
    public java.util.List<AddWorkspaceDocMembersRequestMembers> members;

    /**
     * <p>发起操作者unionId</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static AddWorkspaceDocMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        AddWorkspaceDocMembersRequest self = new AddWorkspaceDocMembersRequest();
        return TeaModel.build(map, self);
    }

    public AddWorkspaceDocMembersRequest setMembers(java.util.List<AddWorkspaceDocMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<AddWorkspaceDocMembersRequestMembers> getMembers() {
        return this.members;
    }

    public AddWorkspaceDocMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class AddWorkspaceDocMembersRequestMembers extends TeaModel {
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

        public static AddWorkspaceDocMembersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            AddWorkspaceDocMembersRequestMembers self = new AddWorkspaceDocMembersRequestMembers();
            return TeaModel.build(map, self);
        }

        public AddWorkspaceDocMembersRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public AddWorkspaceDocMembersRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public AddWorkspaceDocMembersRequestMembers setRoleType(String roleType) {
            this.roleType = roleType;
            return this;
        }
        public String getRoleType() {
            return this.roleType;
        }

    }

}
