// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class SetSuperUserMeetingRoomRequest extends TeaModel {
    @NameInMap("deptIdWhiteList")
    public java.util.List<Long> deptIdWhiteList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("roomId")
    public String roomId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OcMXXXXXM2eRogiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    @NameInMap("userIdWhiteList")
    public java.util.List<String> userIdWhiteList;

    public static SetSuperUserMeetingRoomRequest build(java.util.Map<String, ?> map) throws Exception {
        SetSuperUserMeetingRoomRequest self = new SetSuperUserMeetingRoomRequest();
        return TeaModel.build(map, self);
    }

    public SetSuperUserMeetingRoomRequest setDeptIdWhiteList(java.util.List<Long> deptIdWhiteList) {
        this.deptIdWhiteList = deptIdWhiteList;
        return this;
    }
    public java.util.List<Long> getDeptIdWhiteList() {
        return this.deptIdWhiteList;
    }

    public SetSuperUserMeetingRoomRequest setRoomId(String roomId) {
        this.roomId = roomId;
        return this;
    }
    public String getRoomId() {
        return this.roomId;
    }

    public SetSuperUserMeetingRoomRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public SetSuperUserMeetingRoomRequest setUserIdWhiteList(java.util.List<String> userIdWhiteList) {
        this.userIdWhiteList = userIdWhiteList;
        return this;
    }
    public java.util.List<String> getUserIdWhiteList() {
        return this.userIdWhiteList;
    }

}
