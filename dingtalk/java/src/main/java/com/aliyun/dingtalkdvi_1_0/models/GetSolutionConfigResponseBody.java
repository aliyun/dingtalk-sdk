// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetSolutionConfigResponseBody extends TeaModel {
    @NameInMap("result")
    public GetSolutionConfigResponseBodyResult result;

    public static GetSolutionConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSolutionConfigResponseBody self = new GetSolutionConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSolutionConfigResponseBody setResult(GetSolutionConfigResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetSolutionConfigResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetSolutionConfigResponseBodyResultDialectList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static GetSolutionConfigResponseBodyResultDialectList build(java.util.Map<String, ?> map) throws Exception {
            GetSolutionConfigResponseBodyResultDialectList self = new GetSolutionConfigResponseBodyResultDialectList();
            return TeaModel.build(map, self);
        }

        public GetSolutionConfigResponseBodyResultDialectList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetSolutionConfigResponseBodyResultDialectList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetSolutionConfigResponseBodyResultSolutionListSceneList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static GetSolutionConfigResponseBodyResultSolutionListSceneList build(java.util.Map<String, ?> map) throws Exception {
            GetSolutionConfigResponseBodyResultSolutionListSceneList self = new GetSolutionConfigResponseBodyResultSolutionListSceneList();
            return TeaModel.build(map, self);
        }

        public GetSolutionConfigResponseBodyResultSolutionListSceneList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetSolutionConfigResponseBodyResultSolutionListSceneList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetSolutionConfigResponseBodyResultSolutionList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        @NameInMap("sceneList")
        public java.util.List<GetSolutionConfigResponseBodyResultSolutionListSceneList> sceneList;

        public static GetSolutionConfigResponseBodyResultSolutionList build(java.util.Map<String, ?> map) throws Exception {
            GetSolutionConfigResponseBodyResultSolutionList self = new GetSolutionConfigResponseBodyResultSolutionList();
            return TeaModel.build(map, self);
        }

        public GetSolutionConfigResponseBodyResultSolutionList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetSolutionConfigResponseBodyResultSolutionList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetSolutionConfigResponseBodyResultSolutionList setSceneList(java.util.List<GetSolutionConfigResponseBodyResultSolutionListSceneList> sceneList) {
            this.sceneList = sceneList;
            return this;
        }
        public java.util.List<GetSolutionConfigResponseBodyResultSolutionListSceneList> getSceneList() {
            return this.sceneList;
        }

    }

    public static class GetSolutionConfigResponseBodyResult extends TeaModel {
        @NameInMap("dialectList")
        public java.util.List<GetSolutionConfigResponseBodyResultDialectList> dialectList;

        @NameInMap("solutionList")
        public java.util.List<GetSolutionConfigResponseBodyResultSolutionList> solutionList;

        public static GetSolutionConfigResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSolutionConfigResponseBodyResult self = new GetSolutionConfigResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSolutionConfigResponseBodyResult setDialectList(java.util.List<GetSolutionConfigResponseBodyResultDialectList> dialectList) {
            this.dialectList = dialectList;
            return this;
        }
        public java.util.List<GetSolutionConfigResponseBodyResultDialectList> getDialectList() {
            return this.dialectList;
        }

        public GetSolutionConfigResponseBodyResult setSolutionList(java.util.List<GetSolutionConfigResponseBodyResultSolutionList> solutionList) {
            this.solutionList = solutionList;
            return this;
        }
        public java.util.List<GetSolutionConfigResponseBodyResultSolutionList> getSolutionList() {
            return this.solutionList;
        }

    }

}
