// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetCorpInfoHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("serviceGroup")
    public String serviceGroup;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetCorpInfoHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetCorpInfoHeaders self = new GetCorpInfoHeaders();
        return TeaModel.build(map, self);
    }

    public GetCorpInfoHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetCorpInfoHeaders setServiceGroup(String serviceGroup) {
        this.serviceGroup = serviceGroup;
        return this;
    }
    public String getServiceGroup() {
        return this.serviceGroup;
    }

    public GetCorpInfoHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
