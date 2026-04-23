// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2LikeTagRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("actionType")
    public String actionType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

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

    public static TalentV2LikeTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentV2LikeTagRequest self = new TalentV2LikeTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentV2LikeTagRequest setActionType(String actionType) {
        this.actionType = actionType;
        return this;
    }
    public String getActionType() {
        return this.actionType;
    }

    public TalentV2LikeTagRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public TalentV2LikeTagRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

    public TalentV2LikeTagRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
