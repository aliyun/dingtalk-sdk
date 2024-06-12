// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class MeetingRoomRespondRequest extends TeaModel {
    @NameInMap("responseStatus")
    public String responseStatus;

    public static MeetingRoomRespondRequest build(java.util.Map<String, ?> map) throws Exception {
        MeetingRoomRespondRequest self = new MeetingRoomRespondRequest();
        return TeaModel.build(map, self);
    }

    public MeetingRoomRespondRequest setResponseStatus(String responseStatus) {
        this.responseStatus = responseStatus;
        return this;
    }
    public String getResponseStatus() {
        return this.responseStatus;
    }

}
