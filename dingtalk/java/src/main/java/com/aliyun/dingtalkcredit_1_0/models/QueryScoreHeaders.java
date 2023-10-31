// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcredit_1_0.models;

import com.aliyun.tea.*;

public class QueryScoreHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static QueryScoreHeaders build(java.util.Map<String, ?> map) throws Exception {
        QueryScoreHeaders self = new QueryScoreHeaders();
        return TeaModel.build(map, self);
    }

    public QueryScoreHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public QueryScoreHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
