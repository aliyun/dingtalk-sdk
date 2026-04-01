// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentDeletePersonalityTagRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tagCode")
    public String tagCode;

    public static TalentDeletePersonalityTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentDeletePersonalityTagRequest self = new TalentDeletePersonalityTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentDeletePersonalityTagRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

}
