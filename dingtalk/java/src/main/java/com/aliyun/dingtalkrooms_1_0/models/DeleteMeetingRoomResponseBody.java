// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteMeetingRoomResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static DeleteMeetingRoomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteMeetingRoomResponseBody self = new DeleteMeetingRoomResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteMeetingRoomResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
