// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleByTimeSchoolRequest extends TeaModel {
    // 1621676000000
    @NameInMap("endTime")
    public Long endTime;

    // 1621566000000
    @NameInMap("opUserId")
    public String opUserId;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    public static QueryClassScheduleByTimeSchoolRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryClassScheduleByTimeSchoolRequest self = new QueryClassScheduleByTimeSchoolRequest();
        return TeaModel.build(map, self);
    }

    public QueryClassScheduleByTimeSchoolRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryClassScheduleByTimeSchoolRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public QueryClassScheduleByTimeSchoolRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
