// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class CreateAsrTranscriptionHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static CreateAsrTranscriptionHeaders build(java.util.Map<String, ?> map) throws Exception {
        CreateAsrTranscriptionHeaders self = new CreateAsrTranscriptionHeaders();
        return TeaModel.build(map, self);
    }

    public CreateAsrTranscriptionHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public CreateAsrTranscriptionHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
