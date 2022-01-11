// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class MachineUsersUpdateRequest extends TeaModel {
    // 新增的员工id列表
    @NameInMap("addUserIds")
    public java.util.List<String> addUserIds;

    // 移除的员工id列表
    @NameInMap("delUserIds")
    public java.util.List<String> delUserIds;

    // 设备唯一标识id列表，Long数组
    @NameInMap("devIds")
    public java.util.List<Long> devIds;

    // 设备唯一标识id列表，字符串数组
    @NameInMap("deviceIds")
    public java.util.List<String> deviceIds;

    public static MachineUsersUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        MachineUsersUpdateRequest self = new MachineUsersUpdateRequest();
        return TeaModel.build(map, self);
    }

    public MachineUsersUpdateRequest setAddUserIds(java.util.List<String> addUserIds) {
        this.addUserIds = addUserIds;
        return this;
    }
    public java.util.List<String> getAddUserIds() {
        return this.addUserIds;
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
