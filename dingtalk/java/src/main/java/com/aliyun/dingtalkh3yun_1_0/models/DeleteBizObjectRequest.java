// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class DeleteBizObjectRequest extends TeaModel {
    // 业务数据id
    @NameInMap("bizObjectId")
    public String bizObjectId;

    // 表单编码
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
