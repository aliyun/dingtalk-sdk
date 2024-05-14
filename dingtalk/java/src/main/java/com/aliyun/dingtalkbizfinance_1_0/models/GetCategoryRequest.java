// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetCategoryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("code")
    public String code;

    public static GetCategoryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCategoryRequest self = new GetCategoryRequest();
        return TeaModel.build(map, self);
    }

    public GetCategoryRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
