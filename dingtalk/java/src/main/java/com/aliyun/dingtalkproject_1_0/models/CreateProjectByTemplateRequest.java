// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectByTemplateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>项目1</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>578cae9dbf83e5xxxx</p>
     */
    @NameInMap("templateId")
    public String templateId;

    public static CreateProjectByTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectByTemplateRequest self = new CreateProjectByTemplateRequest();
        return TeaModel.build(map, self);
    }

    public CreateProjectByTemplateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateProjectByTemplateRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
