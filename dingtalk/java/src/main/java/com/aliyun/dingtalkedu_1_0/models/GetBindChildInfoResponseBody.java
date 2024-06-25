// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetBindChildInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>3000000000307711730</p>
     */
    @NameInMap("childUserId")
    public String childUserId;

    /**
     * <strong>example:</strong>
     * <p>3000000000433459511</p>
     */
    @NameInMap("currentUserId")
    public String currentUserId;

    /**
     * <strong>example:</strong>
     * <p>ding95eef8003c9ca8ca24f2f5cc6abecb85</p>
     */
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

    public GetBindChildInfoResponseBody setCurrentUserId(String currentUserId) {
        this.currentUserId = currentUserId;
        return this;
    }
    public String getCurrentUserId() {
        return this.currentUserId;
    }

    public GetBindChildInfoResponseBody setFamilyCorpId(String familyCorpId) {
        this.familyCorpId = familyCorpId;
        return this;
    }
    public String getFamilyCorpId() {
        return this.familyCorpId;
    }

}
