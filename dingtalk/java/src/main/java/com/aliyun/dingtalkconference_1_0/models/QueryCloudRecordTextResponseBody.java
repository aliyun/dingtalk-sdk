// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordTextResponseBody extends TeaModel {
    // 是否有更多
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 段落列表
    @NameInMap("paragraphList")
    public java.util.List<QueryCloudRecordTextResponseBodyParagraphList> paragraphList;

    public static QueryCloudRecordTextResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCloudRecordTextResponseBody self = new QueryCloudRecordTextResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCloudRecordTextResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryCloudRecordTextResponseBody setParagraphList(java.util.List<QueryCloudRecordTextResponseBodyParagraphList> paragraphList) {
        this.paragraphList = paragraphList;
        return this;
    }
    public java.util.List<QueryCloudRecordTextResponseBodyParagraphList> getParagraphList() {
        return this.paragraphList;
    }

    public static class QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList extends TeaModel {
        // 单词
        @NameInMap("word")
        public String word;

        // 开始时间
        @NameInMap("startTime")
        public Long startTime;

        // 结束时间
        @NameInMap("endTime")
        public Long endTime;

        // 单词id
        @NameInMap("wordId")
        public String wordId;

        public static QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList build(java.util.Map<String, ?> map) throws Exception {
            QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList self = new QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList();
            return TeaModel.build(map, self);
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList setWord(String word) {
            this.word = word;
            return this;
        }
        public String getWord() {
            return this.word;
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList setWordId(String wordId) {
            this.wordId = wordId;
            return this;
        }
        public String getWordId() {
            return this.wordId;
        }

    }

    public static class QueryCloudRecordTextResponseBodyParagraphListSentenceList extends TeaModel {
        // 用户unionId
        @NameInMap("unionId")
        public String unionId;

        // 句子
        @NameInMap("sentence")
        public String sentence;

        // 开始时间
        @NameInMap("startTime")
        public Long startTime;

        // 结束时间
        @NameInMap("endTime")
        public Long endTime;

        // 单词列表
        @NameInMap("wordList")
        public java.util.List<QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList> wordList;

        public static QueryCloudRecordTextResponseBodyParagraphListSentenceList build(java.util.Map<String, ?> map) throws Exception {
            QueryCloudRecordTextResponseBodyParagraphListSentenceList self = new QueryCloudRecordTextResponseBodyParagraphListSentenceList();
            return TeaModel.build(map, self);
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceList setSentence(String sentence) {
            this.sentence = sentence;
            return this;
        }
        public String getSentence() {
            return this.sentence;
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceList setWordList(java.util.List<QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList> wordList) {
            this.wordList = wordList;
            return this;
        }
        public java.util.List<QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList> getWordList() {
            return this.wordList;
        }

    }

    public static class QueryCloudRecordTextResponseBodyParagraphList extends TeaModel {
        // 游标，下次查询时使用
        @NameInMap("nextTtoken")
        public Long nextTtoken;

        // 状态，暂不解析
        @NameInMap("status")
        public Long status;

        // 发言人unionId
        @NameInMap("unionId")
        public String unionId;

        // 发言人昵称
        @NameInMap("nickName")
        public String nickName;

        // 云录制id
        @NameInMap("recordId")
        public Long recordId;

        // 开始时间，毫秒
        @NameInMap("startTime")
        public Long startTime;

        // 结束时间，毫秒
        @NameInMap("endTime")
        public Long endTime;

        // 段落内容
        @NameInMap("paragraph")
        public String paragraph;

        // 句子列表
        @NameInMap("sentenceList")
        public java.util.List<QueryCloudRecordTextResponseBodyParagraphListSentenceList> sentenceList;

        public static QueryCloudRecordTextResponseBodyParagraphList build(java.util.Map<String, ?> map) throws Exception {
            QueryCloudRecordTextResponseBodyParagraphList self = new QueryCloudRecordTextResponseBodyParagraphList();
            return TeaModel.build(map, self);
        }

        public QueryCloudRecordTextResponseBodyParagraphList setNextTtoken(Long nextTtoken) {
            this.nextTtoken = nextTtoken;
            return this;
        }
        public Long getNextTtoken() {
            return this.nextTtoken;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setRecordId(Long recordId) {
            this.recordId = recordId;
            return this;
        }
        public Long getRecordId() {
            return this.recordId;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setParagraph(String paragraph) {
            this.paragraph = paragraph;
            return this;
        }
        public String getParagraph() {
            return this.paragraph;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setSentenceList(java.util.List<QueryCloudRecordTextResponseBodyParagraphListSentenceList> sentenceList) {
            this.sentenceList = sentenceList;
            return this;
        }
        public java.util.List<QueryCloudRecordTextResponseBodyParagraphListSentenceList> getSentenceList() {
            return this.sentenceList;
        }

    }

}
