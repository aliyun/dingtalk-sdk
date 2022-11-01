// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class RemoveMeetingRoomsRequest extends TeaModel {
    @NameInMap("meetingRoomsToRemove")
    public java.util.List<RemoveMeetingRoomsRequestMeetingRoomsToRemove> meetingRoomsToRemove;

    public static RemoveMeetingRoomsRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveMeetingRoomsRequest self = new RemoveMeetingRoomsRequest();
        return TeaModel.build(map, self);
    }

    public RemoveMeetingRoomsRequest setMeetingRoomsToRemove(java.util.List<RemoveMeetingRoomsRequestMeetingRoomsToRemove> meetingRoomsToRemove) {
        this.meetingRoomsToRemove = meetingRoomsToRemove;
        return this;
    }
    public java.util.List<RemoveMeetingRoomsRequestMeetingRoomsToRemove> getMeetingRoomsToRemove() {
        return this.meetingRoomsToRemove;
    }

    public static class RemoveMeetingRoomsRequestMeetingRoomsToRemove extends TeaModel {
        @NameInMap("roomId")
        public String roomId;

        public static RemoveMeetingRoomsRequestMeetingRoomsToRemove build(java.util.Map<String, ?> map) throws Exception {
            RemoveMeetingRoomsRequestMeetingRoomsToRemove self = new RemoveMeetingRoomsRequestMeetingRoomsToRemove();
            return TeaModel.build(map, self);
        }

        public RemoveMeetingRoomsRequestMeetingRoomsToRemove setRoomId(String roomId) {
            this.roomId = roomId;
            return this;
        }
        public String getRoomId() {
            return this.roomId;
        }

    }

}
