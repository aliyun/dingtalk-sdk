// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class AssignOrgHoldingToEmpHoldingBatchHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static AssignOrgHoldingToEmpHoldingBatchHeaders build(java.util.Map<String, ?> map) throws Exception {
        AssignOrgHoldingToEmpHoldingBatchHeaders self = new AssignOrgHoldingToEmpHoldingBatchHeaders();
        return TeaModel.build(map, self);
    }

    public AssignOrgHoldingToEmpHoldingBatchHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public AssignOrgHoldingToEmpHoldingBatchHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
