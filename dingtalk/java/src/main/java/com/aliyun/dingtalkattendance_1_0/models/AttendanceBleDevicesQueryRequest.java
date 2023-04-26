// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AttendanceBleDevicesQueryRequest extends TeaModel {
    @NameInMap("groupKey")
    public String groupKey;

    @NameInMap("opUserId")
    public String opUserId;

    public static AttendanceBleDevicesQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        AttendanceBleDevicesQueryRequest self = new AttendanceBleDevicesQueryRequest();
        return TeaModel.build(map, self);
    }

    public AttendanceBleDevicesQueryRequest setGroupKey(String groupKey) {
        this.groupKey = groupKey;
        return this;
    }
    public String getGroupKey() {
        return this.groupKey;
    }

    public AttendanceBleDevicesQueryRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
