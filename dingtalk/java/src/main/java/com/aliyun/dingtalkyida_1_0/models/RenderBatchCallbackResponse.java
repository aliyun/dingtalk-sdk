// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RenderBatchCallbackResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static RenderBatchCallbackResponse build(java.util.Map<String, ?> map) throws Exception {
        RenderBatchCallbackResponse self = new RenderBatchCallbackResponse();
        return TeaModel.build(map, self);
    }

    public RenderBatchCallbackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
