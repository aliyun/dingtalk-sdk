// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class TitleMention extends TeaModel {
    @NameInMap("length")
    public Long length;

    @NameInMap("offset")
    public Long offset;

    @NameInMap("user")
    public OpenUserDTO user;

    public static TitleMention build(java.util.Map<String, ?> map) throws Exception {
        TitleMention self = new TitleMention();
        return TeaModel.build(map, self);
    }

    public TitleMention setLength(Long length) {
        this.length = length;
        return this;
    }
    public Long getLength() {
        return this.length;
    }

    public TitleMention setOffset(Long offset) {
        this.offset = offset;
        return this;
    }
    public Long getOffset() {
        return this.offset;
    }

    public TitleMention setUser(OpenUserDTO user) {
        this.user = user;
        return this;
    }
    public OpenUserDTO getUser() {
        return this.user;
    }

}
