// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class AddRoleMemberRequest extends TeaModel {
    @NameInMap("roleMemberList")
    public java.util.List<AddRoleMemberRequestRoleMemberList> roleMemberList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static AddRoleMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        AddRoleMemberRequest self = new AddRoleMemberRequest();
        return TeaModel.build(map, self);
    }

    public AddRoleMemberRequest setRoleMemberList(java.util.List<AddRoleMemberRequestRoleMemberList> roleMemberList) {
        this.roleMemberList = roleMemberList;
        return this;
    }
    public java.util.List<AddRoleMemberRequestRoleMemberList> getRoleMemberList() {
        return this.roleMemberList;
    }

    public AddRoleMemberRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class AddRoleMemberRequestRoleMemberList extends TeaModel {
        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberIdBelongOrgId")
        public Long memberIdBelongOrgId;

        @NameInMap("memberType")
        public String memberType;

        @NameInMap("roleId")
        public String roleId;

        public static AddRoleMemberRequestRoleMemberList build(java.util.Map<String, ?> map) throws Exception {
            AddRoleMemberRequestRoleMemberList self = new AddRoleMemberRequestRoleMemberList();
            return TeaModel.build(map, self);
        }

        public AddRoleMemberRequestRoleMemberList setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public AddRoleMemberRequestRoleMemberList setMemberIdBelongOrgId(Long memberIdBelongOrgId) {
            this.memberIdBelongOrgId = memberIdBelongOrgId;
            return this;
        }
        public Long getMemberIdBelongOrgId() {
            return this.memberIdBelongOrgId;
        }

        public AddRoleMemberRequestRoleMemberList setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public AddRoleMemberRequestRoleMemberList setRoleId(String roleId) {
            this.roleId = roleId;
            return this;
        }
        public String getRoleId() {
            return this.roleId;
        }

    }

}
