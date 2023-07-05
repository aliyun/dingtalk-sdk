// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class RePushSuiteTicketRequest extends TeaModel {
    @NameInMap("suiteId")
    public Long suiteId;

    @NameInMap("suiteSecret")
    public String suiteSecret;

    public static RePushSuiteTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        RePushSuiteTicketRequest self = new RePushSuiteTicketRequest();
        return TeaModel.build(map, self);
    }

    public RePushSuiteTicketRequest setSuiteId(Long suiteId) {
        this.suiteId = suiteId;
        return this;
    }
    public Long getSuiteId() {
        return this.suiteId;
    }

    public RePushSuiteTicketRequest setSuiteSecret(String suiteSecret) {
        this.suiteSecret = suiteSecret;
        return this;
    }
    public String getSuiteSecret() {
        return this.suiteSecret;
    }

}
