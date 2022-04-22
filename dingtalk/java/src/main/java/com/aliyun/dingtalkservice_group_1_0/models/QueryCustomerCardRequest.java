// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerCardRequest extends TeaModel {
    // 查询jsonString
    @NameInMap("jsonParams")
    public String jsonParams;

    @NameInMap("openTeamId")
    public String openTeamId;

    public static QueryCustomerCardRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerCardRequest self = new QueryCustomerCardRequest();
        return TeaModel.build(map, self);
    }

    public QueryCustomerCardRequest setJsonParams(String jsonParams) {
        this.jsonParams = jsonParams;
        return this;
    }
    public String getJsonParams() {
        return this.jsonParams;
    }

    public QueryCustomerCardRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
