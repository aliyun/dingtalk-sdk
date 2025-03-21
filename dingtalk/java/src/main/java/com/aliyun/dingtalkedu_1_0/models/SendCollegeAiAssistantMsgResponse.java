// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SendCollegeAiAssistantMsgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendCollegeAiAssistantMsgResponseBody body;

    public static SendCollegeAiAssistantMsgResponse build(java.util.Map<String, ?> map) throws Exception {
        SendCollegeAiAssistantMsgResponse self = new SendCollegeAiAssistantMsgResponse();
        return TeaModel.build(map, self);
    }

    public SendCollegeAiAssistantMsgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendCollegeAiAssistantMsgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendCollegeAiAssistantMsgResponse setBody(SendCollegeAiAssistantMsgResponseBody body) {
        this.body = body;
        return this;
    }
    public SendCollegeAiAssistantMsgResponseBody getBody() {
        return this.body;
    }

}
