// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetOrgLiveListShrinkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("requestBody")
    public String requestBodyShrink;

    public static GetOrgLiveListShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOrgLiveListShrinkRequest self = new GetOrgLiveListShrinkRequest();
        return TeaModel.build(map, self);
    }

    public GetOrgLiveListShrinkRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetOrgLiveListShrinkRequest setRequestBodyShrink(String requestBodyShrink) {
        this.requestBodyShrink = requestBodyShrink;
        return this;
    }
    public String getRequestBodyShrink() {
        return this.requestBodyShrink;
    }

}
