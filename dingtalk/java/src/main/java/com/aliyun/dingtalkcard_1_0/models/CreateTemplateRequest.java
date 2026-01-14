// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateTemplateRequest extends TeaModel {
    @NameInMap("appId")
    public String appId;

    @NameInMap("blockTemplate")
    public Boolean blockTemplate;

    @NameInMap("creatorId")
    public String creatorId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("extendType")
    public String extendType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("type")
    public String type;

    public static CreateTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTemplateRequest self = new CreateTemplateRequest();
        return TeaModel.build(map, self);
    }

    public CreateTemplateRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public CreateTemplateRequest setBlockTemplate(Boolean blockTemplate) {
        this.blockTemplate = blockTemplate;
        return this;
    }
    public Boolean getBlockTemplate() {
        return this.blockTemplate;
    }

    public CreateTemplateRequest setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public CreateTemplateRequest setExtendType(String extendType) {
        this.extendType = extendType;
        return this;
    }
    public String getExtendType() {
        return this.extendType;
    }

    public CreateTemplateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateTemplateRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
