// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkrecord_1_0.models;

import com.aliyun.tea.*;

public class CountWorkRecordHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static CountWorkRecordHeaders build(java.util.Map<String, ?> map) throws Exception {
        CountWorkRecordHeaders self = new CountWorkRecordHeaders();
        return TeaModel.build(map, self);
    }

    public CountWorkRecordHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public CountWorkRecordHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
