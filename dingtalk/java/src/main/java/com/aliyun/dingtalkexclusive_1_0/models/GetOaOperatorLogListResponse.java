// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetOaOperatorLogListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOaOperatorLogListResponseBody body;

    public static GetOaOperatorLogListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOaOperatorLogListResponse self = new GetOaOperatorLogListResponse();
        return TeaModel.build(map, self);
    }

    public GetOaOperatorLogListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOaOperatorLogListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOaOperatorLogListResponse setBody(GetOaOperatorLogListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOaOperatorLogListResponseBody getBody() {
        return this.body;
    }

}
