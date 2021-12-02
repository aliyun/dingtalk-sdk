// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetReceiptRequest extends TeaModel {
    // 模型id
    @NameInMap("modelId")
    public String modelId;

    // 单据号
    @NameInMap("code")
    public String code;

    public static GetReceiptRequest build(java.util.Map<String, ?> map) throws Exception {
        GetReceiptRequest self = new GetReceiptRequest();
        return TeaModel.build(map, self);
    }

    public GetReceiptRequest setModelId(String modelId) {
        this.modelId = modelId;
        return this;
    }
    public String getModelId() {
        return this.modelId;
    }

    public GetReceiptRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
