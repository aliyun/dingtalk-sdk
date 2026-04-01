// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentDeleteObjectiveTagRequest extends TeaModel {
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

    public static TalentDeleteObjectiveTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentDeleteObjectiveTagRequest self = new TalentDeleteObjectiveTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentDeleteObjectiveTagRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

    public TalentDeleteObjectiveTagRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
