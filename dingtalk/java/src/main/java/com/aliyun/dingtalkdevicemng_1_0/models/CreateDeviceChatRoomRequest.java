// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceChatRoomRequest extends TeaModel {
    @NameInMap("chatType")
    public String chatType;

    @NameInMap("deviceCodes")
    public java.util.List<String> deviceCodes;

    @NameInMap("deviceUuids")
    public java.util.List<String> deviceUuids;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ownerUserId")
    public String ownerUserId;

    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static CreateDeviceChatRoomRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDeviceChatRoomRequest self = new CreateDeviceChatRoomRequest();
        return TeaModel.build(map, self);
    }

    public CreateDeviceChatRoomRequest setChatType(String chatType) {
        this.chatType = chatType;
        return this;
    }
    public String getChatType() {
        return this.chatType;
    }

    public CreateDeviceChatRoomRequest setDeviceCodes(java.util.List<String> deviceCodes) {
        this.deviceCodes = deviceCodes;
        return this;
    }
    public java.util.List<String> getDeviceCodes() {
        return this.deviceCodes;
    }

    public CreateDeviceChatRoomRequest setDeviceUuids(java.util.List<String> deviceUuids) {
        this.deviceUuids = deviceUuids;
        return this;
    }
    public java.util.List<String> getDeviceUuids() {
        return this.deviceUuids;
    }

    public CreateDeviceChatRoomRequest setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public CreateDeviceChatRoomRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public CreateDeviceChatRoomRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
