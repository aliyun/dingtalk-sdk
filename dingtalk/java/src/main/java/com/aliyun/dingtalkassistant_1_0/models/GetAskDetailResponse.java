// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class GetAskDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAskDetailResponseBody body;

    public static GetAskDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAskDetailResponse self = new GetAskDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetAskDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAskDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAskDetailResponse setBody(GetAskDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAskDetailResponseBody getBody() {
        return this.body;
    }

}
