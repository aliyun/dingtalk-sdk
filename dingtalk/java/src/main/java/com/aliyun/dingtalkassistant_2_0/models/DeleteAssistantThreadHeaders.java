// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class DeleteAssistantThreadHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static DeleteAssistantThreadHeaders build(java.util.Map<String, ?> map) throws Exception {
        DeleteAssistantThreadHeaders self = new DeleteAssistantThreadHeaders();
        return TeaModel.build(map, self);
    }

    public DeleteAssistantThreadHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public DeleteAssistantThreadHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
