// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class PushEventResponseBody extends TeaModel {
    // 事件ID。
    @NameInMap("eventId")
    public String eventId;

    public static PushEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushEventResponseBody self = new PushEventResponseBody();
        return TeaModel.build(map, self);
    }

    public PushEventResponseBody setEventId(String eventId) {
        this.eventId = eventId;
        return this;
    }
    public String getEventId() {
        return this.eventId;
    }

}
