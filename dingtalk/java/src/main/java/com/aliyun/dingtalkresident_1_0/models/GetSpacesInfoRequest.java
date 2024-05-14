// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetSpacesInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("referIds")
    public java.util.List<Long> referIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("residentCorpId")
    public String residentCorpId;

    public static GetSpacesInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSpacesInfoRequest self = new GetSpacesInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetSpacesInfoRequest setReferIds(java.util.List<Long> referIds) {
        this.referIds = referIds;
        return this;
    }
    public java.util.List<Long> getReferIds() {
        return this.referIds;
    }

    public GetSpacesInfoRequest setResidentCorpId(String residentCorpId) {
        this.residentCorpId = residentCorpId;
        return this;
    }
    public String getResidentCorpId() {
        return this.residentCorpId;
    }

}
