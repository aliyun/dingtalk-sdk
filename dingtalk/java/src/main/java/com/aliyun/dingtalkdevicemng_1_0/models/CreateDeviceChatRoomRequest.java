// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceChatRoomRequest extends TeaModel {
    // 场景群类型，不填，为默认普通设备群，示例值--维修群：REPAIR_GROUP，点检群:INSPECT_GROUP,保养群：MAINTAIN_GROUP。
    @NameInMap("chatType")
    public String chatType;

    // 设备编码，客户侧生成的设备标识，能够唯一标识一个设备，该字段与deviceUuids字段需要二选一，并且不能都填充。
    @NameInMap("deviceCodes")
    public java.util.List<String> deviceCodes;

    // 设备唯一标识，钉钉侧生成的设备标识，能够唯一标识一个设备，该字段与deviceCodes字段需要二选一，并且不能都填充。
    @NameInMap("deviceUuids")
    public java.util.List<String> deviceUuids;

    // 群主钉钉账户。
    @NameInMap("ownerUserId")
    public String ownerUserId;

    // 设备场景群名称。
    @NameInMap("title")
    public String title;

    // 需要被拉入群聊的钉钉账号，可以传多个，通过英文逗号分隔。
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
