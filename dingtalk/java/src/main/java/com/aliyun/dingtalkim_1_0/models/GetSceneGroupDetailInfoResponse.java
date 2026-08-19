// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupDetailInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSceneGroupDetailInfoResponseBody body;

    public static GetSceneGroupDetailInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSceneGroupDetailInfoResponse self = new GetSceneGroupDetailInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetSceneGroupDetailInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSceneGroupDetailInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSceneGroupDetailInfoResponse setBody(GetSceneGroupDetailInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSceneGroupDetailInfoResponseBody getBody() {
        return this.body;
    }

}
