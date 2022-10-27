// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateMeetingRoomResponseBody extends TeaModel {
    // 创建的会议室id
    @NameInMap("result")
    public Long result;

    public static CreateMeetingRoomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateMeetingRoomResponseBody self = new CreateMeetingRoomResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateMeetingRoomResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

}
