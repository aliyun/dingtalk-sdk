// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupNameHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("operatingSource")
    public String operatingSource;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static UpdateGroupNameHeaders build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupNameHeaders self = new UpdateGroupNameHeaders();
        return TeaModel.build(map, self);
    }

    public UpdateGroupNameHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public UpdateGroupNameHeaders setOperatingSource(String operatingSource) {
        this.operatingSource = operatingSource;
        return this;
    }
    public String getOperatingSource() {
        return this.operatingSource;
    }

    public UpdateGroupNameHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
