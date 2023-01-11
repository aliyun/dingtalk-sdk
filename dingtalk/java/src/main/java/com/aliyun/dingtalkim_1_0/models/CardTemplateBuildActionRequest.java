// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CardTemplateBuildActionRequest extends TeaModel {
    /**
     * <p>模板构建的action：含create、save、deploy</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>模板构建的dto对象</p>
     */
    @NameInMap("cardTemplateJson")
    public String cardTemplateJson;

    public static CardTemplateBuildActionRequest build(java.util.Map<String, ?> map) throws Exception {
        CardTemplateBuildActionRequest self = new CardTemplateBuildActionRequest();
        return TeaModel.build(map, self);
    }

    public CardTemplateBuildActionRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public CardTemplateBuildActionRequest setCardTemplateJson(String cardTemplateJson) {
        this.cardTemplateJson = cardTemplateJson;
        return this;
    }
    public String getCardTemplateJson() {
        return this.cardTemplateJson;
    }

}
