// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListSubSpaceRequest extends TeaModel {
    // A short description of struct
    @NameInMap("residentCorpId")
    public String residentCorpId;

    @NameInMap("referId")
    public Long referId;

    public static ListSubSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSubSpaceRequest self = new ListSubSpaceRequest();
        return TeaModel.build(map, self);
    }

    public ListSubSpaceRequest setResidentCorpId(String residentCorpId) {
        this.residentCorpId = residentCorpId;
        return this;
    }
    public String getResidentCorpId() {
        return this.residentCorpId;
    }

    public ListSubSpaceRequest setReferId(Long referId) {
        this.referId = referId;
        return this;
    }
    public Long getReferId() {
        return this.referId;
    }

}
