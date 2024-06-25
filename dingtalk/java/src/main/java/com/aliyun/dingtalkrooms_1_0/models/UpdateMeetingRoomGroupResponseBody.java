// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class UpdateMeetingRoomGroupResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateMeetingRoomGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateMeetingRoomGroupResponseBody self = new UpdateMeetingRoomGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateMeetingRoomGroupResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
