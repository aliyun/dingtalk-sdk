// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class InviteMcuRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("mcuRoomCode")
    public String mcuRoomCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234567890</p>
     */
    @NameInMap("roomCode")
    public String roomCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>qzR1iSMDvzR9iPXXXXXXXXXXXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static InviteMcuRequest build(java.util.Map<String, ?> map) throws Exception {
        InviteMcuRequest self = new InviteMcuRequest();
        return TeaModel.build(map, self);
    }

    public InviteMcuRequest setMcuRoomCode(String mcuRoomCode) {
        this.mcuRoomCode = mcuRoomCode;
        return this;
    }
    public String getMcuRoomCode() {
        return this.mcuRoomCode;
    }

    public InviteMcuRequest setRoomCode(String roomCode) {
        this.roomCode = roomCode;
        return this;
    }
    public String getRoomCode() {
        return this.roomCode;
    }

    public InviteMcuRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
