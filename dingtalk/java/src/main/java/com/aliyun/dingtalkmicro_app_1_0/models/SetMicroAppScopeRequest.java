// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class SetMicroAppScopeRequest extends TeaModel {
    /**
     * <p>增加的可见部门</p>
     */
    @NameInMap("addDeptIds")
    public java.util.List<Long> addDeptIds;

    /**
     * <p>增加的可见角色</p>
     */
    @NameInMap("addRoleIds")
    public java.util.List<Long> addRoleIds;

    /**
     * <p>增加的可见用户</p>
     */
    @NameInMap("addUserIds")
    public java.util.List<String> addUserIds;

    /**
     * <p>删除的可见部门</p>
     */
    @NameInMap("delDeptIds")
    public java.util.List<Long> delDeptIds;

    /**
     * <p>删除的可见角色</p>
     */
    @NameInMap("delRoleIds")
    public java.util.List<Long> delRoleIds;

    /**
     * <p>删除的可见用户</p>
     */
    @NameInMap("delUserIds")
    public java.util.List<String> delUserIds;

    /**
     * <p>是否管理员可见</p>
     */
    @NameInMap("onlyAdminVisible")
    public Boolean onlyAdminVisible;

    public static SetMicroAppScopeRequest build(java.util.Map<String, ?> map) throws Exception {
        SetMicroAppScopeRequest self = new SetMicroAppScopeRequest();
        return TeaModel.build(map, self);
    }

    public SetMicroAppScopeRequest setAddDeptIds(java.util.List<Long> addDeptIds) {
        this.addDeptIds = addDeptIds;
        return this;
    }
    public java.util.List<Long> getAddDeptIds() {
        return this.addDeptIds;
    }

    public SetMicroAppScopeRequest setAddRoleIds(java.util.List<Long> addRoleIds) {
        this.addRoleIds = addRoleIds;
        return this;
    }
    public java.util.List<Long> getAddRoleIds() {
        return this.addRoleIds;
    }

    public SetMicroAppScopeRequest setAddUserIds(java.util.List<String> addUserIds) {
        this.addUserIds = addUserIds;
        return this;
    }
    public java.util.List<String> getAddUserIds() {
        return this.addUserIds;
    }

    public SetMicroAppScopeRequest setDelDeptIds(java.util.List<Long> delDeptIds) {
        this.delDeptIds = delDeptIds;
        return this;
    }
    public java.util.List<Long> getDelDeptIds() {
        return this.delDeptIds;
    }

    public SetMicroAppScopeRequest setDelRoleIds(java.util.List<Long> delRoleIds) {
        this.delRoleIds = delRoleIds;
        return this;
    }
    public java.util.List<Long> getDelRoleIds() {
        return this.delRoleIds;
    }

    public SetMicroAppScopeRequest setDelUserIds(java.util.List<String> delUserIds) {
        this.delUserIds = delUserIds;
        return this;
    }
    public java.util.List<String> getDelUserIds() {
        return this.delUserIds;
    }

    public SetMicroAppScopeRequest setOnlyAdminVisible(Boolean onlyAdminVisible) {
        this.onlyAdminVisible = onlyAdminVisible;
        return this;
    }
    public Boolean getOnlyAdminVisible() {
        return this.onlyAdminVisible;
    }

}
