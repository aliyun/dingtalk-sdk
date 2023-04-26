// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class MachineUsersUpdateRequest extends TeaModel {
    @NameInMap("addDeptIds")
    public java.util.List<Long> addDeptIds;

    @NameInMap("addUserIds")
    public java.util.List<String> addUserIds;

    @NameInMap("delDeptIds")
    public java.util.List<Long> delDeptIds;

    @NameInMap("delUserIds")
    public java.util.List<String> delUserIds;

    @NameInMap("devIds")
    public java.util.List<Long> devIds;

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
