// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ChannelOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ChannelOrderResponseBody body;

    public static ChannelOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        ChannelOrderResponse self = new ChannelOrderResponse();
        return TeaModel.build(map, self);
    }

    public ChannelOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChannelOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChannelOrderResponse setBody(ChannelOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public ChannelOrderResponseBody getBody() {
        return this.body;
    }

}
