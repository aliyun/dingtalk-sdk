// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetRecordingScheduleResponseBody extends TeaModel {
    @NameInMap("result")
    public GetRecordingScheduleResponseBodyResult result;

    public static GetRecordingScheduleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRecordingScheduleResponseBody self = new GetRecordingScheduleResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRecordingScheduleResponseBody setResult(GetRecordingScheduleResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetRecordingScheduleResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetRecordingScheduleResponseBodyResult extends TeaModel {
        @NameInMap("businessOrder")
        public String businessOrder;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("sn")
        public String sn;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("status")
        public Integer status;

        @NameInMap("taskId")
        public String taskId;

        public static GetRecordingScheduleResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetRecordingScheduleResponseBodyResult self = new GetRecordingScheduleResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetRecordingScheduleResponseBodyResult setBusinessOrder(String businessOrder) {
            this.businessOrder = businessOrder;
            return this;
        }
        public String getBusinessOrder() {
            return this.businessOrder;
        }

        public GetRecordingScheduleResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetRecordingScheduleResponseBodyResult setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

        public GetRecordingScheduleResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetRecordingScheduleResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public GetRecordingScheduleResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
