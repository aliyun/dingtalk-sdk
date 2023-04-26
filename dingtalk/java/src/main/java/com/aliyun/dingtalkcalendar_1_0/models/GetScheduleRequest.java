// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetScheduleRequest extends TeaModel {
    @NameInMap("endTime")
    public String endTime;

    @NameInMap("startTime")
    public String startTime;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetScheduleRequest build(java.util.Map<String, ?> map) throws Exception {
        GetScheduleRequest self = new GetScheduleRequest();
        return TeaModel.build(map, self);
    }

    public GetScheduleRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public GetScheduleRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

    public GetScheduleRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
