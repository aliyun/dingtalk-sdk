// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateDeviceResponseBody extends TeaModel {
    /**
     * <p>修改成功的设备ID列表。</p>
     */
    @NameInMap("deviceIds")
    public java.util.List<String> deviceIds;

    public static BatchUpdateDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateDeviceResponseBody self = new BatchUpdateDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchUpdateDeviceResponseBody setDeviceIds(java.util.List<String> deviceIds) {
        this.deviceIds = deviceIds;
        return this;
    }
    public java.util.List<String> getDeviceIds() {
        return this.deviceIds;
    }

}
