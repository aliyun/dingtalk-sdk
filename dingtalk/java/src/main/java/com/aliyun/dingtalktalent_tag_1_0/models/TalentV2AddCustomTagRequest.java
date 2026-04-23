// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2AddCustomTagRequest extends TeaModel {
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

    public static TalentV2AddCustomTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentV2AddCustomTagRequest self = new TalentV2AddCustomTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentV2AddCustomTagRequest setSortOrder(Integer sortOrder) {
        this.sortOrder = sortOrder;
        return this;
    }
    public Integer getSortOrder() {
        return this.sortOrder;
    }

    public TalentV2AddCustomTagRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

    public TalentV2AddCustomTagRequest setTagName(String tagName) {
        this.tagName = tagName;
        return this;
    }
    public String getTagName() {
        return this.tagName;
    }

    public TalentV2AddCustomTagRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
