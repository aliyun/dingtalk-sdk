// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordTextResponseBody extends TeaModel {
    /**
     * <p>是否有更多</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>段落列表</p>
     */
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
        /**
         * <p>结束时间</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>开始时间</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <p>单词</p>
         */
        @NameInMap("word")
        public String word;

        /**
         * <p>单词id</p>
         */
        @NameInMap("wordId")
        public String wordId;

        public static QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList build(java.util.Map<String, ?> map) throws Exception {
            QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList self = new QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList();
            return TeaModel.build(map, self);
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList setWord(String word) {
            this.word = word;
            return this;
        }
        public String getWord() {
            return this.word;
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
        /**
         * <p>结束时间</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>句子</p>
         */
        @NameInMap("sentence")
        public String sentence;

        /**
         * <p>开始时间</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <p>用户unionId</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <p>单词列表</p>
         */
        @NameInMap("wordList")
        public java.util.List<QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList> wordList;

        public static QueryCloudRecordTextResponseBodyParagraphListSentenceList build(java.util.Map<String, ?> map) throws Exception {
            QueryCloudRecordTextResponseBodyParagraphListSentenceList self = new QueryCloudRecordTextResponseBodyParagraphListSentenceList();
            return TeaModel.build(map, self);
        }

        public QueryCloudRecordTextResponseBodyParagraphListSentenceList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
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

        public QueryCloudRecordTextResponseBodyParagraphListSentenceList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
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
        /**
         * <p>结束时间，毫秒</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>游标，下次查询时使用</p>
         */
        @NameInMap("nextTtoken")
        public Long nextTtoken;

        /**
         * <p>发言人昵称</p>
         */
        @NameInMap("nickName")
        public String nickName;

        /**
         * <p>段落内容</p>
         */
        @NameInMap("paragraph")
        public String paragraph;

        /**
         * <p>云录制id</p>
         */
        @NameInMap("recordId")
        public Long recordId;

        /**
         * <p>句子列表</p>
         */
        @NameInMap("sentenceList")
        public java.util.List<QueryCloudRecordTextResponseBodyParagraphListSentenceList> sentenceList;

        /**
         * <p>开始时间，毫秒</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <p>状态，暂不解析</p>
         */
        @NameInMap("status")
        public Long status;

        /**
         * <p>发言人unionId</p>
         */
        @NameInMap("unionId")
        public String unionId;

        public static QueryCloudRecordTextResponseBodyParagraphList build(java.util.Map<String, ?> map) throws Exception {
            QueryCloudRecordTextResponseBodyParagraphList self = new QueryCloudRecordTextResponseBodyParagraphList();
            return TeaModel.build(map, self);
        }

        public QueryCloudRecordTextResponseBodyParagraphList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setNextTtoken(Long nextTtoken) {
            this.nextTtoken = nextTtoken;
            return this;
        }
        public Long getNextTtoken() {
            return this.nextTtoken;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setParagraph(String paragraph) {
            this.paragraph = paragraph;
            return this;
        }
        public String getParagraph() {
            return this.paragraph;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setRecordId(Long recordId) {
            this.recordId = recordId;
            return this;
        }
        public Long getRecordId() {
            return this.recordId;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setSentenceList(java.util.List<QueryCloudRecordTextResponseBodyParagraphListSentenceList> sentenceList) {
            this.sentenceList = sentenceList;
            return this;
        }
        public java.util.List<QueryCloudRecordTextResponseBodyParagraphListSentenceList> getSentenceList() {
            return this.sentenceList;
        }

        public QueryCloudRecordTextResponseBodyParagraphList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
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

    }

}
