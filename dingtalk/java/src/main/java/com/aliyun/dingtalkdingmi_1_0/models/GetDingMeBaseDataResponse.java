// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetDingMeBaseDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDingMeBaseDataResponseBody body;

    public static GetDingMeBaseDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDingMeBaseDataResponse self = new GetDingMeBaseDataResponse();
        return TeaModel.build(map, self);
    }

    public GetDingMeBaseDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDingMeBaseDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDingMeBaseDataResponse setBody(GetDingMeBaseDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDingMeBaseDataResponseBody getBody() {
        return this.body;
    }

}
