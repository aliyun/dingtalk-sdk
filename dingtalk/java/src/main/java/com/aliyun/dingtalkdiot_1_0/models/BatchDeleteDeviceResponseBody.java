// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchDeleteDeviceResponseBody extends TeaModel {
    @NameInMap("deviceIds")
    public java.util.List<String> deviceIds;

    public static BatchDeleteDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteDeviceResponseBody self = new BatchDeleteDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchDeleteDeviceResponseBody setDeviceIds(java.util.List<String> deviceIds) {
        this.deviceIds = deviceIds;
        return this;
    }
    public java.util.List<String> getDeviceIds() {
        return this.deviceIds;
    }

}
