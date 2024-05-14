// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class CreateTemplatesResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("templateId")
    public String templateId;

    public static CreateTemplatesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTemplatesResponseBody self = new CreateTemplatesResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTemplatesResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
