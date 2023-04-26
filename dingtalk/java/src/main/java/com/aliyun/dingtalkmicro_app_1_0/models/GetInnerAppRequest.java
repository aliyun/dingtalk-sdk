// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetInnerAppRequest extends TeaModel {
    @NameInMap("ecologicalCorpId")
    public String ecologicalCorpId;

    @NameInMap("opUnionId")
    public String opUnionId;

    public static GetInnerAppRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInnerAppRequest self = new GetInnerAppRequest();
        return TeaModel.build(map, self);
    }

    public GetInnerAppRequest setEcologicalCorpId(String ecologicalCorpId) {
        this.ecologicalCorpId = ecologicalCorpId;
        return this;
    }
    public String getEcologicalCorpId() {
        return this.ecologicalCorpId;
    }

    public GetInnerAppRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

}
