// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubDeptIdsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subCorpId")
    public String subCorpId;

    public static ListSubDeptIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSubDeptIdsRequest self = new ListSubDeptIdsRequest();
        return TeaModel.build(map, self);
    }

    public ListSubDeptIdsRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
