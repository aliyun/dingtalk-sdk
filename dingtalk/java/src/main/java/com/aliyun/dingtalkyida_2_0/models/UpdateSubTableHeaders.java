// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class UpdateSubTableHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static UpdateSubTableHeaders build(java.util.Map<String, ?> map) throws Exception {
        UpdateSubTableHeaders self = new UpdateSubTableHeaders();
        return TeaModel.build(map, self);
    }

    public UpdateSubTableHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public UpdateSubTableHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
