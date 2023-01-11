// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupSetRequest extends TeaModel {
    /**
     * <p>openTeamId</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    public static QueryGroupSetRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupSetRequest self = new QueryGroupSetRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupSetRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
