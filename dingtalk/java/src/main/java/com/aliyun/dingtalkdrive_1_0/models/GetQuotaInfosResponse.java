// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetQuotaInfosResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetQuotaInfosResponseBody body;

    public static GetQuotaInfosResponse build(java.util.Map<String, ?> map) throws Exception {
        GetQuotaInfosResponse self = new GetQuotaInfosResponse();
        return TeaModel.build(map, self);
    }

    public GetQuotaInfosResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetQuotaInfosResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetQuotaInfosResponse setBody(GetQuotaInfosResponseBody body) {
        this.body = body;
        return this;
    }
    public GetQuotaInfosResponseBody getBody() {
        return this.body;
    }

}
