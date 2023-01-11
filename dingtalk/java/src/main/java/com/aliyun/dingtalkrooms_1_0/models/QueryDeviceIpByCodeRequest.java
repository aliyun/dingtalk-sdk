// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceIpByCodeRequest extends TeaModel {
    /**
     * <p>设备sn号</p>
     */
    @NameInMap("deviceSn")
    public String deviceSn;

    public static QueryDeviceIpByCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceIpByCodeRequest self = new QueryDeviceIpByCodeRequest();
        return TeaModel.build(map, self);
    }

    public QueryDeviceIpByCodeRequest setDeviceSn(String deviceSn) {
        this.deviceSn = deviceSn;
        return this;
    }
    public String getDeviceSn() {
        return this.deviceSn;
    }

}
