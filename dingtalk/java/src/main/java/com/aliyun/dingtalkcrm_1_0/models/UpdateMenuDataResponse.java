// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateMenuDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateMenuDataResponseBody body;

    public static UpdateMenuDataResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateMenuDataResponse self = new UpdateMenuDataResponse();
        return TeaModel.build(map, self);
    }

    public UpdateMenuDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateMenuDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateMenuDataResponse setBody(UpdateMenuDataResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateMenuDataResponseBody getBody() {
        return this.body;
    }

}
