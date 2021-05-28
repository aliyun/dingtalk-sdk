// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddAppRolesToMemberRequest extends TeaModel {
    // 执行用户userId
    @NameInMap("opUserId")
    public String opUserId;

    // 人员id
    @NameInMap("memberId")
    public String memberId;

    // 人员类型，“DEPT”表示部门，“USER”表示员工
    @NameInMap("memberType")
    public String memberType;

    // 角色Id列表
    @NameInMap("roleList")
    public java.util.List<AddAppRolesToMemberRequestRoleList> roleList;

    public static AddAppRolesToMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        AddAppRolesToMemberRequest self = new AddAppRolesToMemberRequest();
        return TeaModel.build(map, self);
    }

    public AddAppRolesToMemberRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public AddAppRolesToMemberRequest setMemberId(String memberId) {
        this.memberId = memberId;
        return this;
    }
    public String getMemberId() {
        return this.memberId;
    }

    public AddAppRolesToMemberRequest setMemberType(String memberType) {
        this.memberType = memberType;
        return this;
    }
    public String getMemberType() {
        return this.memberType;
    }

    public AddAppRolesToMemberRequest setRoleList(java.util.List<AddAppRolesToMemberRequestRoleList> roleList) {
        this.roleList = roleList;
        return this;
    }
    public java.util.List<AddAppRolesToMemberRequestRoleList> getRoleList() {
        return this.roleList;
    }

    public static class AddAppRolesToMemberRequestRoleList extends TeaModel {
        // 角色ID
        @NameInMap("roleId")
        public Long roleId;

        // 角色范围版本号
        @NameInMap("scopeVersion")
        public Long scopeVersion;

        public static AddAppRolesToMemberRequestRoleList build(java.util.Map<String, ?> map) throws Exception {
            AddAppRolesToMemberRequestRoleList self = new AddAppRolesToMemberRequestRoleList();
            return TeaModel.build(map, self);
        }

        public AddAppRolesToMemberRequestRoleList setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

        public AddAppRolesToMemberRequestRoleList setScopeVersion(Long scopeVersion) {
            this.scopeVersion = scopeVersion;
            return this;
        }
        public Long getScopeVersion() {
            return this.scopeVersion;
        }

    }

}
