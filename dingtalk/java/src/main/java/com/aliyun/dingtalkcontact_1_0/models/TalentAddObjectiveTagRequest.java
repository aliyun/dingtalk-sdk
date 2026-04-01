// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentAddObjectiveTagRequest extends TeaModel {
    @NameInMap("sortOrder")
    public Integer sortOrder;

    @NameInMap("tagCode")
    public String tagCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tagName")
    public String tagName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static TalentAddObjectiveTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentAddObjectiveTagRequest self = new TalentAddObjectiveTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentAddObjectiveTagRequest setSortOrder(Integer sortOrder) {
        this.sortOrder = sortOrder;
        return this;
    }
    public Integer getSortOrder() {
        return this.sortOrder;
    }

    public TalentAddObjectiveTagRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

    public TalentAddObjectiveTagRequest setTagName(String tagName) {
        this.tagName = tagName;
        return this;
    }
    public String getTagName() {
        return this.tagName;
    }

    public TalentAddObjectiveTagRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
