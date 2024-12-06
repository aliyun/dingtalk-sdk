// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetFootprintTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFootprintTaskResponseBody body;

    public static GetFootprintTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFootprintTaskResponse self = new GetFootprintTaskResponse();
        return TeaModel.build(map, self);
    }

    public GetFootprintTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFootprintTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFootprintTaskResponse setBody(GetFootprintTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFootprintTaskResponseBody getBody() {
        return this.body;
    }

}
