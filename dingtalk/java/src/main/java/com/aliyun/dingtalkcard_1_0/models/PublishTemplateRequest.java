// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class PublishTemplateRequest extends TeaModel {
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("templateId")
    public String templateId;

    @NameInMap("templateSource")
    public String templateSource;

    public static PublishTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        PublishTemplateRequest self = new PublishTemplateRequest();
        return TeaModel.build(map, self);
    }

    public PublishTemplateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public PublishTemplateRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public PublishTemplateRequest setTemplateSource(String templateSource) {
        this.templateSource = templateSource;
        return this;
    }
    public String getTemplateSource() {
        return this.templateSource;
    }

}
