// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeleteAssistantThreadResponseBody extends TeaModel {
    @NameInMap("deleted")
    public Boolean deleted;

    @NameInMap("id")
    public String id;

    @NameInMap("object")
    public String object;

    public static DeleteAssistantThreadResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteAssistantThreadResponseBody self = new DeleteAssistantThreadResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteAssistantThreadResponseBody setDeleted(Boolean deleted) {
        this.deleted = deleted;
        return this;
    }
    public Boolean getDeleted() {
        return this.deleted;
    }

    public DeleteAssistantThreadResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public DeleteAssistantThreadResponseBody setObject(String object) {
        this.object = object;
        return this;
    }
    public String getObject() {
        return this.object;
    }

}
