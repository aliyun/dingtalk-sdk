// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class ListMarketMcpsHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static ListMarketMcpsHeaders build(java.util.Map<String, ?> map) throws Exception {
        ListMarketMcpsHeaders self = new ListMarketMcpsHeaders();
        return TeaModel.build(map, self);
    }

    public ListMarketMcpsHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public ListMarketMcpsHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
