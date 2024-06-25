// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class TitleMention extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("length")
    public Integer length;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("offset")
    public Integer offset;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("user")
    public OpenAgoalUserDTO user;

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

    public TitleMention setUser(OpenAgoalUserDTO user) {
        this.user = user;
        return this;
    }
    public OpenAgoalUserDTO getUser() {
        return this.user;
    }

}
