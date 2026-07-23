// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class GetDeviceDetailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deviceName")
    public String deviceName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("productKey")
    public String productKey;

    public static GetDeviceDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDeviceDetailRequest self = new GetDeviceDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetDeviceDetailRequest setDeviceName(String deviceName) {
        this.deviceName = deviceName;
        return this;
    }
    public String getDeviceName() {
        return this.deviceName;
    }

    public GetDeviceDetailRequest setProductKey(String productKey) {
        this.productKey = productKey;
        return this;
    }
    public String getProductKey() {
        return this.productKey;
    }

}
