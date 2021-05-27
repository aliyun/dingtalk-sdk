// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ProcessStartHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("serviceGroup")
    public String serviceGroup;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static ProcessStartHeaders build(java.util.Map<String, ?> map) throws Exception {
        ProcessStartHeaders self = new ProcessStartHeaders();
        return TeaModel.build(map, self);
    }

    public ProcessStartHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public ProcessStartHeaders setServiceGroup(String serviceGroup) {
        this.serviceGroup = serviceGroup;
        return this;
    }
    public String getServiceGroup() {
        return this.serviceGroup;
    }

    public ProcessStartHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
