// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RebuildRoleScopeForAppRoleRequest extends TeaModel {
    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("scopeType")
    public String scopeType;

    @NameInMap("scopeVersion")
    public Long scopeVersion;

    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static RebuildRoleScopeForAppRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        RebuildRoleScopeForAppRoleRequest self = new RebuildRoleScopeForAppRoleRequest();
        return TeaModel.build(map, self);
    }

    public RebuildRoleScopeForAppRoleRequest setDeptIdList(java.util.List<Long> deptIdList) {
        this.deptIdList = deptIdList;
        return this;
    }
    public java.util.List<Long> getDeptIdList() {
        return this.deptIdList;
    }

    public RebuildRoleScopeForAppRoleRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public RebuildRoleScopeForAppRoleRequest setScopeType(String scopeType) {
        this.scopeType = scopeType;
        return this;
    }
    public String getScopeType() {
        return this.scopeType;
    }

    public RebuildRoleScopeForAppRoleRequest setScopeVersion(Long scopeVersion) {
        this.scopeVersion = scopeVersion;
        return this;
    }
    public Long getScopeVersion() {
        return this.scopeVersion;
    }

    public RebuildRoleScopeForAppRoleRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
