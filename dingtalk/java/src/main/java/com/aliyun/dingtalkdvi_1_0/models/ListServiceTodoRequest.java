// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListServiceTodoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("recordId")
    public String recordId;

    public static ListServiceTodoRequest build(java.util.Map<String, ?> map) throws Exception {
        ListServiceTodoRequest self = new ListServiceTodoRequest();
        return TeaModel.build(map, self);
    }

    public ListServiceTodoRequest setRecordId(String recordId) {
        this.recordId = recordId;
        return this;
    }
    public String getRecordId() {
        return this.recordId;
    }

}
