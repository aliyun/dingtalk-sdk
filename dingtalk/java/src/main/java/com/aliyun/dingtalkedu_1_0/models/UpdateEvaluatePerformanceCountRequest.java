// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateEvaluatePerformanceCountRequest extends TeaModel {
    @NameInMap("teacherId")
    public String teacherId;

    @NameInMap("unreadData")
    public java.util.List<UpdateEvaluatePerformanceCountRequestUnreadData> unreadData;

    public static UpdateEvaluatePerformanceCountRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateEvaluatePerformanceCountRequest self = new UpdateEvaluatePerformanceCountRequest();
        return TeaModel.build(map, self);
    }

    public UpdateEvaluatePerformanceCountRequest setTeacherId(String teacherId) {
        this.teacherId = teacherId;
        return this;
    }
    public String getTeacherId() {
        return this.teacherId;
    }

    public UpdateEvaluatePerformanceCountRequest setUnreadData(java.util.List<UpdateEvaluatePerformanceCountRequestUnreadData> unreadData) {
        this.unreadData = unreadData;
        return this;
    }
    public java.util.List<UpdateEvaluatePerformanceCountRequestUnreadData> getUnreadData() {
        return this.unreadData;
    }

    public static class UpdateEvaluatePerformanceCountRequestUnreadData extends TeaModel {
        @NameInMap("number")
        public Integer number;

        @NameInMap("studentId")
        public String studentId;

        public static UpdateEvaluatePerformanceCountRequestUnreadData build(java.util.Map<String, ?> map) throws Exception {
            UpdateEvaluatePerformanceCountRequestUnreadData self = new UpdateEvaluatePerformanceCountRequestUnreadData();
            return TeaModel.build(map, self);
        }

        public UpdateEvaluatePerformanceCountRequestUnreadData setNumber(Integer number) {
            this.number = number;
            return this;
        }
        public Integer getNumber() {
            return this.number;
        }

        public UpdateEvaluatePerformanceCountRequestUnreadData setStudentId(String studentId) {
            this.studentId = studentId;
            return this;
        }
        public String getStudentId() {
            return this.studentId;
        }

    }

}
