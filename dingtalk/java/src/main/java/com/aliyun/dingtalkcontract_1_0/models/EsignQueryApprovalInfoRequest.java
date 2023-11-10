// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignQueryApprovalInfoRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("esignFlowId")
    public String esignFlowId;

    @NameInMap("unionId")
    public String unionId;

    public static EsignQueryApprovalInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        EsignQueryApprovalInfoRequest self = new EsignQueryApprovalInfoRequest();
        return TeaModel.build(map, self);
    }

    public EsignQueryApprovalInfoRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public EsignQueryApprovalInfoRequest setEsignFlowId(String esignFlowId) {
        this.esignFlowId = esignFlowId;
        return this;
    }
    public String getEsignFlowId() {
        return this.esignFlowId;
    }

    public EsignQueryApprovalInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
