// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentAddPersonalityTagRequest extends TeaModel {
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

    public static TalentAddPersonalityTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentAddPersonalityTagRequest self = new TalentAddPersonalityTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentAddPersonalityTagRequest setCategoryCode(String categoryCode) {
        this.categoryCode = categoryCode;
        return this;
    }
    public String getCategoryCode() {
        return this.categoryCode;
    }

    public TalentAddPersonalityTagRequest setCategoryName(String categoryName) {
        this.categoryName = categoryName;
        return this;
    }
    public String getCategoryName() {
        return this.categoryName;
    }

    public TalentAddPersonalityTagRequest setCategorySortOrder(Integer categorySortOrder) {
        this.categorySortOrder = categorySortOrder;
        return this;
    }
    public Integer getCategorySortOrder() {
        return this.categorySortOrder;
    }

    public TalentAddPersonalityTagRequest setSortOrder(Integer sortOrder) {
        this.sortOrder = sortOrder;
        return this;
    }
    public Integer getSortOrder() {
        return this.sortOrder;
    }

    public TalentAddPersonalityTagRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

    public TalentAddPersonalityTagRequest setTagName(String tagName) {
        this.tagName = tagName;
        return this;
    }
    public String getTagName() {
        return this.tagName;
    }

}
