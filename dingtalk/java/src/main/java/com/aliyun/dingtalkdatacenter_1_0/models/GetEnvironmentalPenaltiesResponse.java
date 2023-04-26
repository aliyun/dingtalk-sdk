// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetEnvironmentalPenaltiesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetEnvironmentalPenaltiesResponseBody body;

    public static GetEnvironmentalPenaltiesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetEnvironmentalPenaltiesResponse self = new GetEnvironmentalPenaltiesResponse();
        return TeaModel.build(map, self);
    }

    public GetEnvironmentalPenaltiesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetEnvironmentalPenaltiesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetEnvironmentalPenaltiesResponse setBody(GetEnvironmentalPenaltiesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetEnvironmentalPenaltiesResponseBody getBody() {
        return this.body;
    }

}
