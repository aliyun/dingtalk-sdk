// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetFileUploadUrlHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("serviceGroup")
    public String serviceGroup;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetFileUploadUrlHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadUrlHeaders self = new GetFileUploadUrlHeaders();
        return TeaModel.build(map, self);
    }

    public GetFileUploadUrlHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetFileUploadUrlHeaders setServiceGroup(String serviceGroup) {
        this.serviceGroup = serviceGroup;
        return this;
    }
    public String getServiceGroup() {
        return this.serviceGroup;
    }

    public GetFileUploadUrlHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
