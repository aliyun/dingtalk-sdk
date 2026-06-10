// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgCorrectTaskDetailResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public java.util.List<QueryOrgCorrectTaskDetailResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static QueryOrgCorrectTaskDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgCorrectTaskDetailResponseBody self = new QueryOrgCorrectTaskDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgCorrectTaskDetailResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public QueryOrgCorrectTaskDetailResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public QueryOrgCorrectTaskDetailResponseBody setResult(java.util.List<QueryOrgCorrectTaskDetailResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryOrgCorrectTaskDetailResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryOrgCorrectTaskDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryOrgCorrectTaskDetailResponseBodyResult extends TeaModel {
        @NameInMap("aiMarkId")
        public Long aiMarkId;

        @NameInMap("aiMarkTime")
        public Long aiMarkTime;

        @NameInMap("aiModel")
        public String aiModel;

        @NameInMap("className")
        public String className;

        @NameInMap("gradeLevel")
        public Long gradeLevel;

        @NameInMap("gradeName")
        public String gradeName;

        @NameInMap("periodCode")
        public String periodCode;

        @NameInMap("scanDeviceId")
        public String scanDeviceId;

        @NameInMap("scanTime")
        public Long scanTime;

        @NameInMap("schoolName")
        public String schoolName;

        @NameInMap("score")
        public Double score;

        @NameInMap("studentName")
        public String studentName;

        @NameInMap("taskCode")
        public String taskCode;

        @NameInMap("taskName")
        public String taskName;

        @NameInMap("teacherName")
        public String teacherName;

        @NameInMap("totalScore")
        public Double totalScore;

        public static QueryOrgCorrectTaskDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgCorrectTaskDetailResponseBodyResult self = new QueryOrgCorrectTaskDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setAiMarkId(Long aiMarkId) {
            this.aiMarkId = aiMarkId;
            return this;
        }
        public Long getAiMarkId() {
            return this.aiMarkId;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setAiMarkTime(Long aiMarkTime) {
            this.aiMarkTime = aiMarkTime;
            return this;
        }
        public Long getAiMarkTime() {
            return this.aiMarkTime;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setAiModel(String aiModel) {
            this.aiModel = aiModel;
            return this;
        }
        public String getAiModel() {
            return this.aiModel;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setClassName(String className) {
            this.className = className;
            return this;
        }
        public String getClassName() {
            return this.className;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setGradeLevel(Long gradeLevel) {
            this.gradeLevel = gradeLevel;
            return this;
        }
        public Long getGradeLevel() {
            return this.gradeLevel;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setGradeName(String gradeName) {
            this.gradeName = gradeName;
            return this;
        }
        public String getGradeName() {
            return this.gradeName;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setPeriodCode(String periodCode) {
            this.periodCode = periodCode;
            return this;
        }
        public String getPeriodCode() {
            return this.periodCode;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setScanDeviceId(String scanDeviceId) {
            this.scanDeviceId = scanDeviceId;
            return this;
        }
        public String getScanDeviceId() {
            return this.scanDeviceId;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setScanTime(Long scanTime) {
            this.scanTime = scanTime;
            return this;
        }
        public Long getScanTime() {
            return this.scanTime;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setSchoolName(String schoolName) {
            this.schoolName = schoolName;
            return this;
        }
        public String getSchoolName() {
            return this.schoolName;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setScore(Double score) {
            this.score = score;
            return this;
        }
        public Double getScore() {
            return this.score;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setStudentName(String studentName) {
            this.studentName = studentName;
            return this;
        }
        public String getStudentName() {
            return this.studentName;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setTaskCode(String taskCode) {
            this.taskCode = taskCode;
            return this;
        }
        public String getTaskCode() {
            return this.taskCode;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setTaskName(String taskName) {
            this.taskName = taskName;
            return this;
        }
        public String getTaskName() {
            return this.taskName;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setTeacherName(String teacherName) {
            this.teacherName = teacherName;
            return this;
        }
        public String getTeacherName() {
            return this.teacherName;
        }

        public QueryOrgCorrectTaskDetailResponseBodyResult setTotalScore(Double totalScore) {
            this.totalScore = totalScore;
            return this;
        }
        public Double getTotalScore() {
            return this.totalScore;
        }

    }

}
