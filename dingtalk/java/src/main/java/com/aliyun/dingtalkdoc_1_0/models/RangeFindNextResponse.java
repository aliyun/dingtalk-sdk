// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class RangeFindNextResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RangeFindNextResponseBody body;

    public static RangeFindNextResponse build(java.util.Map<String, ?> map) throws Exception {
        RangeFindNextResponse self = new RangeFindNextResponse();
        return TeaModel.build(map, self);
    }

    public RangeFindNextResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RangeFindNextResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RangeFindNextResponse setBody(RangeFindNextResponseBody body) {
        this.body = body;
        return this;
    }
    public RangeFindNextResponseBody getBody() {
        return this.body;
    }

}
