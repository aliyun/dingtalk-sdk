// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeleteAssistantMessageResponseBody extends TeaModel {
    @NameInMap("deleted")
    public Boolean deleted;

    @NameInMap("id")
    public String id;

    @NameInMap("object")
    public String object;

    public static DeleteAssistantMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteAssistantMessageResponseBody self = new DeleteAssistantMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteAssistantMessageResponseBody setDeleted(Boolean deleted) {
        this.deleted = deleted;
        return this;
    }
    public Boolean getDeleted() {
        return this.deleted;
    }

    public DeleteAssistantMessageResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public DeleteAssistantMessageResponseBody setObject(String object) {
        this.object = object;
        return this;
    }
    public String getObject() {
        return this.object;
    }

}
