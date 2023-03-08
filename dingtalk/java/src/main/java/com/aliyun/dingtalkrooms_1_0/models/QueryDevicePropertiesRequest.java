// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDevicePropertiesRequest extends TeaModel {
    /**
     * <p>设备属性名称列表</p>
     */
    @NameInMap("propertyNames")
    public java.util.List<String> propertyNames;

    /**
     * <p>查询设备id</p>
     */
    @NameInMap("deviceId")
    public String deviceId;

    /**
     * <p>查询设备unionId</p>
     */
    @NameInMap("deviceUnionId")
    public String deviceUnionId;

    /**
     * <p>查询人unionId</p>
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
