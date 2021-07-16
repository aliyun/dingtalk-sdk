// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ListTicketOperateRecordRequest extends TeaModel {
    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 工单开放ID
    @NameInMap("openTicketId")
    public String openTicketId;

    public static ListTicketOperateRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        ListTicketOperateRecordRequest self = new ListTicketOperateRecordRequest();
        return TeaModel.build(map, self);
    }

    public ListTicketOperateRecordRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public ListTicketOperateRecordRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

}
