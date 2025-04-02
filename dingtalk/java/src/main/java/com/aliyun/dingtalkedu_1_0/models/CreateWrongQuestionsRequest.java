// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateWrongQuestionsRequest extends TeaModel {
    @NameInMap("answerContent")
    public String answerContent;

    @NameInMap("difficultyLevel")
    public Integer difficultyLevel;

    @NameInMap("explainAudio")
    public String explainAudio;

    @NameInMap("explainContent")
    public String explainContent;

    @NameInMap("generateTime")
    public Long generateTime;

    @NameInMap("knowledgePointList")
    public java.util.List<String> knowledgePointList;

    @NameInMap("ownerCode")
    public String ownerCode;

    @NameInMap("ownerType")
    public String ownerType;

    @NameInMap("proficiencyLevel")
    public Integer proficiencyLevel;

    @NameInMap("questionAudio")
    public String questionAudio;

    @NameInMap("questionContent")
    public String questionContent;

    @NameInMap("questionExtension")
    public java.util.Map<String, String> questionExtension;

    @NameInMap("questionPicUrl")
    public String questionPicUrl;

    @NameInMap("questionType")
    public String questionType;

    @NameInMap("sourceCode")
    public String sourceCode;

    @NameInMap("studentUserId")
    public String studentUserId;

    @NameInMap("subject")
    public String subject;

    public static CreateWrongQuestionsRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateWrongQuestionsRequest self = new CreateWrongQuestionsRequest();
        return TeaModel.build(map, self);
    }

    public CreateWrongQuestionsRequest setAnswerContent(String answerContent) {
        this.answerContent = answerContent;
        return this;
    }
    public String getAnswerContent() {
        return this.answerContent;
    }

    public CreateWrongQuestionsRequest setDifficultyLevel(Integer difficultyLevel) {
        this.difficultyLevel = difficultyLevel;
        return this;
    }
    public Integer getDifficultyLevel() {
        return this.difficultyLevel;
    }

    public CreateWrongQuestionsRequest setExplainAudio(String explainAudio) {
        this.explainAudio = explainAudio;
        return this;
    }
    public String getExplainAudio() {
        return this.explainAudio;
    }

    public CreateWrongQuestionsRequest setExplainContent(String explainContent) {
        this.explainContent = explainContent;
        return this;
    }
    public String getExplainContent() {
        return this.explainContent;
    }

    public CreateWrongQuestionsRequest setGenerateTime(Long generateTime) {
        this.generateTime = generateTime;
        return this;
    }
    public Long getGenerateTime() {
        return this.generateTime;
    }

    public CreateWrongQuestionsRequest setKnowledgePointList(java.util.List<String> knowledgePointList) {
        this.knowledgePointList = knowledgePointList;
        return this;
    }
    public java.util.List<String> getKnowledgePointList() {
        return this.knowledgePointList;
    }

    public CreateWrongQuestionsRequest setOwnerCode(String ownerCode) {
        this.ownerCode = ownerCode;
        return this;
    }
    public String getOwnerCode() {
        return this.ownerCode;
    }

    public CreateWrongQuestionsRequest setOwnerType(String ownerType) {
        this.ownerType = ownerType;
        return this;
    }
    public String getOwnerType() {
        return this.ownerType;
    }

    public CreateWrongQuestionsRequest setProficiencyLevel(Integer proficiencyLevel) {
        this.proficiencyLevel = proficiencyLevel;
        return this;
    }
    public Integer getProficiencyLevel() {
        return this.proficiencyLevel;
    }

    public CreateWrongQuestionsRequest setQuestionAudio(String questionAudio) {
        this.questionAudio = questionAudio;
        return this;
    }
    public String getQuestionAudio() {
        return this.questionAudio;
    }

    public CreateWrongQuestionsRequest setQuestionContent(String questionContent) {
        this.questionContent = questionContent;
        return this;
    }
    public String getQuestionContent() {
        return this.questionContent;
    }

    public CreateWrongQuestionsRequest setQuestionExtension(java.util.Map<String, String> questionExtension) {
        this.questionExtension = questionExtension;
        return this;
    }
    public java.util.Map<String, String> getQuestionExtension() {
        return this.questionExtension;
    }

    public CreateWrongQuestionsRequest setQuestionPicUrl(String questionPicUrl) {
        this.questionPicUrl = questionPicUrl;
        return this;
    }
    public String getQuestionPicUrl() {
        return this.questionPicUrl;
    }

    public CreateWrongQuestionsRequest setQuestionType(String questionType) {
        this.questionType = questionType;
        return this;
    }
    public String getQuestionType() {
        return this.questionType;
    }

    public CreateWrongQuestionsRequest setSourceCode(String sourceCode) {
        this.sourceCode = sourceCode;
        return this;
    }
    public String getSourceCode() {
        return this.sourceCode;
    }

    public CreateWrongQuestionsRequest setStudentUserId(String studentUserId) {
        this.studentUserId = studentUserId;
        return this;
    }
    public String getStudentUserId() {
        return this.studentUserId;
    }

    public CreateWrongQuestionsRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

}
