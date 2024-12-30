// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class GetCategorySourceConfigListRequest extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    public static GetCategorySourceConfigListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCategorySourceConfigListRequest self = new GetCategorySourceConfigListRequest();
        return TeaModel.build(map, self);
    }

    public GetCategorySourceConfigListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
