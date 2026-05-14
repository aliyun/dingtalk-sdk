// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class TruncateSheetRecordsHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static TruncateSheetRecordsHeaders build(java.util.Map<String, ?> map) throws Exception {
        TruncateSheetRecordsHeaders self = new TruncateSheetRecordsHeaders();
        return TeaModel.build(map, self);
    }

    public TruncateSheetRecordsHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public TruncateSheetRecordsHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
