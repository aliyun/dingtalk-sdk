// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustGroupRequest extends TeaModel {
    // MPASS渠道编码
    @NameInMap("channel")
    public String channel;

    // 素材ID
    @NameInMap("iconMediaId")
    public String iconMediaId;

    // 群名称
    @NameInMap("name")
    public String name;

    // 其他扩展参数
    @NameInMap("properties")
    public java.util.Map<String, String> properties;

    // 外部系统映射唯一标识
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

    public CreateTrustGroupRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
