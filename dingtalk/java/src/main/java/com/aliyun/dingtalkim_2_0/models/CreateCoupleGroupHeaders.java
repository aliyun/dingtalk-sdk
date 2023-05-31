// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CreateCoupleGroupHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static CreateCoupleGroupHeaders build(java.util.Map<String, ?> map) throws Exception {
        CreateCoupleGroupHeaders self = new CreateCoupleGroupHeaders();
        return TeaModel.build(map, self);
    }

    public CreateCoupleGroupHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public CreateCoupleGroupHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
