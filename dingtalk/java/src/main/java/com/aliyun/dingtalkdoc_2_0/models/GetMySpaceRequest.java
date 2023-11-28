// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetMySpaceRequest extends TeaModel {
    @NameInMap("isMySpace")
    public Boolean isMySpace;

    public static GetMySpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMySpaceRequest self = new GetMySpaceRequest();
        return TeaModel.build(map, self);
    }

    public GetMySpaceRequest setIsMySpace(Boolean isMySpace) {
        this.isMySpace = isMySpace;
        return this;
    }
    public Boolean getIsMySpace() {
        return this.isMySpace;
    }

}
