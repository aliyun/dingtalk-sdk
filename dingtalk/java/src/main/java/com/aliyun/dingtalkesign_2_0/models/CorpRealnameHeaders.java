// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CorpRealnameHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("serviceGroup")
    public String serviceGroup;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static CorpRealnameHeaders build(java.util.Map<String, ?> map) throws Exception {
        CorpRealnameHeaders self = new CorpRealnameHeaders();
        return TeaModel.build(map, self);
    }

    public CorpRealnameHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public CorpRealnameHeaders setServiceGroup(String serviceGroup) {
        this.serviceGroup = serviceGroup;
        return this;
    }
    public String getServiceGroup() {
        return this.serviceGroup;
    }

    public CorpRealnameHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
