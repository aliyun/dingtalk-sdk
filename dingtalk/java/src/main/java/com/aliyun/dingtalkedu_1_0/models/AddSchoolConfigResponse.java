// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddSchoolConfigResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddSchoolConfigResponseBody body;

    public static AddSchoolConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        AddSchoolConfigResponse self = new AddSchoolConfigResponse();
        return TeaModel.build(map, self);
    }

    public AddSchoolConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddSchoolConfigResponse setBody(AddSchoolConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public AddSchoolConfigResponseBody getBody() {
        return this.body;
    }

}
