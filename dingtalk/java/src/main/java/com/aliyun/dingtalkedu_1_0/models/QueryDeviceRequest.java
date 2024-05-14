// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sn")
    public String sn;

    public static QueryDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceRequest self = new QueryDeviceRequest();
        return TeaModel.build(map, self);
    }

    public QueryDeviceRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

}
