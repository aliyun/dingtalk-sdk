// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ListCommentsResponseBody extends TeaModel {
    @NameInMap("result")
    public ListCommentsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static ListCommentsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListCommentsResponseBody self = new ListCommentsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListCommentsResponseBody setResult(ListCommentsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListCommentsResponseBodyResult getResult() {
        return this.result;
    }

    public ListCommentsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListCommentsResponseBodyResultCommentListContent extends TeaModel {
        @NameInMap("elements")
        public java.util.List<?> elements;

        public static ListCommentsResponseBodyResultCommentListContent build(java.util.Map<String, ?> map) throws Exception {
            ListCommentsResponseBodyResultCommentListContent self = new ListCommentsResponseBodyResultCommentListContent();
            return TeaModel.build(map, self);
        }

        public ListCommentsResponseBodyResultCommentListContent setElements(java.util.List<?> elements) {
            this.elements = elements;
            return this;
        }
        public java.util.List<?> getElements() {
            return this.elements;
        }

    }

    public static class ListCommentsResponseBodyResultCommentList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>comment_id</p>
         */
        @NameInMap("commentId")
        public String commentId;

        @NameInMap("content")
        public ListCommentsResponseBodyResultCommentListContent content;

        @NameInMap("createTime")
        public Long createTime;

        /**
         * <strong>example:</strong>
         * <p>user_id</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("isGlobal")
        public Boolean isGlobal;

        /**
         * <strong>example:</strong>
         * <p>quote</p>
         */
        @NameInMap("isSolved")
        public Boolean isSolved;

        /**
         * <strong>example:</strong>
         * <p>quote</p>
         */
        @NameInMap("quote")
        public String quote;

        /**
         * <strong>example:</strong>
         * <p>topic_id</p>
         */
        @NameInMap("topicId")
        public String topicId;

        @NameInMap("updateTime")
        public Long updateTime;

        public static ListCommentsResponseBodyResultCommentList build(java.util.Map<String, ?> map) throws Exception {
            ListCommentsResponseBodyResultCommentList self = new ListCommentsResponseBodyResultCommentList();
            return TeaModel.build(map, self);
        }

        public ListCommentsResponseBodyResultCommentList setCommentId(String commentId) {
            this.commentId = commentId;
            return this;
        }
        public String getCommentId() {
            return this.commentId;
        }

        public ListCommentsResponseBodyResultCommentList setContent(ListCommentsResponseBodyResultCommentListContent content) {
            this.content = content;
            return this;
        }
        public ListCommentsResponseBodyResultCommentListContent getContent() {
            return this.content;
        }

        public ListCommentsResponseBodyResultCommentList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public ListCommentsResponseBodyResultCommentList setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public ListCommentsResponseBodyResultCommentList setIsGlobal(Boolean isGlobal) {
            this.isGlobal = isGlobal;
            return this;
        }
        public Boolean getIsGlobal() {
            return this.isGlobal;
        }

        public ListCommentsResponseBodyResultCommentList setIsSolved(Boolean isSolved) {
            this.isSolved = isSolved;
            return this;
        }
        public Boolean getIsSolved() {
            return this.isSolved;
        }

        public ListCommentsResponseBodyResultCommentList setQuote(String quote) {
            this.quote = quote;
            return this;
        }
        public String getQuote() {
            return this.quote;
        }

        public ListCommentsResponseBodyResultCommentList setTopicId(String topicId) {
            this.topicId = topicId;
            return this;
        }
        public String getTopicId() {
            return this.topicId;
        }

        public ListCommentsResponseBodyResultCommentList setUpdateTime(Long updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public Long getUpdateTime() {
            return this.updateTime;
        }

    }

    public static class ListCommentsResponseBodyResult extends TeaModel {
        @NameInMap("commentList")
        public java.util.List<ListCommentsResponseBodyResultCommentList> commentList;

        @NameInMap("hasMore")
        public Boolean hasMore;

        /**
         * <strong>example:</strong>
         * <p>next_token</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        public static ListCommentsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListCommentsResponseBodyResult self = new ListCommentsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListCommentsResponseBodyResult setCommentList(java.util.List<ListCommentsResponseBodyResultCommentList> commentList) {
            this.commentList = commentList;
            return this;
        }
        public java.util.List<ListCommentsResponseBodyResultCommentList> getCommentList() {
            return this.commentList;
        }

        public ListCommentsResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public ListCommentsResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
