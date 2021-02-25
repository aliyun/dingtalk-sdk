// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ChannelOrderResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("message")
    public String message;

    @NameInMap("data")
    public ChannelOrderResponseBodyData data;

    public static ChannelOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChannelOrderResponseBody self = new ChannelOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public ChannelOrderResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public ChannelOrderResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public ChannelOrderResponseBody setData(ChannelOrderResponseBodyData data) {
        this.data = data;
        return this;
    }
    public ChannelOrderResponseBodyData getData() {
        return this.data;
    }

    public static class ChannelOrderResponseBodyData extends TeaModel {
        @NameInMap("esignOrderId")
        public String esignOrderId;

        public static ChannelOrderResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ChannelOrderResponseBodyData self = new ChannelOrderResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ChannelOrderResponseBodyData setEsignOrderId(String esignOrderId) {
            this.esignOrderId = esignOrderId;
            return this;
        }
        public String getEsignOrderId() {
            return this.esignOrderId;
        }

    }

}
