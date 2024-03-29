// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class CreateResidentBlackBoardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateResidentBlackBoardResponseBody body;

    public static CreateResidentBlackBoardResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateResidentBlackBoardResponse self = new CreateResidentBlackBoardResponse();
        return TeaModel.build(map, self);
    }

    public CreateResidentBlackBoardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateResidentBlackBoardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateResidentBlackBoardResponse setBody(CreateResidentBlackBoardResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateResidentBlackBoardResponseBody getBody() {
        return this.body;
    }

}
