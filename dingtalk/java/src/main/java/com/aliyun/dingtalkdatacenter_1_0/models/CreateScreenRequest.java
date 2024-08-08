// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class CreateScreenRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("templateId")
    public String templateId;

    public static CreateScreenRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateScreenRequest self = new CreateScreenRequest();
        return TeaModel.build(map, self);
    }

    public CreateScreenRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateScreenRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
