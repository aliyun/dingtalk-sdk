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
        /**
         * <strong>example:</strong>
         * <p>博澜爸爸</p>
         */
        @NameInMap("showName")
        public String showName;

        /**
         * <strong>example:</strong>
         * <p>234234234</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>guardian</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("contentType")
        public Integer contentType;

        /**
         * <strong>example:</strong>
         * <p>{&quot;cardEditRedirectDTO&quot;:{&quot;jumpType&quot;:&quot;internal&quot;},&quot;content&quot;:&quot;测试&quot;,&quot;medias&quot;:&quot;\&quot;[{\\\&quot;type\\\&quot;:\\\&quot;image\\\&quot;,\\\&quot;data\\\&quot;:{\\\&quot;mediaUrl\\\&quot;:\\\&quot;<a href="https://static.dingtalk.com/media/lQDPNDWzHQNv3fjNBQDNAlCwKIvuyoJrOfAFLEMmYrpsAA_592_1280.jpg%5C%5C%5C%5C%5C%5C%5C%22,%5C%5C%5C%5C%5C%5C%5C%22thumbnailUrl%5C%5C%5C%5C%5C%5C%5C%22:%5C%5C%5C%5C%5C%5C%5C%22https://static.dingtalk.com/media/lQDPNDWzHQNv3fjNBQDNAlCwKIvuyoJrOfAFLEMmYrpsAA_592_1280.jpg_200x200.jpg?bizType=edu_card%5C%5C%5C%5C%5C%5C%5C%22%7D%7D%5D%5C%5C%5C%22%5C%22,%5C%22reissueCard%5C%22:false,%5C%22resultEvaluation%5C%22:%5C%22%5C%22,%5C%22showName%5C%22:%5C%22%E5%8D%9A%E6%BE%9C%E7%88%B8%E7%88%B8%5C%22,%5C%22sourceType%5C%22:%5C%22%5C%22,%5C%22studentId%5C%22:%5C%223000000000847390208%5C%22,%5C%22unitOfMeasurement%5C%22:%5C%22%5C%22%7D">https://static.dingtalk.com/media/lQDPNDWzHQNv3fjNBQDNAlCwKIvuyoJrOfAFLEMmYrpsAA_592_1280.jpg\\\\\\\&quot;,\\\\\\\&quot;thumbnailUrl\\\\\\\&quot;:\\\\\\\&quot;https://static.dingtalk.com/media/lQDPNDWzHQNv3fjNBQDNAlCwKIvuyoJrOfAFLEMmYrpsAA_592_1280.jpg_200x200.jpg?bizType=edu_card\\\\\\\&quot;}}]\\\&quot;\&quot;,\&quot;reissueCard\&quot;:false,\&quot;resultEvaluation\&quot;:\&quot;\&quot;,\&quot;showName\&quot;:\&quot;博澜爸爸\&quot;,\&quot;sourceType\&quot;:\&quot;\&quot;,\&quot;studentId\&quot;:\&quot;3000000000847390208\&quot;,\&quot;unitOfMeasurement\&quot;:\&quot;\&quot;}</a></p>
         */
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

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("bizType")
        public Integer bizType;

        @NameInMap("content")
        public CardQueryCardFeedsResponseBodyResultPostsContent content;

        /**
         * <strong>example:</strong>
         * <p>23424234234</p>
         */
        @NameInMap("createAt")
        public Long createAt;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("feedType")
        public Integer feedType;

        /**
         * <strong>example:</strong>
         * <p>232423423</p>
         */
        @NameInMap("postId")
        public Long postId;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
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
