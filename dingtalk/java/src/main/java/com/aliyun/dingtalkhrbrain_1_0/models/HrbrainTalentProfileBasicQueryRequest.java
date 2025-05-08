// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainTalentProfileBasicQueryRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<String> body;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    public static HrbrainTalentProfileBasicQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainTalentProfileBasicQueryRequest self = new HrbrainTalentProfileBasicQueryRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainTalentProfileBasicQueryRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

    public HrbrainTalentProfileBasicQueryRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

}
