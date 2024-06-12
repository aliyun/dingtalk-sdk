// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DataSyncRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sql")
    public String sql;

    public static DataSyncRequest build(java.util.Map<String, ?> map) throws Exception {
        DataSyncRequest self = new DataSyncRequest();
        return TeaModel.build(map, self);
    }

    public DataSyncRequest setSql(String sql) {
        this.sql = sql;
        return this;
    }
    public String getSql() {
        return this.sql;
    }

}
