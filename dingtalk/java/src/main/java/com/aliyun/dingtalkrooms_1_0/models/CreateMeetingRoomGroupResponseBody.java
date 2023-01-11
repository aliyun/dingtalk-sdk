// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateMeetingRoomGroupResponseBody extends TeaModel {
    /**
     * <p>创建的分组id</p>
     */
    @NameInMap("result")
    public Long result;

    public static CreateMeetingRoomGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateMeetingRoomGroupResponseBody self = new CreateMeetingRoomGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateMeetingRoomGroupResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

}
