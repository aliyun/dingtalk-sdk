// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjobs_1_0.models;

import com.aliyun.tea.*;

public class CreateResumeHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static CreateResumeHeaders build(java.util.Map<String, ?> map) throws Exception {
        CreateResumeHeaders self = new CreateResumeHeaders();
        return TeaModel.build(map, self);
    }

    public CreateResumeHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public CreateResumeHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
