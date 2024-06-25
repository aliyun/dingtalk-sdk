// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class RemoveSuperUserMeetingRoomRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed</p>
     */
    @NameInMap("roomId")
    public String roomId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
     */
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
