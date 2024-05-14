// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDevicePropertiesRequest extends TeaModel {
    @NameInMap("propertyNames")
    public java.util.List<String> propertyNames;

    @NameInMap("deviceId")
    public String deviceId;

    @NameInMap("deviceUnionId")
    public String deviceUnionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    public static QueryDevicePropertiesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDevicePropertiesRequest self = new QueryDevicePropertiesRequest();
        return TeaModel.build(map, self);
    }

    public QueryDevicePropertiesRequest setPropertyNames(java.util.List<String> propertyNames) {
        this.propertyNames = propertyNames;
        return this;
    }
    public java.util.List<String> getPropertyNames() {
        return this.propertyNames;
    }

    public QueryDevicePropertiesRequest setDeviceId(String deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public String getDeviceId() {
        return this.deviceId;
    }

    public QueryDevicePropertiesRequest setDeviceUnionId(String deviceUnionId) {
        this.deviceUnionId = deviceUnionId;
        return this;
    }
    public String getDeviceUnionId() {
        return this.deviceUnionId;
    }

    public QueryDevicePropertiesRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

}
