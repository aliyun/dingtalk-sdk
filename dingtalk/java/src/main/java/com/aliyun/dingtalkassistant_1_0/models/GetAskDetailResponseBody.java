// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class GetAskDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public GetAskDetailResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetAskDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAskDetailResponseBody self = new GetAskDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAskDetailResponseBody setResult(GetAskDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetAskDetailResponseBodyResult getResult() {
        return this.result;
    }

    public GetAskDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetAskDetailResponseBodyResultListReferences extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("url")
        public String url;

        public static GetAskDetailResponseBodyResultListReferences build(java.util.Map<String, ?> map) throws Exception {
            GetAskDetailResponseBodyResultListReferences self = new GetAskDetailResponseBodyResultListReferences();
            return TeaModel.build(map, self);
        }

        public GetAskDetailResponseBodyResultListReferences setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetAskDetailResponseBodyResultListReferences setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetAskDetailResponseBodyResultList extends TeaModel {
        @NameInMap("answer")
        public String answer;

        @NameInMap("answerResult")
        public String answerResult;

        @NameInMap("commentTags")
        public java.util.List<String> commentTags;

        @NameInMap("isMarkResolved")
        public Boolean isMarkResolved;

        @NameInMap("nick")
        public String nick;

        @NameInMap("question")
        public String question;

        @NameInMap("references")
        public java.util.List<GetAskDetailResponseBodyResultListReferences> references;

        @NameInMap("time")
        public Long time;

        public static GetAskDetailResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            GetAskDetailResponseBodyResultList self = new GetAskDetailResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public GetAskDetailResponseBodyResultList setAnswer(String answer) {
            this.answer = answer;
            return this;
        }
        public String getAnswer() {
            return this.answer;
        }

        public GetAskDetailResponseBodyResultList setAnswerResult(String answerResult) {
            this.answerResult = answerResult;
            return this;
        }
        public String getAnswerResult() {
            return this.answerResult;
        }

        public GetAskDetailResponseBodyResultList setCommentTags(java.util.List<String> commentTags) {
            this.commentTags = commentTags;
            return this;
        }
        public java.util.List<String> getCommentTags() {
            return this.commentTags;
        }

        public GetAskDetailResponseBodyResultList setIsMarkResolved(Boolean isMarkResolved) {
            this.isMarkResolved = isMarkResolved;
            return this;
        }
        public Boolean getIsMarkResolved() {
            return this.isMarkResolved;
        }

        public GetAskDetailResponseBodyResultList setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public GetAskDetailResponseBodyResultList setQuestion(String question) {
            this.question = question;
            return this;
        }
        public String getQuestion() {
            return this.question;
        }

        public GetAskDetailResponseBodyResultList setReferences(java.util.List<GetAskDetailResponseBodyResultListReferences> references) {
            this.references = references;
            return this;
        }
        public java.util.List<GetAskDetailResponseBodyResultListReferences> getReferences() {
            return this.references;
        }

        public GetAskDetailResponseBodyResultList setTime(Long time) {
            this.time = time;
            return this;
        }
        public Long getTime() {
            return this.time;
        }

    }

    public static class GetAskDetailResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<GetAskDetailResponseBodyResultList> list;

        @NameInMap("nextCursor")
        public Long nextCursor;

        @NameInMap("totalCount")
        public Integer totalCount;

        public static GetAskDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetAskDetailResponseBodyResult self = new GetAskDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetAskDetailResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetAskDetailResponseBodyResult setList(java.util.List<GetAskDetailResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<GetAskDetailResponseBodyResultList> getList() {
            return this.list;
        }

        public GetAskDetailResponseBodyResult setNextCursor(Long nextCursor) {
            this.nextCursor = nextCursor;
            return this;
        }
        public Long getNextCursor() {
            return this.nextCursor;
        }

        public GetAskDetailResponseBodyResult setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

}
