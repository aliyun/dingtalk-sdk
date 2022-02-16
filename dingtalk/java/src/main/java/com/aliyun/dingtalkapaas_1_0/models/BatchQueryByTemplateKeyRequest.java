// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryByTemplateKeyRequest extends TeaModel {
    @NameInMap("templateKeys")
    public java.util.List<String> templateKeys;

    public static BatchQueryByTemplateKeyRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryByTemplateKeyRequest self = new BatchQueryByTemplateKeyRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryByTemplateKeyRequest setTemplateKeys(java.util.List<String> templateKeys) {
        this.templateKeys = templateKeys;
        return this;
    }
    public java.util.List<String> getTemplateKeys() {
        return this.templateKeys;
    }

}
