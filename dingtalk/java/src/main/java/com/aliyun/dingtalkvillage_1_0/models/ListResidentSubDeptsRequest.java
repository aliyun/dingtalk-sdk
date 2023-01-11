// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentSubDeptsRequest extends TeaModel {
    /**
     * <p>游标，不传默认1</p>
     */
    @NameInMap("cursor")
    public Long cursor;

    /**
     * <p>大小</p>
     */
    @NameInMap("size")
    public Integer size;

    /**
     * <p>下属组织的组织ID，比如下属镇、村的corpId</p>
     */
    @NameInMap("subCorpId")
    public String subCorpId;

    public static ListResidentSubDeptsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListResidentSubDeptsRequest self = new ListResidentSubDeptsRequest();
        return TeaModel.build(map, self);
    }

    public ListResidentSubDeptsRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public ListResidentSubDeptsRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public ListResidentSubDeptsRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
