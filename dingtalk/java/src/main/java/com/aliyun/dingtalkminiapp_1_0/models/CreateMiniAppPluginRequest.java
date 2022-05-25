// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class CreateMiniAppPluginRequest extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("bizType")
    public Integer bizType;

    @NameInMap("bundleId")
    public String bundleId;

    @NameInMap("desc")
    public String desc;

    @NameInMap("icon")
    public String icon;

    @NameInMap("name")
    public String name;

    public static CreateMiniAppPluginRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateMiniAppPluginRequest self = new CreateMiniAppPluginRequest();
        return TeaModel.build(map, self);
    }

    public CreateMiniAppPluginRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public CreateMiniAppPluginRequest setBizType(Integer bizType) {
        this.bizType = bizType;
        return this;
    }
    public Integer getBizType() {
        return this.bizType;
    }

    public CreateMiniAppPluginRequest setBundleId(String bundleId) {
        this.bundleId = bundleId;
        return this;
    }
    public String getBundleId() {
        return this.bundleId;
    }

    public CreateMiniAppPluginRequest setDesc(String desc) {
        this.desc = desc;
        return this;
    }
    public String getDesc() {
        return this.desc;
    }

    public CreateMiniAppPluginRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateMiniAppPluginRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
