// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class DeleteMatrixDataByRowIdsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteMatrixDataByRowIdsResponseBody body;

    public static DeleteMatrixDataByRowIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteMatrixDataByRowIdsResponse self = new DeleteMatrixDataByRowIdsResponse();
        return TeaModel.build(map, self);
    }

    public DeleteMatrixDataByRowIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteMatrixDataByRowIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteMatrixDataByRowIdsResponse setBody(DeleteMatrixDataByRowIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteMatrixDataByRowIdsResponseBody getBody() {
        return this.body;
    }

}
