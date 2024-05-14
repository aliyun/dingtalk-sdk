// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetCommentListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("data")
    public java.util.List<GetCommentListResponseBodyData> data;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static GetCommentListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCommentListResponseBody self = new GetCommentListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCommentListResponseBody setData(java.util.List<GetCommentListResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetCommentListResponseBodyData> getData() {
        return this.data;
    }

    public GetCommentListResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetCommentListResponseBodyData extends TeaModel {
        @NameInMap("commentId")
        public String commentId;

        @NameInMap("commentTime")
        public Float commentTime;

        @NameInMap("commentUserName")
        public String commentUserName;

        @NameInMap("content")
        public String content;

        public static GetCommentListResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetCommentListResponseBodyData self = new GetCommentListResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetCommentListResponseBodyData setCommentId(String commentId) {
            this.commentId = commentId;
            return this;
        }
        public String getCommentId() {
            return this.commentId;
        }

        public GetCommentListResponseBodyData setCommentTime(Float commentTime) {
            this.commentTime = commentTime;
            return this;
        }
        public Float getCommentTime() {
            return this.commentTime;
        }

        public GetCommentListResponseBodyData setCommentUserName(String commentUserName) {
            this.commentUserName = commentUserName;
            return this;
        }
        public String getCommentUserName() {
            return this.commentUserName;
        }

        public GetCommentListResponseBodyData setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
