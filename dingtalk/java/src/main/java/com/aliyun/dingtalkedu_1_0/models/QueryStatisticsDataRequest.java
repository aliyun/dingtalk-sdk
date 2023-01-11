// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryStatisticsDataRequest extends TeaModel {
    /**
     * <p>课程节次列表</p>
     */
    @NameInMap("sectionIndexList")
    public java.util.List<Long> sectionIndexList;

    /**
     * <p>老师UserIds</p>
     */
    @NameInMap("teacherUserIds")
    public java.util.List<String> teacherUserIds;

    /**
     * <p>endTime</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>opUserId</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>startTime</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    public static QueryStatisticsDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryStatisticsDataRequest self = new QueryStatisticsDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryStatisticsDataRequest setSectionIndexList(java.util.List<Long> sectionIndexList) {
        this.sectionIndexList = sectionIndexList;
        return this;
    }
    public java.util.List<Long> getSectionIndexList() {
        return this.sectionIndexList;
    }

    public QueryStatisticsDataRequest setTeacherUserIds(java.util.List<String> teacherUserIds) {
        this.teacherUserIds = teacherUserIds;
        return this;
    }
    public java.util.List<String> getTeacherUserIds() {
        return this.teacherUserIds;
    }

    public QueryStatisticsDataRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryStatisticsDataRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public QueryStatisticsDataRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
