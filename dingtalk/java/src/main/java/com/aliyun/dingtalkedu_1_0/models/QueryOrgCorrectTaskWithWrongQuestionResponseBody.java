// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgCorrectTaskWithWrongQuestionResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public java.util.List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static QueryOrgCorrectTaskWithWrongQuestionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgCorrectTaskWithWrongQuestionResponseBody self = new QueryOrgCorrectTaskWithWrongQuestionResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgCorrectTaskWithWrongQuestionResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public QueryOrgCorrectTaskWithWrongQuestionResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public QueryOrgCorrectTaskWithWrongQuestionResponseBody setResult(java.util.List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryOrgCorrectTaskWithWrongQuestionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestionsWrongQuestionRecords extends TeaModel {
        @NameInMap("questionCutUrl")
        public String questionCutUrl;

        @NameInMap("questionId")
        public String questionId;

        public static QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestionsWrongQuestionRecords build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestionsWrongQuestionRecords self = new QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestionsWrongQuestionRecords();
            return TeaModel.build(map, self);
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestionsWrongQuestionRecords setQuestionCutUrl(String questionCutUrl) {
            this.questionCutUrl = questionCutUrl;
            return this;
        }
        public String getQuestionCutUrl() {
            return this.questionCutUrl;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestionsWrongQuestionRecords setQuestionId(String questionId) {
            this.questionId = questionId;
            return this;
        }
        public String getQuestionId() {
            return this.questionId;
        }

    }

    public static class QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions extends TeaModel {
        @NameInMap("assignmentPicUrlList")
        public java.util.List<String> assignmentPicUrlList;

        @NameInMap("studentId")
        public String studentId;

        @NameInMap("studentName")
        public String studentName;

        @NameInMap("wrongQuestionRecords")
        public java.util.List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestionsWrongQuestionRecords> wrongQuestionRecords;

        public static QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions self = new QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions();
            return TeaModel.build(map, self);
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions setAssignmentPicUrlList(java.util.List<String> assignmentPicUrlList) {
            this.assignmentPicUrlList = assignmentPicUrlList;
            return this;
        }
        public java.util.List<String> getAssignmentPicUrlList() {
            return this.assignmentPicUrlList;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions setStudentId(String studentId) {
            this.studentId = studentId;
            return this;
        }
        public String getStudentId() {
            return this.studentId;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions setStudentName(String studentName) {
            this.studentName = studentName;
            return this;
        }
        public String getStudentName() {
            return this.studentName;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions setWrongQuestionRecords(java.util.List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestionsWrongQuestionRecords> wrongQuestionRecords) {
            this.wrongQuestionRecords = wrongQuestionRecords;
            return this;
        }
        public java.util.List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestionsWrongQuestionRecords> getWrongQuestionRecords() {
            return this.wrongQuestionRecords;
        }

    }

    public static class QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult extends TeaModel {
        @NameInMap("classId")
        public Long classId;

        @NameInMap("className")
        public String className;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("correctedPdfUrl")
        public String correctedPdfUrl;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("extInfo")
        public java.util.Map<String, ?> extInfo;

        @NameInMap("gradeName")
        public String gradeName;

        @NameInMap("paperName")
        public String paperName;

        @NameInMap("scannedPdfUrl")
        public String scannedPdfUrl;

        @NameInMap("studentWrongQuestions")
        public java.util.List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions> studentWrongQuestions;

        @NameInMap("submitTime")
        public Long submitTime;

        @NameInMap("taskCode")
        public String taskCode;

        @NameInMap("teacherId")
        public String teacherId;

        @NameInMap("teacherPdfUrl")
        public String teacherPdfUrl;

        public static QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult self = new QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setClassName(String className) {
            this.className = className;
            return this;
        }
        public String getClassName() {
            return this.className;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setCorrectedPdfUrl(String correctedPdfUrl) {
            this.correctedPdfUrl = correctedPdfUrl;
            return this;
        }
        public String getCorrectedPdfUrl() {
            return this.correctedPdfUrl;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setExtInfo(java.util.Map<String, ?> extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtInfo() {
            return this.extInfo;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setGradeName(String gradeName) {
            this.gradeName = gradeName;
            return this;
        }
        public String getGradeName() {
            return this.gradeName;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setPaperName(String paperName) {
            this.paperName = paperName;
            return this;
        }
        public String getPaperName() {
            return this.paperName;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setScannedPdfUrl(String scannedPdfUrl) {
            this.scannedPdfUrl = scannedPdfUrl;
            return this;
        }
        public String getScannedPdfUrl() {
            return this.scannedPdfUrl;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setStudentWrongQuestions(java.util.List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions> studentWrongQuestions) {
            this.studentWrongQuestions = studentWrongQuestions;
            return this;
        }
        public java.util.List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions> getStudentWrongQuestions() {
            return this.studentWrongQuestions;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setSubmitTime(Long submitTime) {
            this.submitTime = submitTime;
            return this;
        }
        public Long getSubmitTime() {
            return this.submitTime;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setTaskCode(String taskCode) {
            this.taskCode = taskCode;
            return this;
        }
        public String getTaskCode() {
            return this.taskCode;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setTeacherId(String teacherId) {
            this.teacherId = teacherId;
            return this;
        }
        public String getTeacherId() {
            return this.teacherId;
        }

        public QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult setTeacherPdfUrl(String teacherPdfUrl) {
            this.teacherPdfUrl = teacherPdfUrl;
            return this;
        }
        public String getTeacherPdfUrl() {
            return this.teacherPdfUrl;
        }

    }

}
