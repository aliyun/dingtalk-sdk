// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetConversationUrlRequest extends TeaModel {
    @NameInMap("appUserId")
    public String appUserId;

    @NameInMap("channelCode")
    public String channelCode;

    @NameInMap("openConversationId")
    public String openConversationId;

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
