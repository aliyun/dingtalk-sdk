// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryUnionOrderRequest extends TeaModel {
    // 第三方企业id
    @NameInMap("corpId")
    public String corpId;

    // 第三方申请单id
    @NameInMap("thirdPartApplyId")
    public String thirdPartApplyId;

    // 关联单号
    @NameInMap("unionNo")
    public String unionNo;

    public static QueryUnionOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUnionOrderRequest self = new QueryUnionOrderRequest();
        return TeaModel.build(map, self);
    }

    public QueryUnionOrderRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryUnionOrderRequest setThirdPartApplyId(String thirdPartApplyId) {
        this.thirdPartApplyId = thirdPartApplyId;
        return this;
    }
    public String getThirdPartApplyId() {
        return this.thirdPartApplyId;
    }

    public QueryUnionOrderRequest setUnionNo(String unionNo) {
        this.unionNo = unionNo;
        return this;
    }
    public String getUnionNo() {
        return this.unionNo;
    }

}
