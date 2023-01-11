// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceIdByTypeResponseBody extends TeaModel {
    /**
     * <p>部门id</p>
     */
    @NameInMap("referId")
    public Long referId;

    public static GetSpaceIdByTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceIdByTypeResponseBody self = new GetSpaceIdByTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSpaceIdByTypeResponseBody setReferId(Long referId) {
        this.referId = referId;
        return this;
    }
    public Long getReferId() {
        return this.referId;
    }

}
