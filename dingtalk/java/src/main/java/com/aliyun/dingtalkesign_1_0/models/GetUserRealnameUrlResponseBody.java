// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetUserRealnameUrlResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public GetUserRealnameUrlResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static GetUserRealnameUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserRealnameUrlResponseBody self = new GetUserRealnameUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserRealnameUrlResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GetUserRealnameUrlResponseBody setData(GetUserRealnameUrlResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetUserRealnameUrlResponseBodyData getData() {
        return this.data;
    }

    public GetUserRealnameUrlResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetUserRealnameUrlResponseBodyData extends TeaModel {
        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("taskId")
        public String taskId;

        public static GetUserRealnameUrlResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetUserRealnameUrlResponseBodyData self = new GetUserRealnameUrlResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetUserRealnameUrlResponseBodyData setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public GetUserRealnameUrlResponseBodyData setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public GetUserRealnameUrlResponseBodyData setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
