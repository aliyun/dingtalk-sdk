// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RemoveDeviceFromGroupRequest extends TeaModel {
    /**
     * <p>设备编号列表（与设备唯一标识列表二选一）</p>
     */
    @NameInMap("deviceCodes")
    public java.util.List<String> deviceCodes;

    /**
     * <p>设备唯一标识列表（与设备编码列表二选一）</p>
     */
    @NameInMap("deviceUuids")
    public java.util.List<String> deviceUuids;

    /**
     * <p>开放群唯一标识</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>操作人唯一标识</p>
     */
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
