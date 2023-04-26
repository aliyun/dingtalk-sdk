// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListCommodityResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListCommodityResponseBody body;

    public static ListCommodityResponse build(java.util.Map<String, ?> map) throws Exception {
        ListCommodityResponse self = new ListCommodityResponse();
        return TeaModel.build(map, self);
    }

    public ListCommodityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListCommodityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListCommodityResponse setBody(ListCommodityResponseBody body) {
        this.body = body;
        return this;
    }
    public ListCommodityResponseBody getBody() {
        return this.body;
    }

}
