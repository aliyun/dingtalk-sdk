// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class DeleteResidentBlackBoardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteResidentBlackBoardResponseBody body;

    public static DeleteResidentBlackBoardResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteResidentBlackBoardResponse self = new DeleteResidentBlackBoardResponse();
        return TeaModel.build(map, self);
    }

    public DeleteResidentBlackBoardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteResidentBlackBoardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteResidentBlackBoardResponse setBody(DeleteResidentBlackBoardResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteResidentBlackBoardResponseBody getBody() {
        return this.body;
    }

}
