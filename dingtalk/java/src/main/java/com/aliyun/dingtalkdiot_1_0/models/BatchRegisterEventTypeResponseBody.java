// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchRegisterEventTypeResponseBody extends TeaModel {
    @NameInMap("eventTypes")
    public java.util.List<String> eventTypes;

    public static BatchRegisterEventTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchRegisterEventTypeResponseBody self = new BatchRegisterEventTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchRegisterEventTypeResponseBody setEventTypes(java.util.List<String> eventTypes) {
        this.eventTypes = eventTypes;
        return this;
    }
    public java.util.List<String> getEventTypes() {
        return this.eventTypes;
    }

}
