// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateHrmLegalEntityNameResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateHrmLegalEntityNameResponseBody body;

    public static UpdateHrmLegalEntityNameResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateHrmLegalEntityNameResponse self = new UpdateHrmLegalEntityNameResponse();
        return TeaModel.build(map, self);
    }

    public UpdateHrmLegalEntityNameResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateHrmLegalEntityNameResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateHrmLegalEntityNameResponse setBody(UpdateHrmLegalEntityNameResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateHrmLegalEntityNameResponseBody getBody() {
        return this.body;
    }

}
