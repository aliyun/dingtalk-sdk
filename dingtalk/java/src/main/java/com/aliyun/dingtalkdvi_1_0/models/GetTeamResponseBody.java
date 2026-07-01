// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetTeamResponseBody extends TeaModel {
    @NameInMap("result")
    public GetTeamResponseBodyResult result;

    public static GetTeamResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTeamResponseBody self = new GetTeamResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTeamResponseBody setResult(GetTeamResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetTeamResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetTeamResponseBodyResultSceneList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static GetTeamResponseBodyResultSceneList build(java.util.Map<String, ?> map) throws Exception {
            GetTeamResponseBodyResultSceneList self = new GetTeamResponseBodyResultSceneList();
            return TeaModel.build(map, self);
        }

        public GetTeamResponseBodyResultSceneList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetTeamResponseBodyResultSceneList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetTeamResponseBodyResultTagListValueList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static GetTeamResponseBodyResultTagListValueList build(java.util.Map<String, ?> map) throws Exception {
            GetTeamResponseBodyResultTagListValueList self = new GetTeamResponseBodyResultTagListValueList();
            return TeaModel.build(map, self);
        }

        public GetTeamResponseBodyResultTagListValueList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetTeamResponseBodyResultTagListValueList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetTeamResponseBodyResultTagList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        @NameInMap("valueList")
        public java.util.List<GetTeamResponseBodyResultTagListValueList> valueList;

        public static GetTeamResponseBodyResultTagList build(java.util.Map<String, ?> map) throws Exception {
            GetTeamResponseBodyResultTagList self = new GetTeamResponseBodyResultTagList();
            return TeaModel.build(map, self);
        }

        public GetTeamResponseBodyResultTagList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetTeamResponseBodyResultTagList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTeamResponseBodyResultTagList setValueList(java.util.List<GetTeamResponseBodyResultTagListValueList> valueList) {
            this.valueList = valueList;
            return this;
        }
        public java.util.List<GetTeamResponseBodyResultTagListValueList> getValueList() {
            return this.valueList;
        }

    }

    public static class GetTeamResponseBodyResult extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("dialectCode")
        public String dialectCode;

        @NameInMap("dialectName")
        public String dialectName;

        @NameInMap("name")
        public String name;

        @NameInMap("sceneList")
        public java.util.List<GetTeamResponseBodyResultSceneList> sceneList;

        @NameInMap("solutionCode")
        public String solutionCode;

        @NameInMap("solutionName")
        public String solutionName;

        @NameInMap("tagList")
        public java.util.List<GetTeamResponseBodyResultTagList> tagList;

        public static GetTeamResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetTeamResponseBodyResult self = new GetTeamResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetTeamResponseBodyResult setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetTeamResponseBodyResult setDialectCode(String dialectCode) {
            this.dialectCode = dialectCode;
            return this;
        }
        public String getDialectCode() {
            return this.dialectCode;
        }

        public GetTeamResponseBodyResult setDialectName(String dialectName) {
            this.dialectName = dialectName;
            return this;
        }
        public String getDialectName() {
            return this.dialectName;
        }

        public GetTeamResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTeamResponseBodyResult setSceneList(java.util.List<GetTeamResponseBodyResultSceneList> sceneList) {
            this.sceneList = sceneList;
            return this;
        }
        public java.util.List<GetTeamResponseBodyResultSceneList> getSceneList() {
            return this.sceneList;
        }

        public GetTeamResponseBodyResult setSolutionCode(String solutionCode) {
            this.solutionCode = solutionCode;
            return this;
        }
        public String getSolutionCode() {
            return this.solutionCode;
        }

        public GetTeamResponseBodyResult setSolutionName(String solutionName) {
            this.solutionName = solutionName;
            return this;
        }
        public String getSolutionName() {
            return this.solutionName;
        }

        public GetTeamResponseBodyResult setTagList(java.util.List<GetTeamResponseBodyResultTagList> tagList) {
            this.tagList = tagList;
            return this;
        }
        public java.util.List<GetTeamResponseBodyResultTagList> getTagList() {
            return this.tagList;
        }

    }

}
