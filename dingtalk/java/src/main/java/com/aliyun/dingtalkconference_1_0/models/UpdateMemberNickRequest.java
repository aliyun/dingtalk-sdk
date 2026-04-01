// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateMemberNickRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>新昵称</p>
     */
    @NameInMap("nick")
    public String nick;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>qzR1iSMDvzR9iP7Pxxxxxxxxxxxxxxx</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdateMemberNickRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMemberNickRequest self = new UpdateMemberNickRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMemberNickRequest setNick(String nick) {
        this.nick = nick;
        return this;
    }
    public String getNick() {
        return this.nick;
    }

    public UpdateMemberNickRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
