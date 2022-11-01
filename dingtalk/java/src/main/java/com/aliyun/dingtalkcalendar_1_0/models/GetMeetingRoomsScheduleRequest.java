// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetMeetingRoomsScheduleRequest extends TeaModel {
    // 查询结束时间
    @NameInMap("endTime")
    public String endTime;

    // 待查询的用户列表
    @NameInMap("roomIds")
    public java.util.List<String> roomIds;

    // 查询开始时间
    @NameInMap("startTime")
    public String startTime;

    public static GetMeetingRoomsScheduleRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMeetingRoomsScheduleRequest self = new GetMeetingRoomsScheduleRequest();
        return TeaModel.build(map, self);
    }

    public GetMeetingRoomsScheduleRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public GetMeetingRoomsScheduleRequest setRoomIds(java.util.List<String> roomIds) {
        this.roomIds = roomIds;
        return this;
    }
    public java.util.List<String> getRoomIds() {
        return this.roomIds;
    }

    public GetMeetingRoomsScheduleRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

}
