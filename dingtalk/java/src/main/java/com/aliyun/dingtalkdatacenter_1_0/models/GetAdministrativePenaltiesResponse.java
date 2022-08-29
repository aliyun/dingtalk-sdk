// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAdministrativePenaltiesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetAdministrativePenaltiesResponse setBody(GetAdministrativePenaltiesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAdministrativePenaltiesResponseBody getBody() {
        return this.body;
    }

}
