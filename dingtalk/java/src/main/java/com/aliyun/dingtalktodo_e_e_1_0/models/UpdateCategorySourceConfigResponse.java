// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class UpdateCategorySourceConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCategorySourceConfigResponseBody body;

    public static UpdateCategorySourceConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCategorySourceConfigResponse self = new UpdateCategorySourceConfigResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCategorySourceConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCategorySourceConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCategorySourceConfigResponse setBody(UpdateCategorySourceConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCategorySourceConfigResponseBody getBody() {
        return this.body;
    }

}
