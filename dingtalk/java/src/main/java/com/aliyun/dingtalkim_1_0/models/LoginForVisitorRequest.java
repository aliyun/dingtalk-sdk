// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class LoginForVisitorRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>uuid_a123</p>
     */
    @NameInMap("appUserId")
    public String appUserId;

    /**
     * <strong>example:</strong>
     * <p>your_channel_code</p>
     */
    @NameInMap("channelCode")
    public String channelCode;

    /**
     * <strong>example:</strong>
     * <p>abc123xyz</p>
     */
    @NameInMap("customAccessToken")
    public String customAccessToken;

    public static LoginForVisitorRequest build(java.util.Map<String, ?> map) throws Exception {
        LoginForVisitorRequest self = new LoginForVisitorRequest();
        return TeaModel.build(map, self);
    }

    public LoginForVisitorRequest setAppUserId(String appUserId) {
        this.appUserId = appUserId;
        return this;
    }
    public String getAppUserId() {
        return this.appUserId;
    }

    public LoginForVisitorRequest setChannelCode(String channelCode) {
        this.channelCode = channelCode;
        return this;
    }
    public String getChannelCode() {
        return this.channelCode;
    }

    public LoginForVisitorRequest setCustomAccessToken(String customAccessToken) {
        this.customAccessToken = customAccessToken;
        return this;
    }
    public String getCustomAccessToken() {
        return this.customAccessToken;
    }

}
