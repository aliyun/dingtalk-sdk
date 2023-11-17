// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class GetSendAndReceiveReportListHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetSendAndReceiveReportListHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetSendAndReceiveReportListHeaders self = new GetSendAndReceiveReportListHeaders();
        return TeaModel.build(map, self);
    }

    public GetSendAndReceiveReportListHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetSendAndReceiveReportListHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
