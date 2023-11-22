// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateMenuDataHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static UpdateMenuDataHeaders build(java.util.Map<String, ?> map) throws Exception {
        UpdateMenuDataHeaders self = new UpdateMenuDataHeaders();
        return TeaModel.build(map, self);
    }

    public UpdateMenuDataHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public UpdateMenuDataHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
