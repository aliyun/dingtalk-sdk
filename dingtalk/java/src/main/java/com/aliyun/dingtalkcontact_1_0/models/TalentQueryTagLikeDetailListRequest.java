// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryTagLikeDetailListRequest extends TeaModel {
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

    public static TalentQueryTagLikeDetailListRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryTagLikeDetailListRequest self = new TalentQueryTagLikeDetailListRequest();
        return TeaModel.build(map, self);
    }

    public TalentQueryTagLikeDetailListRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public TalentQueryTagLikeDetailListRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public TalentQueryTagLikeDetailListRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

    public TalentQueryTagLikeDetailListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
