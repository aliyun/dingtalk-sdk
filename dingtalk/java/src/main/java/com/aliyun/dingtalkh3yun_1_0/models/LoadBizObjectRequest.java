// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizObjectRequest extends TeaModel {
    @NameInMap("bizObjectId")
    public String bizObjectId;

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
