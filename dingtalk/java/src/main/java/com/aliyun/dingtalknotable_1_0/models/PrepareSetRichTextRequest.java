// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class PrepareSetRichTextRequest extends TeaModel {
    @NameInMap("markdown")
    public String markdown;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static PrepareSetRichTextRequest build(java.util.Map<String, ?> map) throws Exception {
        PrepareSetRichTextRequest self = new PrepareSetRichTextRequest();
        return TeaModel.build(map, self);
    }

    public PrepareSetRichTextRequest setMarkdown(String markdown) {
        this.markdown = markdown;
        return this;
    }
    public String getMarkdown() {
        return this.markdown;
    }

    public PrepareSetRichTextRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
