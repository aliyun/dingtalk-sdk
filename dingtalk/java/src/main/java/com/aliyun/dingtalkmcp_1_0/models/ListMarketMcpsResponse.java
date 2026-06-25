// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class ListMarketMcpsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListMarketMcpsResponseBody body;

    public static ListMarketMcpsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListMarketMcpsResponse self = new ListMarketMcpsResponse();
        return TeaModel.build(map, self);
    }

    public ListMarketMcpsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListMarketMcpsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListMarketMcpsResponse setBody(ListMarketMcpsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListMarketMcpsResponseBody getBody() {
        return this.body;
    }

}
