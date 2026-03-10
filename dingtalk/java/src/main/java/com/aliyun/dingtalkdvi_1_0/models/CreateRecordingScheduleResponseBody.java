// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class CreateRecordingScheduleResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<CreateRecordingScheduleResponseBodyResult> result;

    public static CreateRecordingScheduleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateRecordingScheduleResponseBody self = new CreateRecordingScheduleResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateRecordingScheduleResponseBody setResult(java.util.List<CreateRecordingScheduleResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<CreateRecordingScheduleResponseBodyResult> getResult() {
        return this.result;
    }

    public static class CreateRecordingScheduleResponseBodyResult extends TeaModel {
        @NameInMap("businessOrder")
        public String businessOrder;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("taskId")
        public String taskId;

        public static CreateRecordingScheduleResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateRecordingScheduleResponseBodyResult self = new CreateRecordingScheduleResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateRecordingScheduleResponseBodyResult setBusinessOrder(String businessOrder) {
            this.businessOrder = businessOrder;
            return this;
        }
        public String getBusinessOrder() {
            return this.businessOrder;
        }

        public CreateRecordingScheduleResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public CreateRecordingScheduleResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public CreateRecordingScheduleResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
