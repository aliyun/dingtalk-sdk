// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktre_1_0.models;

import com.aliyun.tea.*;

public class CreateTicketResponseBody extends TeaModel {
    @NameInMap("data")
    public CreateTicketResponseBodyData data;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static CreateTicketResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTicketResponseBody self = new CreateTicketResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTicketResponseBody setData(CreateTicketResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CreateTicketResponseBodyData getData() {
        return this.data;
    }

    public CreateTicketResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateTicketResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateTicketResponseBodyData extends TeaModel {
        @NameInMap("ticketId")
        public String ticketId;

        public static CreateTicketResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CreateTicketResponseBodyData self = new CreateTicketResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CreateTicketResponseBodyData setTicketId(String ticketId) {
            this.ticketId = ticketId;
            return this;
        }
        public String getTicketId() {
            return this.ticketId;
        }

    }

}
