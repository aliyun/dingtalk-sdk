// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceIpByCodeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1005F1K203604N000676</p>
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
