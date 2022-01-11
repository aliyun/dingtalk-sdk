// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SaveUserExtendValuesRequest extends TeaModel {
    // 字段展示名称
    @NameInMap("userDisplayName")
    public String userDisplayName;

    // 用户拓展字段key
    @NameInMap("userExtendKey")
    public String userExtendKey;

    // 用户扩展字段value
    @NameInMap("userExtendValue")
    public String userExtendValue;

    public static SaveUserExtendValuesRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveUserExtendValuesRequest self = new SaveUserExtendValuesRequest();
        return TeaModel.build(map, self);
    }

    public SaveUserExtendValuesRequest setUserDisplayName(String userDisplayName) {
        this.userDisplayName = userDisplayName;
        return this;
    }
    public String getUserDisplayName() {
        return this.userDisplayName;
    }

    public SaveUserExtendValuesRequest setUserExtendKey(String userExtendKey) {
        this.userExtendKey = userExtendKey;
        return this;
    }
    public String getUserExtendKey() {
        return this.userExtendKey;
    }

    public SaveUserExtendValuesRequest setUserExtendValue(String userExtendValue) {
        this.userExtendValue = userExtendValue;
        return this;
    }
    public String getUserExtendValue() {
        return this.userExtendValue;
    }

}
