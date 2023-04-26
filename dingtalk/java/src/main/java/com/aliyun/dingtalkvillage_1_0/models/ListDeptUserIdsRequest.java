// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptUserIdsRequest extends TeaModel {
    @NameInMap("subCorpId")
    public String subCorpId;

    public static ListDeptUserIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDeptUserIdsRequest self = new ListDeptUserIdsRequest();
        return TeaModel.build(map, self);
    }

    public ListDeptUserIdsRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
