// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetIndicatorDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetIndicatorDetailResponseBody body;

    public static GetIndicatorDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetIndicatorDetailResponse self = new GetIndicatorDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetIndicatorDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetIndicatorDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetIndicatorDetailResponse setBody(GetIndicatorDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetIndicatorDetailResponseBody getBody() {
        return this.body;
    }

}
