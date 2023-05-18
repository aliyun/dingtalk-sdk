// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcheck_in_1_0.models;

import com.aliyun.tea.*;

public class GetCheckinRecordByUserHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetCheckinRecordByUserHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetCheckinRecordByUserHeaders self = new GetCheckinRecordByUserHeaders();
        return TeaModel.build(map, self);
    }

    public GetCheckinRecordByUserHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetCheckinRecordByUserHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
