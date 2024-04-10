// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SearchPublishDentriesHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static SearchPublishDentriesHeaders build(java.util.Map<String, ?> map) throws Exception {
        SearchPublishDentriesHeaders self = new SearchPublishDentriesHeaders();
        return TeaModel.build(map, self);
    }

    public SearchPublishDentriesHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public SearchPublishDentriesHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
