// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class UpdateMeetingRoomResponseBody extends TeaModel {
    // 是否成功
    @NameInMap("result")
    public Boolean result;

    public static UpdateMeetingRoomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateMeetingRoomResponseBody self = new UpdateMeetingRoomResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateMeetingRoomResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
