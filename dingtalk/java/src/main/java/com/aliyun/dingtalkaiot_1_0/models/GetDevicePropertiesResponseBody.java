// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class GetDevicePropertiesResponseBody extends TeaModel {
    @NameInMap("deviceName")
    public String deviceName;

    @NameInMap("productKey")
    public String productKey;

    @NameInMap("properties")
    public java.util.Map<String, PropertiesValue> properties;

    @NameInMap("snapshotAt")
    public String snapshotAt;

    public static GetDevicePropertiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDevicePropertiesResponseBody self = new GetDevicePropertiesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDevicePropertiesResponseBody setDeviceName(String deviceName) {
        this.deviceName = deviceName;
        return this;
    }
    public String getDeviceName() {
        return this.deviceName;
    }

    public GetDevicePropertiesResponseBody setProductKey(String productKey) {
        this.productKey = productKey;
        return this;
    }
    public String getProductKey() {
        return this.productKey;
    }

    public GetDevicePropertiesResponseBody setProperties(java.util.Map<String, PropertiesValue> properties) {
        this.properties = properties;
        return this;
    }
    public java.util.Map<String, PropertiesValue> getProperties() {
        return this.properties;
    }

    public GetDevicePropertiesResponseBody setSnapshotAt(String snapshotAt) {
        this.snapshotAt = snapshotAt;
        return this;
    }
    public String getSnapshotAt() {
        return this.snapshotAt;
    }

}
