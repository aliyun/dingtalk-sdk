// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CancelSnsOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CancelSnsOrderResponseBody body;

    public static CancelSnsOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        CancelSnsOrderResponse self = new CancelSnsOrderResponse();
        return TeaModel.build(map, self);
    }

    public CancelSnsOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CancelSnsOrderResponse setBody(CancelSnsOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CancelSnsOrderResponseBody getBody() {
        return this.body;
    }

}
