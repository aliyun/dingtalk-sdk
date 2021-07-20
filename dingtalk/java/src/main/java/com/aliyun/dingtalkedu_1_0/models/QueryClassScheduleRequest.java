// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleRequest extends TeaModel {
    // subscriberIds
    @NameInMap("subscriberIds")
    public java.util.List<String> subscriberIds;

    // subscriberType
    @NameInMap("subscriberType")
    public String subscriberType;

    // sectionIndexList
    @NameInMap("sectionIndexList")
    public java.util.List<Integer> sectionIndexList;

    // startTime
    @NameInMap("startTime")
    public Long startTime;

    // endTime
    @NameInMap("endTime")
    public Long endTime;

    // opUserId
    @NameInMap("opUserId")
    public String opUserId;

    public static QueryClassScheduleRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryClassScheduleRequest self = new QueryClassScheduleRequest();
        return TeaModel.build(map, self);
    }

    public QueryClassScheduleRequest setSubscriberIds(java.util.List<String> subscriberIds) {
        this.subscriberIds = subscriberIds;
        return this;
    }
    public java.util.List<String> getSubscriberIds() {
        return this.subscriberIds;
    }

    public QueryClassScheduleRequest setSubscriberType(String subscriberType) {
        this.subscriberType = subscriberType;
        return this;
    }
    public String getSubscriberType() {
        return this.subscriberType;
    }

    public QueryClassScheduleRequest setSectionIndexList(java.util.List<Integer> sectionIndexList) {
        this.sectionIndexList = sectionIndexList;
        return this;
    }
    public java.util.List<Integer> getSectionIndexList() {
        return this.sectionIndexList;
    }

    public QueryClassScheduleRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
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

}
