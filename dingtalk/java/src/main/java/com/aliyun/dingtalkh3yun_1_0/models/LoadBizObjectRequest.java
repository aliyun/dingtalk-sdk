// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizObjectRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>193f9efea-e27b-427d-bd13-e3be65e00ef9</p>
     */
    @NameInMap("bizObjectId")
    public String bizObjectId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D0001839bbbbe346bbf496498bb76c44c7eb972</p>
     */
    @NameInMap("schemaCode")
    public String schemaCode;

    public static LoadBizObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        LoadBizObjectRequest self = new LoadBizObjectRequest();
        return TeaModel.build(map, self);
    }

    public LoadBizObjectRequest setBizObjectId(String bizObjectId) {
        this.bizObjectId = bizObjectId;
        return this;
    }
    public String getBizObjectId() {
        return this.bizObjectId;
    }

    public LoadBizObjectRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

}
