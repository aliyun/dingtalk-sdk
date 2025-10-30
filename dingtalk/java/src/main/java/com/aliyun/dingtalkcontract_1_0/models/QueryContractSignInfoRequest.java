// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractSignInfoRequest extends TeaModel {
    @NameInMap("contractBizId")
    public String contractBizId;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("staffId")
    public String staffId;

    public static QueryContractSignInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryContractSignInfoRequest self = new QueryContractSignInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryContractSignInfoRequest setContractBizId(String contractBizId) {
        this.contractBizId = contractBizId;
        return this;
    }
    public String getContractBizId() {
        return this.contractBizId;
    }

    public QueryContractSignInfoRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryContractSignInfoRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

}
