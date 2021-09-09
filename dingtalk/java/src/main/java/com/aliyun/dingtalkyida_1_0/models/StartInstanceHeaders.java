// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class StartInstanceHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static StartInstanceHeaders build(java.util.Map<String, ?> map) throws Exception {
        StartInstanceHeaders self = new StartInstanceHeaders();
        return TeaModel.build(map, self);
    }

    public StartInstanceHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public StartInstanceHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
