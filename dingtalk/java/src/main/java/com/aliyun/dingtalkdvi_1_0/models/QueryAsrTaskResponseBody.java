// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryAsrTaskResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public QueryAsrTaskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryAsrTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAsrTaskResponseBody self = new QueryAsrTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAsrTaskResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public QueryAsrTaskResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public QueryAsrTaskResponseBody setResult(QueryAsrTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryAsrTaskResponseBodyResult getResult() {
        return this.result;
    }

    public QueryAsrTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList extends TeaModel {
        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("text")
        public String text;

        public static QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList build(java.util.Map<String, ?> map) throws Exception {
            QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList self = new QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList();
            return TeaModel.build(map, self);
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList extends TeaModel {
        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("sentence")
        public String sentence;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("wordList")
        public java.util.List<QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList> wordList;

        public static QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList build(java.util.Map<String, ?> map) throws Exception {
            QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList self = new QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList();
            return TeaModel.build(map, self);
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList setSentence(String sentence) {
            this.sentence = sentence;
            return this;
        }
        public String getSentence() {
            return this.sentence;
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList setWordList(java.util.List<QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList> wordList) {
            this.wordList = wordList;
            return this;
        }
        public java.util.List<QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList> getWordList() {
            return this.wordList;
        }

    }

    public static class QueryAsrTaskResponseBodyResultResultInfoParagraphList extends TeaModel {
        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("paragraph")
        public String paragraph;

        @NameInMap("sentenceList")
        public java.util.List<QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList> sentenceList;

        @NameInMap("speakerId")
        public String speakerId;

        @NameInMap("startTime")
        public Long startTime;

        public static QueryAsrTaskResponseBodyResultResultInfoParagraphList build(java.util.Map<String, ?> map) throws Exception {
            QueryAsrTaskResponseBodyResultResultInfoParagraphList self = new QueryAsrTaskResponseBodyResultResultInfoParagraphList();
            return TeaModel.build(map, self);
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphList setParagraph(String paragraph) {
            this.paragraph = paragraph;
            return this;
        }
        public String getParagraph() {
            return this.paragraph;
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphList setSentenceList(java.util.List<QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList> sentenceList) {
            this.sentenceList = sentenceList;
            return this;
        }
        public java.util.List<QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList> getSentenceList() {
            return this.sentenceList;
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphList setSpeakerId(String speakerId) {
            this.speakerId = speakerId;
            return this;
        }
        public String getSpeakerId() {
            return this.speakerId;
        }

        public QueryAsrTaskResponseBodyResultResultInfoParagraphList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

    }

    public static class QueryAsrTaskResponseBodyResultResultInfo extends TeaModel {
        @NameInMap("paragraphList")
        public java.util.List<QueryAsrTaskResponseBodyResultResultInfoParagraphList> paragraphList;

        public static QueryAsrTaskResponseBodyResultResultInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryAsrTaskResponseBodyResultResultInfo self = new QueryAsrTaskResponseBodyResultResultInfo();
            return TeaModel.build(map, self);
        }

        public QueryAsrTaskResponseBodyResultResultInfo setParagraphList(java.util.List<QueryAsrTaskResponseBodyResultResultInfoParagraphList> paragraphList) {
            this.paragraphList = paragraphList;
            return this;
        }
        public java.util.List<QueryAsrTaskResponseBodyResultResultInfoParagraphList> getParagraphList() {
            return this.paragraphList;
        }

    }

    public static class QueryAsrTaskResponseBodyResult extends TeaModel {
        @NameInMap("bizKey")
        public String bizKey;

        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMessage")
        public String errorMessage;

        @NameInMap("resultInfo")
        public QueryAsrTaskResponseBodyResultResultInfo resultInfo;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("taskStatus")
        public String taskStatus;

        public static QueryAsrTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryAsrTaskResponseBodyResult self = new QueryAsrTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryAsrTaskResponseBodyResult setBizKey(String bizKey) {
            this.bizKey = bizKey;
            return this;
        }
        public String getBizKey() {
            return this.bizKey;
        }

        public QueryAsrTaskResponseBodyResult setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public QueryAsrTaskResponseBodyResult setErrorMessage(String errorMessage) {
            this.errorMessage = errorMessage;
            return this;
        }
        public String getErrorMessage() {
            return this.errorMessage;
        }

        public QueryAsrTaskResponseBodyResult setResultInfo(QueryAsrTaskResponseBodyResultResultInfo resultInfo) {
            this.resultInfo = resultInfo;
            return this;
        }
        public QueryAsrTaskResponseBodyResultResultInfo getResultInfo() {
            return this.resultInfo;
        }

        public QueryAsrTaskResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public QueryAsrTaskResponseBodyResult setTaskStatus(String taskStatus) {
            this.taskStatus = taskStatus;
            return this;
        }
        public String getTaskStatus() {
            return this.taskStatus;
        }

    }

}
