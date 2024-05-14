// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetUserLastMetricRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionIdList")
    public java.util.List<String> unionIdList;

    public static GetUserLastMetricRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserLastMetricRequest self = new GetUserLastMetricRequest();
        return TeaModel.build(map, self);
    }

    public GetUserLastMetricRequest setUnionIdList(java.util.List<String> unionIdList) {
        this.unionIdList = unionIdList;
        return this;
    }
    public java.util.List<String> getUnionIdList() {
        return this.unionIdList;
    }

}
