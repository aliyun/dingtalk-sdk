// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportCustomRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<java.util.Map<String, ?>> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("modelCode")
    public String modelCode;

    public static HrbrainImportCustomRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportCustomRequest self = new HrbrainImportCustomRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportCustomRequest setBody(java.util.List<java.util.Map<String, ?>> body) {
        this.body = body;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getBody() {
        return this.body;
    }

    public HrbrainImportCustomRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public HrbrainImportCustomRequest setModelCode(String modelCode) {
        this.modelCode = modelCode;
        return this;
    }
    public String getModelCode() {
        return this.modelCode;
    }

}
