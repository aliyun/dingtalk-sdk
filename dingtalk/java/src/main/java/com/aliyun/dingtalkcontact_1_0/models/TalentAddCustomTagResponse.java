// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentAddCustomTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentAddCustomTagResponseBody body;

    public static TalentAddCustomTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentAddCustomTagResponse self = new TalentAddCustomTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentAddCustomTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentAddCustomTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentAddCustomTagResponse setBody(TalentAddCustomTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentAddCustomTagResponseBody getBody() {
        return this.body;
    }

}
