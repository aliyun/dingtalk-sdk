// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetObjectiveDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetObjectiveDetailResponseBody body;

    public static GetObjectiveDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetObjectiveDetailResponse self = new GetObjectiveDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetObjectiveDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetObjectiveDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetObjectiveDetailResponse setBody(GetObjectiveDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetObjectiveDetailResponseBody getBody() {
        return this.body;
    }

}
