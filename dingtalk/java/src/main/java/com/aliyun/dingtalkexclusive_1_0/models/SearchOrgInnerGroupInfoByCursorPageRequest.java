// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SearchOrgInnerGroupInfoByCursorPageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("count")
    public Integer count;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cursor")
    public Long cursor;

    @NameInMap("forward")
    public Boolean forward;

    public static SearchOrgInnerGroupInfoByCursorPageRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchOrgInnerGroupInfoByCursorPageRequest self = new SearchOrgInnerGroupInfoByCursorPageRequest();
        return TeaModel.build(map, self);
    }

    public SearchOrgInnerGroupInfoByCursorPageRequest setCount(Integer count) {
        this.count = count;
        return this;
    }
    public Integer getCount() {
        return this.count;
    }

    public SearchOrgInnerGroupInfoByCursorPageRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public SearchOrgInnerGroupInfoByCursorPageRequest setForward(Boolean forward) {
        this.forward = forward;
        return this;
    }
    public Boolean getForward() {
        return this.forward;
    }

}
