// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduGetFileSpaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EduGetFileSpaceResponseBody body;

    public static EduGetFileSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        EduGetFileSpaceResponse self = new EduGetFileSpaceResponse();
        return TeaModel.build(map, self);
    }

    public EduGetFileSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EduGetFileSpaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EduGetFileSpaceResponse setBody(EduGetFileSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public EduGetFileSpaceResponseBody getBody() {
        return this.body;
    }

}
