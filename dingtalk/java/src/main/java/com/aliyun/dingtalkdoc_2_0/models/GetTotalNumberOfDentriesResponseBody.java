// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetTotalNumberOfDentriesResponseBody extends TeaModel {
    @NameInMap("dentriesCount")
    public String dentriesCount;

    public static GetTotalNumberOfDentriesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTotalNumberOfDentriesResponseBody self = new GetTotalNumberOfDentriesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTotalNumberOfDentriesResponseBody setDentriesCount(String dentriesCount) {
        this.dentriesCount = dentriesCount;
        return this;
    }
    public String getDentriesCount() {
        return this.dentriesCount;
    }

}
