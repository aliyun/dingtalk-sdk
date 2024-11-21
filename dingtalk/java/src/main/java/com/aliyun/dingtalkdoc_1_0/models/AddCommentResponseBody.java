// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AddCommentResponseBody extends TeaModel {
    @NameInMap("result")
    public AddCommentResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AddCommentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCommentResponseBody self = new AddCommentResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCommentResponseBody setResult(AddCommentResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddCommentResponseBodyResult getResult() {
        return this.result;
    }

    public AddCommentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddCommentResponseBodyResult extends TeaModel {
        @NameInMap("commentId")
        public String commentId;

        public static AddCommentResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddCommentResponseBodyResult self = new AddCommentResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddCommentResponseBodyResult setCommentId(String commentId) {
            this.commentId = commentId;
            return this;
        }
        public String getCommentId() {
            return this.commentId;
        }

    }

}
