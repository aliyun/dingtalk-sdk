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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的全部职级</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetAllJobLevelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllJobLevelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的全部职级</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetAllJobLevelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllJobLevelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的全部职级</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAllJobLevelResponse
        /// </returns>
        public GetAllJobLevelResponse GetAllJobLevel()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobLevelHeaders headers = new GetAllJobLevelHeaders();
            return GetAllJobLevelWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的全部职级</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAllJobLevelResponse
        /// </returns>
        public async Task<GetAllJobLevelResponse> GetAllJobLevelAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobLevelHeaders headers = new GetAllJobLevelHeaders();
            return await GetAllJobLevelWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公司全部职位</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetAllJobPositionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllJobPositionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公司全部职位</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetAllJobPositionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllJobPositionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公司全部职位</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAllJobPositionResponse
        /// </returns>
        public GetAllJobPositionResponse GetAllJobPosition()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobPositionHeaders headers = new GetAllJobPositionHeaders();
            return GetAllJobPositionWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公司全部职位</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAllJobPositionResponse
        /// </returns>
        public async Task<GetAllJobPositionResponse> GetAllJobPositionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobPositionHeaders headers = new GetAllJobPositionHeaders();
            return await GetAllJobPositionWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的所有职务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetAllJobPostHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllJobPostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的所有职务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetAllJobPostHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllJobPostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的所有职务</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAllJobPostResponse
        /// </returns>
        public GetAllJobPostResponse GetAllJobPost()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobPostHeaders headers = new GetAllJobPostHeaders();
            return GetAllJobPostWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的所有职务</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAllJobPostResponse
        /// </returns>
        public async Task<GetAllJobPostResponse> GetAllJobPostAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllJobPostHeaders headers = new GetAllJobPostHeaders();
            return await GetAllJobPostWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分析运营数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAnalyzeDataRequest
        /// </param>
        /// <param name="headers">
        /// GetAnalyzeDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAnalyzeDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分析运营数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAnalyzeDataRequest
        /// </param>
        /// <param name="headers">
        /// GetAnalyzeDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAnalyzeDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分析运营数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAnalyzeDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAnalyzeDataResponse
        /// </returns>
        public GetAnalyzeDataResponse GetAnalyzeData(GetAnalyzeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAnalyzeDataHeaders headers = new GetAnalyzeDataHeaders();
            return GetAnalyzeDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分析运营数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAnalyzeDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAnalyzeDataResponse
        /// </returns>
        public async Task<GetAnalyzeDataResponse> GetAnalyzeDataAsync(GetAnalyzeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAnalyzeDataHeaders headers = new GetAnalyzeDataHeaders();
            return await GetAnalyzeDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据部门编码查询下组织列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChildOrgListRequest
        /// </param>
        /// <param name="headers">
        /// GetChildOrgListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChildOrgListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据部门编码查询下组织列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChildOrgListRequest
        /// </param>
        /// <param name="headers">
        /// GetChildOrgListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChildOrgListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据部门编码查询下组织列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChildOrgListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChildOrgListResponse
        /// </returns>
        public GetChildOrgListResponse GetChildOrgList(GetChildOrgListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetChildOrgListHeaders headers = new GetChildOrgListHeaders();
            return GetChildOrgListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据部门编码查询下组织列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChildOrgListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChildOrgListResponse
        /// </returns>
        public async Task<GetChildOrgListResponse> GetChildOrgListAsync(GetChildOrgListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetChildOrgListHeaders headers = new GetChildOrgListHeaders();
            return await GetChildOrgListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据工号查询员工基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmployeeInfoByWorkNoRequest
        /// </param>
        /// <param name="headers">
        /// GetEmployeeInfoByWorkNoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmployeeInfoByWorkNoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据工号查询员工基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmployeeInfoByWorkNoRequest
        /// </param>
        /// <param name="headers">
        /// GetEmployeeInfoByWorkNoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmployeeInfoByWorkNoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据工号查询员工基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmployeeInfoByWorkNoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEmployeeInfoByWorkNoResponse
        /// </returns>
        public GetEmployeeInfoByWorkNoResponse GetEmployeeInfoByWorkNo(GetEmployeeInfoByWorkNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmployeeInfoByWorkNoHeaders headers = new GetEmployeeInfoByWorkNoHeaders();
            return GetEmployeeInfoByWorkNoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据工号查询员工基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmployeeInfoByWorkNoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEmployeeInfoByWorkNoResponse
        /// </returns>
        public async Task<GetEmployeeInfoByWorkNoResponse> GetEmployeeInfoByWorkNoAsync(GetEmployeeInfoByWorkNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmployeeInfoByWorkNoHeaders headers = new GetEmployeeInfoByWorkNoHeaders();
            return await GetEmployeeInfoByWorkNoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据人员工号查询人员任职记录</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetEmploymentRecordByWorkNoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmploymentRecordByWorkNoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据人员工号查询人员任职记录</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetEmploymentRecordByWorkNoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmploymentRecordByWorkNoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据人员工号查询人员任职记录</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEmploymentRecordByWorkNoResponse
        /// </returns>
        public GetEmploymentRecordByWorkNoResponse GetEmploymentRecordByWorkNo(string workNumbers)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmploymentRecordByWorkNoHeaders headers = new GetEmploymentRecordByWorkNoHeaders();
            return GetEmploymentRecordByWorkNoWithOptions(workNumbers, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据人员工号查询人员任职记录</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEmploymentRecordByWorkNoResponse
        /// </returns>
        public async Task<GetEmploymentRecordByWorkNoResponse> GetEmploymentRecordByWorkNoAsync(string workNumbers)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmploymentRecordByWorkNoHeaders headers = new GetEmploymentRecordByWorkNoHeaders();
            return await GetEmploymentRecordByWorkNoWithOptionsAsync(workNumbers, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取职位详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobPositionRequest
        /// </param>
        /// <param name="headers">
        /// GetJobPositionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobPositionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取职位详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobPositionRequest
        /// </param>
        /// <param name="headers">
        /// GetJobPositionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobPositionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取职位详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobPositionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobPositionResponse
        /// </returns>
        public GetJobPositionResponse GetJobPosition(GetJobPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobPositionHeaders headers = new GetJobPositionHeaders();
            return GetJobPositionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取职位详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobPositionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobPositionResponse
        /// </returns>
        public async Task<GetJobPositionResponse> GetJobPositionAsync(GetJobPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobPositionHeaders headers = new GetJobPositionHeaders();
            return await GetJobPositionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据编码获取职位详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobPostRequest
        /// </param>
        /// <param name="headers">
        /// GetJobPostHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobPostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据编码获取职位详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobPostRequest
        /// </param>
        /// <param name="headers">
        /// GetJobPostHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobPostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据编码获取职位详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobPostRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobPostResponse
        /// </returns>
        public GetJobPostResponse GetJobPost(GetJobPostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobPostHeaders headers = new GetJobPostHeaders();
            return GetJobPostWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据编码获取职位详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobPostRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobPostResponse
        /// </returns>
        public async Task<GetJobPostResponse> GetJobPostAsync(GetJobPostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobPostHeaders headers = new GetJobPostHeaders();
            return await GetJobPostWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetOrgInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrgInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetOrgInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrgInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrgInfoResponse
        /// </returns>
        public GetOrgInfoResponse GetOrgInfo(GetOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgInfoHeaders headers = new GetOrgInfoHeaders();
            return GetOrgInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrgInfoResponse
        /// </returns>
        public async Task<GetOrgInfoResponse> GetOrgInfoAsync(GetOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgInfoHeaders headers = new GetOrgInfoHeaders();
            return await GetOrgInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据员工工号获取员工的基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaffInfoByWorkNoRequest
        /// </param>
        /// <param name="headers">
        /// GetStaffInfoByWorkNoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStaffInfoByWorkNoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据员工工号获取员工的基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaffInfoByWorkNoRequest
        /// </param>
        /// <param name="headers">
        /// GetStaffInfoByWorkNoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStaffInfoByWorkNoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据员工工号获取员工的基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaffInfoByWorkNoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStaffInfoByWorkNoResponse
        /// </returns>
        public GetStaffInfoByWorkNoResponse GetStaffInfoByWorkNo(GetStaffInfoByWorkNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStaffInfoByWorkNoHeaders headers = new GetStaffInfoByWorkNoHeaders();
            return GetStaffInfoByWorkNoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据员工工号获取员工的基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaffInfoByWorkNoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStaffInfoByWorkNoResponse
        /// </returns>
        public async Task<GetStaffInfoByWorkNoResponse> GetStaffInfoByWorkNoAsync(GetStaffInfoByWorkNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStaffInfoByWorkNoHeaders headers = new GetStaffInfoByWorkNoHeaders();
            return await GetStaffInfoByWorkNoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询员工信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaffPageQueryRequest
        /// </param>
        /// <param name="headers">
        /// GetStaffPageQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStaffPageQueryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询员工信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaffPageQueryRequest
        /// </param>
        /// <param name="headers">
        /// GetStaffPageQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStaffPageQueryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询员工信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaffPageQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStaffPageQueryResponse
        /// </returns>
        public GetStaffPageQueryResponse GetStaffPageQuery(GetStaffPageQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStaffPageQueryHeaders headers = new GetStaffPageQueryHeaders();
            return GetStaffPageQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询员工信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaffPageQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStaffPageQueryResponse
        /// </returns>
        public async Task<GetStaffPageQueryResponse> GetStaffPageQueryAsync(GetStaffPageQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStaffPageQueryHeaders headers = new GetStaffPageQueryHeaders();
            return await GetStaffPageQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="headers">
        /// GetUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="headers">
        /// GetUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return GetUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return await GetUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运营数据分析下的周期列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListAnalyzePeriodsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnalyzePeriodsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运营数据分析下的周期列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListAnalyzePeriodsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnalyzePeriodsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运营数据分析下的周期列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAnalyzePeriodsResponse
        /// </returns>
        public ListAnalyzePeriodsResponse ListAnalyzePeriods()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAnalyzePeriodsHeaders headers = new ListAnalyzePeriodsHeaders();
            return ListAnalyzePeriodsWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运营数据分析下的周期列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAnalyzePeriodsResponse
        /// </returns>
        public async Task<ListAnalyzePeriodsResponse> ListAnalyzePeriodsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAnalyzePeriodsHeaders headers = new ListAnalyzePeriodsHeaders();
            return await ListAnalyzePeriodsWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据目标id批量获取目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectiveByIdsRequest
        /// </param>
        /// <param name="headers">
        /// ListObjectiveByIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListObjectiveByIdsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据目标id批量获取目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectiveByIdsRequest
        /// </param>
        /// <param name="headers">
        /// ListObjectiveByIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListObjectiveByIdsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据目标id批量获取目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectiveByIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListObjectiveByIdsResponse
        /// </returns>
        public ListObjectiveByIdsResponse ListObjectiveByIds(ListObjectiveByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListObjectiveByIdsHeaders headers = new ListObjectiveByIdsHeaders();
            return ListObjectiveByIdsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据目标id批量获取目标列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectiveByIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListObjectiveByIdsResponse
        /// </returns>
        public async Task<ListObjectiveByIdsResponse> ListObjectiveByIdsAsync(ListObjectiveByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListObjectiveByIdsHeaders headers = new ListObjectiveByIdsHeaders();
            return await ListObjectiveByIdsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户的 OKR 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectiveByUserRequest
        /// </param>
        /// <param name="headers">
        /// ListObjectiveByUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListObjectiveByUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户的 OKR 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectiveByUserRequest
        /// </param>
        /// <param name="headers">
        /// ListObjectiveByUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListObjectiveByUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户的 OKR 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectiveByUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListObjectiveByUserResponse
        /// </returns>
        public ListObjectiveByUserResponse ListObjectiveByUser(ListObjectiveByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListObjectiveByUserHeaders headers = new ListObjectiveByUserHeaders();
            return ListObjectiveByUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户的 OKR 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectiveByUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListObjectiveByUserResponse
        /// </returns>
        public async Task<ListObjectiveByUserResponse> ListObjectiveByUserAsync(ListObjectiveByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListObjectiveByUserHeaders headers = new ListObjectiveByUserHeaders();
            return await ListObjectiveByUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据进展id获取进展列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProgressByIdsRequest
        /// </param>
        /// <param name="headers">
        /// ListProgressByIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProgressByIdsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据进展id获取进展列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProgressByIdsRequest
        /// </param>
        /// <param name="headers">
        /// ListProgressByIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProgressByIdsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据进展id获取进展列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProgressByIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProgressByIdsResponse
        /// </returns>
        public ListProgressByIdsResponse ListProgressByIds(ListProgressByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProgressByIdsHeaders headers = new ListProgressByIdsHeaders();
            return ListProgressByIdsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据进展id获取进展列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProgressByIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProgressByIdsResponse
        /// </returns>
        public async Task<ListProgressByIdsResponse> ListProgressByIdsAsync(ListProgressByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProgressByIdsHeaders headers = new ListProgressByIdsHeaders();
            return await ListProgressByIdsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的日志数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSlsLogRequest
        /// </param>
        /// <param name="headers">
        /// ListSlsLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSlsLogResponse
        /// </returns>
        public ListSlsLogResponse ListSlsLogWithOptions(ListSlsLogRequest request, ListSlsLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["appCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "ListSlsLog",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/organizations/slsLogDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSlsLogResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的日志数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSlsLogRequest
        /// </param>
        /// <param name="headers">
        /// ListSlsLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSlsLogResponse
        /// </returns>
        public async Task<ListSlsLogResponse> ListSlsLogWithOptionsAsync(ListSlsLogRequest request, ListSlsLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["appCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "ListSlsLog",
                Version = "chengfeng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/chengfeng/organizations/slsLogDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSlsLogResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的日志数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSlsLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSlsLogResponse
        /// </returns>
        public ListSlsLogResponse ListSlsLog(ListSlsLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSlsLogHeaders headers = new ListSlsLogHeaders();
            return ListSlsLogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的日志数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSlsLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSlsLogResponse
        /// </returns>
        public async Task<ListSlsLogResponse> ListSlsLogAsync(ListSlsLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSlsLogHeaders headers = new ListSlsLogHeaders();
            return await ListSlsLogWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取目标进展记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListObjectiveProgressRequest
        /// </param>
        /// <param name="headers">
        /// PageListObjectiveProgressHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListObjectiveProgressResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取目标进展记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListObjectiveProgressRequest
        /// </param>
        /// <param name="headers">
        /// PageListObjectiveProgressHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListObjectiveProgressResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取目标进展记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListObjectiveProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListObjectiveProgressResponse
        /// </returns>
        public PageListObjectiveProgressResponse PageListObjectiveProgress(PageListObjectiveProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListObjectiveProgressHeaders headers = new PageListObjectiveProgressHeaders();
            return PageListObjectiveProgressWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取目标进展记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListObjectiveProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListObjectiveProgressResponse
        /// </returns>
        public async Task<PageListObjectiveProgressResponse> PageListObjectiveProgressAsync(PageListObjectiveProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListObjectiveProgressHeaders headers = new PageListObjectiveProgressHeaders();
            return await PageListObjectiveProgressWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转交目标OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferUserObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// TransferUserObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferUserObjectiveResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转交目标OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferUserObjectiveRequest
        /// </param>
        /// <param name="headers">
        /// TransferUserObjectiveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferUserObjectiveResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转交目标OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferUserObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferUserObjectiveResponse
        /// </returns>
        public TransferUserObjectiveResponse TransferUserObjective(TransferUserObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransferUserObjectiveHeaders headers = new TransferUserObjectiveHeaders();
            return TransferUserObjectiveWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转交目标OKR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferUserObjectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferUserObjectiveResponse
        /// </returns>
        public async Task<TransferUserObjectiveResponse> TransferUserObjectiveAsync(TransferUserObjectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransferUserObjectiveHeaders headers = new TransferUserObjectiveHeaders();
            return await TransferUserObjectiveWithOptionsAsync(request, headers, runtime);
        }

    }
}
