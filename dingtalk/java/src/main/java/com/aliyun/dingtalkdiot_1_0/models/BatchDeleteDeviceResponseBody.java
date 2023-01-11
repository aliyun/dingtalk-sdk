// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchDeleteDeviceResponseBody extends TeaModel {
    /**
     * <p>成功删除设备ID列表。</p>
     */
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
