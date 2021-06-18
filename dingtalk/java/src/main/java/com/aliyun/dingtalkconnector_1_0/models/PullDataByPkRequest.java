// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class PullDataByPkRequest extends TeaModel {
    // 数据的主键字段值。
    @NameInMap("primaryKey")
    public String primaryKey;

    public static PullDataByPkRequest build(java.util.Map<String, ?> map) throws Exception {
        PullDataByPkRequest self = new PullDataByPkRequest();
        return TeaModel.build(map, self);
    }

    public PullDataByPkRequest setPrimaryKey(String primaryKey) {
        this.primaryKey = primaryKey;
        return this;
    }
    public String getPrimaryKey() {
        return this.primaryKey;
    }

}
