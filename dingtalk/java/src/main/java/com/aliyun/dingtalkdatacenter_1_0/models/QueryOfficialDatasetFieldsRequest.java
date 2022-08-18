// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialDatasetFieldsRequest extends TeaModel {
    // 数据集id
    @NameInMap("dsId")
    public String dsId;

    // 用户id
    @NameInMap("userId")
    public String userId;

    public static QueryOfficialDatasetFieldsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialDatasetFieldsRequest self = new QueryOfficialDatasetFieldsRequest();
        return TeaModel.build(map, self);
    }

    public QueryOfficialDatasetFieldsRequest setDsId(String dsId) {
        this.dsId = dsId;
        return this;
    }
    public String getDsId() {
        return this.dsId;
    }

    public QueryOfficialDatasetFieldsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
