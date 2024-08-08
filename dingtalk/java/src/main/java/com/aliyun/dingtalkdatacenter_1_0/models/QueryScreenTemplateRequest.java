// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryScreenTemplateRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("sample")
    public Boolean sample;

    public static QueryScreenTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryScreenTemplateRequest self = new QueryScreenTemplateRequest();
        return TeaModel.build(map, self);
    }

    public QueryScreenTemplateRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public QueryScreenTemplateRequest setSample(Boolean sample) {
        this.sample = sample;
        return this;
    }
    public Boolean getSample() {
        return this.sample;
    }

}
