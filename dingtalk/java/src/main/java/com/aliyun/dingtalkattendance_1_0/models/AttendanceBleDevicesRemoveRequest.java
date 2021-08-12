// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AttendanceBleDevicesRemoveRequest extends TeaModel {
    // 操作人id
    @NameInMap("opUserId")
    public String opUserId;

    // 考勤组Id
    @NameInMap("groupKey")
    public String groupKey;

    // 蓝牙设备Id列表
    @NameInMap("deviceIdList")
    public java.util.List<Long> deviceIdList;

    public static AttendanceBleDevicesRemoveRequest build(java.util.Map<String, ?> map) throws Exception {
        AttendanceBleDevicesRemoveRequest self = new AttendanceBleDevicesRemoveRequest();
        return TeaModel.build(map, self);
    }

    public AttendanceBleDevicesRemoveRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public AttendanceBleDevicesRemoveRequest setGroupKey(String groupKey) {
        this.groupKey = groupKey;
        return this;
    }
    public String getGroupKey() {
        return this.groupKey;
    }

    public AttendanceBleDevicesRemoveRequest setDeviceIdList(java.util.List<Long> deviceIdList) {
        this.deviceIdList = deviceIdList;
        return this;
    }
    public java.util.List<Long> getDeviceIdList() {
        return this.deviceIdList;
    }

}
