// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class CreateRecordingScheduleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("schedules")
    public java.util.List<CreateRecordingScheduleRequestSchedules> schedules;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sn")
    public String sn;

    public static CreateRecordingScheduleRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateRecordingScheduleRequest self = new CreateRecordingScheduleRequest();
        return TeaModel.build(map, self);
    }

    public CreateRecordingScheduleRequest setSchedules(java.util.List<CreateRecordingScheduleRequestSchedules> schedules) {
        this.schedules = schedules;
        return this;
    }
    public java.util.List<CreateRecordingScheduleRequestSchedules> getSchedules() {
        return this.schedules;
    }

    public CreateRecordingScheduleRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public static class CreateRecordingScheduleRequestSchedules extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("businessOrder")
        public String businessOrder;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        public static CreateRecordingScheduleRequestSchedules build(java.util.Map<String, ?> map) throws Exception {
            CreateRecordingScheduleRequestSchedules self = new CreateRecordingScheduleRequestSchedules();
            return TeaModel.build(map, self);
        }

        public CreateRecordingScheduleRequestSchedules setBusinessOrder(String businessOrder) {
            this.businessOrder = businessOrder;
            return this;
        }
        public String getBusinessOrder() {
            return this.businessOrder;
        }

        public CreateRecordingScheduleRequestSchedules setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public CreateRecordingScheduleRequestSchedules setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

    }

}
