// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryAllSubjectsFromClassScheduleRequest extends TeaModel {
    @NameInMap("classIds")
    public java.util.List<Long> classIds;

    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("periodCode")
    public String periodCode;

    public static QueryAllSubjectsFromClassScheduleRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllSubjectsFromClassScheduleRequest self = new QueryAllSubjectsFromClassScheduleRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllSubjectsFromClassScheduleRequest setClassIds(java.util.List<Long> classIds) {
        this.classIds = classIds;
        return this;
    }
    public java.util.List<Long> getClassIds() {
        return this.classIds;
    }

    public QueryAllSubjectsFromClassScheduleRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public QueryAllSubjectsFromClassScheduleRequest setPeriodCode(String periodCode) {
        this.periodCode = periodCode;
        return this;
    }
    public String getPeriodCode() {
        return this.periodCode;
    }

}
