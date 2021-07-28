// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateInterviewSignInInfoHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static UpdateInterviewSignInInfoHeaders build(java.util.Map<String, ?> map) throws Exception {
        UpdateInterviewSignInInfoHeaders self = new UpdateInterviewSignInInfoHeaders();
        return TeaModel.build(map, self);
    }

    public UpdateInterviewSignInInfoHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public UpdateInterviewSignInInfoHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
