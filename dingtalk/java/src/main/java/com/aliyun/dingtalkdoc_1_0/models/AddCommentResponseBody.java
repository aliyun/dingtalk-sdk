// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AddCommentResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddCommentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCommentResponseBody self = new AddCommentResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCommentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
