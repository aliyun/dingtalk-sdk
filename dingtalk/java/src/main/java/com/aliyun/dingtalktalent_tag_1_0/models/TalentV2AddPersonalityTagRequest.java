// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2AddPersonalityTagRequest extends TeaModel {
    @NameInMap("categoryCode")
    public String categoryCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("categoryName")
    public String categoryName;

    @NameInMap("categorySortOrder")
    public Integer categorySortOrder;

    @NameInMap("sortOrder")
    public Integer sortOrder;

    @NameInMap("tagCode")
    public String tagCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tagName")
    public String tagName;

    public static TalentV2AddPersonalityTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentV2AddPersonalityTagRequest self = new TalentV2AddPersonalityTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentV2AddPersonalityTagRequest setCategoryCode(String categoryCode) {
        this.categoryCode = categoryCode;
        return this;
    }
    public String getCategoryCode() {
        return this.categoryCode;
    }

    public TalentV2AddPersonalityTagRequest setCategoryName(String categoryName) {
        this.categoryName = categoryName;
        return this;
    }
    public String getCategoryName() {
        return this.categoryName;
    }

    public TalentV2AddPersonalityTagRequest setCategorySortOrder(Integer categorySortOrder) {
        this.categorySortOrder = categorySortOrder;
        return this;
    }
    public Integer getCategorySortOrder() {
        return this.categorySortOrder;
    }

    public TalentV2AddPersonalityTagRequest setSortOrder(Integer sortOrder) {
        this.sortOrder = sortOrder;
        return this;
    }
    public Integer getSortOrder() {
        return this.sortOrder;
    }

    public TalentV2AddPersonalityTagRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

    public TalentV2AddPersonalityTagRequest setTagName(String tagName) {
        this.tagName = tagName;
        return this;
    }
    public String getTagName() {
        return this.tagName;
    }

}
