// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RemoveMemberForAppRoleRequest extends TeaModel {
    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("scopeVersion")
    public Long scopeVersion;

    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static RemoveMemberForAppRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveMemberForAppRoleRequest self = new RemoveMemberForAppRoleRequest();
        return TeaModel.build(map, self);
    }

    public RemoveMemberForAppRoleRequest setDeptIdList(java.util.List<Long> deptIdList) {
        this.deptIdList = deptIdList;
        return this;
    }
    public java.util.List<Long> getDeptIdList() {
        return this.deptIdList;
    }

    public RemoveMemberForAppRoleRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public RemoveMemberForAppRoleRequest setScopeVersion(Long scopeVersion) {
        this.scopeVersion = scopeVersion;
        return this;
    }
    public Long getScopeVersion() {
        return this.scopeVersion;
    }

    public RemoveMemberForAppRoleRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
