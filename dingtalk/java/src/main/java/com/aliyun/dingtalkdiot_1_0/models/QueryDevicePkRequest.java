// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class QueryDevicePkRequest extends TeaModel {
    @NameInMap("deviceId")
    public Long deviceId;

    public static QueryDevicePkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDevicePkRequest self = new QueryDevicePkRequest();
        return TeaModel.build(map, self);
    }

    public QueryDevicePkRequest setDeviceId(Long deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public Long getDeviceId() {
        return this.deviceId;
    }

}
