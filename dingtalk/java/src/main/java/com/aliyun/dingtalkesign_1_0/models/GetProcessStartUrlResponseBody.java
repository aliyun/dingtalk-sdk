// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetProcessStartUrlResponseBody extends TeaModel {
    @NameInMap("message")
    public String message;

    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public GetProcessStartUrlResponseBodyData data;

    public static GetProcessStartUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProcessStartUrlResponseBody self = new GetProcessStartUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProcessStartUrlResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
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

    public static class GetProcessStartUrlResponseBodyData extends TeaModel {
        @NameInMap("taskId")
        public String taskId;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("mobileUrl")
        public String mobileUrl;

        public static GetProcessStartUrlResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetProcessStartUrlResponseBodyData self = new GetProcessStartUrlResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetProcessStartUrlResponseBodyData setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetProcessStartUrlResponseBodyData setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public GetProcessStartUrlResponseBodyData setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

    }

}
