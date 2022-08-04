// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ConnectorEventPushRequest extends TeaModel {
    // 设备类型唯一标识
    @NameInMap("deviceTypeUuid")
    public String deviceTypeUuid;

    // 事件名称
    @NameInMap("eventName")
    public String eventName;

    // 事件入参，json字符串
    @NameInMap("input")
    public String input;

    public static ConnectorEventPushRequest build(java.util.Map<String, ?> map) throws Exception {
        ConnectorEventPushRequest self = new ConnectorEventPushRequest();
        return TeaModel.build(map, self);
    }

    public ConnectorEventPushRequest setDeviceTypeUuid(String deviceTypeUuid) {
        this.deviceTypeUuid = deviceTypeUuid;
        return this;
    }
    public String getDeviceTypeUuid() {
        return this.deviceTypeUuid;
    }

    public ConnectorEventPushRequest setEventName(String eventName) {
        this.eventName = eventName;
        return this;
    }
    public String getEventName() {
        return this.eventName;
    }

    public ConnectorEventPushRequest setInput(String input) {
        this.input = input;
        return this;
    }
    public String getInput() {
        return this.input;
    }

}
