// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetRecordResponseBody extends TeaModel {
    @NameInMap("fields")
    public java.util.Map<String, ?> fields;

    @NameInMap("id")
    public String id;

    public static GetRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRecordResponseBody self = new GetRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRecordResponseBody setFields(java.util.Map<String, ?> fields) {
        this.fields = fields;
        return this;
    }
    public java.util.Map<String, ?> getFields() {
        return this.fields;
    }

    public GetRecordResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
