// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteDeviceCustomTemplateRequest extends TeaModel {
    @NameInMap("templateId")
    public Long templateId;

    public static DeleteDeviceCustomTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDeviceCustomTemplateRequest self = new DeleteDeviceCustomTemplateRequest();
        return TeaModel.build(map, self);
    }

    public DeleteDeviceCustomTemplateRequest setTemplateId(Long templateId) {
        this.templateId = templateId;
        return this;
    }
    public Long getTemplateId() {
        return this.templateId;
    }

}
