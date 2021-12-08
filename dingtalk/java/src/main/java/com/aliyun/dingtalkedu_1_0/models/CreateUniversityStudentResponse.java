// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityStudentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateUniversityStudentResponseBody body;

    public static CreateUniversityStudentResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateUniversityStudentResponse self = new CreateUniversityStudentResponse();
        return TeaModel.build(map, self);
    }

    public CreateUniversityStudentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateUniversityStudentResponse setBody(CreateUniversityStudentResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateUniversityStudentResponseBody getBody() {
        return this.body;
    }

}
