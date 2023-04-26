// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetMySpaceInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetMySpaceInfoResponseBody body;

    public static GetMySpaceInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMySpaceInfoResponse self = new GetMySpaceInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetMySpaceInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMySpaceInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMySpaceInfoResponse setBody(GetMySpaceInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMySpaceInfoResponseBody getBody() {
        return this.body;
    }

}
