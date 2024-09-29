// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetWebOfficeUrlResponseBody extends TeaModel {
    @NameInMap("webOfficeAccessToken")
    public String webOfficeAccessToken;

    @NameInMap("webOfficeRefreshToken")
    public String webOfficeRefreshToken;

    @NameInMap("webOfficeUrl")
    public String webOfficeUrl;

    public static GetWebOfficeUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWebOfficeUrlResponseBody self = new GetWebOfficeUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWebOfficeUrlResponseBody setWebOfficeAccessToken(String webOfficeAccessToken) {
        this.webOfficeAccessToken = webOfficeAccessToken;
        return this;
    }
    public String getWebOfficeAccessToken() {
        return this.webOfficeAccessToken;
    }

    public GetWebOfficeUrlResponseBody setWebOfficeRefreshToken(String webOfficeRefreshToken) {
        this.webOfficeRefreshToken = webOfficeRefreshToken;
        return this;
    }
    public String getWebOfficeRefreshToken() {
        return this.webOfficeRefreshToken;
    }

    public GetWebOfficeUrlResponseBody setWebOfficeUrl(String webOfficeUrl) {
        this.webOfficeUrl = webOfficeUrl;
        return this;
    }
    public String getWebOfficeUrl() {
        return this.webOfficeUrl;
    }

}
