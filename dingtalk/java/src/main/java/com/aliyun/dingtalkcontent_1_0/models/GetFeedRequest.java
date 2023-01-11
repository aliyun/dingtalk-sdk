// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetFeedRequest extends TeaModel {
    /**
     * <p>入驻账号Id(请联系钉钉接口同学获取)</p>
     */
    @NameInMap("mcnId")
    public String mcnId;

    public static GetFeedRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFeedRequest self = new GetFeedRequest();
        return TeaModel.build(map, self);
    }

    public GetFeedRequest setMcnId(String mcnId) {
        this.mcnId = mcnId;
        return this;
    }
    public String getMcnId() {
        return this.mcnId;
    }

}
