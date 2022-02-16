// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class RecallAuditTemplateRequest extends TeaModel {
    @NameInMap("templateKeys")
    public java.util.List<String> templateKeys;

    public static RecallAuditTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        RecallAuditTemplateRequest self = new RecallAuditTemplateRequest();
        return TeaModel.build(map, self);
    }

    public RecallAuditTemplateRequest setTemplateKeys(java.util.List<String> templateKeys) {
        this.templateKeys = templateKeys;
        return this;
    }
    public java.util.List<String> getTemplateKeys() {
        return this.templateKeys;
    }

}
