// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class DeleteBizObjectRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1a1ce0ab-0181-4dc2-9968-793d20906b27</p>
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

    public static DeleteBizObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteBizObjectRequest self = new DeleteBizObjectRequest();
        return TeaModel.build(map, self);
    }

    public DeleteBizObjectRequest setBizObjectId(String bizObjectId) {
        this.bizObjectId = bizObjectId;
        return this;
    }
    public String getBizObjectId() {
        return this.bizObjectId;
    }

    public DeleteBizObjectRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

}
