// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesKeywordResponseBody extends TeaModel {
    @NameInMap("keywords")
    public java.util.List<String> keywords;

    public static QueryMinutesKeywordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesKeywordResponseBody self = new QueryMinutesKeywordResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMinutesKeywordResponseBody setKeywords(java.util.List<String> keywords) {
        this.keywords = keywords;
        return this;
    }
    public java.util.List<String> getKeywords() {
        return this.keywords;
    }

}
