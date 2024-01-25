// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetOssTempUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOssTempUrlResponseBody body;

    public static GetOssTempUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOssTempUrlResponse self = new GetOssTempUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetOssTempUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOssTempUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOssTempUrlResponse setBody(GetOssTempUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOssTempUrlResponseBody getBody() {
        return this.body;
    }

}
