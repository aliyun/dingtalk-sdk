// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialFormDataRequest extends TeaModel {
    @NameInMap("param")
    public String param;

    @NameInMap("userId")
    public String userId;

    public static QueryOfficialFormDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialFormDataRequest self = new QueryOfficialFormDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryOfficialFormDataRequest setParam(String param) {
        this.param = param;
        return this;
    }
    public String getParam() {
        return this.param;
    }

    public QueryOfficialFormDataRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
