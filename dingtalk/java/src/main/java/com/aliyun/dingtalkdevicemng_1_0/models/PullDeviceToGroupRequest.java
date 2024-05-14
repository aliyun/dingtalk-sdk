// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class PullDeviceToGroupRequest extends TeaModel {
    @NameInMap("deviceCodes")
    public java.util.List<String> deviceCodes;

    @NameInMap("deviceUuids")
    public java.util.List<String> deviceUuids;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("operator")
    public String operator;

    public static PullDeviceToGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        PullDeviceToGroupRequest self = new PullDeviceToGroupRequest();
        return TeaModel.build(map, self);
    }

    public PullDeviceToGroupRequest setDeviceCodes(java.util.List<String> deviceCodes) {
        this.deviceCodes = deviceCodes;
        return this;
    }
    public java.util.List<String> getDeviceCodes() {
        return this.deviceCodes;
    }

    public PullDeviceToGroupRequest setDeviceUuids(java.util.List<String> deviceUuids) {
        this.deviceUuids = deviceUuids;
        return this;
    }
    public java.util.List<String> getDeviceUuids() {
        return this.deviceUuids;
    }

    public PullDeviceToGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public PullDeviceToGroupRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
