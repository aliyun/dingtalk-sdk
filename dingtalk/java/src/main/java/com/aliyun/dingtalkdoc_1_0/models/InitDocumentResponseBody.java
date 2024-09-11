// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InitDocumentResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, ?> result;

    @NameInMap("success")
    public Boolean success;

    public static InitDocumentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InitDocumentResponseBody self = new InitDocumentResponseBody();
        return TeaModel.build(map, self);
    }

    public InitDocumentResponseBody setResult(java.util.Map<String, ?> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ?> getResult() {
        return this.result;
    }

    public InitDocumentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
