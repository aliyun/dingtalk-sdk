// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class UpdateBizObjectRequest extends TeaModel {
    /**
     * <p>业务数据id</p>
     */
    @NameInMap("bizObjectId")
    public String bizObjectId;

    /**
     * <p>待修改的json格式业务数据</p>
     */
    @NameInMap("bizObjectJson")
    public String bizObjectJson;

    /**
     * <p>表单编码</p>
     */
    @NameInMap("schemaCode")
    public String schemaCode;

    public static UpdateBizObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateBizObjectRequest self = new UpdateBizObjectRequest();
        return TeaModel.build(map, self);
    }

    public UpdateBizObjectRequest setBizObjectId(String bizObjectId) {
        this.bizObjectId = bizObjectId;
        return this;
    }
    public String getBizObjectId() {
        return this.bizObjectId;
    }

    public UpdateBizObjectRequest setBizObjectJson(String bizObjectJson) {
        this.bizObjectJson = bizObjectJson;
        return this;
    }
    public String getBizObjectJson() {
        return this.bizObjectJson;
    }

    public UpdateBizObjectRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

}
