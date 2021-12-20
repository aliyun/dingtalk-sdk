// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetResidentInfoRequest extends TeaModel {
    @NameInMap("residentCorpId")
    public String residentCorpId;

    public static GetResidentInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetResidentInfoRequest self = new GetResidentInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetResidentInfoRequest setResidentCorpId(String residentCorpId) {
        this.residentCorpId = residentCorpId;
        return this;
    }
    public String getResidentCorpId() {
        return this.residentCorpId;
    }

}
