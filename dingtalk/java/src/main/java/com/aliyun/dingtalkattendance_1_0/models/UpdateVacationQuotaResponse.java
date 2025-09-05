// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class UpdateVacationQuotaResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateVacationQuotaResponseBody body;

    public static UpdateVacationQuotaResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateVacationQuotaResponse self = new UpdateVacationQuotaResponse();
        return TeaModel.build(map, self);
    }

    public UpdateVacationQuotaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateVacationQuotaResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateVacationQuotaResponse setBody(UpdateVacationQuotaResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateVacationQuotaResponseBody getBody() {
        return this.body;
    }

}
