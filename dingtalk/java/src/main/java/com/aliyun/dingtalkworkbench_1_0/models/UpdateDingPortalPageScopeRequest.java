// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class UpdateDingPortalPageScopeRequest extends TeaModel {
    /**
     * <p>是否全员可见</p>
     */
    @NameInMap("allVisible")
    public Boolean allVisible;

    /**
     * <p>可见部门列表</p>
     */
    @NameInMap("deptIds")
    public java.util.List<Long> deptIds;

    /**
     * <p>可见角色列表</p>
     */
    @NameInMap("roleIds")
    public java.util.List<Long> roleIds;

    /**
     * <p>可见用户列表</p>
     */
    @NameInMap("userids")
    public java.util.List<String> userids;

    public static UpdateDingPortalPageScopeRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateDingPortalPageScopeRequest self = new UpdateDingPortalPageScopeRequest();
        return TeaModel.build(map, self);
    }

    public UpdateDingPortalPageScopeRequest setAllVisible(Boolean allVisible) {
        this.allVisible = allVisible;
        return this;
    }
    public Boolean getAllVisible() {
        return this.allVisible;
    }

    public UpdateDingPortalPageScopeRequest setDeptIds(java.util.List<Long> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<Long> getDeptIds() {
        return this.deptIds;
    }

    public UpdateDingPortalPageScopeRequest setRoleIds(java.util.List<Long> roleIds) {
        this.roleIds = roleIds;
        return this;
    }
    public java.util.List<Long> getRoleIds() {
        return this.roleIds;
    }

    public UpdateDingPortalPageScopeRequest setUserids(java.util.List<String> userids) {
        this.userids = userids;
        return this;
    }
    public java.util.List<String> getUserids() {
        return this.userids;
    }

}
