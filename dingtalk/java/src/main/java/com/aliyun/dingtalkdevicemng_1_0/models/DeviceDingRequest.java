// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class DeviceDingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("deviceKey")
    public String deviceKey;

    /**
     * <strong>example:</strong>
     * <p>json字符串</p>
     */
    @NameInMap("paramsJson")
    public String paramsJson;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    public static DeviceDingRequest build(java.util.Map<String, ?> map) throws Exception {
        DeviceDingRequest self = new DeviceDingRequest();
        return TeaModel.build(map, self);
    }

    public DeviceDingRequest setDeviceKey(String deviceKey) {
        this.deviceKey = deviceKey;
        return this;
    }
    public String getDeviceKey() {
        return this.deviceKey;
    }

    public DeviceDingRequest setParamsJson(String paramsJson) {
        this.paramsJson = paramsJson;
        return this;
    }
    public String getParamsJson() {
        return this.paramsJson;
    }

    public DeviceDingRequest setReceiverUserIdList(java.util.List<String> receiverUserIdList) {
        this.receiverUserIdList = receiverUserIdList;
        return this;
    }
    public java.util.List<String> getReceiverUserIdList() {
        return this.receiverUserIdList;
    }

}
