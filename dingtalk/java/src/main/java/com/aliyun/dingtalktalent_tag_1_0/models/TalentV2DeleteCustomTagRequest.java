// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2DeleteCustomTagRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tagCode")
    public String tagCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static TalentV2DeleteCustomTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentV2DeleteCustomTagRequest self = new TalentV2DeleteCustomTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentV2DeleteCustomTagRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

    public TalentV2DeleteCustomTagRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
