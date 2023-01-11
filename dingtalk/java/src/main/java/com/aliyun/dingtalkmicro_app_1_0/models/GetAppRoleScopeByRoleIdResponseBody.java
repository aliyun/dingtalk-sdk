// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetAppRoleScopeByRoleIdResponseBody extends TeaModel {
    /**
     * <p>是否拥有角色管理权限，默认false</p>
     */
    @NameInMap("canManageRole")
    public Boolean canManageRole;

    /**
     * <p>部门id列表</p>
     */
    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    /**
     * <p>角色id</p>
     */
    @NameInMap("roleId")
    public Long roleId;

    /**
     * <p>角色名称</p>
     */
    @NameInMap("roleName")
    public String roleName;

    /**
     * <p>角色范围类型，“ALL_VISIBLE”表示全员，“PART_VISIBLE”表示部分</p>
     */
    @NameInMap("scopeType")
    public String scopeType;

    /**
     * <p>角色范围版本号</p>
     */
    @NameInMap("scopeVersion")
    public String scopeVersion;

    /**
     * <p>员工userId列表</p>
     */
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static GetAppRoleScopeByRoleIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAppRoleScopeByRoleIdResponseBody self = new GetAppRoleScopeByRoleIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAppRoleScopeByRoleIdResponseBody setCanManageRole(Boolean canManageRole) {
        this.canManageRole = canManageRole;
        return this;
    }
    public Boolean getCanManageRole() {
        return this.canManageRole;
    }

    public GetAppRoleScopeByRoleIdResponseBody setDeptIdList(java.util.List<Long> deptIdList) {
        this.deptIdList = deptIdList;
        return this;
    }
    public java.util.List<Long> getDeptIdList() {
        return this.deptIdList;
    }

    public GetAppRoleScopeByRoleIdResponseBody setRoleId(Long roleId) {
        this.roleId = roleId;
        return this;
    }
    public Long getRoleId() {
        return this.roleId;
    }

    public GetAppRoleScopeByRoleIdResponseBody setRoleName(String roleName) {
        this.roleName = roleName;
        return this;
    }
    public String getRoleName() {
        return this.roleName;
    }

    public GetAppRoleScopeByRoleIdResponseBody setScopeType(String scopeType) {
        this.scopeType = scopeType;
        return this;
    }
    public String getScopeType() {
        return this.scopeType;
    }

    public GetAppRoleScopeByRoleIdResponseBody setScopeVersion(String scopeVersion) {
        this.scopeVersion = scopeVersion;
        return this;
    }
    public String getScopeVersion() {
        return this.scopeVersion;
    }

    public GetAppRoleScopeByRoleIdResponseBody setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
