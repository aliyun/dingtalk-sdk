// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAdministrativePenaltiesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAdministrativePenaltiesResponseBody body;

    public static GetAdministrativePenaltiesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAdministrativePenaltiesResponse self = new GetAdministrativePenaltiesResponse();
        return TeaModel.build(map, self);
    }

    public GetAdministrativePenaltiesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAdministrativePenaltiesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAdministrativePenaltiesResponse setBody(GetAdministrativePenaltiesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAdministrativePenaltiesResponseBody getBody() {
        return this.body;
    }

}
