// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddEvaluatePerformanceRequest extends TeaModel {
    @NameInMap("evaluationData")
    public java.util.List<AddEvaluatePerformanceRequestEvaluationData> evaluationData;

    public static AddEvaluatePerformanceRequest build(java.util.Map<String, ?> map) throws Exception {
        AddEvaluatePerformanceRequest self = new AddEvaluatePerformanceRequest();
        return TeaModel.build(map, self);
    }

    public AddEvaluatePerformanceRequest setEvaluationData(java.util.List<AddEvaluatePerformanceRequestEvaluationData> evaluationData) {
        this.evaluationData = evaluationData;
        return this;
    }
    public java.util.List<AddEvaluatePerformanceRequestEvaluationData> getEvaluationData() {
        return this.evaluationData;
    }

    public static class AddEvaluatePerformanceRequestEvaluationData extends TeaModel {
        @NameInMap("evaluationContent")
        public String evaluationContent;

        @NameInMap("eventTime")
        public String eventTime;

        @NameInMap("id")
        public String id;

        @NameInMap("studentId")
        public String studentId;

        @NameInMap("teacherId")
        public String teacherId;

        public static AddEvaluatePerformanceRequestEvaluationData build(java.util.Map<String, ?> map) throws Exception {
            AddEvaluatePerformanceRequestEvaluationData self = new AddEvaluatePerformanceRequestEvaluationData();
            return TeaModel.build(map, self);
        }

        public AddEvaluatePerformanceRequestEvaluationData setEvaluationContent(String evaluationContent) {
            this.evaluationContent = evaluationContent;
            return this;
        }
        public String getEvaluationContent() {
            return this.evaluationContent;
        }

        public AddEvaluatePerformanceRequestEvaluationData setEventTime(String eventTime) {
            this.eventTime = eventTime;
            return this;
        }
        public String getEventTime() {
            return this.eventTime;
        }

        public AddEvaluatePerformanceRequestEvaluationData setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public AddEvaluatePerformanceRequestEvaluationData setStudentId(String studentId) {
            this.studentId = studentId;
            return this;
        }
        public String getStudentId() {
            return this.studentId;
        }

        public AddEvaluatePerformanceRequestEvaluationData setTeacherId(String teacherId) {
            this.teacherId = teacherId;
            return this;
        }
        public String getTeacherId() {
            return this.teacherId;
        }

    }

}
