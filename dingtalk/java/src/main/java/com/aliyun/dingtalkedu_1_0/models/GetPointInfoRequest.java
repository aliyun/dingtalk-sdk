// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetPointInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pointType")
    public String pointType;

    public static GetPointInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPointInfoRequest self = new GetPointInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetPointInfoRequest setPointType(String pointType) {
        this.pointType = pointType;
        return this;
    }
    public String getPointType() {
        return this.pointType;
    }

}
