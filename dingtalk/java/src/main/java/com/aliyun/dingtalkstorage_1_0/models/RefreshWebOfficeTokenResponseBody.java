// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RefreshWebOfficeTokenResponseBody extends TeaModel {
    @NameInMap("webOfficeAccessToken")
    public String webOfficeAccessToken;

    @NameInMap("webOfficeRefreshToken")
    public String webOfficeRefreshToken;

    public static RefreshWebOfficeTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RefreshWebOfficeTokenResponseBody self = new RefreshWebOfficeTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public RefreshWebOfficeTokenResponseBody setWebOfficeAccessToken(String webOfficeAccessToken) {
        this.webOfficeAccessToken = webOfficeAccessToken;
        return this;
    }
    public String getWebOfficeAccessToken() {
        return this.webOfficeAccessToken;
    }

    public RefreshWebOfficeTokenResponseBody setWebOfficeRefreshToken(String webOfficeRefreshToken) {
        this.webOfficeRefreshToken = webOfficeRefreshToken;
        return this;
    }
    public String getWebOfficeRefreshToken() {
        return this.webOfficeRefreshToken;
    }

}
