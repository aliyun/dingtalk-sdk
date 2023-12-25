// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_ops_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryOpportunityTagRequest extends TeaModel {
    @NameInMap("corpIdList")
    public java.util.List<String> corpIdList;

    public static BatchQueryOpportunityTagRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryOpportunityTagRequest self = new BatchQueryOpportunityTagRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryOpportunityTagRequest setCorpIdList(java.util.List<String> corpIdList) {
        this.corpIdList = corpIdList;
        return this;
    }
    public java.util.List<String> getCorpIdList() {
        return this.corpIdList;
    }

}
