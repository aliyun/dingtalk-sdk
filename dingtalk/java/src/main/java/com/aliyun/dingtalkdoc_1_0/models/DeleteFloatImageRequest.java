// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteFloatImageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteFloatImageRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteFloatImageRequest self = new DeleteFloatImageRequest();
        return TeaModel.build(map, self);
    }

    public DeleteFloatImageRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
