// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class GetBaseProfileListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetBaseProfileListResponseBody body;

    public static GetBaseProfileListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBaseProfileListResponse self = new GetBaseProfileListResponse();
        return TeaModel.build(map, self);
    }

    public GetBaseProfileListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetBaseProfileListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetBaseProfileListResponse setBody(GetBaseProfileListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetBaseProfileListResponseBody getBody() {
        return this.body;
    }

}
