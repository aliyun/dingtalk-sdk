// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CardTemplateBuildActionResponseBody extends TeaModel {
    // 模板构建的dto对象
    @NameInMap("cardTemplateJson")
    public String cardTemplateJson;

    public static CardTemplateBuildActionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CardTemplateBuildActionResponseBody self = new CardTemplateBuildActionResponseBody();
        return TeaModel.build(map, self);
    }

    public CardTemplateBuildActionResponseBody setCardTemplateJson(String cardTemplateJson) {
        this.cardTemplateJson = cardTemplateJson;
        return this;
    }
    public String getCardTemplateJson() {
        return this.cardTemplateJson;
    }

}