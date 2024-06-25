// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialFormDataDirectHoloRequest extends TeaModel {
    @NameInMap("param")
    public String param;

    @NameInMap("userId")
    public String userId;

    public static QueryOfficialFormDataDirectHoloRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialFormDataDirectHoloRequest self = new QueryOfficialFormDataDirectHoloRequest();
        return TeaModel.build(map, self);
    }

    public QueryOfficialFormDataDirectHoloRequest setParam(String param) {
        this.param = param;
        return this;
    }
    public String getParam() {
        return this.param;
    }

    public QueryOfficialFormDataDirectHoloRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
