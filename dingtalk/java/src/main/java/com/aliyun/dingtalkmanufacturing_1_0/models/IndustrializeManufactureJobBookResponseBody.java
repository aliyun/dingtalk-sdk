// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureJobBookResponseBody extends TeaModel {
    @NameInMap("content")
    public IndustrializeManufactureJobBookResponseBodyContent content;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorLevel")
    public Integer errorLevel;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("httpCode")
    public String httpCode;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("uuid")
    public String uuid;

    public static IndustrializeManufactureJobBookResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustrializeManufactureJobBookResponseBody self = new IndustrializeManufactureJobBookResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustrializeManufactureJobBookResponseBody setContent(IndustrializeManufactureJobBookResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public IndustrializeManufactureJobBookResponseBodyContent getContent() {
        return this.content;
    }

    public IndustrializeManufactureJobBookResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public IndustrializeManufactureJobBookResponseBody setErrorLevel(Integer errorLevel) {
        this.errorLevel = errorLevel;
        return this;
    }
    public Integer getErrorLevel() {
        return this.errorLevel;
    }

    public IndustrializeManufactureJobBookResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public IndustrializeManufactureJobBookResponseBody setHttpCode(String httpCode) {
        this.httpCode = httpCode;
        return this;
    }
    public String getHttpCode() {
        return this.httpCode;
    }

    public IndustrializeManufactureJobBookResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public IndustrializeManufactureJobBookResponseBody setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public static class IndustrializeManufactureJobBookResponseBodyContent extends TeaModel {
        @NameInMap("count")
        public Integer count;

        @NameInMap("id")
        public Long id;

        public static IndustrializeManufactureJobBookResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            IndustrializeManufactureJobBookResponseBodyContent self = new IndustrializeManufactureJobBookResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public IndustrializeManufactureJobBookResponseBodyContent setCount(Integer count) {
            this.count = count;
            return this;
        }
        public Integer getCount() {
            return this.count;
        }

        public IndustrializeManufactureJobBookResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

    }

}
