// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class RetrieveRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("answerer")
    public String answerer;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("dragRequestContext")
    public RetrieveRequestDragRequestContext dragRequestContext;

    @NameInMap("keywordList")
    public java.util.List<String> keywordList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("limit")
    public Integer limit;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("question")
    public String question;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("questioner")
    public String questioner;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("retrievalExtendParams")
    public java.util.Map<String, RetrievalExtendParamsValue> retrievalExtendParams;

    @NameInMap("retrieveScoreThreshold")
    public Double retrieveScoreThreshold;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("scene")
    public String scene;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tenant")
    public String tenant;

    @NameInMap("tokenLimit")
    public Integer tokenLimit;

    public static RetrieveRequest build(java.util.Map<String, ?> map) throws Exception {
        RetrieveRequest self = new RetrieveRequest();
        return TeaModel.build(map, self);
    }

    public RetrieveRequest setAnswerer(String answerer) {
        this.answerer = answerer;
        return this;
    }
    public String getAnswerer() {
        return this.answerer;
    }

    public RetrieveRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public RetrieveRequest setDragRequestContext(RetrieveRequestDragRequestContext dragRequestContext) {
        this.dragRequestContext = dragRequestContext;
        return this;
    }
    public RetrieveRequestDragRequestContext getDragRequestContext() {
        return this.dragRequestContext;
    }

    public RetrieveRequest setKeywordList(java.util.List<String> keywordList) {
        this.keywordList = keywordList;
        return this;
    }
    public java.util.List<String> getKeywordList() {
        return this.keywordList;
    }

    public RetrieveRequest setLimit(Integer limit) {
        this.limit = limit;
        return this;
    }
    public Integer getLimit() {
        return this.limit;
    }

    public RetrieveRequest setQuestion(String question) {
        this.question = question;
        return this;
    }
    public String getQuestion() {
        return this.question;
    }

    public RetrieveRequest setQuestioner(String questioner) {
        this.questioner = questioner;
        return this;
    }
    public String getQuestioner() {
        return this.questioner;
    }

    public RetrieveRequest setRetrievalExtendParams(java.util.Map<String, RetrievalExtendParamsValue> retrievalExtendParams) {
        this.retrievalExtendParams = retrievalExtendParams;
        return this;
    }
    public java.util.Map<String, RetrievalExtendParamsValue> getRetrievalExtendParams() {
        return this.retrievalExtendParams;
    }

    public RetrieveRequest setRetrieveScoreThreshold(Double retrieveScoreThreshold) {
        this.retrieveScoreThreshold = retrieveScoreThreshold;
        return this;
    }
    public Double getRetrieveScoreThreshold() {
        return this.retrieveScoreThreshold;
    }

    public RetrieveRequest setScene(String scene) {
        this.scene = scene;
        return this;
    }
    public String getScene() {
        return this.scene;
    }

    public RetrieveRequest setTenant(String tenant) {
        this.tenant = tenant;
        return this;
    }
    public String getTenant() {
        return this.tenant;
    }

    public RetrieveRequest setTokenLimit(Integer tokenLimit) {
        this.tokenLimit = tokenLimit;
        return this;
    }
    public Integer getTokenLimit() {
        return this.tokenLimit;
    }

    public static class RetrieveRequestDragRequestContextEvaluationContext extends TeaModel {
        @NameInMap("sourceDentryId")
        public String sourceDentryId;

        public static RetrieveRequestDragRequestContextEvaluationContext build(java.util.Map<String, ?> map) throws Exception {
            RetrieveRequestDragRequestContextEvaluationContext self = new RetrieveRequestDragRequestContextEvaluationContext();
            return TeaModel.build(map, self);
        }

        public RetrieveRequestDragRequestContextEvaluationContext setSourceDentryId(String sourceDentryId) {
            this.sourceDentryId = sourceDentryId;
            return this;
        }
        public String getSourceDentryId() {
            return this.sourceDentryId;
        }

    }

    public static class RetrieveRequestDragRequestContext extends TeaModel {
        @NameInMap("evaluationContext")
        public RetrieveRequestDragRequestContextEvaluationContext evaluationContext;

        public static RetrieveRequestDragRequestContext build(java.util.Map<String, ?> map) throws Exception {
            RetrieveRequestDragRequestContext self = new RetrieveRequestDragRequestContext();
            return TeaModel.build(map, self);
        }

        public RetrieveRequestDragRequestContext setEvaluationContext(RetrieveRequestDragRequestContextEvaluationContext evaluationContext) {
            this.evaluationContext = evaluationContext;
            return this;
        }
        public RetrieveRequestDragRequestContextEvaluationContext getEvaluationContext() {
            return this.evaluationContext;
        }

    }

}
