// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryAllSubjectsFromClassScheduleRequest extends TeaModel {
    /**
     * <p>班级ID。</p>
     */
    @NameInMap("classIds")
    public java.util.List<Long> classIds;

    /**
     * <p>操作者的userid。</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>学段编码：KINDERGARTEN：小学 PRIMARY_SCHOOL：小学 MODDLE_SCHOOL： 初中 HIGH_SCHOOL： 高中 UNIVERSITY：大学 NOT_SCHOOL：无学段</p>
     */
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
