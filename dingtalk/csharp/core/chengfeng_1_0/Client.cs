// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 获取组织下的全部职级
         *
         * @param headers GetAllJobLevelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllJobLevelResponse
         */
        public GetAllJobLevelResponse GetAllJobLevelWithOptions(GetAllJobLevelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllJobLevel",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/jobLevels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllJobLevelResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取组织下的全部职级
         *
         * @param headers GetAllJobLevelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllJobLevelResponse
         */
        public async Task<GetAllJobLevelResponse> GetAllJobLevelWithOptionsAsync(GetAllJobLevelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllJobLevel",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/jobLevels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllJobLevelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取组织下的全部职级
         *
         * @return GetAllJobLevelResponse
         */
        public GetAllJobLevelResponse GetAllJobLevel()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobLevelHeaders headers = new GetAllJobLevelHeaders();
            return GetAllJobLevelWithOptions(headers, runtime);
        }

        /**
         * @summary 获取组织下的全部职级
         *
         * @return GetAllJobLevelResponse
         */
        public async Task<GetAllJobLevelResponse> GetAllJobLevelAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobLevelHeaders headers = new GetAllJobLevelHeaders();
            return await GetAllJobLevelWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取公司全部职位
         *
         * @param headers GetAllJobPositionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllJobPositionResponse
         */
        public GetAllJobPositionResponse GetAllJobPositionWithOptions(GetAllJobPositionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllJobPosition",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/jobPositions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllJobPositionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取公司全部职位
         *
         * @param headers GetAllJobPositionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllJobPositionResponse
         */
        public async Task<GetAllJobPositionResponse> GetAllJobPositionWithOptionsAsync(GetAllJobPositionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllJobPosition",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/jobPositions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllJobPositionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公司全部职位
         *
         * @return GetAllJobPositionResponse
         */
        public GetAllJobPositionResponse GetAllJobPosition()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobPositionHeaders headers = new GetAllJobPositionHeaders();
            return GetAllJobPositionWithOptions(headers, runtime);
        }

        /**
         * @summary 获取公司全部职位
         *
         * @return GetAllJobPositionResponse
         */
        public async Task<GetAllJobPositionResponse> GetAllJobPositionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobPositionHeaders headers = new GetAllJobPositionHeaders();
            return await GetAllJobPositionWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取组织下的所有职务
         *
         * @param headers GetAllJobPostHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllJobPostResponse
         */
        public GetAllJobPostResponse GetAllJobPostWithOptions(GetAllJobPostHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllJobPost",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/jobPosts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllJobPostResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取组织下的所有职务
         *
         * @param headers GetAllJobPostHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllJobPostResponse
         */
        public async Task<GetAllJobPostResponse> GetAllJobPostWithOptionsAsync(GetAllJobPostHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllJobPost",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/jobPosts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllJobPostResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取组织下的所有职务
         *
         * @return GetAllJobPostResponse
         */
        public GetAllJobPostResponse GetAllJobPost()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobPostHeaders headers = new GetAllJobPostHeaders();
            return GetAllJobPostWithOptions(headers, runtime);
        }

        /**
         * @summary 获取组织下的所有职务
         *
         * @return GetAllJobPostResponse
         */
        public async Task<GetAllJobPostResponse> GetAllJobPostAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobPostHeaders headers = new GetAllJobPostHeaders();
            return await GetAllJobPostWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取分析运营数据
         *
         * @param request GetAnalyzeDataRequest
         * @param headers GetAnalyzeDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAnalyzeDataResponse
         */
        public GetAnalyzeDataResponse GetAnalyzeDataWithOptions(GetAnalyzeDataRequest request, GetAnalyzeDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodIds))
            {
                body["periodIds"] = request.PeriodIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAnalyzeData",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/analyses/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnalyzeDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取分析运营数据
         *
         * @param request GetAnalyzeDataRequest
         * @param headers GetAnalyzeDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAnalyzeDataResponse
         */
        public async Task<GetAnalyzeDataResponse> GetAnalyzeDataWithOptionsAsync(GetAnalyzeDataRequest request, GetAnalyzeDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodIds))
            {
                body["periodIds"] = request.PeriodIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAnalyzeData",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/analyses/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnalyzeDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取分析运营数据
         *
         * @param request GetAnalyzeDataRequest
         * @return GetAnalyzeDataResponse
         */
        public GetAnalyzeDataResponse GetAnalyzeData(GetAnalyzeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAnalyzeDataHeaders headers = new GetAnalyzeDataHeaders();
            return GetAnalyzeDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取分析运营数据
         *
         * @param request GetAnalyzeDataRequest
         * @return GetAnalyzeDataResponse
         */
        public async Task<GetAnalyzeDataResponse> GetAnalyzeDataAsync(GetAnalyzeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAnalyzeDataHeaders headers = new GetAnalyzeDataHeaders();
            return await GetAnalyzeDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据部门编码查询下组织列表
         *
         * @param request GetChildOrgListRequest
         * @param headers GetChildOrgListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChildOrgListResponse
         */
        public GetChildOrgListResponse GetChildOrgListWithOptions(GetChildOrgListRequest request, GetChildOrgListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptCode))
            {
                query["deptCode"] = request.DeptCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChildOrgList",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChildOrgListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据部门编码查询下组织列表
         *
         * @param request GetChildOrgListRequest
         * @param headers GetChildOrgListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChildOrgListResponse
         */
        public async Task<GetChildOrgListResponse> GetChildOrgListWithOptionsAsync(GetChildOrgListRequest request, GetChildOrgListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptCode))
            {
                query["deptCode"] = request.DeptCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChildOrgList",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChildOrgListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据部门编码查询下组织列表
         *
         * @param request GetChildOrgListRequest
         * @return GetChildOrgListResponse
         */
        public GetChildOrgListResponse GetChildOrgList(GetChildOrgListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetChildOrgListHeaders headers = new GetChildOrgListHeaders();
            return GetChildOrgListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据部门编码查询下组织列表
         *
         * @param request GetChildOrgListRequest
         * @return GetChildOrgListResponse
         */
        public async Task<GetChildOrgListResponse> GetChildOrgListAsync(GetChildOrgListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetChildOrgListHeaders headers = new GetChildOrgListHeaders();
            return await GetChildOrgListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据工号查询员工基础信息
         *
         * @param request GetEmployeeInfoByWorkNoRequest
         * @param headers GetEmployeeInfoByWorkNoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmployeeInfoByWorkNoResponse
         */
        public GetEmployeeInfoByWorkNoResponse GetEmployeeInfoByWorkNoWithOptions(GetEmployeeInfoByWorkNoRequest request, GetEmployeeInfoByWorkNoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkNo))
            {
                query["workNo"] = request.WorkNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmployeeInfoByWorkNo",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/workNumbers/employees",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmployeeInfoByWorkNoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据工号查询员工基础信息
         *
         * @param request GetEmployeeInfoByWorkNoRequest
         * @param headers GetEmployeeInfoByWorkNoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmployeeInfoByWorkNoResponse
         */
        public async Task<GetEmployeeInfoByWorkNoResponse> GetEmployeeInfoByWorkNoWithOptionsAsync(GetEmployeeInfoByWorkNoRequest request, GetEmployeeInfoByWorkNoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkNo))
            {
                query["workNo"] = request.WorkNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmployeeInfoByWorkNo",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/workNumbers/employees",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmployeeInfoByWorkNoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据工号查询员工基础信息
         *
         * @param request GetEmployeeInfoByWorkNoRequest
         * @return GetEmployeeInfoByWorkNoResponse
         */
        public GetEmployeeInfoByWorkNoResponse GetEmployeeInfoByWorkNo(GetEmployeeInfoByWorkNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmployeeInfoByWorkNoHeaders headers = new GetEmployeeInfoByWorkNoHeaders();
            return GetEmployeeInfoByWorkNoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据工号查询员工基础信息
         *
         * @param request GetEmployeeInfoByWorkNoRequest
         * @return GetEmployeeInfoByWorkNoResponse
         */
        public async Task<GetEmployeeInfoByWorkNoResponse> GetEmployeeInfoByWorkNoAsync(GetEmployeeInfoByWorkNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmployeeInfoByWorkNoHeaders headers = new GetEmployeeInfoByWorkNoHeaders();
            return await GetEmployeeInfoByWorkNoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据人员工号查询人员任职记录
         *
         * @param headers GetEmploymentRecordByWorkNoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmploymentRecordByWorkNoResponse
         */
        public GetEmploymentRecordByWorkNoResponse GetEmploymentRecordByWorkNoWithOptions(string workNumbers, GetEmploymentRecordByWorkNoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmploymentRecordByWorkNo",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/users/workNumber/" + workNumbers + "employmentRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmploymentRecordByWorkNoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据人员工号查询人员任职记录
         *
         * @param headers GetEmploymentRecordByWorkNoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmploymentRecordByWorkNoResponse
         */
        public async Task<GetEmploymentRecordByWorkNoResponse> GetEmploymentRecordByWorkNoWithOptionsAsync(string workNumbers, GetEmploymentRecordByWorkNoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmploymentRecordByWorkNo",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/users/workNumber/" + workNumbers + "employmentRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmploymentRecordByWorkNoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据人员工号查询人员任职记录
         *
         * @return GetEmploymentRecordByWorkNoResponse
         */
        public GetEmploymentRecordByWorkNoResponse GetEmploymentRecordByWorkNo(string workNumbers)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmploymentRecordByWorkNoHeaders headers = new GetEmploymentRecordByWorkNoHeaders();
            return GetEmploymentRecordByWorkNoWithOptions(workNumbers, headers, runtime);
        }

        /**
         * @summary 根据人员工号查询人员任职记录
         *
         * @return GetEmploymentRecordByWorkNoResponse
         */
        public async Task<GetEmploymentRecordByWorkNoResponse> GetEmploymentRecordByWorkNoAsync(string workNumbers)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmploymentRecordByWorkNoHeaders headers = new GetEmploymentRecordByWorkNoHeaders();
            return await GetEmploymentRecordByWorkNoWithOptionsAsync(workNumbers, headers, runtime);
        }

        /**
         * @summary 获取职位详情
         *
         * @param request GetJobPositionRequest
         * @param headers GetJobPositionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobPositionResponse
         */
        public GetJobPositionResponse GetJobPositionWithOptions(GetJobPositionRequest request, GetJobPositionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPositionCode))
            {
                query["jobPositionCode"] = request.JobPositionCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobPosition",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/jobPositions/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobPositionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取职位详情
         *
         * @param request GetJobPositionRequest
         * @param headers GetJobPositionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobPositionResponse
         */
        public async Task<GetJobPositionResponse> GetJobPositionWithOptionsAsync(GetJobPositionRequest request, GetJobPositionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPositionCode))
            {
                query["jobPositionCode"] = request.JobPositionCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobPosition",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/jobPositions/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobPositionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取职位详情
         *
         * @param request GetJobPositionRequest
         * @return GetJobPositionResponse
         */
        public GetJobPositionResponse GetJobPosition(GetJobPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobPositionHeaders headers = new GetJobPositionHeaders();
            return GetJobPositionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取职位详情
         *
         * @param request GetJobPositionRequest
         * @return GetJobPositionResponse
         */
        public async Task<GetJobPositionResponse> GetJobPositionAsync(GetJobPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobPositionHeaders headers = new GetJobPositionHeaders();
            return await GetJobPositionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据编码获取职位详情
         *
         * @param request GetJobPostRequest
         * @param headers GetJobPostHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobPostResponse
         */
        public GetJobPostResponse GetJobPostWithOptions(GetJobPostRequest request, GetJobPostHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPostCode))
            {
                query["jobPostCode"] = request.JobPostCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobPost",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/jobPosts/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobPostResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据编码获取职位详情
         *
         * @param request GetJobPostRequest
         * @param headers GetJobPostHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobPostResponse
         */
        public async Task<GetJobPostResponse> GetJobPostWithOptionsAsync(GetJobPostRequest request, GetJobPostHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPostCode))
            {
                query["jobPostCode"] = request.JobPostCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobPost",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/jobPosts/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobPostResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据编码获取职位详情
         *
         * @param request GetJobPostRequest
         * @return GetJobPostResponse
         */
        public GetJobPostResponse GetJobPost(GetJobPostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobPostHeaders headers = new GetJobPostHeaders();
            return GetJobPostWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据编码获取职位详情
         *
         * @param request GetJobPostRequest
         * @return GetJobPostResponse
         */
        public async Task<GetJobPostResponse> GetJobPostAsync(GetJobPostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobPostHeaders headers = new GetJobPostHeaders();
            return await GetJobPostWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取组织详情
         *
         * @param request GetOrgInfoRequest
         * @param headers GetOrgInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrgInfoResponse
         */
        public GetOrgInfoResponse GetOrgInfoWithOptions(GetOrgInfoRequest request, GetOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptCode))
            {
                query["deptCode"] = request.DeptCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgInfo",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/organizations/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取组织详情
         *
         * @param request GetOrgInfoRequest
         * @param headers GetOrgInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrgInfoResponse
         */
        public async Task<GetOrgInfoResponse> GetOrgInfoWithOptionsAsync(GetOrgInfoRequest request, GetOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptCode))
            {
                query["deptCode"] = request.DeptCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgInfo",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/organizations/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取组织详情
         *
         * @param request GetOrgInfoRequest
         * @return GetOrgInfoResponse
         */
        public GetOrgInfoResponse GetOrgInfo(GetOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgInfoHeaders headers = new GetOrgInfoHeaders();
            return GetOrgInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取组织详情
         *
         * @param request GetOrgInfoRequest
         * @return GetOrgInfoResponse
         */
        public async Task<GetOrgInfoResponse> GetOrgInfoAsync(GetOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgInfoHeaders headers = new GetOrgInfoHeaders();
            return await GetOrgInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据员工工号获取员工的基本信息
         *
         * @param request GetStaffInfoByWorkNoRequest
         * @param headers GetStaffInfoByWorkNoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStaffInfoByWorkNoResponse
         */
        public GetStaffInfoByWorkNoResponse GetStaffInfoByWorkNoWithOptions(GetStaffInfoByWorkNoRequest request, GetStaffInfoByWorkNoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkNumbers))
            {
                query["workNumbers"] = request.WorkNumbers;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStaffInfoByWorkNo",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStaffInfoByWorkNoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据员工工号获取员工的基本信息
         *
         * @param request GetStaffInfoByWorkNoRequest
         * @param headers GetStaffInfoByWorkNoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStaffInfoByWorkNoResponse
         */
        public async Task<GetStaffInfoByWorkNoResponse> GetStaffInfoByWorkNoWithOptionsAsync(GetStaffInfoByWorkNoRequest request, GetStaffInfoByWorkNoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkNumbers))
            {
                query["workNumbers"] = request.WorkNumbers;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStaffInfoByWorkNo",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStaffInfoByWorkNoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据员工工号获取员工的基本信息
         *
         * @param request GetStaffInfoByWorkNoRequest
         * @return GetStaffInfoByWorkNoResponse
         */
        public GetStaffInfoByWorkNoResponse GetStaffInfoByWorkNo(GetStaffInfoByWorkNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStaffInfoByWorkNoHeaders headers = new GetStaffInfoByWorkNoHeaders();
            return GetStaffInfoByWorkNoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据员工工号获取员工的基本信息
         *
         * @param request GetStaffInfoByWorkNoRequest
         * @return GetStaffInfoByWorkNoResponse
         */
        public async Task<GetStaffInfoByWorkNoResponse> GetStaffInfoByWorkNoAsync(GetStaffInfoByWorkNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStaffInfoByWorkNoHeaders headers = new GetStaffInfoByWorkNoHeaders();
            return await GetStaffInfoByWorkNoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页查询员工信息
         *
         * @param request GetStaffPageQueryRequest
         * @param headers GetStaffPageQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStaffPageQueryResponse
         */
        public GetStaffPageQueryResponse GetStaffPageQueryWithOptions(GetStaffPageQueryRequest request, GetStaffPageQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptCode))
            {
                query["deptCode"] = request.DeptCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkNo))
            {
                query["workNo"] = request.WorkNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStaffPageQuery",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/users/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStaffPageQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 分页查询员工信息
         *
         * @param request GetStaffPageQueryRequest
         * @param headers GetStaffPageQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStaffPageQueryResponse
         */
        public async Task<GetStaffPageQueryResponse> GetStaffPageQueryWithOptionsAsync(GetStaffPageQueryRequest request, GetStaffPageQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptCode))
            {
                query["deptCode"] = request.DeptCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkNo))
            {
                query["workNo"] = request.WorkNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStaffPageQuery",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/users/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStaffPageQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 分页查询员工信息
         *
         * @param request GetStaffPageQueryRequest
         * @return GetStaffPageQueryResponse
         */
        public GetStaffPageQueryResponse GetStaffPageQuery(GetStaffPageQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStaffPageQueryHeaders headers = new GetStaffPageQueryHeaders();
            return GetStaffPageQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页查询员工信息
         *
         * @param request GetStaffPageQueryRequest
         * @return GetStaffPageQueryResponse
         */
        public async Task<GetStaffPageQueryResponse> GetStaffPageQueryAsync(GetStaffPageQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStaffPageQueryHeaders headers = new GetStaffPageQueryHeaders();
            return await GetStaffPageQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户信息
         *
         * @param request GetUserRequest
         * @param headers GetUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public GetUserResponse GetUserWithOptions(GetUserRequest request, GetUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OkrUserId))
            {
                query["okrUserId"] = request.OkrUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户信息
         *
         * @param request GetUserRequest
         * @param headers GetUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, GetUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OkrUserId))
            {
                query["okrUserId"] = request.OkrUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户信息
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return GetUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户信息
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return await GetUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 运营数据分析下的周期列表
         *
         * @param headers ListAnalyzePeriodsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAnalyzePeriodsResponse
         */
        public ListAnalyzePeriodsResponse ListAnalyzePeriodsWithOptions(ListAnalyzePeriodsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnalyzePeriods",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/analyses/periods",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnalyzePeriodsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 运营数据分析下的周期列表
         *
         * @param headers ListAnalyzePeriodsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAnalyzePeriodsResponse
         */
        public async Task<ListAnalyzePeriodsResponse> ListAnalyzePeriodsWithOptionsAsync(ListAnalyzePeriodsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnalyzePeriods",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/analyses/periods",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnalyzePeriodsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 运营数据分析下的周期列表
         *
         * @return ListAnalyzePeriodsResponse
         */
        public ListAnalyzePeriodsResponse ListAnalyzePeriods()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAnalyzePeriodsHeaders headers = new ListAnalyzePeriodsHeaders();
            return ListAnalyzePeriodsWithOptions(headers, runtime);
        }

        /**
         * @summary 运营数据分析下的周期列表
         *
         * @return ListAnalyzePeriodsResponse
         */
        public async Task<ListAnalyzePeriodsResponse> ListAnalyzePeriodsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAnalyzePeriodsHeaders headers = new ListAnalyzePeriodsHeaders();
            return await ListAnalyzePeriodsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 根据目标id批量获取目标列表
         *
         * @param request ListObjectiveByIdsRequest
         * @param headers ListObjectiveByIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListObjectiveByIdsResponse
         */
        public ListObjectiveByIdsResponse ListObjectiveByIdsWithOptions(ListObjectiveByIdsRequest request, ListObjectiveByIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveIds))
            {
                body["objectiveIds"] = request.ObjectiveIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjectiveByIds",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/objectives/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListObjectiveByIdsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据目标id批量获取目标列表
         *
         * @param request ListObjectiveByIdsRequest
         * @param headers ListObjectiveByIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListObjectiveByIdsResponse
         */
        public async Task<ListObjectiveByIdsResponse> ListObjectiveByIdsWithOptionsAsync(ListObjectiveByIdsRequest request, ListObjectiveByIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveIds))
            {
                body["objectiveIds"] = request.ObjectiveIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjectiveByIds",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/objectives/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListObjectiveByIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据目标id批量获取目标列表
         *
         * @param request ListObjectiveByIdsRequest
         * @return ListObjectiveByIdsResponse
         */
        public ListObjectiveByIdsResponse ListObjectiveByIds(ListObjectiveByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListObjectiveByIdsHeaders headers = new ListObjectiveByIdsHeaders();
            return ListObjectiveByIdsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据目标id批量获取目标列表
         *
         * @param request ListObjectiveByIdsRequest
         * @return ListObjectiveByIdsResponse
         */
        public async Task<ListObjectiveByIdsResponse> ListObjectiveByIdsAsync(ListObjectiveByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListObjectiveByIdsHeaders headers = new ListObjectiveByIdsHeaders();
            return await ListObjectiveByIdsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户的 OKR 列表
         *
         * @param request ListObjectiveByUserRequest
         * @param headers ListObjectiveByUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListObjectiveByUserResponse
         */
        public ListObjectiveByUserResponse ListObjectiveByUserWithOptions(ListObjectiveByUserRequest request, ListObjectiveByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjectiveByUser",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/users/objectives",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListObjectiveByUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户的 OKR 列表
         *
         * @param request ListObjectiveByUserRequest
         * @param headers ListObjectiveByUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListObjectiveByUserResponse
         */
        public async Task<ListObjectiveByUserResponse> ListObjectiveByUserWithOptionsAsync(ListObjectiveByUserRequest request, ListObjectiveByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjectiveByUser",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/users/objectives",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListObjectiveByUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户的 OKR 列表
         *
         * @param request ListObjectiveByUserRequest
         * @return ListObjectiveByUserResponse
         */
        public ListObjectiveByUserResponse ListObjectiveByUser(ListObjectiveByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListObjectiveByUserHeaders headers = new ListObjectiveByUserHeaders();
            return ListObjectiveByUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户的 OKR 列表
         *
         * @param request ListObjectiveByUserRequest
         * @return ListObjectiveByUserResponse
         */
        public async Task<ListObjectiveByUserResponse> ListObjectiveByUserAsync(ListObjectiveByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListObjectiveByUserHeaders headers = new ListObjectiveByUserHeaders();
            return await ListObjectiveByUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据进展id获取进展列表
         *
         * @param request ListProgressByIdsRequest
         * @param headers ListProgressByIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProgressByIdsResponse
         */
        public ListProgressByIdsResponse ListProgressByIdsWithOptions(ListProgressByIdsRequest request, ListProgressByIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressIds))
            {
                body["progressIds"] = request.ProgressIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProgressByIds",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/objectives/progresses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProgressByIdsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据进展id获取进展列表
         *
         * @param request ListProgressByIdsRequest
         * @param headers ListProgressByIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProgressByIdsResponse
         */
        public async Task<ListProgressByIdsResponse> ListProgressByIdsWithOptionsAsync(ListProgressByIdsRequest request, ListProgressByIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressIds))
            {
                body["progressIds"] = request.ProgressIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProgressByIds",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/objectives/progresses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProgressByIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据进展id获取进展列表
         *
         * @param request ListProgressByIdsRequest
         * @return ListProgressByIdsResponse
         */
        public ListProgressByIdsResponse ListProgressByIds(ListProgressByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProgressByIdsHeaders headers = new ListProgressByIdsHeaders();
            return ListProgressByIdsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据进展id获取进展列表
         *
         * @param request ListProgressByIdsRequest
         * @return ListProgressByIdsResponse
         */
        public async Task<ListProgressByIdsResponse> ListProgressByIdsAsync(ListProgressByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProgressByIdsHeaders headers = new ListProgressByIdsHeaders();
            return await ListProgressByIdsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页获取目标进展记录
         *
         * @param request PageListObjectiveProgressRequest
         * @param headers PageListObjectiveProgressHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListObjectiveProgressResponse
         */
        public PageListObjectiveProgressResponse PageListObjectiveProgressWithOptions(PageListObjectiveProgressRequest request, PageListObjectiveProgressHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListObjectiveProgress",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/objectives/progresses/records",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListObjectiveProgressResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 分页获取目标进展记录
         *
         * @param request PageListObjectiveProgressRequest
         * @param headers PageListObjectiveProgressHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListObjectiveProgressResponse
         */
        public async Task<PageListObjectiveProgressResponse> PageListObjectiveProgressWithOptionsAsync(PageListObjectiveProgressRequest request, PageListObjectiveProgressHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListObjectiveProgress",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/objectives/progresses/records",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListObjectiveProgressResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 分页获取目标进展记录
         *
         * @param request PageListObjectiveProgressRequest
         * @return PageListObjectiveProgressResponse
         */
        public PageListObjectiveProgressResponse PageListObjectiveProgress(PageListObjectiveProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListObjectiveProgressHeaders headers = new PageListObjectiveProgressHeaders();
            return PageListObjectiveProgressWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页获取目标进展记录
         *
         * @param request PageListObjectiveProgressRequest
         * @return PageListObjectiveProgressResponse
         */
        public async Task<PageListObjectiveProgressResponse> PageListObjectiveProgressAsync(PageListObjectiveProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListObjectiveProgressHeaders headers = new PageListObjectiveProgressHeaders();
            return await PageListObjectiveProgressWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 转交目标OKR
         *
         * @param request TransferUserObjectiveRequest
         * @param headers TransferUserObjectiveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferUserObjectiveResponse
         */
        public TransferUserObjectiveResponse TransferUserObjectiveWithOptions(TransferUserObjectiveRequest request, TransferUserObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["targetUserId"] = request.TargetUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferUserObjective",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/objectives/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferUserObjectiveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 转交目标OKR
         *
         * @param request TransferUserObjectiveRequest
         * @param headers TransferUserObjectiveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferUserObjectiveResponse
         */
        public async Task<TransferUserObjectiveResponse> TransferUserObjectiveWithOptionsAsync(TransferUserObjectiveRequest request, TransferUserObjectiveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["targetUserId"] = request.TargetUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferUserObjective",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/okr/objectives/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferUserObjectiveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 转交目标OKR
         *
         * @param request TransferUserObjectiveRequest
         * @return TransferUserObjectiveResponse
         */
        public TransferUserObjectiveResponse TransferUserObjective(TransferUserObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransferUserObjectiveHeaders headers = new TransferUserObjectiveHeaders();
            return TransferUserObjectiveWithOptions(request, headers, runtime);
        }

        /**
         * @summary 转交目标OKR
         *
         * @param request TransferUserObjectiveRequest
         * @return TransferUserObjectiveResponse
         */
        public async Task<TransferUserObjectiveResponse> TransferUserObjectiveAsync(TransferUserObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransferUserObjectiveHeaders headers = new TransferUserObjectiveHeaders();
            return await TransferUserObjectiveWithOptionsAsync(request, headers, runtime);
        }

    }
}
