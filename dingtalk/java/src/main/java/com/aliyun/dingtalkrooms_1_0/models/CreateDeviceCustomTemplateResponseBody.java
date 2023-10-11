// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceCustomTemplateResponseBody extends TeaModel {
    @NameInMap("templateId")
    public Long templateId;

    public static CreateDeviceCustomTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateDeviceCustomTemplateResponseBody self = new CreateDeviceCustomTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateDeviceCustomTemplateResponseBody setTemplateId(Long templateId) {
        this.templateId = templateId;
        return this;
    }
    public Long getTemplateId() {
        return this.templateId;
    }

}
