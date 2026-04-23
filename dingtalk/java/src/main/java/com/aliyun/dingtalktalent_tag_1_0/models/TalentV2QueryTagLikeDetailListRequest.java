// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryTagLikeDetailListRequest extends TeaModel {
    @NameInMap("cursor")
    public Long cursor;

    @NameInMap("size")
    public Integer size;

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

    public static TalentV2QueryTagLikeDetailListRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryTagLikeDetailListRequest self = new TalentV2QueryTagLikeDetailListRequest();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryTagLikeDetailListRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public TalentV2QueryTagLikeDetailListRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public TalentV2QueryTagLikeDetailListRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

    public TalentV2QueryTagLikeDetailListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
