// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetAppRoleScopeByRoleIdResponseBody extends TeaModel {
    // 角色名称
    @NameInMap("roleName")
    public String roleName;

    // 角色id
    @NameInMap("roleId")
    public Long roleId;

    // 角色范围类型，“ALL_VISIBLE”表示全员，“PART_VISIBLE”表示部分
    @NameInMap("scopeType")
    public String scopeType;

    // 部门id列表
    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    // 员工userId列表
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    // 角色范围版本号
    @NameInMap("scopeVersion")
    public String scopeVersion;

    // 是否拥有角色管理权限，默认false
    @NameInMap("canManageRole")
    public Boolean canManageRole;

    public static GetAppRoleScopeByRoleIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAppRoleScopeByRoleIdResponseBody self = new GetAppRoleScopeByRoleIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAppRoleScopeByRoleIdResponseBody setRoleName(String roleName) {
        this.roleName = roleName;
        return this;
    }
    public String getRoleName() {
        return this.roleName;
    }

    public GetAppRoleScopeByRoleIdResponseBody setRoleId(Long roleId) {
        this.roleId = roleId;
        return this;
    }
    public Long getRoleId() {
        return this.roleId;
    }

    public GetAppRoleScopeByRoleIdResponseBody setScopeType(String scopeType) {
        this.scopeType = scopeType;
        return this;
    }
    public String getScopeType() {
        return this.scopeType;
    }

    public GetAppRoleScopeByRoleIdResponseBody setDeptIdList(java.util.List<Long> deptIdList) {
        this.deptIdList = deptIdList;
        return this;
    }
    public java.util.List<Long> getDeptIdList() {
        return this.deptIdList;
    }

    public GetAppRoleScopeByRoleIdResponseBody setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

    public GetAppRoleScopeByRoleIdResponseBody setScopeVersion(String scopeVersion) {
        this.scopeVersion = scopeVersion;
        return this;
    }
    public String getScopeVersion() {
        return this.scopeVersion;
    }

    public GetAppRoleScopeByRoleIdResponseBody setCanManageRole(Boolean canManageRole) {
        this.canManageRole = canManageRole;
        return this;
    }
    public Boolean getCanManageRole() {
        return this.canManageRole;
    }

}
