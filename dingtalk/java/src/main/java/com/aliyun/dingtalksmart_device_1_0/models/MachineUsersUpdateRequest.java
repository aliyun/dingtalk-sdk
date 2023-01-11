// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class MachineUsersUpdateRequest extends TeaModel {
    /**
     * <p>新增的部门id列表</p>
     */
    @NameInMap("addDeptIds")
    public java.util.List<Long> addDeptIds;

    /**
     * <p>新增的员工id列表</p>
     */
    @NameInMap("addUserIds")
    public java.util.List<String> addUserIds;

    /**
     * <p>移除的部门id列表</p>
     */
    @NameInMap("delDeptIds")
    public java.util.List<Long> delDeptIds;

    /**
     * <p>移除的员工id列表</p>
     */
    @NameInMap("delUserIds")
    public java.util.List<String> delUserIds;

    /**
     * <p>设备唯一标识id列表，Long数组</p>
     */
    @NameInMap("devIds")
    public java.util.List<Long> devIds;

    /**
     * <p>设备唯一标识id列表，字符串数组</p>
     */
    @NameInMap("deviceIds")
    public java.util.List<String> deviceIds;

    public static MachineUsersUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        MachineUsersUpdateRequest self = new MachineUsersUpdateRequest();
        return TeaModel.build(map, self);
    }

    public MachineUsersUpdateRequest setAddDeptIds(java.util.List<Long> addDeptIds) {
        this.addDeptIds = addDeptIds;
        return this;
    }
    public java.util.List<Long> getAddDeptIds() {
        return this.addDeptIds;
    }

    public MachineUsersUpdateRequest setAddUserIds(java.util.List<String> addUserIds) {
        this.addUserIds = addUserIds;
        return this;
    }
    public java.util.List<String> getAddUserIds() {
        return this.addUserIds;
    }

    public MachineUsersUpdateRequest setDelDeptIds(java.util.List<Long> delDeptIds) {
        this.delDeptIds = delDeptIds;
        return this;
    }
    public java.util.List<Long> getDelDeptIds() {
        return this.delDeptIds;
    }

    public MachineUsersUpdateRequest setDelUserIds(java.util.List<String> delUserIds) {
        this.delUserIds = delUserIds;
        return this;
    }
    public java.util.List<String> getDelUserIds() {
        return this.delUserIds;
    }

    public MachineUsersUpdateRequest setDevIds(java.util.List<Long> devIds) {
        this.devIds = devIds;
        return this;
    }
    public java.util.List<Long> getDevIds() {
        return this.devIds;
    }

    public MachineUsersUpdateRequest setDeviceIds(java.util.List<String> deviceIds) {
        this.deviceIds = deviceIds;
        return this;
    }
    public java.util.List<String> getDeviceIds() {
        return this.deviceIds;
    }

}
