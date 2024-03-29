// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetNegativeWordCloudResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetNegativeWordCloudResponseBody body;

    public static GetNegativeWordCloudResponse build(java.util.Map<String, ?> map) throws Exception {
        GetNegativeWordCloudResponse self = new GetNegativeWordCloudResponse();
        return TeaModel.build(map, self);
    }

    public GetNegativeWordCloudResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetNegativeWordCloudResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetNegativeWordCloudResponse setBody(GetNegativeWordCloudResponseBody body) {
        this.body = body;
        return this;
    }
    public GetNegativeWordCloudResponseBody getBody() {
        return this.body;
    }

}
