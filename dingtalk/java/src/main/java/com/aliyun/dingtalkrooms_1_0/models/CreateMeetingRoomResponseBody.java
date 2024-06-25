// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateMeetingRoomResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed</p>
     */
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
