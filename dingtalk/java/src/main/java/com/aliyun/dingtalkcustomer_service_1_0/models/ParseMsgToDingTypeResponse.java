// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class ParseMsgToDingTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ParseMsgToDingTypeResponseBody body;

    public static ParseMsgToDingTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        ParseMsgToDingTypeResponse self = new ParseMsgToDingTypeResponse();
        return TeaModel.build(map, self);
    }

    public ParseMsgToDingTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ParseMsgToDingTypeResponse setBody(ParseMsgToDingTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public ParseMsgToDingTypeResponseBody getBody() {
        return this.body;
    }

}
