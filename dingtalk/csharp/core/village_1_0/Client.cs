// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkvillage_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0
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


        /**
         * @summary 获取部门详情
         *
         * @param request GetDeptRequest
         * @param headers GetDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeptResponse
         */
        public GetDeptResponse GetDeptWithOptions(string departmentId, GetDeptRequest request, GetDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "GetDept",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/deptartments/" + departmentId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeptResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取部门详情
         *
         * @param request GetDeptRequest
         * @param headers GetDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeptResponse
         */
        public async Task<GetDeptResponse> GetDeptWithOptionsAsync(string departmentId, GetDeptRequest request, GetDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "GetDept",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/deptartments/" + departmentId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取部门详情
         *
         * @param request GetDeptRequest
         * @return GetDeptResponse
         */
        public GetDeptResponse GetDept(string departmentId, GetDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeptHeaders headers = new GetDeptHeaders();
            return GetDeptWithOptions(departmentId, request, headers, runtime);
        }

        /**
         * @summary 获取部门详情
         *
         * @param request GetDeptRequest
         * @return GetDeptResponse
         */
        public async Task<GetDeptResponse> GetDeptAsync(string departmentId, GetDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeptHeaders headers = new GetDeptHeaders();
            return await GetDeptWithOptionsAsync(departmentId, request, headers, runtime);
        }

        /**
         * @summary 居民通讯录获取部门信息
         *
         * @param request GetResidentDeptRequest
         * @param headers GetResidentDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResidentDeptResponse
         */
        public GetResidentDeptResponse GetResidentDeptWithOptions(string departmentId, GetResidentDeptRequest request, GetResidentDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "GetResidentDept",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/residentDepartments/departments/" + departmentId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResidentDeptResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 居民通讯录获取部门信息
         *
         * @param request GetResidentDeptRequest
         * @param headers GetResidentDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResidentDeptResponse
         */
        public async Task<GetResidentDeptResponse> GetResidentDeptWithOptionsAsync(string departmentId, GetResidentDeptRequest request, GetResidentDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "GetResidentDept",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/residentDepartments/departments/" + departmentId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResidentDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 居民通讯录获取部门信息
         *
         * @param request GetResidentDeptRequest
         * @return GetResidentDeptResponse
         */
        public GetResidentDeptResponse GetResidentDept(string departmentId, GetResidentDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentDeptHeaders headers = new GetResidentDeptHeaders();
            return GetResidentDeptWithOptions(departmentId, request, headers, runtime);
        }

        /**
         * @summary 居民通讯录获取部门信息
         *
         * @param request GetResidentDeptRequest
         * @return GetResidentDeptResponse
         */
        public async Task<GetResidentDeptResponse> GetResidentDeptAsync(string departmentId, GetResidentDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentDeptHeaders headers = new GetResidentDeptHeaders();
            return await GetResidentDeptWithOptionsAsync(departmentId, request, headers, runtime);
        }

        /**
         * @summary 居民通讯录获取部门下某个人的详细信息
         *
         * @param request GetResidentUserInfoRequest
         * @param headers GetResidentUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResidentUserInfoResponse
         */
        public GetResidentUserInfoResponse GetResidentUserInfoWithOptions(string departmentId, string userId, GetResidentUserInfoRequest request, GetResidentUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "GetResidentUserInfo",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/residentDepartments/" + departmentId + "/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResidentUserInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 居民通讯录获取部门下某个人的详细信息
         *
         * @param request GetResidentUserInfoRequest
         * @param headers GetResidentUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResidentUserInfoResponse
         */
        public async Task<GetResidentUserInfoResponse> GetResidentUserInfoWithOptionsAsync(string departmentId, string userId, GetResidentUserInfoRequest request, GetResidentUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "GetResidentUserInfo",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/residentDepartments/" + departmentId + "/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResidentUserInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 居民通讯录获取部门下某个人的详细信息
         *
         * @param request GetResidentUserInfoRequest
         * @return GetResidentUserInfoResponse
         */
        public GetResidentUserInfoResponse GetResidentUserInfo(string departmentId, string userId, GetResidentUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentUserInfoHeaders headers = new GetResidentUserInfoHeaders();
            return GetResidentUserInfoWithOptions(departmentId, userId, request, headers, runtime);
        }

        /**
         * @summary 居民通讯录获取部门下某个人的详细信息
         *
         * @param request GetResidentUserInfoRequest
         * @return GetResidentUserInfoResponse
         */
        public async Task<GetResidentUserInfoResponse> GetResidentUserInfoAsync(string departmentId, string userId, GetResidentUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentUserInfoHeaders headers = new GetResidentUserInfoHeaders();
            return await GetResidentUserInfoWithOptionsAsync(departmentId, userId, request, headers, runtime);
        }

        /**
         * @summary 查询用户详情
         *
         * @param request GetUserRequest
         * @param headers GetUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public GetUserResponse GetUserWithOptions(string userId, GetUserRequest request, GetUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/users/getByUserId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询用户详情
         *
         * @param request GetUserRequest
         * @param headers GetUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserWithOptionsAsync(string userId, GetUserRequest request, GetUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/users/getByUserId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户详情
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public GetUserResponse GetUser(string userId, GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return GetUserWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 查询用户详情
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserAsync(string userId, GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return await GetUserWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 根据unionId查询用户详情
         *
         * @param request GetUserByUnionIdRequest
         * @param headers GetUserByUnionIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserByUnionIdResponse
         */
        public GetUserByUnionIdResponse GetUserByUnionIdWithOptions(GetUserByUnionIdRequest request, GetUserByUnionIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "GetUserByUnionId",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/users/getByUnionId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserByUnionIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据unionId查询用户详情
         *
         * @param request GetUserByUnionIdRequest
         * @param headers GetUserByUnionIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserByUnionIdResponse
         */
        public async Task<GetUserByUnionIdResponse> GetUserByUnionIdWithOptionsAsync(GetUserByUnionIdRequest request, GetUserByUnionIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "GetUserByUnionId",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/users/getByUnionId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserByUnionIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据unionId查询用户详情
         *
         * @param request GetUserByUnionIdRequest
         * @return GetUserByUnionIdResponse
         */
        public GetUserByUnionIdResponse GetUserByUnionId(GetUserByUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserByUnionIdHeaders headers = new GetUserByUnionIdHeaders();
            return GetUserByUnionIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据unionId查询用户详情
         *
         * @param request GetUserByUnionIdRequest
         * @return GetUserByUnionIdResponse
         */
        public async Task<GetUserByUnionIdResponse> GetUserByUnionIdAsync(GetUserByUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserByUnionIdHeaders headers = new GetUserByUnionIdHeaders();
            return await GetUserByUnionIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取对外开放的企业信息
         *
         * @param headers GetVillageOrgInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVillageOrgInfoResponse
         */
        public GetVillageOrgInfoResponse GetVillageOrgInfoWithOptions(string subCorpId, GetVillageOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetVillageOrgInfo",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/corps/" + subCorpId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVillageOrgInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取对外开放的企业信息
         *
         * @param headers GetVillageOrgInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVillageOrgInfoResponse
         */
        public async Task<GetVillageOrgInfoResponse> GetVillageOrgInfoWithOptionsAsync(string subCorpId, GetVillageOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetVillageOrgInfo",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/corps/" + subCorpId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVillageOrgInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取对外开放的企业信息
         *
         * @return GetVillageOrgInfoResponse
         */
        public GetVillageOrgInfoResponse GetVillageOrgInfo(string subCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetVillageOrgInfoHeaders headers = new GetVillageOrgInfoHeaders();
            return GetVillageOrgInfoWithOptions(subCorpId, headers, runtime);
        }

        /**
         * @summary 获取对外开放的企业信息
         *
         * @return GetVillageOrgInfoResponse
         */
        public async Task<GetVillageOrgInfoResponse> GetVillageOrgInfoAsync(string subCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetVillageOrgInfoHeaders headers = new GetVillageOrgInfoHeaders();
            return await GetVillageOrgInfoWithOptionsAsync(subCorpId, headers, runtime);
        }

        /**
         * @summary 查询部门下简略用户列表
         *
         * @param request ListDeptSimpleUsersRequest
         * @param headers ListDeptSimpleUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeptSimpleUsersResponse
         */
        public ListDeptSimpleUsersResponse ListDeptSimpleUsersWithOptions(string departmentId, ListDeptSimpleUsersRequest request, ListDeptSimpleUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainAccessLimit))
            {
                query["containAccessLimit"] = request.ContainAccessLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                query["orderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListDeptSimpleUsers",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/" + departmentId + "/simpleUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeptSimpleUsersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询部门下简略用户列表
         *
         * @param request ListDeptSimpleUsersRequest
         * @param headers ListDeptSimpleUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeptSimpleUsersResponse
         */
        public async Task<ListDeptSimpleUsersResponse> ListDeptSimpleUsersWithOptionsAsync(string departmentId, ListDeptSimpleUsersRequest request, ListDeptSimpleUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainAccessLimit))
            {
                query["containAccessLimit"] = request.ContainAccessLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                query["orderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListDeptSimpleUsers",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/" + departmentId + "/simpleUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeptSimpleUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询部门下简略用户列表
         *
         * @param request ListDeptSimpleUsersRequest
         * @return ListDeptSimpleUsersResponse
         */
        public ListDeptSimpleUsersResponse ListDeptSimpleUsers(string departmentId, ListDeptSimpleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeptSimpleUsersHeaders headers = new ListDeptSimpleUsersHeaders();
            return ListDeptSimpleUsersWithOptions(departmentId, request, headers, runtime);
        }

        /**
         * @summary 查询部门下简略用户列表
         *
         * @param request ListDeptSimpleUsersRequest
         * @return ListDeptSimpleUsersResponse
         */
        public async Task<ListDeptSimpleUsersResponse> ListDeptSimpleUsersAsync(string departmentId, ListDeptSimpleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeptSimpleUsersHeaders headers = new ListDeptSimpleUsersHeaders();
            return await ListDeptSimpleUsersWithOptionsAsync(departmentId, request, headers, runtime);
        }

        /**
         * @summary 查询部门下userid列表
         *
         * @param request ListDeptUserIdsRequest
         * @param headers ListDeptUserIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeptUserIdsResponse
         */
        public ListDeptUserIdsResponse ListDeptUserIdsWithOptions(string departmentId, ListDeptUserIdsRequest request, ListDeptUserIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListDeptUserIds",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/" + departmentId + "/userIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeptUserIdsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询部门下userid列表
         *
         * @param request ListDeptUserIdsRequest
         * @param headers ListDeptUserIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeptUserIdsResponse
         */
        public async Task<ListDeptUserIdsResponse> ListDeptUserIdsWithOptionsAsync(string departmentId, ListDeptUserIdsRequest request, ListDeptUserIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListDeptUserIds",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/" + departmentId + "/userIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeptUserIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询部门下userid列表
         *
         * @param request ListDeptUserIdsRequest
         * @return ListDeptUserIdsResponse
         */
        public ListDeptUserIdsResponse ListDeptUserIds(string departmentId, ListDeptUserIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeptUserIdsHeaders headers = new ListDeptUserIdsHeaders();
            return ListDeptUserIdsWithOptions(departmentId, request, headers, runtime);
        }

        /**
         * @summary 查询部门下userid列表
         *
         * @param request ListDeptUserIdsRequest
         * @return ListDeptUserIdsResponse
         */
        public async Task<ListDeptUserIdsResponse> ListDeptUserIdsAsync(string departmentId, ListDeptUserIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeptUserIdsHeaders headers = new ListDeptUserIdsHeaders();
            return await ListDeptUserIdsWithOptionsAsync(departmentId, request, headers, runtime);
        }

        /**
         * @summary 查询部门下user完整信息
         *
         * @param request ListDeptUsersRequest
         * @param headers ListDeptUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeptUsersResponse
         */
        public ListDeptUsersResponse ListDeptUsersWithOptions(string departmentId, ListDeptUsersRequest request, ListDeptUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainAccessLimit))
            {
                query["containAccessLimit"] = request.ContainAccessLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                query["orderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListDeptUsers",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/" + departmentId + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeptUsersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询部门下user完整信息
         *
         * @param request ListDeptUsersRequest
         * @param headers ListDeptUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeptUsersResponse
         */
        public async Task<ListDeptUsersResponse> ListDeptUsersWithOptionsAsync(string departmentId, ListDeptUsersRequest request, ListDeptUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainAccessLimit))
            {
                query["containAccessLimit"] = request.ContainAccessLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                query["orderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListDeptUsers",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/" + departmentId + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeptUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询部门下user完整信息
         *
         * @param request ListDeptUsersRequest
         * @return ListDeptUsersResponse
         */
        public ListDeptUsersResponse ListDeptUsers(string departmentId, ListDeptUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeptUsersHeaders headers = new ListDeptUsersHeaders();
            return ListDeptUsersWithOptions(departmentId, request, headers, runtime);
        }

        /**
         * @summary 查询部门下user完整信息
         *
         * @param request ListDeptUsersRequest
         * @return ListDeptUsersResponse
         */
        public async Task<ListDeptUsersResponse> ListDeptUsersAsync(string departmentId, ListDeptUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeptUsersHeaders headers = new ListDeptUsersHeaders();
            return await ListDeptUsersWithOptionsAsync(departmentId, request, headers, runtime);
        }

        /**
         * @summary 查询部门所有父部门列表
         *
         * @param request ListParentByDeptRequest
         * @param headers ListParentByDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListParentByDeptResponse
         */
        public ListParentByDeptResponse ListParentByDeptWithOptions(ListParentByDeptRequest request, ListParentByDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListParentByDept",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/listParentByDepartment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParentByDeptResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询部门所有父部门列表
         *
         * @param request ListParentByDeptRequest
         * @param headers ListParentByDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListParentByDeptResponse
         */
        public async Task<ListParentByDeptResponse> ListParentByDeptWithOptionsAsync(ListParentByDeptRequest request, ListParentByDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListParentByDept",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/listParentByDepartment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParentByDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询部门所有父部门列表
         *
         * @param request ListParentByDeptRequest
         * @return ListParentByDeptResponse
         */
        public ListParentByDeptResponse ListParentByDept(ListParentByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListParentByDeptHeaders headers = new ListParentByDeptHeaders();
            return ListParentByDeptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询部门所有父部门列表
         *
         * @param request ListParentByDeptRequest
         * @return ListParentByDeptResponse
         */
        public async Task<ListParentByDeptResponse> ListParentByDeptAsync(ListParentByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListParentByDeptHeaders headers = new ListParentByDeptHeaders();
            return await ListParentByDeptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户所有父部门列表
         *
         * @param request ListParentByUserRequest
         * @param headers ListParentByUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListParentByUserResponse
         */
        public ListParentByUserResponse ListParentByUserWithOptions(ListParentByUserRequest request, ListParentByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListParentByUser",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/listParentByUser",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParentByUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询用户所有父部门列表
         *
         * @param request ListParentByUserRequest
         * @param headers ListParentByUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListParentByUserResponse
         */
        public async Task<ListParentByUserResponse> ListParentByUserWithOptionsAsync(ListParentByUserRequest request, ListParentByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListParentByUser",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/listParentByUser",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParentByUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户所有父部门列表
         *
         * @param request ListParentByUserRequest
         * @return ListParentByUserResponse
         */
        public ListParentByUserResponse ListParentByUser(ListParentByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListParentByUserHeaders headers = new ListParentByUserHeaders();
            return ListParentByUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户所有父部门列表
         *
         * @param request ListParentByUserRequest
         * @return ListParentByUserResponse
         */
        public async Task<ListParentByUserResponse> ListParentByUserAsync(ListParentByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListParentByUserHeaders headers = new ListParentByUserHeaders();
            return await ListParentByUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 居民通讯录获取部门下人员信息
         *
         * @param request ListResidentDeptUsersRequest
         * @param headers ListResidentDeptUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResidentDeptUsersResponse
         */
        public ListResidentDeptUsersResponse ListResidentDeptUsersWithOptions(string departmentId, ListResidentDeptUsersRequest request, ListResidentDeptUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListResidentDeptUsers",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/residentDepartments/" + departmentId + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResidentDeptUsersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 居民通讯录获取部门下人员信息
         *
         * @param request ListResidentDeptUsersRequest
         * @param headers ListResidentDeptUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResidentDeptUsersResponse
         */
        public async Task<ListResidentDeptUsersResponse> ListResidentDeptUsersWithOptionsAsync(string departmentId, ListResidentDeptUsersRequest request, ListResidentDeptUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListResidentDeptUsers",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/residentDepartments/" + departmentId + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResidentDeptUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 居民通讯录获取部门下人员信息
         *
         * @param request ListResidentDeptUsersRequest
         * @return ListResidentDeptUsersResponse
         */
        public ListResidentDeptUsersResponse ListResidentDeptUsers(string departmentId, ListResidentDeptUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListResidentDeptUsersHeaders headers = new ListResidentDeptUsersHeaders();
            return ListResidentDeptUsersWithOptions(departmentId, request, headers, runtime);
        }

        /**
         * @summary 居民通讯录获取部门下人员信息
         *
         * @param request ListResidentDeptUsersRequest
         * @return ListResidentDeptUsersResponse
         */
        public async Task<ListResidentDeptUsersResponse> ListResidentDeptUsersAsync(string departmentId, ListResidentDeptUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListResidentDeptUsersHeaders headers = new ListResidentDeptUsersHeaders();
            return await ListResidentDeptUsersWithOptionsAsync(departmentId, request, headers, runtime);
        }

        /**
         * @summary 居民通讯录获取子部门列表
         *
         * @param request ListResidentSubDeptsRequest
         * @param headers ListResidentSubDeptsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResidentSubDeptsResponse
         */
        public ListResidentSubDeptsResponse ListResidentSubDeptsWithOptions(string departmentId, ListResidentSubDeptsRequest request, ListResidentSubDeptsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListResidentSubDepts",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/residentDepartments/" + departmentId + "/subDepartments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResidentSubDeptsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 居民通讯录获取子部门列表
         *
         * @param request ListResidentSubDeptsRequest
         * @param headers ListResidentSubDeptsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResidentSubDeptsResponse
         */
        public async Task<ListResidentSubDeptsResponse> ListResidentSubDeptsWithOptionsAsync(string departmentId, ListResidentSubDeptsRequest request, ListResidentSubDeptsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListResidentSubDepts",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/residentDepartments/" + departmentId + "/subDepartments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResidentSubDeptsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 居民通讯录获取子部门列表
         *
         * @param request ListResidentSubDeptsRequest
         * @return ListResidentSubDeptsResponse
         */
        public ListResidentSubDeptsResponse ListResidentSubDepts(string departmentId, ListResidentSubDeptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListResidentSubDeptsHeaders headers = new ListResidentSubDeptsHeaders();
            return ListResidentSubDeptsWithOptions(departmentId, request, headers, runtime);
        }

        /**
         * @summary 居民通讯录获取子部门列表
         *
         * @param request ListResidentSubDeptsRequest
         * @return ListResidentSubDeptsResponse
         */
        public async Task<ListResidentSubDeptsResponse> ListResidentSubDeptsAsync(string departmentId, ListResidentSubDeptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListResidentSubDeptsHeaders headers = new ListResidentSubDeptsHeaders();
            return await ListResidentSubDeptsWithOptionsAsync(departmentId, request, headers, runtime);
        }

        /**
         * @summary 居民通讯录批量获取用户详细信息
         *
         * @param tmpReq ListResidentUserInfosRequest
         * @param headers ListResidentUserInfosHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResidentUserInfosResponse
         */
        public ListResidentUserInfosResponse ListResidentUserInfosWithOptions(ListResidentUserInfosRequest tmpReq, ListResidentUserInfosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListResidentUserInfosShrinkRequest request = new ListResidentUserInfosShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIds))
            {
                request.UserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIds, "userIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdsShrink))
            {
                query["userIds"] = request.UserIdsShrink;
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
                Action = "ListResidentUserInfos",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/residentUsers/getByUserIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResidentUserInfosResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 居民通讯录批量获取用户详细信息
         *
         * @param tmpReq ListResidentUserInfosRequest
         * @param headers ListResidentUserInfosHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResidentUserInfosResponse
         */
        public async Task<ListResidentUserInfosResponse> ListResidentUserInfosWithOptionsAsync(ListResidentUserInfosRequest tmpReq, ListResidentUserInfosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListResidentUserInfosShrinkRequest request = new ListResidentUserInfosShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIds))
            {
                request.UserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIds, "userIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdsShrink))
            {
                query["userIds"] = request.UserIdsShrink;
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
                Action = "ListResidentUserInfos",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/residentUsers/getByUserIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResidentUserInfosResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 居民通讯录批量获取用户详细信息
         *
         * @param request ListResidentUserInfosRequest
         * @return ListResidentUserInfosResponse
         */
        public ListResidentUserInfosResponse ListResidentUserInfos(ListResidentUserInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListResidentUserInfosHeaders headers = new ListResidentUserInfosHeaders();
            return ListResidentUserInfosWithOptions(request, headers, runtime);
        }

        /**
         * @summary 居民通讯录批量获取用户详细信息
         *
         * @param request ListResidentUserInfosRequest
         * @return ListResidentUserInfosResponse
         */
        public async Task<ListResidentUserInfosResponse> ListResidentUserInfosAsync(ListResidentUserInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListResidentUserInfosHeaders headers = new ListResidentUserInfosHeaders();
            return await ListResidentUserInfosWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据角色获取用户列表
         *
         * @param request ListSimpleUsersByRoleRequest
         * @param headers ListSimpleUsersByRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSimpleUsersByRoleResponse
         */
        public ListSimpleUsersByRoleResponse ListSimpleUsersByRoleWithOptions(ListSimpleUsersByRoleRequest request, ListSimpleUsersByRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["roleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListSimpleUsersByRole",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/users/listByRole",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSimpleUsersByRoleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据角色获取用户列表
         *
         * @param request ListSimpleUsersByRoleRequest
         * @param headers ListSimpleUsersByRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSimpleUsersByRoleResponse
         */
        public async Task<ListSimpleUsersByRoleResponse> ListSimpleUsersByRoleWithOptionsAsync(ListSimpleUsersByRoleRequest request, ListSimpleUsersByRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["roleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListSimpleUsersByRole",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/users/listByRole",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSimpleUsersByRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据角色获取用户列表
         *
         * @param request ListSimpleUsersByRoleRequest
         * @return ListSimpleUsersByRoleResponse
         */
        public ListSimpleUsersByRoleResponse ListSimpleUsersByRole(ListSimpleUsersByRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSimpleUsersByRoleHeaders headers = new ListSimpleUsersByRoleHeaders();
            return ListSimpleUsersByRoleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据角色获取用户列表
         *
         * @param request ListSimpleUsersByRoleRequest
         * @return ListSimpleUsersByRoleResponse
         */
        public async Task<ListSimpleUsersByRoleResponse> ListSimpleUsersByRoleAsync(ListSimpleUsersByRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSimpleUsersByRoleHeaders headers = new ListSimpleUsersByRoleHeaders();
            return await ListSimpleUsersByRoleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取下级指定区域层级组织
         *
         * @param request ListSubCorpsRequest
         * @param headers ListSubCorpsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubCorpsResponse
         */
        public ListSubCorpsResponse ListSubCorpsWithOptions(ListSubCorpsRequest request, ListSubCorpsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnlyDirect))
            {
                query["isOnlyDirect"] = request.IsOnlyDirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
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
                Action = "ListSubCorps",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/corps/subCorps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubCorpsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取下级指定区域层级组织
         *
         * @param request ListSubCorpsRequest
         * @param headers ListSubCorpsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubCorpsResponse
         */
        public async Task<ListSubCorpsResponse> ListSubCorpsWithOptionsAsync(ListSubCorpsRequest request, ListSubCorpsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnlyDirect))
            {
                query["isOnlyDirect"] = request.IsOnlyDirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
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
                Action = "ListSubCorps",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/corps/subCorps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubCorpsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取下级指定区域层级组织
         *
         * @param request ListSubCorpsRequest
         * @return ListSubCorpsResponse
         */
        public ListSubCorpsResponse ListSubCorps(ListSubCorpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubCorpsHeaders headers = new ListSubCorpsHeaders();
            return ListSubCorpsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取下级指定区域层级组织
         *
         * @param request ListSubCorpsRequest
         * @return ListSubCorpsResponse
         */
        public async Task<ListSubCorpsResponse> ListSubCorpsAsync(ListSubCorpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubCorpsHeaders headers = new ListSubCorpsHeaders();
            return await ListSubCorpsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询子部门列表
         *
         * @param request ListSubDeptRequest
         * @param headers ListSubDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubDeptResponse
         */
        public ListSubDeptResponse ListSubDeptWithOptions(string departmentId, ListSubDeptRequest request, ListSubDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListSubDept",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/" + departmentId + "/subDepartments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubDeptResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询子部门列表
         *
         * @param request ListSubDeptRequest
         * @param headers ListSubDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubDeptResponse
         */
        public async Task<ListSubDeptResponse> ListSubDeptWithOptionsAsync(string departmentId, ListSubDeptRequest request, ListSubDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListSubDept",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/" + departmentId + "/subDepartments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询子部门列表
         *
         * @param request ListSubDeptRequest
         * @return ListSubDeptResponse
         */
        public ListSubDeptResponse ListSubDept(string departmentId, ListSubDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubDeptHeaders headers = new ListSubDeptHeaders();
            return ListSubDeptWithOptions(departmentId, request, headers, runtime);
        }

        /**
         * @summary 查询子部门列表
         *
         * @param request ListSubDeptRequest
         * @return ListSubDeptResponse
         */
        public async Task<ListSubDeptResponse> ListSubDeptAsync(string departmentId, ListSubDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubDeptHeaders headers = new ListSubDeptHeaders();
            return await ListSubDeptWithOptionsAsync(departmentId, request, headers, runtime);
        }

        /**
         * @summary 查询部门下的子部门ID列表，不会递归查询，只包含ID
         *
         * @param request ListSubDeptIdsRequest
         * @param headers ListSubDeptIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubDeptIdsResponse
         */
        public ListSubDeptIdsResponse ListSubDeptIdsWithOptions(string departmentId, ListSubDeptIdsRequest request, ListSubDeptIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListSubDeptIds",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/" + departmentId + "/subDepartmentIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubDeptIdsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询部门下的子部门ID列表，不会递归查询，只包含ID
         *
         * @param request ListSubDeptIdsRequest
         * @param headers ListSubDeptIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubDeptIdsResponse
         */
        public async Task<ListSubDeptIdsResponse> ListSubDeptIdsWithOptionsAsync(string departmentId, ListSubDeptIdsRequest request, ListSubDeptIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["subCorpId"] = request.SubCorpId;
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
                Action = "ListSubDeptIds",
                Version = "village_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/village/departments/" + departmentId + "/subDepartmentIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubDeptIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询部门下的子部门ID列表，不会递归查询，只包含ID
         *
         * @param request ListSubDeptIdsRequest
         * @return ListSubDeptIdsResponse
         */
        public ListSubDeptIdsResponse ListSubDeptIds(string departmentId, ListSubDeptIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubDeptIdsHeaders headers = new ListSubDeptIdsHeaders();
            return ListSubDeptIdsWithOptions(departmentId, request, headers, runtime);
        }

        /**
         * @summary 查询部门下的子部门ID列表，不会递归查询，只包含ID
         *
         * @param request ListSubDeptIdsRequest
         * @return ListSubDeptIdsResponse
         */
        public async Task<ListSubDeptIdsResponse> ListSubDeptIdsAsync(string departmentId, ListSubDeptIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubDeptIdsHeaders headers = new ListSubDeptIdsHeaders();
            return await ListSubDeptIdsWithOptionsAsync(departmentId, request, headers, runtime);
        }

    }
}
