// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryDocContentRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("targetFormat")
    public String targetFormat;

    public static QueryDocContentRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDocContentRequest self = new QueryDocContentRequest();
        return TeaModel.build(map, self);
    }

    public QueryDocContentRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public QueryDocContentRequest setTargetFormat(String targetFormat) {
        this.targetFormat = targetFormat;
        return this;
    }
    public String getTargetFormat() {
        return this.targetFormat;
    }

}
