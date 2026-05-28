// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktre_1_0.models;

import com.aliyun.tea.*;

public class CreateTicketShrinkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("description")
    public String description;

    @NameInMap("priority")
    public String priority;

    @NameInMap("reporters")
    public String reportersShrink;

    public static CreateTicketShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTicketShrinkRequest self = new CreateTicketShrinkRequest();
        return TeaModel.build(map, self);
    }

    public CreateTicketShrinkRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateTicketShrinkRequest setPriority(String priority) {
        this.priority = priority;
        return this;
    }
    public String getPriority() {
        return this.priority;
    }

    public CreateTicketShrinkRequest setReportersShrink(String reportersShrink) {
        this.reportersShrink = reportersShrink;
        return this;
    }
    public String getReportersShrink() {
        return this.reportersShrink;
    }

}
