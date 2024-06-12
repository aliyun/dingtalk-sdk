// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class MeetingRoomRespondResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static MeetingRoomRespondResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MeetingRoomRespondResponseBody self = new MeetingRoomRespondResponseBody();
        return TeaModel.build(map, self);
    }

    public MeetingRoomRespondResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
