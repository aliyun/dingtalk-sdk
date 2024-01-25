// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetBasicInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetBasicInfoResponseBody body;

    public static GetBasicInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBasicInfoResponse self = new GetBasicInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetBasicInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetBasicInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetBasicInfoResponse setBody(GetBasicInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetBasicInfoResponseBody getBody() {
        return this.body;
    }

}
