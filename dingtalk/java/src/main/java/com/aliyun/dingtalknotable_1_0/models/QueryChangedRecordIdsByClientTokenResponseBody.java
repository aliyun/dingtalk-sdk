// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class QueryChangedRecordIdsByClientTokenResponseBody extends TeaModel {
    @NameInMap("changedRecordIds")
    public Object changedRecordIds;

    public static QueryChangedRecordIdsByClientTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryChangedRecordIdsByClientTokenResponseBody self = new QueryChangedRecordIdsByClientTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryChangedRecordIdsByClientTokenResponseBody setChangedRecordIds(Object changedRecordIds) {
        this.changedRecordIds = changedRecordIds;
        return this;
    }
    public Object getChangedRecordIds() {
        return this.changedRecordIds;
    }

}
