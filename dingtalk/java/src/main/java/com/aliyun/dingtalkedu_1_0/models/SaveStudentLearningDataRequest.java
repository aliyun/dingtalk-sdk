// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SaveStudentLearningDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("assignNum")
    public Integer assignNum;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>HOMEWORK</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxxxxxxxxxxxxxxxxxxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("correctNum")
    public Integer correctNum;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <strong>example:</strong>
     * <p>.jpeg</p>
     */
    @NameInMap("fileSuffix")
    public String fileSuffix;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1672502400000</p>
     */
    @NameInMap("generatedTime")
    public Long generatedTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("questionNum")
    public Integer questionNum;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0123456</p>
     */
    @NameInMap("studentUserId")
    public String studentUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>shuxue</p>
     */
    @NameInMap("subjectCode")
    public String subjectCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("submitNum")
    public Integer submitNum;

    @NameInMap("wrongQuestions")
    public java.util.List<SaveStudentLearningDataRequestWrongQuestions> wrongQuestions;

    public static SaveStudentLearningDataRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveStudentLearningDataRequest self = new SaveStudentLearningDataRequest();
        return TeaModel.build(map, self);
    }

    public SaveStudentLearningDataRequest setAssignNum(Integer assignNum) {
        this.assignNum = assignNum;
        return this;
    }
    public Integer getAssignNum() {
        return this.assignNum;
    }

    public SaveStudentLearningDataRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public SaveStudentLearningDataRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public SaveStudentLearningDataRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SaveStudentLearningDataRequest setCorrectNum(Integer correctNum) {
        this.correctNum = correctNum;
        return this;
    }
    public Integer getCorrectNum() {
        return this.correctNum;
    }

    public SaveStudentLearningDataRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public SaveStudentLearningDataRequest setFileSuffix(String fileSuffix) {
        this.fileSuffix = fileSuffix;
        return this;
    }
    public String getFileSuffix() {
        return this.fileSuffix;
    }

    public SaveStudentLearningDataRequest setGeneratedTime(Long generatedTime) {
        this.generatedTime = generatedTime;
        return this;
    }
    public Long getGeneratedTime() {
        return this.generatedTime;
    }

    public SaveStudentLearningDataRequest setQuestionNum(Integer questionNum) {
        this.questionNum = questionNum;
        return this;
    }
    public Integer getQuestionNum() {
        return this.questionNum;
    }

    public SaveStudentLearningDataRequest setStudentUserId(String studentUserId) {
        this.studentUserId = studentUserId;
        return this;
    }
    public String getStudentUserId() {
        return this.studentUserId;
    }

    public SaveStudentLearningDataRequest setSubjectCode(String subjectCode) {
        this.subjectCode = subjectCode;
        return this;
    }
    public String getSubjectCode() {
        return this.subjectCode;
    }

    public SaveStudentLearningDataRequest setSubmitNum(Integer submitNum) {
        this.submitNum = submitNum;
        return this;
    }
    public Integer getSubmitNum() {
        return this.submitNum;
    }

    public SaveStudentLearningDataRequest setWrongQuestions(java.util.List<SaveStudentLearningDataRequestWrongQuestions> wrongQuestions) {
        this.wrongQuestions = wrongQuestions;
        return this;
    }
    public java.util.List<SaveStudentLearningDataRequestWrongQuestions> getWrongQuestions() {
        return this.wrongQuestions;
    }

    public static class SaveStudentLearningDataRequestWrongQuestions extends TeaModel {
        @NameInMap("knowledgePoints")
        public java.util.List<String> knowledgePoints;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("questionNo")
        public String questionNo;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("questionPictureNum")
        public Integer questionPictureNum;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("standardAnswerPictureNum")
        public Integer standardAnswerPictureNum;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("userAnswerPictureNum")
        public Integer userAnswerPictureNum;

        public static SaveStudentLearningDataRequestWrongQuestions build(java.util.Map<String, ?> map) throws Exception {
            SaveStudentLearningDataRequestWrongQuestions self = new SaveStudentLearningDataRequestWrongQuestions();
            return TeaModel.build(map, self);
        }

        public SaveStudentLearningDataRequestWrongQuestions setKnowledgePoints(java.util.List<String> knowledgePoints) {
            this.knowledgePoints = knowledgePoints;
            return this;
        }
        public java.util.List<String> getKnowledgePoints() {
            return this.knowledgePoints;
        }

        public SaveStudentLearningDataRequestWrongQuestions setQuestionNo(String questionNo) {
            this.questionNo = questionNo;
            return this;
        }
        public String getQuestionNo() {
            return this.questionNo;
        }

        public SaveStudentLearningDataRequestWrongQuestions setQuestionPictureNum(Integer questionPictureNum) {
            this.questionPictureNum = questionPictureNum;
            return this;
        }
        public Integer getQuestionPictureNum() {
            return this.questionPictureNum;
        }

        public SaveStudentLearningDataRequestWrongQuestions setStandardAnswerPictureNum(Integer standardAnswerPictureNum) {
            this.standardAnswerPictureNum = standardAnswerPictureNum;
            return this;
        }
        public Integer getStandardAnswerPictureNum() {
            return this.standardAnswerPictureNum;
        }

        public SaveStudentLearningDataRequestWrongQuestions setUserAnswerPictureNum(Integer userAnswerPictureNum) {
            this.userAnswerPictureNum = userAnswerPictureNum;
            return this;
        }
        public Integer getUserAnswerPictureNum() {
            return this.userAnswerPictureNum;
        }

    }

}
