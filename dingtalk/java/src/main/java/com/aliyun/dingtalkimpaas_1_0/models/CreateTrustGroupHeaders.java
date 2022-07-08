// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustGroupHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("operationSource")
    public String operationSource;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static CreateTrustGroupHeaders build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustGroupHeaders self = new CreateTrustGroupHeaders();
        return TeaModel.build(map, self);
    }

    public CreateTrustGroupHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public CreateTrustGroupHeaders setOperationSource(String operationSource) {
        this.operationSource = operationSource;
        return this;
    }
    public String getOperationSource() {
        return this.operationSource;
    }

    public CreateTrustGroupHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
