// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class PullDataByPkRequest extends TeaModel {
    @NameInMap("appId")
    public String appId;

    @NameInMap("primaryKey")
    public String primaryKey;

    public static PullDataByPkRequest build(java.util.Map<String, ?> map) throws Exception {
        PullDataByPkRequest self = new PullDataByPkRequest();
        return TeaModel.build(map, self);
    }

    public PullDataByPkRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public PullDataByPkRequest setPrimaryKey(String primaryKey) {
        this.primaryKey = primaryKey;
        return this;
    }
    public String getPrimaryKey() {
        return this.primaryKey;
    }

}
