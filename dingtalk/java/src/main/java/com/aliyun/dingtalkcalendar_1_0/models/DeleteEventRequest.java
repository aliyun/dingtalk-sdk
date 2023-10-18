// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class DeleteEventRequest extends TeaModel {
    @NameInMap("pushNotification")
    public Boolean pushNotification;

    public static DeleteEventRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteEventRequest self = new DeleteEventRequest();
        return TeaModel.build(map, self);
    }

    public DeleteEventRequest setPushNotification(Boolean pushNotification) {
        this.pushNotification = pushNotification;
        return this;
    }
    public Boolean getPushNotification() {
        return this.pushNotification;
    }

}
