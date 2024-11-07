// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListVisibleAssistantRequest extends TeaModel {
    @NameInMap("cursor")
    public Long cursor;

    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ListVisibleAssistantRequest build(java.util.Map<String, ?> map) throws Exception {
        ListVisibleAssistantRequest self = new ListVisibleAssistantRequest();
        return TeaModel.build(map, self);
    }

    public ListVisibleAssistantRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public ListVisibleAssistantRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public ListVisibleAssistantRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListVisibleAssistantRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
