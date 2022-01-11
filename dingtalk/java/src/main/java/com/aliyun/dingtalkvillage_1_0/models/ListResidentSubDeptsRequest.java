// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentSubDeptsRequest extends TeaModel {
    // 游标，不传默认1
    @NameInMap("cursor")
    public Long cursor;

    // 大小
    @NameInMap("size")
    public Integer size;

    // 下属组织的组织ID，比如下属镇、村的corpId
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
