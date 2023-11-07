// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardQueryCardFeedsResponseBody extends TeaModel {
    @NameInMap("result")
    public CardQueryCardFeedsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CardQueryCardFeedsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CardQueryCardFeedsResponseBody self = new CardQueryCardFeedsResponseBody();
        return TeaModel.build(map, self);
    }

    public CardQueryCardFeedsResponseBody setResult(CardQueryCardFeedsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CardQueryCardFeedsResponseBodyResult getResult() {
        return this.result;
    }

    public CardQueryCardFeedsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CardQueryCardFeedsResponseBodyResultPostsAuthor extends TeaModel {
        @NameInMap("showName")
        public String showName;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userRole")
        public String userRole;

        public static CardQueryCardFeedsResponseBodyResultPostsAuthor build(java.util.Map<String, ?> map) throws Exception {
            CardQueryCardFeedsResponseBodyResultPostsAuthor self = new CardQueryCardFeedsResponseBodyResultPostsAuthor();
            return TeaModel.build(map, self);
        }

        public CardQueryCardFeedsResponseBodyResultPostsAuthor setShowName(String showName) {
            this.showName = showName;
            return this;
        }
        public String getShowName() {
            return this.showName;
        }

        public CardQueryCardFeedsResponseBodyResultPostsAuthor setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public CardQueryCardFeedsResponseBodyResultPostsAuthor setUserRole(String userRole) {
            this.userRole = userRole;
            return this;
        }
        public String getUserRole() {
            return this.userRole;
        }

    }

    public static class CardQueryCardFeedsResponseBodyResultPostsContent extends TeaModel {
        @NameInMap("contentType")
        public Integer contentType;

        @NameInMap("text")
        public String text;

        public static CardQueryCardFeedsResponseBodyResultPostsContent build(java.util.Map<String, ?> map) throws Exception {
            CardQueryCardFeedsResponseBodyResultPostsContent self = new CardQueryCardFeedsResponseBodyResultPostsContent();
            return TeaModel.build(map, self);
        }

        public CardQueryCardFeedsResponseBodyResultPostsContent setContentType(Integer contentType) {
            this.contentType = contentType;
            return this;
        }
        public Integer getContentType() {
            return this.contentType;
        }

        public CardQueryCardFeedsResponseBodyResultPostsContent setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class CardQueryCardFeedsResponseBodyResultPosts extends TeaModel {
        @NameInMap("author")
        public CardQueryCardFeedsResponseBodyResultPostsAuthor author;

        @NameInMap("bizType")
        public Integer bizType;

        @NameInMap("content")
        public CardQueryCardFeedsResponseBodyResultPostsContent content;

        @NameInMap("createAt")
        public Long createAt;

        @NameInMap("feedType")
        public Integer feedType;

        @NameInMap("postId")
        public Long postId;

        @NameInMap("status")
        public Integer status;

        public static CardQueryCardFeedsResponseBodyResultPosts build(java.util.Map<String, ?> map) throws Exception {
            CardQueryCardFeedsResponseBodyResultPosts self = new CardQueryCardFeedsResponseBodyResultPosts();
            return TeaModel.build(map, self);
        }

        public CardQueryCardFeedsResponseBodyResultPosts setAuthor(CardQueryCardFeedsResponseBodyResultPostsAuthor author) {
            this.author = author;
            return this;
        }
        public CardQueryCardFeedsResponseBodyResultPostsAuthor getAuthor() {
            return this.author;
        }

        public CardQueryCardFeedsResponseBodyResultPosts setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public CardQueryCardFeedsResponseBodyResultPosts setContent(CardQueryCardFeedsResponseBodyResultPostsContent content) {
            this.content = content;
            return this;
        }
        public CardQueryCardFeedsResponseBodyResultPostsContent getContent() {
            return this.content;
        }

        public CardQueryCardFeedsResponseBodyResultPosts setCreateAt(Long createAt) {
            this.createAt = createAt;
            return this;
        }
        public Long getCreateAt() {
            return this.createAt;
        }

        public CardQueryCardFeedsResponseBodyResultPosts setFeedType(Integer feedType) {
            this.feedType = feedType;
            return this;
        }
        public Integer getFeedType() {
            return this.feedType;
        }

        public CardQueryCardFeedsResponseBodyResultPosts setPostId(Long postId) {
            this.postId = postId;
            return this;
        }
        public Long getPostId() {
            return this.postId;
        }

        public CardQueryCardFeedsResponseBodyResultPosts setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

    public static class CardQueryCardFeedsResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("posts")
        public java.util.List<CardQueryCardFeedsResponseBodyResultPosts> posts;

        public static CardQueryCardFeedsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CardQueryCardFeedsResponseBodyResult self = new CardQueryCardFeedsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CardQueryCardFeedsResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public CardQueryCardFeedsResponseBodyResult setPosts(java.util.List<CardQueryCardFeedsResponseBodyResultPosts> posts) {
            this.posts = posts;
            return this;
        }
        public java.util.List<CardQueryCardFeedsResponseBodyResultPosts> getPosts() {
            return this.posts;
        }

    }

}
