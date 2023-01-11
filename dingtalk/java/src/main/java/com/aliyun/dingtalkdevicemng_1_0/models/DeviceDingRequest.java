// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class DeviceDingRequest extends TeaModel {
    /**
     * <p>设备标识</p>
     */
    @NameInMap("deviceKey")
    public String deviceKey;

    /**
     * <p>消息体动态参数</p>
     */
    @NameInMap("paramsJson")
    public String paramsJson;

    /**
     * <p>staffId列表</p>
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
