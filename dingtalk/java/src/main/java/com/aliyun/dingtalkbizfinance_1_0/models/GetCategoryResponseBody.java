// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetCategoryResponseBody extends TeaModel {
    /**
     * <p>类别code</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>是否为目录</p>
     */
    @NameInMap("isDir")
    public Boolean isDir;

    /**
     * <p>名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>父类别code</p>
     */
    @NameInMap("parentCode")
    public String parentCode;

    /**
     * <p>状态:valid,invalid,deleted</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>类型：income收入，expense支出</p>
     */
    @NameInMap("type")
    public String type;

    public static GetCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCategoryResponseBody self = new GetCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCategoryResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetCategoryResponseBody setIsDir(Boolean isDir) {
        this.isDir = isDir;
        return this;
    }
    public Boolean getIsDir() {
        return this.isDir;
    }

    public GetCategoryResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetCategoryResponseBody setParentCode(String parentCode) {
        this.parentCode = parentCode;
        return this;
    }
    public String getParentCode() {
        return this.parentCode;
    }

    public GetCategoryResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetCategoryResponseBody setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
