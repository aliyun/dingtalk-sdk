// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class BusinessMatchResultResponseBody extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("isMatched")
    public Boolean isMatched;

    @NameInMap("status")
    public Integer status;

    public static BusinessMatchResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BusinessMatchResultResponseBody self = new BusinessMatchResultResponseBody();
        return TeaModel.build(map, self);
    }

    public BusinessMatchResultResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public BusinessMatchResultResponseBody setIsMatched(Boolean isMatched) {
        this.isMatched = isMatched;
        return this;
    }
    public Boolean getIsMatched() {
        return this.isMatched;
    }

    public BusinessMatchResultResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
