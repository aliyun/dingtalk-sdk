// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddAppRolesToMemberRequest extends TeaModel {
    /**
     * <p>人员id</p>
     */
    @NameInMap("memberId")
    public String memberId;

    /**
     * <p>人员类型，“DEPT”表示部门，“USER”表示员工</p>
     */
    @NameInMap("memberType")
    public String memberType;

    /**
     * <p>执行用户userId</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>角色Id列表</p>
     */
    @NameInMap("roleList")
    public java.util.List<AddAppRolesToMemberRequestRoleList> roleList;

    public static AddAppRolesToMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        AddAppRolesToMemberRequest self = new AddAppRolesToMemberRequest();
        return TeaModel.build(map, self);
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

    public AddAppRolesToMemberRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public AddAppRolesToMemberRequest setRoleList(java.util.List<AddAppRolesToMemberRequestRoleList> roleList) {
        this.roleList = roleList;
        return this;
    }
    public java.util.List<AddAppRolesToMemberRequestRoleList> getRoleList() {
        return this.roleList;
    }

    public static class AddAppRolesToMemberRequestRoleList extends TeaModel {
        /**
         * <p>角色ID</p>
         */
        @NameInMap("roleId")
        public Long roleId;

        /**
         * <p>角色范围版本号</p>
         */
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
