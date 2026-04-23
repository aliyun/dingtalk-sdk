// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2DeleteObjectiveTagRequest extends TeaModel {
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

    public static TalentV2DeleteObjectiveTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentV2DeleteObjectiveTagRequest self = new TalentV2DeleteObjectiveTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentV2DeleteObjectiveTagRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

    public TalentV2DeleteObjectiveTagRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
