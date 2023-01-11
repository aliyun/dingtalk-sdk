// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleByTimeSchoolRequest extends TeaModel {
    /**
     * <p>1621676000000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>1621566000000</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>开始时间</p>
     */
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
