// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class GetPointInfoRequest extends TeaModel {
    @NameInMap("pointPoolCode")
    public String pointPoolCode;

    public static GetPointInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPointInfoRequest self = new GetPointInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetPointInfoRequest setPointPoolCode(String pointPoolCode) {
        this.pointPoolCode = pointPoolCode;
        return this;
    }
    public String getPointPoolCode() {
        return this.pointPoolCode;
    }

}
