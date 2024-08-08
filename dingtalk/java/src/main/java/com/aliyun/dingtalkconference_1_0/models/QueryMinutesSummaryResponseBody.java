// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesSummaryResponseBody extends TeaModel {
    @NameInMap("summary")
    public QueryMinutesSummaryResponseBodySummary summary;

    public static QueryMinutesSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesSummaryResponseBody self = new QueryMinutesSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMinutesSummaryResponseBody setSummary(QueryMinutesSummaryResponseBodySummary summary) {
        this.summary = summary;
        return this;
    }
    public QueryMinutesSummaryResponseBodySummary getSummary() {
        return this.summary;
    }

    public static class QueryMinutesSummaryResponseBodySummaryActions extends TeaModel {
        @NameInMap("end")
        public Long end;

        @NameInMap("id")
        public Long id;

        @NameInMap("sentenceId")
        public Long sentenceId;

        @NameInMap("start")
        public Long start;

        @NameInMap("text")
        public String text;

        public static QueryMinutesSummaryResponseBodySummaryActions build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesSummaryResponseBodySummaryActions self = new QueryMinutesSummaryResponseBodySummaryActions();
            return TeaModel.build(map, self);
        }

        public QueryMinutesSummaryResponseBodySummaryActions setEnd(Long end) {
            this.end = end;
            return this;
        }
        public Long getEnd() {
            return this.end;
        }

        public QueryMinutesSummaryResponseBodySummaryActions setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryMinutesSummaryResponseBodySummaryActions setSentenceId(Long sentenceId) {
            this.sentenceId = sentenceId;
            return this;
        }
        public Long getSentenceId() {
            return this.sentenceId;
        }

        public QueryMinutesSummaryResponseBodySummaryActions setStart(Long start) {
            this.start = start;
            return this;
        }
        public Long getStart() {
            return this.start;
        }

        public QueryMinutesSummaryResponseBodySummaryActions setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class QueryMinutesSummaryResponseBodySummaryAutoChapters extends TeaModel {
        @NameInMap("end")
        public Long end;

        @NameInMap("headline")
        public String headline;

        @NameInMap("id")
        public Long id;

        @NameInMap("start")
        public Long start;

        @NameInMap("summary")
        public String summary;

        public static QueryMinutesSummaryResponseBodySummaryAutoChapters build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesSummaryResponseBodySummaryAutoChapters self = new QueryMinutesSummaryResponseBodySummaryAutoChapters();
            return TeaModel.build(map, self);
        }

        public QueryMinutesSummaryResponseBodySummaryAutoChapters setEnd(Long end) {
            this.end = end;
            return this;
        }
        public Long getEnd() {
            return this.end;
        }

        public QueryMinutesSummaryResponseBodySummaryAutoChapters setHeadline(String headline) {
            this.headline = headline;
            return this;
        }
        public String getHeadline() {
            return this.headline;
        }

        public QueryMinutesSummaryResponseBodySummaryAutoChapters setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryMinutesSummaryResponseBodySummaryAutoChapters setStart(Long start) {
            this.start = start;
            return this;
        }
        public Long getStart() {
            return this.start;
        }

        public QueryMinutesSummaryResponseBodySummaryAutoChapters setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

    }

    public static class QueryMinutesSummaryResponseBodySummaryConversationalSummary extends TeaModel {
        @NameInMap("speakerId")
        public String speakerId;

        @NameInMap("speakerName")
        public String speakerName;

        @NameInMap("summary")
        public String summary;

        public static QueryMinutesSummaryResponseBodySummaryConversationalSummary build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesSummaryResponseBodySummaryConversationalSummary self = new QueryMinutesSummaryResponseBodySummaryConversationalSummary();
            return TeaModel.build(map, self);
        }

        public QueryMinutesSummaryResponseBodySummaryConversationalSummary setSpeakerId(String speakerId) {
            this.speakerId = speakerId;
            return this;
        }
        public String getSpeakerId() {
            return this.speakerId;
        }

        public QueryMinutesSummaryResponseBodySummaryConversationalSummary setSpeakerName(String speakerName) {
            this.speakerName = speakerName;
            return this;
        }
        public String getSpeakerName() {
            return this.speakerName;
        }

        public QueryMinutesSummaryResponseBodySummaryConversationalSummary setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

    }

    public static class QueryMinutesSummaryResponseBodySummaryKeySentences extends TeaModel {
        @NameInMap("end")
        public Long end;

        @NameInMap("id")
        public Long id;

        @NameInMap("sentenceId")
        public Long sentenceId;

        @NameInMap("start")
        public Long start;

        @NameInMap("text")
        public String text;

        public static QueryMinutesSummaryResponseBodySummaryKeySentences build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesSummaryResponseBodySummaryKeySentences self = new QueryMinutesSummaryResponseBodySummaryKeySentences();
            return TeaModel.build(map, self);
        }

        public QueryMinutesSummaryResponseBodySummaryKeySentences setEnd(Long end) {
            this.end = end;
            return this;
        }
        public Long getEnd() {
            return this.end;
        }

        public QueryMinutesSummaryResponseBodySummaryKeySentences setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryMinutesSummaryResponseBodySummaryKeySentences setSentenceId(Long sentenceId) {
            this.sentenceId = sentenceId;
            return this;
        }
        public Long getSentenceId() {
            return this.sentenceId;
        }

        public QueryMinutesSummaryResponseBodySummaryKeySentences setStart(Long start) {
            this.start = start;
            return this;
        }
        public Long getStart() {
            return this.start;
        }

        public QueryMinutesSummaryResponseBodySummaryKeySentences setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary extends TeaModel {
        @NameInMap("answer")
        public String answer;

        @NameInMap("question")
        public String question;

        @NameInMap("sentenceIdsOfAnswer")
        public java.util.List<Long> sentenceIdsOfAnswer;

        @NameInMap("sentenceIdsOfQuestion")
        public java.util.List<Long> sentenceIdsOfQuestion;

        public static QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary self = new QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary();
            return TeaModel.build(map, self);
        }

        public QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary setAnswer(String answer) {
            this.answer = answer;
            return this;
        }
        public String getAnswer() {
            return this.answer;
        }

        public QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary setQuestion(String question) {
            this.question = question;
            return this;
        }
        public String getQuestion() {
            return this.question;
        }

        public QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary setSentenceIdsOfAnswer(java.util.List<Long> sentenceIdsOfAnswer) {
            this.sentenceIdsOfAnswer = sentenceIdsOfAnswer;
            return this;
        }
        public java.util.List<Long> getSentenceIdsOfAnswer() {
            return this.sentenceIdsOfAnswer;
        }

        public QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary setSentenceIdsOfQuestion(java.util.List<Long> sentenceIdsOfQuestion) {
            this.sentenceIdsOfQuestion = sentenceIdsOfQuestion;
            return this;
        }
        public java.util.List<Long> getSentenceIdsOfQuestion() {
            return this.sentenceIdsOfQuestion;
        }

    }

    public static class QueryMinutesSummaryResponseBodySummary extends TeaModel {
        @NameInMap("actions")
        public java.util.List<QueryMinutesSummaryResponseBodySummaryActions> actions;

        @NameInMap("autoChapters")
        public java.util.List<QueryMinutesSummaryResponseBodySummaryAutoChapters> autoChapters;

        @NameInMap("conversationalSummary")
        public java.util.List<QueryMinutesSummaryResponseBodySummaryConversationalSummary> conversationalSummary;

        @NameInMap("keySentences")
        public java.util.List<QueryMinutesSummaryResponseBodySummaryKeySentences> keySentences;

        @NameInMap("keywords")
        public java.util.List<String> keywords;

        @NameInMap("paragraphSummary")
        public String paragraphSummary;

        @NameInMap("questionsAnsweringSummary")
        public java.util.List<QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary> questionsAnsweringSummary;

        public static QueryMinutesSummaryResponseBodySummary build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesSummaryResponseBodySummary self = new QueryMinutesSummaryResponseBodySummary();
            return TeaModel.build(map, self);
        }

        public QueryMinutesSummaryResponseBodySummary setActions(java.util.List<QueryMinutesSummaryResponseBodySummaryActions> actions) {
            this.actions = actions;
            return this;
        }
        public java.util.List<QueryMinutesSummaryResponseBodySummaryActions> getActions() {
            return this.actions;
        }

        public QueryMinutesSummaryResponseBodySummary setAutoChapters(java.util.List<QueryMinutesSummaryResponseBodySummaryAutoChapters> autoChapters) {
            this.autoChapters = autoChapters;
            return this;
        }
        public java.util.List<QueryMinutesSummaryResponseBodySummaryAutoChapters> getAutoChapters() {
            return this.autoChapters;
        }

        public QueryMinutesSummaryResponseBodySummary setConversationalSummary(java.util.List<QueryMinutesSummaryResponseBodySummaryConversationalSummary> conversationalSummary) {
            this.conversationalSummary = conversationalSummary;
            return this;
        }
        public java.util.List<QueryMinutesSummaryResponseBodySummaryConversationalSummary> getConversationalSummary() {
            return this.conversationalSummary;
        }

        public QueryMinutesSummaryResponseBodySummary setKeySentences(java.util.List<QueryMinutesSummaryResponseBodySummaryKeySentences> keySentences) {
            this.keySentences = keySentences;
            return this;
        }
        public java.util.List<QueryMinutesSummaryResponseBodySummaryKeySentences> getKeySentences() {
            return this.keySentences;
        }

        public QueryMinutesSummaryResponseBodySummary setKeywords(java.util.List<String> keywords) {
            this.keywords = keywords;
            return this;
        }
        public java.util.List<String> getKeywords() {
            return this.keywords;
        }

        public QueryMinutesSummaryResponseBodySummary setParagraphSummary(String paragraphSummary) {
            this.paragraphSummary = paragraphSummary;
            return this;
        }
        public String getParagraphSummary() {
            return this.paragraphSummary;
        }

        public QueryMinutesSummaryResponseBodySummary setQuestionsAnsweringSummary(java.util.List<QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary> questionsAnsweringSummary) {
            this.questionsAnsweringSummary = questionsAnsweringSummary;
            return this;
        }
        public java.util.List<QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary> getQuestionsAnsweringSummary() {
            return this.questionsAnsweringSummary;
        }

    }

}
