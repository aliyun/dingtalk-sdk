// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizFieldsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D0001839bbbbe346bbf496498bb76c44c7eb972</p>
     */
    @NameInMap("schemaCode")
    public String schemaCode;

    public static LoadBizFieldsRequest build(java.util.Map<String, ?> map) throws Exception {
        LoadBizFieldsRequest self = new LoadBizFieldsRequest();
        return TeaModel.build(map, self);
    }

    public LoadBizFieldsRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

}
