// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class CreateFieldResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>key: id或者name
     *     value: 对应字段值,不同类型的字段传入的value值不同
     *       - text: &quot;TextString&quot;          // 文本字符串
     *       - number: 123                 // 整数/浮点数均可
     *       - singleSelect: &quot;optionIdxxx1&quot; | &quot;optionName1&quot; // 单选选项Id/单选选项名
     *       - date: 1688601600000 ｜ &quot;2023-12-20 03:00&quot;
     *                                     // 支持传时间戳或ISO 8601字符串
     *       - user: [{
     *           uid: &quot;1234567&quot;            // 用户uid
     *         }, {
     *           uid: &quot;2345678&quot;
     *         }]</p>
     */
    @NameInMap("property")
    public java.util.Map<String, ?> property;

    @NameInMap("type")
    public String type;

    public static CreateFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateFieldResponseBody self = new CreateFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateFieldResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateFieldResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateFieldResponseBody setProperty(java.util.Map<String, ?> property) {
        this.property = property;
        return this;
    }
    public java.util.Map<String, ?> getProperty() {
        return this.property;
    }

    public CreateFieldResponseBody setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
