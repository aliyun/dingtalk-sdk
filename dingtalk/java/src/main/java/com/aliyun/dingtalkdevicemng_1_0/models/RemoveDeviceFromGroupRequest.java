// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RemoveDeviceFromGroupRequest extends TeaModel {
    @NameInMap("deviceCodes")
    public java.util.List<String> deviceCodes;

    @NameInMap("deviceUuids")
    public java.util.List<String> deviceUuids;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("operator")
    public String operator;

    public static RemoveDeviceFromGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveDeviceFromGroupRequest self = new RemoveDeviceFromGroupRequest();
        return TeaModel.build(map, self);
    }

    public RemoveDeviceFromGroupRequest setDeviceCodes(java.util.List<String> deviceCodes) {
        this.deviceCodes = deviceCodes;
        return this;
    }
    public java.util.List<String> getDeviceCodes() {
        return this.deviceCodes;
    }

    public RemoveDeviceFromGroupRequest setDeviceUuids(java.util.List<String> deviceUuids) {
        this.deviceUuids = deviceUuids;
        return this;
    }
    public java.util.List<String> getDeviceUuids() {
        return this.deviceUuids;
    }

    public RemoveDeviceFromGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public RemoveDeviceFromGroupRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
