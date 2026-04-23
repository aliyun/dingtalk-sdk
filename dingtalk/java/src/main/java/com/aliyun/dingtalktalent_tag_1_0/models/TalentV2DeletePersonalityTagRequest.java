// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2DeletePersonalityTagRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tagCode")
    public String tagCode;

    public static TalentV2DeletePersonalityTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentV2DeletePersonalityTagRequest self = new TalentV2DeletePersonalityTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentV2DeletePersonalityTagRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

}
