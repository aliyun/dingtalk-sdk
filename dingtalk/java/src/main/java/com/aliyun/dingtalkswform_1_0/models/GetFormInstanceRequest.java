// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class GetFormInstanceRequest extends TeaModel {
    /**
     * <p>填表类型。0表示通用填表，1表示教育版填表</p>
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
