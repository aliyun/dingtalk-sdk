// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureJobBookResponseBody extends TeaModel {
    // content
    @NameInMap("content")
    public IndustrializeManufactureJobBookResponseBodyContent content;

    // 此次报工记录的唯一标识
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

    public IndustrializeManufactureJobBookResponseBody setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public static class IndustrializeManufactureJobBookResponseBodyContent extends TeaModel {
        // 新增记录的数据id
        @NameInMap("id")
        public Long id;

        // 更新记录的条数
        @NameInMap("count")
        public Long count;

        public static IndustrializeManufactureJobBookResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            IndustrializeManufactureJobBookResponseBodyContent self = new IndustrializeManufactureJobBookResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public IndustrializeManufactureJobBookResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public IndustrializeManufactureJobBookResponseBodyContent setCount(Long count) {
            this.count = count;
            return this;
        }
        public Long getCount() {
            return this.count;
        }

    }

}
