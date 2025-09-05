// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetJobInfoByJobIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetJobInfoByJobIdResponseBody body;

    public static GetJobInfoByJobIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetJobInfoByJobIdResponse self = new GetJobInfoByJobIdResponse();
        return TeaModel.build(map, self);
    }

    public GetJobInfoByJobIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetJobInfoByJobIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetJobInfoByJobIdResponse setBody(GetJobInfoByJobIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetJobInfoByJobIdResponseBody getBody() {
        return this.body;
    }

}
