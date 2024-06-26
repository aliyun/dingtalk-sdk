// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AddWorkspaceMembersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("members")
    public java.util.List<AddWorkspaceMembersRequestMembers> members;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static AddWorkspaceMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        AddWorkspaceMembersRequest self = new AddWorkspaceMembersRequest();
        return TeaModel.build(map, self);
    }

    public AddWorkspaceMembersRequest setMembers(java.util.List<AddWorkspaceMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<AddWorkspaceMembersRequestMembers> getMembers() {
        return this.members;
    }

    public AddWorkspaceMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class AddWorkspaceMembersRequestMembers extends TeaModel {
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

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("roleType")
        public String roleType;

        public static AddWorkspaceMembersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            AddWorkspaceMembersRequestMembers self = new AddWorkspaceMembersRequestMembers();
            return TeaModel.build(map, self);
        }

        public AddWorkspaceMembersRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public AddWorkspaceMembersRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public AddWorkspaceMembersRequestMembers setRoleType(String roleType) {
            this.roleType = roleType;
            return this;
        }
        public String getRoleType() {
            return this.roleType;
        }

    }

}
