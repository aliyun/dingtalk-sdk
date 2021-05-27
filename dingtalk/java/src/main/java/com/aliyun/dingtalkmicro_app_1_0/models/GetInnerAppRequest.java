// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetInnerAppRequest extends TeaModel {
    // 操作人unionId
    @NameInMap("opUnionId")
    public String opUnionId;

    // 关联组织corpId
    @NameInMap("ecologicalCorpId")
    public String ecologicalCorpId;

    public static GetInnerAppRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInnerAppRequest self = new GetInnerAppRequest();
        return TeaModel.build(map, self);
    }

    public GetInnerAppRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

    public GetInnerAppRequest setEcologicalCorpId(String ecologicalCorpId) {
        this.ecologicalCorpId = ecologicalCorpId;
        return this;
    }
    public String getEcologicalCorpId() {
        return this.ecologicalCorpId;
    }

}
