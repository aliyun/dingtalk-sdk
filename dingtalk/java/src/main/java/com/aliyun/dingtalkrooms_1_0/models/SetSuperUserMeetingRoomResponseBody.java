// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class SetSuperUserMeetingRoomResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SetSuperUserMeetingRoomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetSuperUserMeetingRoomResponseBody self = new SetSuperUserMeetingRoomResponseBody();
        return TeaModel.build(map, self);
    }

    public SetSuperUserMeetingRoomResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
