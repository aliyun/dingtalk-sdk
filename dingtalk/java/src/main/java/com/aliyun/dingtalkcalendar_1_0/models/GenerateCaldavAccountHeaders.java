// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GenerateCaldavAccountHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("dingUid")
    public String dingUid;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GenerateCaldavAccountHeaders build(java.util.Map<String, ?> map) throws Exception {
        GenerateCaldavAccountHeaders self = new GenerateCaldavAccountHeaders();
        return TeaModel.build(map, self);
    }

    public GenerateCaldavAccountHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GenerateCaldavAccountHeaders setDingUid(String dingUid) {
        this.dingUid = dingUid;
        return this;
    }
    public String getDingUid() {
        return this.dingUid;
    }

    public GenerateCaldavAccountHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
