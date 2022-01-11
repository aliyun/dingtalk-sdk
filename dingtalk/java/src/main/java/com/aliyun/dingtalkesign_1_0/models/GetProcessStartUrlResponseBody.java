// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetProcessStartUrlResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public GetProcessStartUrlResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static GetProcessStartUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProcessStartUrlResponseBody self = new GetProcessStartUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProcessStartUrlResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GetProcessStartUrlResponseBody setData(GetProcessStartUrlResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetProcessStartUrlResponseBodyData getData() {
        return this.data;
    }

    public GetProcessStartUrlResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetProcessStartUrlResponseBodyData extends TeaModel {
        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("taskId")
        public String taskId;

        public static GetProcessStartUrlResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetProcessStartUrlResponseBodyData self = new GetProcessStartUrlResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetProcessStartUrlResponseBodyData setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public GetProcessStartUrlResponseBodyData setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public GetProcessStartUrlResponseBodyData setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
