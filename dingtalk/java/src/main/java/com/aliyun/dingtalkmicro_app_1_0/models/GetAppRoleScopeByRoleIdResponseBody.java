// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetAppRoleScopeByRoleIdResponseBody extends TeaModel {
    @NameInMap("canManageRole")
    public Boolean canManageRole;

    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    @NameInMap("roleId")
    public Long roleId;

    @NameInMap("roleName")
    public String roleName;

    @NameInMap("scopeType")
    public String scopeType;

    @NameInMap("scopeVersion")
    public String scopeVersion;

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
