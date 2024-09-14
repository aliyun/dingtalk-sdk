// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class SaveTemplateRequest extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("templateId")
    public String templateId;

    @NameInMap("templateSource")
    public String templateSource;

    public static SaveTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveTemplateRequest self = new SaveTemplateRequest();
        return TeaModel.build(map, self);
    }

    public SaveTemplateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public SaveTemplateRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public SaveTemplateRequest setTemplateSource(String templateSource) {
        this.templateSource = templateSource;
        return this;
    }
    public String getTemplateSource() {
        return this.templateSource;
    }

}
