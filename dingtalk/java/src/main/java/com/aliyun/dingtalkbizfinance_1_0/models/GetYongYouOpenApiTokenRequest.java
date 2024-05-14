// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetYongYouOpenApiTokenRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetYongYouOpenApiTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetYongYouOpenApiTokenRequest self = new GetYongYouOpenApiTokenRequest();
        return TeaModel.build(map, self);
    }

    public GetYongYouOpenApiTokenRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
