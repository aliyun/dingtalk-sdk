// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class AddMeetingRoomsResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static AddMeetingRoomsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddMeetingRoomsResponseBody self = new AddMeetingRoomsResponseBody();
        return TeaModel.build(map, self);
    }

    public AddMeetingRoomsResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
