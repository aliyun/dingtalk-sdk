// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class SaveAndUpdateMatrixDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveAndUpdateMatrixDataResponseBody body;

    public static SaveAndUpdateMatrixDataResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveAndUpdateMatrixDataResponse self = new SaveAndUpdateMatrixDataResponse();
        return TeaModel.build(map, self);
    }

    public SaveAndUpdateMatrixDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveAndUpdateMatrixDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveAndUpdateMatrixDataResponse setBody(SaveAndUpdateMatrixDataResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveAndUpdateMatrixDataResponseBody getBody() {
        return this.body;
    }

}
