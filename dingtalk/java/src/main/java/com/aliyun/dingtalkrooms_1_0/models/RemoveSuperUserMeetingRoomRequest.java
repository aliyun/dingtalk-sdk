// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class RemoveSuperUserMeetingRoomRequest extends TeaModel {
    @NameInMap("roomId")
    public String roomId;

    @NameInMap("unionId")
    public String unionId;

    public static RemoveSuperUserMeetingRoomRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveSuperUserMeetingRoomRequest self = new RemoveSuperUserMeetingRoomRequest();
        return TeaModel.build(map, self);
    }

    public RemoveSuperUserMeetingRoomRequest setRoomId(String roomId) {
        this.roomId = roomId;
        return this;
    }
    public String getRoomId() {
        return this.roomId;
    }

    public RemoveSuperUserMeetingRoomRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
