// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSchemaAndProcessconfigBatchllyHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetSchemaAndProcessconfigBatchllyHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetSchemaAndProcessconfigBatchllyHeaders self = new GetSchemaAndProcessconfigBatchllyHeaders();
        return TeaModel.build(map, self);
    }

    public GetSchemaAndProcessconfigBatchllyHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetSchemaAndProcessconfigBatchllyHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
