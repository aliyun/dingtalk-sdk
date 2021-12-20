// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class CreateResidentBlackBoardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CreateResidentBlackBoardResponse setBody(CreateResidentBlackBoardResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateResidentBlackBoardResponseBody getBody() {
        return this.body;
    }

}
