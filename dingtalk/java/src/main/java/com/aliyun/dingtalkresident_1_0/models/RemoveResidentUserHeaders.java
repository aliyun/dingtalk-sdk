// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class RemoveResidentUserHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static RemoveResidentUserHeaders build(java.util.Map<String, ?> map) throws Exception {
        RemoveResidentUserHeaders self = new RemoveResidentUserHeaders();
        return TeaModel.build(map, self);
    }

    public RemoveResidentUserHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public RemoveResidentUserHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
