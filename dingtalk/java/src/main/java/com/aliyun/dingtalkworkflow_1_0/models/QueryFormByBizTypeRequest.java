// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryFormByBizTypeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appUuid")
    public String appUuid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizTypes")
    public java.util.List<String> bizTypes;

    public static QueryFormByBizTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryFormByBizTypeRequest self = new QueryFormByBizTypeRequest();
        return TeaModel.build(map, self);
    }

    public QueryFormByBizTypeRequest setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public QueryFormByBizTypeRequest setBizTypes(java.util.List<String> bizTypes) {
        this.bizTypes = bizTypes;
        return this;
    }
    public java.util.List<String> getBizTypes() {
        return this.bizTypes;
    }

}
