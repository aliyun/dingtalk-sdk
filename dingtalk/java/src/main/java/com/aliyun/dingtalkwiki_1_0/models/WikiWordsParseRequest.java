// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_1_0.models;

import com.aliyun.tea.*;

public class WikiWordsParseRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public String content;

    public static WikiWordsParseRequest build(java.util.Map<String, ?> map) throws Exception {
        WikiWordsParseRequest self = new WikiWordsParseRequest();
        return TeaModel.build(map, self);
    }

    public WikiWordsParseRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

}
