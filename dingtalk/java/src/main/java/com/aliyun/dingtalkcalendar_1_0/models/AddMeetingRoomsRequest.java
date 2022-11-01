// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class AddMeetingRoomsRequest extends TeaModel {
    @NameInMap("meetingRoomsToAdd")
    public java.util.List<AddMeetingRoomsRequestMeetingRoomsToAdd> meetingRoomsToAdd;

    public static AddMeetingRoomsRequest build(java.util.Map<String, ?> map) throws Exception {
        AddMeetingRoomsRequest self = new AddMeetingRoomsRequest();
        return TeaModel.build(map, self);
    }

    public AddMeetingRoomsRequest setMeetingRoomsToAdd(java.util.List<AddMeetingRoomsRequestMeetingRoomsToAdd> meetingRoomsToAdd) {
        this.meetingRoomsToAdd = meetingRoomsToAdd;
        return this;
    }
    public java.util.List<AddMeetingRoomsRequestMeetingRoomsToAdd> getMeetingRoomsToAdd() {
        return this.meetingRoomsToAdd;
    }

    public static class AddMeetingRoomsRequestMeetingRoomsToAdd extends TeaModel {
        @NameInMap("roomId")
        public String roomId;

        public static AddMeetingRoomsRequestMeetingRoomsToAdd build(java.util.Map<String, ?> map) throws Exception {
            AddMeetingRoomsRequestMeetingRoomsToAdd self = new AddMeetingRoomsRequestMeetingRoomsToAdd();
            return TeaModel.build(map, self);
        }

        public AddMeetingRoomsRequestMeetingRoomsToAdd setRoomId(String roomId) {
            this.roomId = roomId;
            return this;
        }
        public String getRoomId() {
            return this.roomId;
        }

    }

}
