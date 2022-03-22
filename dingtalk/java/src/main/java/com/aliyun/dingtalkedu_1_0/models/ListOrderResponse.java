// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ListOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListOrderResponseBody body;

    public static ListOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        ListOrderResponse self = new ListOrderResponse();
        return TeaModel.build(map, self);
    }

    public ListOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListOrderResponse setBody(ListOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public ListOrderResponseBody getBody() {
        return this.body;
    }

}
