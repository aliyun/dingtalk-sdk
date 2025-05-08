// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainTalentProfileAttachmentQueryRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<String> body;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    public static HrbrainTalentProfileAttachmentQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainTalentProfileAttachmentQueryRequest self = new HrbrainTalentProfileAttachmentQueryRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainTalentProfileAttachmentQueryRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

    public HrbrainTalentProfileAttachmentQueryRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

}
