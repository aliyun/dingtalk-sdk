// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_1_0.models;

import com.aliyun.tea.*;

public class CustomeRpcCallHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static CustomeRpcCallHeaders build(java.util.Map<String, ?> map) throws Exception {
        CustomeRpcCallHeaders self = new CustomeRpcCallHeaders();
        return TeaModel.build(map, self);
    }

    public CustomeRpcCallHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public CustomeRpcCallHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
