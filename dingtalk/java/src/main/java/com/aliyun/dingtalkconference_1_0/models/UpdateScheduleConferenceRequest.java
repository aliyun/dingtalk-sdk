// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateScheduleConferenceRequest extends TeaModel {
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("scheduleConferenceId")
    public String scheduleConferenceId;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("title")
    public String title;

    public static UpdateScheduleConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateScheduleConferenceRequest self = new UpdateScheduleConferenceRequest();
        return TeaModel.build(map, self);
    }

    public UpdateScheduleConferenceRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public UpdateScheduleConferenceRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public UpdateScheduleConferenceRequest setScheduleConferenceId(String scheduleConferenceId) {
        this.scheduleConferenceId = scheduleConferenceId;
        return this;
    }
    public String getScheduleConferenceId() {
        return this.scheduleConferenceId;
    }

    public UpdateScheduleConferenceRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public UpdateScheduleConferenceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
