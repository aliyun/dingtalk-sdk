// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class DeleteSpaceHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static DeleteSpaceHeaders build(java.util.Map<String, ?> map) throws Exception {
        DeleteSpaceHeaders self = new DeleteSpaceHeaders();
        return TeaModel.build(map, self);
    }

    public DeleteSpaceHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public DeleteSpaceHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
