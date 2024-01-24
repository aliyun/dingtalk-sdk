// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduListUserByFromUserIdsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EduListUserByFromUserIdsResponseBody body;

    public static EduListUserByFromUserIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        EduListUserByFromUserIdsResponse self = new EduListUserByFromUserIdsResponse();
        return TeaModel.build(map, self);
    }

    public EduListUserByFromUserIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EduListUserByFromUserIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EduListUserByFromUserIdsResponse setBody(EduListUserByFromUserIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public EduListUserByFromUserIdsResponseBody getBody() {
        return this.body;
    }

}
