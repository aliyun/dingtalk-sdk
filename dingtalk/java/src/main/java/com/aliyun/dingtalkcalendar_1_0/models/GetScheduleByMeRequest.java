// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetScheduleByMeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("endTime")
    public String endTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startTime")
    public String startTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetScheduleByMeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetScheduleByMeRequest self = new GetScheduleByMeRequest();
        return TeaModel.build(map, self);
    }

    public GetScheduleByMeRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public GetScheduleByMeRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

    public GetScheduleByMeRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
