// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetReceiptRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>20251231541312</p>
     */
    @NameInMap("businessId")
    public String businessId;

    /**
     * <strong>example:</strong>
     * <p>19b98a1c-5a31-4d78-9da7-0e347593820a</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <strong>example:</strong>
     * <p>EM-1017F28E03350B1738B3000X</p>
     */
    @NameInMap("modelId")
    public String modelId;

    public static GetReceiptRequest build(java.util.Map<String, ?> map) throws Exception {
        GetReceiptRequest self = new GetReceiptRequest();
        return TeaModel.build(map, self);
    }

    public GetReceiptRequest setBusinessId(String businessId) {
        this.businessId = businessId;
        return this;
    }
    public String getBusinessId() {
        return this.businessId;
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
