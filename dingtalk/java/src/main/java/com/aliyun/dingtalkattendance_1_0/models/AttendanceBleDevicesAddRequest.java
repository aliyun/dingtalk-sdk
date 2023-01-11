// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AttendanceBleDevicesAddRequest extends TeaModel {
    /**
     * <p>蓝牙设备Id列表</p>
     */
    @NameInMap("deviceIdList")
    public java.util.List<Long> deviceIdList;

    /**
     * <p>考勤组Id</p>
     */
    @NameInMap("groupKey")
    public String groupKey;

    /**
     * <p>操作人Id</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static AttendanceBleDevicesAddRequest build(java.util.Map<String, ?> map) throws Exception {
        AttendanceBleDevicesAddRequest self = new AttendanceBleDevicesAddRequest();
        return TeaModel.build(map, self);
    }

    public AttendanceBleDevicesAddRequest setDeviceIdList(java.util.List<Long> deviceIdList) {
        this.deviceIdList = deviceIdList;
        return this;
    }
    public java.util.List<Long> getDeviceIdList() {
        return this.deviceIdList;
    }

    public AttendanceBleDevicesAddRequest setGroupKey(String groupKey) {
        this.groupKey = groupKey;
        return this;
    }
    public String getGroupKey() {
        return this.groupKey;
    }

    public AttendanceBleDevicesAddRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
