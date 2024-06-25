// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class TakeTicketRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>eKWh3GBwsKEiE</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>a8iS4X94TgtgiE</p>
     */
    @NameInMap("openTicketId")
    public String openTicketId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Dq9hP8Sk2v6vQ6l05nCe5wiEiE</p>
     */
    @NameInMap("takerUnionId")
    public String takerUnionId;

    public static TakeTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        TakeTicketRequest self = new TakeTicketRequest();
        return TeaModel.build(map, self);
    }

    public TakeTicketRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public TakeTicketRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public TakeTicketRequest setTakerUnionId(String takerUnionId) {
        this.takerUnionId = takerUnionId;
        return this;
    }
    public String getTakerUnionId() {
        return this.takerUnionId;
    }

}
