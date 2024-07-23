// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class ListMailFoldersHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static ListMailFoldersHeaders build(java.util.Map<String, ?> map) throws Exception {
        ListMailFoldersHeaders self = new ListMailFoldersHeaders();
        return TeaModel.build(map, self);
    }

    public ListMailFoldersHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public ListMailFoldersHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
