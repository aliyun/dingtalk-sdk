// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class GetTravelProcessDetailRequest extends TeaModel {
    @NameInMap("processCorpId")
    public String processCorpId;

    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static GetTravelProcessDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTravelProcessDetailRequest self = new GetTravelProcessDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetTravelProcessDetailRequest setProcessCorpId(String processCorpId) {
        this.processCorpId = processCorpId;
        return this;
    }
    public String getProcessCorpId() {
        return this.processCorpId;
    }

    public GetTravelProcessDetailRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
