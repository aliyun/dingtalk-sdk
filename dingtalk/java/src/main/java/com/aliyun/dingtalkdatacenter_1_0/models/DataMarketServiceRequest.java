// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class DataMarketServiceRequest extends TeaModel {
    @NameInMap("apiId")
    public String apiId;

    @NameInMap("args")
    public String args;

    public static DataMarketServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        DataMarketServiceRequest self = new DataMarketServiceRequest();
        return TeaModel.build(map, self);
    }

    public DataMarketServiceRequest setApiId(String apiId) {
        this.apiId = apiId;
        return this;
    }
    public String getApiId() {
        return this.apiId;
    }

    public DataMarketServiceRequest setArgs(String args) {
        this.args = args;
        return this;
    }
    public String getArgs() {
        return this.args;
    }

}
