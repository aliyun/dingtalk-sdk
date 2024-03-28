// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0.models;

import com.aliyun.tea.*;

public class QueryCoolAppShortcutOrderRequest extends TeaModel {
    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("templateId")
    public String templateId;

    public static QueryCoolAppShortcutOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCoolAppShortcutOrderRequest self = new QueryCoolAppShortcutOrderRequest();
        return TeaModel.build(map, self);
    }

    public QueryCoolAppShortcutOrderRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public QueryCoolAppShortcutOrderRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public QueryCoolAppShortcutOrderRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
