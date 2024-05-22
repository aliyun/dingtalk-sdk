// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteMeetingRoomControlPanelRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("roomIds")
    public java.util.List<String> roomIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static DeleteMeetingRoomControlPanelRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteMeetingRoomControlPanelRequest self = new DeleteMeetingRoomControlPanelRequest();
        return TeaModel.build(map, self);
    }

    public DeleteMeetingRoomControlPanelRequest setRoomIds(java.util.List<String> roomIds) {
        this.roomIds = roomIds;
        return this;
    }
    public java.util.List<String> getRoomIds() {
        return this.roomIds;
    }

    public DeleteMeetingRoomControlPanelRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
