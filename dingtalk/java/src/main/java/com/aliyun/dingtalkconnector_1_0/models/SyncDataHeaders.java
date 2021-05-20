// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SyncDataHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static SyncDataHeaders build(java.util.Map<String, ?> map) throws Exception {
        SyncDataHeaders self = new SyncDataHeaders();
        return TeaModel.build(map, self);
    }

    public SyncDataHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public SyncDataHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
