// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateScheduleConferenceRequest extends TeaModel {
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

    public static CreateScheduleConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateScheduleConferenceRequest self = new CreateScheduleConferenceRequest();
        return TeaModel.build(map, self);
    }

    public CreateScheduleConferenceRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public CreateScheduleConferenceRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CreateScheduleConferenceRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateScheduleConferenceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
