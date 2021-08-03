// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetAttachsApprovalHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("serviceGroup")
    public String serviceGroup;

    @NameInMap("tsignOpenAppId")
    public String tsignOpenAppId;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetAttachsApprovalHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetAttachsApprovalHeaders self = new GetAttachsApprovalHeaders();
        return TeaModel.build(map, self);
    }

    public GetAttachsApprovalHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetAttachsApprovalHeaders setServiceGroup(String serviceGroup) {
        this.serviceGroup = serviceGroup;
        return this;
    }
    public String getServiceGroup() {
        return this.serviceGroup;
    }

    public GetAttachsApprovalHeaders setTsignOpenAppId(String tsignOpenAppId) {
        this.tsignOpenAppId = tsignOpenAppId;
        return this;
    }
    public String getTsignOpenAppId() {
        return this.tsignOpenAppId;
    }

    public GetAttachsApprovalHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
