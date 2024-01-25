// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class GetTravelProcessDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetTravelProcessDetailResponseBody body;

    public static GetTravelProcessDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTravelProcessDetailResponse self = new GetTravelProcessDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetTravelProcessDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTravelProcessDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTravelProcessDetailResponse setBody(GetTravelProcessDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTravelProcessDetailResponseBody getBody() {
        return this.body;
    }

}
