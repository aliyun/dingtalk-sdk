// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RenameDentryRequest extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("operatorId")
    public String operatorId;

    public static RenameDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        RenameDentryRequest self = new RenameDentryRequest();
        return TeaModel.build(map, self);
    }

    public RenameDentryRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public RenameDentryRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
