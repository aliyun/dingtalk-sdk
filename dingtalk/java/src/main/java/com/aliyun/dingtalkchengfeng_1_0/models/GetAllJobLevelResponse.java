// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetAllJobLevelResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAllJobLevelResponseBody body;

    public static GetAllJobLevelResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAllJobLevelResponse self = new GetAllJobLevelResponse();
        return TeaModel.build(map, self);
    }

    public GetAllJobLevelResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAllJobLevelResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAllJobLevelResponse setBody(GetAllJobLevelResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAllJobLevelResponseBody getBody() {
        return this.body;
    }

}
