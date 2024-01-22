// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class PushVerifyEventHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static PushVerifyEventHeaders build(java.util.Map<String, ?> map) throws Exception {
        PushVerifyEventHeaders self = new PushVerifyEventHeaders();
        return TeaModel.build(map, self);
    }

    public PushVerifyEventHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public PushVerifyEventHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
