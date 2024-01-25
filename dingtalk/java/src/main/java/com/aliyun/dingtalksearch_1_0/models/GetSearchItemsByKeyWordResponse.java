// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchItemsByKeyWordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSearchItemsByKeyWordResponseBody body;

    public static GetSearchItemsByKeyWordResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSearchItemsByKeyWordResponse self = new GetSearchItemsByKeyWordResponse();
        return TeaModel.build(map, self);
    }

    public GetSearchItemsByKeyWordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSearchItemsByKeyWordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSearchItemsByKeyWordResponse setBody(GetSearchItemsByKeyWordResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSearchItemsByKeyWordResponseBody getBody() {
        return this.body;
    }

}
