// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleRequest extends TeaModel {
    // 查询课程的节次。
    @NameInMap("sectionIndexList")
    public java.util.List<Long> sectionIndexList;

    // 订阅者的Id。
    @NameInMap("subscriberIds")
    public java.util.List<String> subscriberIds;

    // 结束时间（unix时间戳）
    @NameInMap("endTime")
    public Long endTime;

    // 操作者UserId
    @NameInMap("opUserId")
    public String opUserId;

    // 开始时间（unix时间戳）
    @NameInMap("startTime")
    public Long startTime;

    // 订阅者类型：  DEPARTMENT：班级订阅 USER：老师订阅
    @NameInMap("subscriberType")
    public String subscriberType;

    public static QueryClassScheduleRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryClassScheduleRequest self = new QueryClassScheduleRequest();
        return TeaModel.build(map, self);
    }

    public QueryClassScheduleRequest setSectionIndexList(java.util.List<Long> sectionIndexList) {
        this.sectionIndexList = sectionIndexList;
        return this;
    }
    public java.util.List<Long> getSectionIndexList() {
        return this.sectionIndexList;
    }

    public QueryClassScheduleRequest setSubscriberIds(java.util.List<String> subscriberIds) {
        this.subscriberIds = subscriberIds;
        return this;
    }
    public java.util.List<String> getSubscriberIds() {
        return this.subscriberIds;
    }

    public QueryClassScheduleRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryClassScheduleRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public QueryClassScheduleRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryClassScheduleRequest setSubscriberType(String subscriberType) {
        this.subscriberType = subscriberType;
        return this;
    }
    public String getSubscriberType() {
        return this.subscriberType;
    }

}
