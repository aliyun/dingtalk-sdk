// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupRequest extends TeaModel {
    @NameInMap("uuid")
    public String uuid;

    @NameInMap("creatorUid")
    public String creatorUid;

    @NameInMap("name")
    public String name;

    @NameInMap("iconMediaId")
    public String iconMediaId;

    @NameInMap("channel")
    public String channel;

    @NameInMap("properties")
    public java.util.Map<String, String> properties;

    public static CreateGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupRequest self = new CreateGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public CreateGroupRequest setCreatorUid(String creatorUid) {
        this.creatorUid = creatorUid;
        return this;
    }
    public String getCreatorUid() {
        return this.creatorUid;
    }

    public CreateGroupRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateGroupRequest setIconMediaId(String iconMediaId) {
        this.iconMediaId = iconMediaId;
        return this;
    }
    public String getIconMediaId() {
        return this.iconMediaId;
    }

    public CreateGroupRequest setChannel(String channel) {
        this.channel = channel;
        return this;
    }
    public String getChannel() {
        return this.channel;
    }

    public CreateGroupRequest setProperties(java.util.Map<String, String> properties) {
        this.properties = properties;
        return this;
    }
    public java.util.Map<String, String> getProperties() {
        return this.properties;
    }

}
