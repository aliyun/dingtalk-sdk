// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateScheduleConferenceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>qzR1iSMDvzR9iP7Pxxxxxxxxxxxx</p>
     */
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1687928400000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2a489xxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</p>
     */
    @NameInMap("scheduleConferenceId")
    public String scheduleConferenceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1687924800000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>预约会议标题</p>
     */
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
