// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateMeetingRoomResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static CreateMeetingRoomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateMeetingRoomResponseBody self = new CreateMeetingRoomResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateMeetingRoomResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
