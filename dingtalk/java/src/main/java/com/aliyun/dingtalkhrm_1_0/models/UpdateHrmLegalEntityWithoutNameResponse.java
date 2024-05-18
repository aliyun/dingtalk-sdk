// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateHrmLegalEntityWithoutNameResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateHrmLegalEntityWithoutNameResponseBody body;

    public static UpdateHrmLegalEntityWithoutNameResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateHrmLegalEntityWithoutNameResponse self = new UpdateHrmLegalEntityWithoutNameResponse();
        return TeaModel.build(map, self);
    }

    public UpdateHrmLegalEntityWithoutNameResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateHrmLegalEntityWithoutNameResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateHrmLegalEntityWithoutNameResponse setBody(UpdateHrmLegalEntityWithoutNameResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateHrmLegalEntityWithoutNameResponseBody getBody() {
        return this.body;
    }

}
