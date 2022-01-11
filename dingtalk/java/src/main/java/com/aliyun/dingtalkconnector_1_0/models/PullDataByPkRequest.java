// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class PullDataByPkRequest extends TeaModel {
    // 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
    @NameInMap("appId")
    public String appId;

    // 数据的主键字段值。
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
