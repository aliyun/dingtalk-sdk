// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class RemoveSuperUserMeetingRoomResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static RemoveSuperUserMeetingRoomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveSuperUserMeetingRoomResponseBody self = new RemoveSuperUserMeetingRoomResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveSuperUserMeetingRoomResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
