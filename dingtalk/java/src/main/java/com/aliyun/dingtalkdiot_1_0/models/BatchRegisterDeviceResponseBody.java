// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchRegisterDeviceResponseBody extends TeaModel {
    /**
     * <p>注册成功的设备ID列表。</p>
     */
    @NameInMap("deviceIds")
    public java.util.List<String> deviceIds;

    public static BatchRegisterDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchRegisterDeviceResponseBody self = new BatchRegisterDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchRegisterDeviceResponseBody setDeviceIds(java.util.List<String> deviceIds) {
        this.deviceIds = deviceIds;
        return this;
    }
    public java.util.List<String> getDeviceIds() {
        return this.deviceIds;
    }

}
