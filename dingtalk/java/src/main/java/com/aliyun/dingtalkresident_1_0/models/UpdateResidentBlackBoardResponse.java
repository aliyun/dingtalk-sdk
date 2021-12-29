// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentBlackBoardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateResidentBlackBoardResponseBody body;

    public static UpdateResidentBlackBoardResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentBlackBoardResponse self = new UpdateResidentBlackBoardResponse();
        return TeaModel.build(map, self);
    }

    public UpdateResidentBlackBoardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateResidentBlackBoardResponse setBody(UpdateResidentBlackBoardResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateResidentBlackBoardResponseBody getBody() {
        return this.body;
    }

}
