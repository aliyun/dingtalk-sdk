// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetWordCloudResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetWordCloudResponseBody body;

    public static GetWordCloudResponse build(java.util.Map<String, ?> map) throws Exception {
        GetWordCloudResponse self = new GetWordCloudResponse();
        return TeaModel.build(map, self);
    }

    public GetWordCloudResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetWordCloudResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetWordCloudResponse setBody(GetWordCloudResponseBody body) {
        this.body = body;
        return this;
    }
    public GetWordCloudResponseBody getBody() {
        return this.body;
    }

}
