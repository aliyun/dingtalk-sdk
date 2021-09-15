// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetDingIdByMigrationDingIdResponseBody extends TeaModel {
    // dingId
    @NameInMap("dingId")
    public String dingId;

    public static GetDingIdByMigrationDingIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDingIdByMigrationDingIdResponseBody self = new GetDingIdByMigrationDingIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDingIdByMigrationDingIdResponseBody setDingId(String dingId) {
        this.dingId = dingId;
        return this;
    }
    public String getDingId() {
        return this.dingId;
    }

}
