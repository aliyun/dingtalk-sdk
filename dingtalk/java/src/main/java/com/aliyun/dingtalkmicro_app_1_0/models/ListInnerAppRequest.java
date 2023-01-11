// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListInnerAppRequest extends TeaModel {
    /**
     * <p>合作空间corpId</p>
     */
    @NameInMap("ecologicalCorpId")
    public String ecologicalCorpId;

    public static ListInnerAppRequest build(java.util.Map<String, ?> map) throws Exception {
        ListInnerAppRequest self = new ListInnerAppRequest();
        return TeaModel.build(map, self);
    }

    public ListInnerAppRequest setEcologicalCorpId(String ecologicalCorpId) {
        this.ecologicalCorpId = ecologicalCorpId;
        return this;
    }
    public String getEcologicalCorpId() {
        return this.ecologicalCorpId;
    }

}
