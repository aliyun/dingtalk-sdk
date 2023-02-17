// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class TitleMention extends TeaModel {
    /**
     * <p>结束位置</p>
     */
    @NameInMap("length")
    public Integer length;

    /**
     * <p>开始位置</p>
     */
    @NameInMap("offset")
    public Integer offset;

    /**
     * <p>“@人员”对象信息</p>
     */
    @NameInMap("user")
    public OpenUserDTO user;

    public static TitleMention build(java.util.Map<String, ?> map) throws Exception {
        TitleMention self = new TitleMention();
        return TeaModel.build(map, self);
    }

    public TitleMention setLength(Integer length) {
        this.length = length;
        return this;
    }
    public Integer getLength() {
        return this.length;
    }

    public TitleMention setOffset(Integer offset) {
        this.offset = offset;
        return this;
    }
    public Integer getOffset() {
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
