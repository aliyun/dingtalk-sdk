// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_1_0.models;

import com.aliyun.tea.*;

public class WikiWordsDetailRequest extends TeaModel {
    // 传递的词条名称
    @NameInMap("wordName")
    public String wordName;

    public static WikiWordsDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        WikiWordsDetailRequest self = new WikiWordsDetailRequest();
        return TeaModel.build(map, self);
    }

    public WikiWordsDetailRequest setWordName(String wordName) {
        this.wordName = wordName;
        return this;
    }
    public String getWordName() {
        return this.wordName;
    }

}
