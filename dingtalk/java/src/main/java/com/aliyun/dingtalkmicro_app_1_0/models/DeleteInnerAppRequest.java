// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class DeleteInnerAppRequest extends TeaModel {
    // 操作人unionId
    @NameInMap("opUnionId")
    public String opUnionId;

    // 合作空间corpId
    @NameInMap("ecologicalCorpId")
    public String ecologicalCorpId;

    public static DeleteInnerAppRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteInnerAppRequest self = new DeleteInnerAppRequest();
        return TeaModel.build(map, self);
    }

    public DeleteInnerAppRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

    public DeleteInnerAppRequest setEcologicalCorpId(String ecologicalCorpId) {
        this.ecologicalCorpId = ecologicalCorpId;
        return this;
    }
    public String getEcologicalCorpId() {
        return this.ecologicalCorpId;
    }

}
