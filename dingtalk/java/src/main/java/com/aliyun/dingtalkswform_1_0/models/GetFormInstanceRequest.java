// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class GetFormInstanceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("bizType")
    public Integer bizType;

    public static GetFormInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFormInstanceRequest self = new GetFormInstanceRequest();
        return TeaModel.build(map, self);
    }

    public GetFormInstanceRequest setBizType(Integer bizType) {
        this.bizType = bizType;
        return this;
    }
    public Integer getBizType() {
        return this.bizType;
    }

}
