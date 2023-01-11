// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class AddApplicationRegFormTemplateResponseBody extends TeaModel {
    /**
     * <p>模板标识</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <p>模板版本</p>
     */
    @NameInMap("version")
    public Integer version;

    public static AddApplicationRegFormTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddApplicationRegFormTemplateResponseBody self = new AddApplicationRegFormTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public AddApplicationRegFormTemplateResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public AddApplicationRegFormTemplateResponseBody setVersion(Integer version) {
        this.version = version;
        return this;
    }
    public Integer getVersion() {
        return this.version;
    }

}
