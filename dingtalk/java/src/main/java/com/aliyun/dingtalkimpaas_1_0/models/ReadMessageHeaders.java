// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class ReadMessageHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("operatingSource")
    public String operatingSource;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static ReadMessageHeaders build(java.util.Map<String, ?> map) throws Exception {
        ReadMessageHeaders self = new ReadMessageHeaders();
        return TeaModel.build(map, self);
    }

    public ReadMessageHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public ReadMessageHeaders setOperatingSource(String operatingSource) {
        this.operatingSource = operatingSource;
        return this;
    }
    public String getOperatingSource() {
        return this.operatingSource;
    }

    public ReadMessageHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
