// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SaveClassLearningDataRequest extends TeaModel {
    @NameInMap("assignNum")
    public Integer assignNum;

    @NameInMap("assignStudentUserIds")
    public java.util.List<String> assignStudentUserIds;

    @NameInMap("bizId")
    public String bizId;

    @NameInMap("bizType")
    public String bizType;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("fileSuffix")
    public String fileSuffix;

    @NameInMap("generatedTime")
    public Long generatedTime;

    @NameInMap("questionNum")
    public Integer questionNum;

    @NameInMap("questionPictureNum")
    public Integer questionPictureNum;

    @NameInMap("standardAnswerPictureNum")
    public Integer standardAnswerPictureNum;

    @NameInMap("subjectCode")
    public String subjectCode;

    @NameInMap("teacherUserId")
    public String teacherUserId;

    public static SaveClassLearningDataRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveClassLearningDataRequest self = new SaveClassLearningDataRequest();
        return TeaModel.build(map, self);
    }

    public SaveClassLearningDataRequest setAssignNum(Integer assignNum) {
        this.assignNum = assignNum;
        return this;
    }
    public Integer getAssignNum() {
        return this.assignNum;
    }

    public SaveClassLearningDataRequest setAssignStudentUserIds(java.util.List<String> assignStudentUserIds) {
        this.assignStudentUserIds = assignStudentUserIds;
        return this;
    }
    public java.util.List<String> getAssignStudentUserIds() {
        return this.assignStudentUserIds;
    }

    public SaveClassLearningDataRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public SaveClassLearningDataRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public SaveClassLearningDataRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SaveClassLearningDataRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public SaveClassLearningDataRequest setFileSuffix(String fileSuffix) {
        this.fileSuffix = fileSuffix;
        return this;
    }
    public String getFileSuffix() {
        return this.fileSuffix;
    }

    public SaveClassLearningDataRequest setGeneratedTime(Long generatedTime) {
        this.generatedTime = generatedTime;
        return this;
    }
    public Long getGeneratedTime() {
        return this.generatedTime;
    }

    public SaveClassLearningDataRequest setQuestionNum(Integer questionNum) {
        this.questionNum = questionNum;
        return this;
    }
    public Integer getQuestionNum() {
        return this.questionNum;
    }

    public SaveClassLearningDataRequest setQuestionPictureNum(Integer questionPictureNum) {
        this.questionPictureNum = questionPictureNum;
        return this;
    }
    public Integer getQuestionPictureNum() {
        return this.questionPictureNum;
    }

    public SaveClassLearningDataRequest setStandardAnswerPictureNum(Integer standardAnswerPictureNum) {
        this.standardAnswerPictureNum = standardAnswerPictureNum;
        return this;
    }
    public Integer getStandardAnswerPictureNum() {
        return this.standardAnswerPictureNum;
    }

    public SaveClassLearningDataRequest setSubjectCode(String subjectCode) {
        this.subjectCode = subjectCode;
        return this;
    }
    public String getSubjectCode() {
        return this.subjectCode;
    }

    public SaveClassLearningDataRequest setTeacherUserId(String teacherUserId) {
        this.teacherUserId = teacherUserId;
        return this;
    }
    public String getTeacherUserId() {
        return this.teacherUserId;
    }

}
