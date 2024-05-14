// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AttendanceBleDevicesRemoveRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deviceIdList")
    public java.util.List<Long> deviceIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupKey")
    public String groupKey;

    @NameInMap("opUserId")
    public String opUserId;

    public static AttendanceBleDevicesRemoveRequest build(java.util.Map<String, ?> map) throws Exception {
        AttendanceBleDevicesRemoveRequest self = new AttendanceBleDevicesRemoveRequest();
        return TeaModel.build(map, self);
    }

    public AttendanceBleDevicesRemoveRequest setDeviceIdList(java.util.List<Long> deviceIdList) {
        this.deviceIdList = deviceIdList;
        return this;
    }
    public java.util.List<Long> getDeviceIdList() {
        return this.deviceIdList;
    }

    public AttendanceBleDevicesRemoveRequest setGroupKey(String groupKey) {
        this.groupKey = groupKey;
        return this;
    }
    public String getGroupKey() {
        return this.groupKey;
    }

    public AttendanceBleDevicesRemoveRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
