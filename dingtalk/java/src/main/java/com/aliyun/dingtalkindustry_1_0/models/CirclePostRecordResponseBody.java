// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CirclePostRecordResponseBody extends TeaModel {
    @NameInMap("result")
    public CirclePostRecordResponseBodyResult result;

    public static CirclePostRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CirclePostRecordResponseBody self = new CirclePostRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public CirclePostRecordResponseBody setResult(CirclePostRecordResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CirclePostRecordResponseBodyResult getResult() {
        return this.result;
    }

    public static class CirclePostRecordResponseBodyResultPostsList extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("postId")
        public Long postId;

        @NameInMap("title")
        public String title;

        @NameInMap("userName")
        public String userName;

        public static CirclePostRecordResponseBodyResultPostsList build(java.util.Map<String, ?> map) throws Exception {
            CirclePostRecordResponseBodyResultPostsList self = new CirclePostRecordResponseBodyResultPostsList();
            return TeaModel.build(map, self);
        }

        public CirclePostRecordResponseBodyResultPostsList setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public CirclePostRecordResponseBodyResultPostsList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public CirclePostRecordResponseBodyResultPostsList setPostId(Long postId) {
            this.postId = postId;
            return this;
        }
        public Long getPostId() {
            return this.postId;
        }

        public CirclePostRecordResponseBodyResultPostsList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CirclePostRecordResponseBodyResultPostsList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

    public static class CirclePostRecordResponseBodyResult extends TeaModel {
        @NameInMap("direction")
        public Long direction;

        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("lastPostId")
        public Long lastPostId;

        @NameInMap("postsList")
        public java.util.List<CirclePostRecordResponseBodyResultPostsList> postsList;

        public static CirclePostRecordResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CirclePostRecordResponseBodyResult self = new CirclePostRecordResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CirclePostRecordResponseBodyResult setDirection(Long direction) {
            this.direction = direction;
            return this;
        }
        public Long getDirection() {
            return this.direction;
        }

        public CirclePostRecordResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public CirclePostRecordResponseBodyResult setLastPostId(Long lastPostId) {
            this.lastPostId = lastPostId;
            return this;
        }
        public Long getLastPostId() {
            return this.lastPostId;
        }

        public CirclePostRecordResponseBodyResult setPostsList(java.util.List<CirclePostRecordResponseBodyResultPostsList> postsList) {
            this.postsList = postsList;
            return this;
        }
        public java.util.List<CirclePostRecordResponseBodyResultPostsList> getPostsList() {
            return this.postsList;
        }

    }

}
