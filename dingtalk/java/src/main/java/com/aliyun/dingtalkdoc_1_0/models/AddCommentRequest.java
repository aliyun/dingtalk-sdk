// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AddCommentRequest extends TeaModel {
    @NameInMap("commentContent")
    public String commentContent;

    @NameInMap("commentType")
    public String commentType;

    @NameInMap("option")
    public AddCommentRequestOption option;

    @NameInMap("operatorId")
    public String operatorId;

    public static AddCommentRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCommentRequest self = new AddCommentRequest();
        return TeaModel.build(map, self);
    }

    public AddCommentRequest setCommentContent(String commentContent) {
        this.commentContent = commentContent;
        return this;
    }
    public String getCommentContent() {
        return this.commentContent;
    }

    public AddCommentRequest setCommentType(String commentType) {
        this.commentType = commentType;
        return this;
    }
    public String getCommentType() {
        return this.commentType;
    }

    public AddCommentRequest setOption(AddCommentRequestOption option) {
        this.option = option;
        return this;
    }
    public AddCommentRequestOption getOption() {
        return this.option;
    }

    public AddCommentRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class AddCommentRequestOption extends TeaModel {
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("extra")
        public java.util.Map<String, String> extra;

        public static AddCommentRequestOption build(java.util.Map<String, ?> map) throws Exception {
            AddCommentRequestOption self = new AddCommentRequestOption();
            return TeaModel.build(map, self);
        }

        public AddCommentRequestOption setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public AddCommentRequestOption setExtra(java.util.Map<String, String> extra) {
            this.extra = extra;
            return this;
        }
        public java.util.Map<String, String> getExtra() {
            return this.extra;
        }

    }

}
