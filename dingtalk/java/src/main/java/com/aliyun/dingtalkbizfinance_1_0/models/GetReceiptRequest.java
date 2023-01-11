// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetReceiptRequest extends TeaModel {
    /**
     * <p>单据号</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>模型id</p>
     */
    @NameInMap("modelId")
    public String modelId;

    public static GetReceiptRequest build(java.util.Map<String, ?> map) throws Exception {
        GetReceiptRequest self = new GetReceiptRequest();
        return TeaModel.build(map, self);
    }

    public GetReceiptRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetReceiptRequest setModelId(String modelId) {
        this.modelId = modelId;
        return this;
    }
    public String getModelId() {
        return this.modelId;
    }

}
