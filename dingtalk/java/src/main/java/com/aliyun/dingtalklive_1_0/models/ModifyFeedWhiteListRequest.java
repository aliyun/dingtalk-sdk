// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class ModifyFeedWhiteListRequest extends TeaModel {
    /**
     * <p>操作类型（1 添加白名单 / 2 删除白名单）</p>
     */
    @NameInMap("action")
    public Long action;

    /**
     * <p>操作的白名单列表</p>
     */
    @NameInMap("modifyUserList")
    public java.util.List<String> modifyUserList;

    /**
     * <p>用户id（操作者的组织内id）</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ModifyFeedWhiteListRequest build(java.util.Map<String, ?> map) throws Exception {
        ModifyFeedWhiteListRequest self = new ModifyFeedWhiteListRequest();
        return TeaModel.build(map, self);
    }

    public ModifyFeedWhiteListRequest setAction(Long action) {
        this.action = action;
        return this;
    }
    public Long getAction() {
        return this.action;
    }

    public ModifyFeedWhiteListRequest setModifyUserList(java.util.List<String> modifyUserList) {
        this.modifyUserList = modifyUserList;
        return this;
    }
    public java.util.List<String> getModifyUserList() {
        return this.modifyUserList;
    }

    public ModifyFeedWhiteListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
