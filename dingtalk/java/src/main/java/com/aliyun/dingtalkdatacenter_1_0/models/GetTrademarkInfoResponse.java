// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetTrademarkInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetTrademarkInfoResponseBody body;

    public static GetTrademarkInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTrademarkInfoResponse self = new GetTrademarkInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetTrademarkInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTrademarkInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTrademarkInfoResponse setBody(GetTrademarkInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTrademarkInfoResponseBody getBody() {
        return this.body;
    }

}
