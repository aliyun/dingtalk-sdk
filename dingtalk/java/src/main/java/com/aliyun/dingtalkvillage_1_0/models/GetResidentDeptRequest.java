// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetResidentDeptRequest extends TeaModel {
    /**
     * <p>下属组织的组织ID，比如下属镇、村的corpId</p>
     */
    @NameInMap("subCorpId")
    public String subCorpId;

    public static GetResidentDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        GetResidentDeptRequest self = new GetResidentDeptRequest();
        return TeaModel.build(map, self);
    }

    public GetResidentDeptRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
