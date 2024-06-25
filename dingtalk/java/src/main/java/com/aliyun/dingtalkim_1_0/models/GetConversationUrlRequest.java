// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetConversationUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1107****2120</p>
     */
    @NameInMap("appUserId")
    public String appUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>oK4e****qER2</p>
     */
    @NameInMap("channelCode")
    public String channelCode;

    /**
     * <strong>example:</strong>
     * <p>123**789</p>
     */
    @NameInMap("deviceId")
    public String deviceId;

    /**
     * <strong>example:</strong>
     * <p>f67b****8a0f</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>1745****8777</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetConversationUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetConversationUrlRequest self = new GetConversationUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetConversationUrlRequest setAppUserId(String appUserId) {
        this.appUserId = appUserId;
        return this;
    }
    public String getAppUserId() {
        return this.appUserId;
    }

    public GetConversationUrlRequest setChannelCode(String channelCode) {
        this.channelCode = channelCode;
        return this;
    }
    public String getChannelCode() {
        return this.channelCode;
    }

    public GetConversationUrlRequest setDeviceId(String deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public String getDeviceId() {
        return this.deviceId;
    }

    public GetConversationUrlRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetConversationUrlRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
