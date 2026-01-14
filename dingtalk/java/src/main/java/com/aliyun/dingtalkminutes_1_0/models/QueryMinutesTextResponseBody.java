// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesTextResponseBody extends TeaModel {
    @NameInMap("hasNext")
    public Boolean hasNext;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("paragraphList")
    public java.util.List<QueryMinutesTextResponseBodyParagraphList> paragraphList;

    public static QueryMinutesTextResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesTextResponseBody self = new QueryMinutesTextResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMinutesTextResponseBody setHasNext(Boolean hasNext) {
        this.hasNext = hasNext;
        return this;
    }
    public Boolean getHasNext() {
        return this.hasNext;
    }

    public QueryMinutesTextResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryMinutesTextResponseBody setParagraphList(java.util.List<QueryMinutesTextResponseBodyParagraphList> paragraphList) {
        this.paragraphList = paragraphList;
        return this;
    }
    public java.util.List<QueryMinutesTextResponseBodyParagraphList> getParagraphList() {
        return this.paragraphList;
    }

    public static class QueryMinutesTextResponseBodyParagraphListSentenceListWordList extends TeaModel {
        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("word")
        public String word;

        @NameInMap("wordId")
        public String wordId;

        public static QueryMinutesTextResponseBodyParagraphListSentenceListWordList build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesTextResponseBodyParagraphListSentenceListWordList self = new QueryMinutesTextResponseBodyParagraphListSentenceListWordList();
            return TeaModel.build(map, self);
        }

        public QueryMinutesTextResponseBodyParagraphListSentenceListWordList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryMinutesTextResponseBodyParagraphListSentenceListWordList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryMinutesTextResponseBodyParagraphListSentenceListWordList setWord(String word) {
            this.word = word;
            return this;
        }
        public String getWord() {
            return this.word;
        }

        public QueryMinutesTextResponseBodyParagraphListSentenceListWordList setWordId(String wordId) {
            this.wordId = wordId;
            return this;
        }
        public String getWordId() {
            return this.wordId;
        }

    }

    public static class QueryMinutesTextResponseBodyParagraphListSentenceList extends TeaModel {
        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("sentence")
        public String sentence;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("wordList")
        public java.util.List<QueryMinutesTextResponseBodyParagraphListSentenceListWordList> wordList;

        public static QueryMinutesTextResponseBodyParagraphListSentenceList build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesTextResponseBodyParagraphListSentenceList self = new QueryMinutesTextResponseBodyParagraphListSentenceList();
            return TeaModel.build(map, self);
        }

        public QueryMinutesTextResponseBodyParagraphListSentenceList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryMinutesTextResponseBodyParagraphListSentenceList setSentence(String sentence) {
            this.sentence = sentence;
            return this;
        }
        public String getSentence() {
            return this.sentence;
        }

        public QueryMinutesTextResponseBodyParagraphListSentenceList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryMinutesTextResponseBodyParagraphListSentenceList setWordList(java.util.List<QueryMinutesTextResponseBodyParagraphListSentenceListWordList> wordList) {
            this.wordList = wordList;
            return this;
        }
        public java.util.List<QueryMinutesTextResponseBodyParagraphListSentenceListWordList> getWordList() {
            return this.wordList;
        }

    }

    public static class QueryMinutesTextResponseBodyParagraphList extends TeaModel {
        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("nickName")
        public String nickName;

        @NameInMap("paragraph")
        public String paragraph;

        @NameInMap("paragraphId")
        public Long paragraphId;

        @NameInMap("recordId")
        public Long recordId;

        @NameInMap("sentenceList")
        public java.util.List<QueryMinutesTextResponseBodyParagraphListSentenceList> sentenceList;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("subSpeakerId")
        public String subSpeakerId;

        @NameInMap("unionId")
        public String unionId;

        public static QueryMinutesTextResponseBodyParagraphList build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesTextResponseBodyParagraphList self = new QueryMinutesTextResponseBodyParagraphList();
            return TeaModel.build(map, self);
        }

        public QueryMinutesTextResponseBodyParagraphList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryMinutesTextResponseBodyParagraphList setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public QueryMinutesTextResponseBodyParagraphList setParagraph(String paragraph) {
            this.paragraph = paragraph;
            return this;
        }
        public String getParagraph() {
            return this.paragraph;
        }

        public QueryMinutesTextResponseBodyParagraphList setParagraphId(Long paragraphId) {
            this.paragraphId = paragraphId;
            return this;
        }
        public Long getParagraphId() {
            return this.paragraphId;
        }

        public QueryMinutesTextResponseBodyParagraphList setRecordId(Long recordId) {
            this.recordId = recordId;
            return this;
        }
        public Long getRecordId() {
            return this.recordId;
        }

        public QueryMinutesTextResponseBodyParagraphList setSentenceList(java.util.List<QueryMinutesTextResponseBodyParagraphListSentenceList> sentenceList) {
            this.sentenceList = sentenceList;
            return this;
        }
        public java.util.List<QueryMinutesTextResponseBodyParagraphListSentenceList> getSentenceList() {
            return this.sentenceList;
        }

        public QueryMinutesTextResponseBodyParagraphList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryMinutesTextResponseBodyParagraphList setSubSpeakerId(String subSpeakerId) {
            this.subSpeakerId = subSpeakerId;
            return this;
        }
        public String getSubSpeakerId() {
            return this.subSpeakerId;
        }

        public QueryMinutesTextResponseBodyParagraphList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
