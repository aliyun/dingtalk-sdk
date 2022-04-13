// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetBindChildInfoResponseBody extends TeaModel {
    // 孩子id
    @NameInMap("childUserId")
    public String childUserId;

    // 家庭id
    @NameInMap("familyCorpId")
    public String familyCorpId;

    public static GetBindChildInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetBindChildInfoResponseBody self = new GetBindChildInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetBindChildInfoResponseBody setChildUserId(String childUserId) {
        this.childUserId = childUserId;
        return this;
    }
    public String getChildUserId() {
        return this.childUserId;
    }

    public GetBindChildInfoResponseBody setFamilyCorpId(String familyCorpId) {
        this.familyCorpId = familyCorpId;
        return this;
    }
    public String getFamilyCorpId() {
        return this.familyCorpId;
    }

}
