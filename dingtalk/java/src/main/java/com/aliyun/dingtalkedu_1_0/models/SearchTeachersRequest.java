// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SearchTeachersRequest extends TeaModel {
    @NameInMap("nameKeyword")
    public String nameKeyword;

    public static SearchTeachersRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchTeachersRequest self = new SearchTeachersRequest();
        return TeaModel.build(map, self);
    }

    public SearchTeachersRequest setNameKeyword(String nameKeyword) {
        this.nameKeyword = nameKeyword;
        return this;
    }
    public String getNameKeyword() {
        return this.nameKeyword;
    }

}
