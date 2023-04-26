// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAdministrativeLicensingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetAdministrativeLicensingResponseBody body;

    public static GetAdministrativeLicensingResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAdministrativeLicensingResponse self = new GetAdministrativeLicensingResponse();
        return TeaModel.build(map, self);
    }

    public GetAdministrativeLicensingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAdministrativeLicensingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAdministrativeLicensingResponse setBody(GetAdministrativeLicensingResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAdministrativeLicensingResponseBody getBody() {
        return this.body;
    }

}
