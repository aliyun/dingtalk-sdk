// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UserListValue extends TeaModel {
    @NameInMap("joinTime")
    public Long joinTime;

    @NameInMap("modifyTime")
    public Long modifyTime;

    @NameInMap("mute")
    public Boolean mute;

    @NameInMap("topRank")
    public Boolean topRank;

    @NameInMap("visible")
    public Boolean visible;

    public static UserListValue build(java.util.Map<String, ?> map) throws Exception {
        UserListValue self = new UserListValue();
        return TeaModel.build(map, self);
    }

    public UserListValue setJoinTime(Long joinTime) {
        this.joinTime = joinTime;
        return this;
    }
    public Long getJoinTime() {
        return this.joinTime;
    }

    public UserListValue setModifyTime(Long modifyTime) {
        this.modifyTime = modifyTime;
        return this;
    }
    public Long getModifyTime() {
        return this.modifyTime;
    }

    public UserListValue setMute(Boolean mute) {
        this.mute = mute;
        return this;
    }
    public Boolean getMute() {
        return this.mute;
    }

    public UserListValue setTopRank(Boolean topRank) {
        this.topRank = topRank;
        return this;
    }
    public Boolean getTopRank() {
        return this.topRank;
    }

    public UserListValue setVisible(Boolean visible) {
        this.visible = visible;
        return this;
    }
    public Boolean getVisible() {
        return this.visible;
    }

}
