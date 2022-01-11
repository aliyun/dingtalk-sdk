// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class CreateChatRoomRequest extends TeaModel {
    @NameInMap("chatGroupName")
    public String chatGroupName;

    @NameInMap("deviceCodes")
    public java.util.List<String> deviceCodes;

    @NameInMap("deviceTypeId")
    public String deviceTypeId;

    @NameInMap("ownerUserId")
    public String ownerUserId;

    @NameInMap("roleList")
    public java.util.List<String> roleList;

    public static CreateChatRoomRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateChatRoomRequest self = new CreateChatRoomRequest();
        return TeaModel.build(map, self);
    }

    public CreateChatRoomRequest setChatGroupName(String chatGroupName) {
        this.chatGroupName = chatGroupName;
        return this;
    }
    public String getChatGroupName() {
        return this.chatGroupName;
    }

    public CreateChatRoomRequest setDeviceCodes(java.util.List<String> deviceCodes) {
        this.deviceCodes = deviceCodes;
        return this;
    }
    public java.util.List<String> getDeviceCodes() {
        return this.deviceCodes;
    }

    public CreateChatRoomRequest setDeviceTypeId(String deviceTypeId) {
        this.deviceTypeId = deviceTypeId;
        return this;
    }
    public String getDeviceTypeId() {
        return this.deviceTypeId;
    }

    public CreateChatRoomRequest setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public CreateChatRoomRequest setRoleList(java.util.List<String> roleList) {
        this.roleList = roleList;
        return this;
    }
    public java.util.List<String> getRoleList() {
        return this.roleList;
    }

}
