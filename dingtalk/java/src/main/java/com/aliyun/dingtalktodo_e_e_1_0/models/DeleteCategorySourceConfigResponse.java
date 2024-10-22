// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class DeleteCategorySourceConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteCategorySourceConfigResponseBody body;

    public static DeleteCategorySourceConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteCategorySourceConfigResponse self = new DeleteCategorySourceConfigResponse();
        return TeaModel.build(map, self);
    }

    public DeleteCategorySourceConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteCategorySourceConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteCategorySourceConfigResponse setBody(DeleteCategorySourceConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteCategorySourceConfigResponseBody getBody() {
        return this.body;
    }

}
