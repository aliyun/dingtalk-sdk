// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class OpenEsignFreeTrailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    public static OpenEsignFreeTrailRequest build(java.util.Map<String, ?> map) throws Exception {
        OpenEsignFreeTrailRequest self = new OpenEsignFreeTrailRequest();
        return TeaModel.build(map, self);
    }

    public OpenEsignFreeTrailRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public OpenEsignFreeTrailRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

}
