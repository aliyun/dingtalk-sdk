// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateRecordingScheduleRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static UpdateRecordingScheduleRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRecordingScheduleRequest self = new UpdateRecordingScheduleRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRecordingScheduleRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public UpdateRecordingScheduleRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public UpdateRecordingScheduleRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
