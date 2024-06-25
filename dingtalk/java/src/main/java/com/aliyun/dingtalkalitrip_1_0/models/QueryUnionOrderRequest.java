// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryUnionOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>tenant1231</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>第三方审批单号，关联单号和申请单号必选其一</p>
     */
    @NameInMap("thirdPartApplyId")
    public String thirdPartApplyId;

    /**
     * <strong>example:</strong>
     * <p>关联单号，关联单号和申请单号必选其一</p>
     */
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
