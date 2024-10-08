// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class CreateOrUpdateFormDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateOrUpdateFormDataResponseBody body;

    public static CreateOrUpdateFormDataResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateOrUpdateFormDataResponse self = new CreateOrUpdateFormDataResponse();
        return TeaModel.build(map, self);
    }

    public CreateOrUpdateFormDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateOrUpdateFormDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateOrUpdateFormDataResponse setBody(CreateOrUpdateFormDataResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateOrUpdateFormDataResponseBody getBody() {
        return this.body;
    }

}
