// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustGroupRequest extends TeaModel {
    @NameInMap("channel")
    public String channel;

    @NameInMap("iconMediaId")
    public String iconMediaId;

    @NameInMap("members")
    public java.util.List<CreateTrustGroupRequestMembers> members;

    @NameInMap("name")
    public String name;

    @NameInMap("properties")
    public java.util.Map<String, String> properties;

    @NameInMap("systemMsg")
    public String systemMsg;

    @NameInMap("uuid")
    public String uuid;

    public static CreateTrustGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustGroupRequest self = new CreateTrustGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateTrustGroupRequest setChannel(String channel) {
        this.channel = channel;
        return this;
    }
    public String getChannel() {
        return this.channel;
    }

    public CreateTrustGroupRequest setIconMediaId(String iconMediaId) {
        this.iconMediaId = iconMediaId;
        return this;
    }
    public String getIconMediaId() {
        return this.iconMediaId;
    }

    public CreateTrustGroupRequest setMembers(java.util.List<CreateTrustGroupRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<CreateTrustGroupRequestMembers> getMembers() {
        return this.members;
    }

    public CreateTrustGroupRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateTrustGroupRequest setProperties(java.util.Map<String, String> properties) {
        this.properties = properties;
        return this;
    }
    public java.util.Map<String, String> getProperties() {
        return this.properties;
    }

    public CreateTrustGroupRequest setSystemMsg(String systemMsg) {
        this.systemMsg = systemMsg;
        return this;
    }
    public String getSystemMsg() {
        return this.systemMsg;
    }

    public CreateTrustGroupRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public static class CreateTrustGroupRequestMembers extends TeaModel {
        @NameInMap("nick")
        public String nick;

        @NameInMap("uid")
        public String uid;

        public static CreateTrustGroupRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            CreateTrustGroupRequestMembers self = new CreateTrustGroupRequestMembers();
            return TeaModel.build(map, self);
        }

        public CreateTrustGroupRequestMembers setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public CreateTrustGroupRequestMembers setUid(String uid) {
            this.uid = uid;
            return this;
        }
        public String getUid() {
            return this.uid;
        }

    }

}
