// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddMemberToAppRoleRequest extends TeaModel {
    // 部门id列表
    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    // 执行用户userId
    @NameInMap("opUserId")
    public String opUserId;

    // 角色范围版本号
    @NameInMap("scopeVersion")
    public Long scopeVersion;

    // 员工userId列表
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static AddMemberToAppRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        AddMemberToAppRoleRequest self = new AddMemberToAppRoleRequest();
        return TeaModel.build(map, self);
    }

    public AddMemberToAppRoleRequest setDeptIdList(java.util.List<Long> deptIdList) {
        this.deptIdList = deptIdList;
        return this;
    }
    public java.util.List<Long> getDeptIdList() {
        return this.deptIdList;
    }

    public AddMemberToAppRoleRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public AddMemberToAppRoleRequest setScopeVersion(Long scopeVersion) {
        this.scopeVersion = scopeVersion;
        return this;
    }
    public Long getScopeVersion() {
        return this.scopeVersion;
    }

    public AddMemberToAppRoleRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
