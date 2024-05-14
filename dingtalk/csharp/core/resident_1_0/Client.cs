// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkresident_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0
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
         * @summary 增加积分
         *
         * @param request AddPointRequest
         * @param headers AddPointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddPointResponse
         */
        public AddPointResponse AddPointWithOptions(AddPointRequest request, AddPointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionTime))
            {
                query["actionTime"] = request.ActionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCode))
            {
                query["ruleCode"] = request.RuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Score))
            {
                query["score"] = request.Score;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
                Action = "AddPoint",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/points",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPointResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 增加积分
         *
         * @param request AddPointRequest
         * @param headers AddPointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddPointResponse
         */
        public async Task<AddPointResponse> AddPointWithOptionsAsync(AddPointRequest request, AddPointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionTime))
            {
                query["actionTime"] = request.ActionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCode))
            {
                query["ruleCode"] = request.RuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Score))
            {
                query["score"] = request.Score;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
                Action = "AddPoint",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/points",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPointResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 增加积分
         *
         * @param request AddPointRequest
         * @return AddPointResponse
         */
        public AddPointResponse AddPoint(AddPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPointHeaders headers = new AddPointHeaders();
            return AddPointWithOptions(request, headers, runtime);
        }

        /**
         * @summary 增加积分
         *
         * @param request AddPointRequest
         * @return AddPointResponse
         */
        public async Task<AddPointResponse> AddPointAsync(AddPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPointHeaders headers = new AddPointHeaders();
            return await AddPointWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 增加组户
         *
         * @param request AddResidentDepartmentRequest
         * @param headers AddResidentDepartmentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddResidentDepartmentResponse
         */
        public AddResidentDepartmentResponse AddResidentDepartmentWithOptions(AddResidentDepartmentRequest request, AddResidentDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsResidenceGroup))
            {
                query["isResidenceGroup"] = request.IsResidenceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDepartmentId))
            {
                query["parentDepartmentId"] = request.ParentDepartmentId;
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
                Action = "AddResidentDepartment",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/departments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddResidentDepartmentResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 增加组户
         *
         * @param request AddResidentDepartmentRequest
         * @param headers AddResidentDepartmentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddResidentDepartmentResponse
         */
        public async Task<AddResidentDepartmentResponse> AddResidentDepartmentWithOptionsAsync(AddResidentDepartmentRequest request, AddResidentDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsResidenceGroup))
            {
                query["isResidenceGroup"] = request.IsResidenceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDepartmentId))
            {
                query["parentDepartmentId"] = request.ParentDepartmentId;
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
                Action = "AddResidentDepartment",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/departments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddResidentDepartmentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 增加组户
         *
         * @param request AddResidentDepartmentRequest
         * @return AddResidentDepartmentResponse
         */
        public AddResidentDepartmentResponse AddResidentDepartment(AddResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentDepartmentHeaders headers = new AddResidentDepartmentHeaders();
            return AddResidentDepartmentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 增加组户
         *
         * @param request AddResidentDepartmentRequest
         * @return AddResidentDepartmentResponse
         */
        public async Task<AddResidentDepartmentResponse> AddResidentDepartmentAsync(AddResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentDepartmentHeaders headers = new AddResidentDepartmentHeaders();
            return await AddResidentDepartmentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加小区成员
         *
         * @param request AddResidentMemberRequest
         * @param headers AddResidentMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddResidentMemberResponse
         */
        public AddResidentMemberResponse AddResidentMemberWithOptions(AddResidentMemberRequest request, AddResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentAddInfo))
            {
                body["residentAddInfo"] = request.ResidentAddInfo;
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
                Action = "AddResidentMember",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddResidentMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 添加小区成员
         *
         * @param request AddResidentMemberRequest
         * @param headers AddResidentMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddResidentMemberResponse
         */
        public async Task<AddResidentMemberResponse> AddResidentMemberWithOptionsAsync(AddResidentMemberRequest request, AddResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentAddInfo))
            {
                body["residentAddInfo"] = request.ResidentAddInfo;
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
                Action = "AddResidentMember",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddResidentMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加小区成员
         *
         * @param request AddResidentMemberRequest
         * @return AddResidentMemberResponse
         */
        public AddResidentMemberResponse AddResidentMember(AddResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentMemberHeaders headers = new AddResidentMemberHeaders();
            return AddResidentMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加小区成员
         *
         * @param request AddResidentMemberRequest
         * @return AddResidentMemberResponse
         */
        public async Task<AddResidentMemberResponse> AddResidentMemberAsync(AddResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentMemberHeaders headers = new AddResidentMemberHeaders();
            return await AddResidentMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新增居民
         *
         * @param request AddResidentUsersRequest
         * @param headers AddResidentUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddResidentUsersResponse
         */
        public AddResidentUsersResponse AddResidentUsersWithOptions(AddResidentUsersRequest request, AddResidentUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtField))
            {
                query["extField"] = request.ExtField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsLeaseholder))
            {
                query["isLeaseholder"] = request.IsLeaseholder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateType))
            {
                query["relateType"] = request.RelateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
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
                Action = "AddResidentUsers",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddResidentUsersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 新增居民
         *
         * @param request AddResidentUsersRequest
         * @param headers AddResidentUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddResidentUsersResponse
         */
        public async Task<AddResidentUsersResponse> AddResidentUsersWithOptionsAsync(AddResidentUsersRequest request, AddResidentUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtField))
            {
                query["extField"] = request.ExtField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsLeaseholder))
            {
                query["isLeaseholder"] = request.IsLeaseholder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateType))
            {
                query["relateType"] = request.RelateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
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
                Action = "AddResidentUsers",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddResidentUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 新增居民
         *
         * @param request AddResidentUsersRequest
         * @return AddResidentUsersResponse
         */
        public AddResidentUsersResponse AddResidentUsers(AddResidentUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentUsersHeaders headers = new AddResidentUsersHeaders();
            return AddResidentUsersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增居民
         *
         * @param request AddResidentUsersRequest
         * @return AddResidentUsersResponse
         */
        public async Task<AddResidentUsersResponse> AddResidentUsersAsync(AddResidentUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentUsersHeaders headers = new AddResidentUsersHeaders();
            return await AddResidentUsersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建小区公告
         *
         * @param request CreateResidentBlackBoardRequest
         * @param headers CreateResidentBlackBoardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResidentBlackBoardResponse
         */
        public CreateResidentBlackBoardResponse CreateResidentBlackBoardWithOptions(CreateResidentBlackBoardRequest request, CreateResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                body["context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendTime))
            {
                body["sendTime"] = request.SendTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "CreateResidentBlackBoard",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/blackboards",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResidentBlackBoardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建小区公告
         *
         * @param request CreateResidentBlackBoardRequest
         * @param headers CreateResidentBlackBoardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResidentBlackBoardResponse
         */
        public async Task<CreateResidentBlackBoardResponse> CreateResidentBlackBoardWithOptionsAsync(CreateResidentBlackBoardRequest request, CreateResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                body["context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendTime))
            {
                body["sendTime"] = request.SendTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "CreateResidentBlackBoard",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/blackboards",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResidentBlackBoardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建小区公告
         *
         * @param request CreateResidentBlackBoardRequest
         * @return CreateResidentBlackBoardResponse
         */
        public CreateResidentBlackBoardResponse CreateResidentBlackBoard(CreateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateResidentBlackBoardHeaders headers = new CreateResidentBlackBoardHeaders();
            return CreateResidentBlackBoardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建小区公告
         *
         * @param request CreateResidentBlackBoardRequest
         * @return CreateResidentBlackBoardResponse
         */
        public async Task<CreateResidentBlackBoardResponse> CreateResidentBlackBoardAsync(CreateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateResidentBlackBoardHeaders headers = new CreateResidentBlackBoardHeaders();
            return await CreateResidentBlackBoardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建小区空间，含分区，楼栋，单元，房屋等
         *
         * @param request CreateSpaceRequest
         * @param headers CreateSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSpaceResponse
         */
        public CreateSpaceResponse CreateSpaceWithOptions(CreateSpaceRequest request, CreateSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingArea))
            {
                body["billingArea"] = request.BillingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildingArea))
            {
                body["buildingArea"] = request.BuildingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Floor))
            {
                body["floor"] = request.Floor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HouseState))
            {
                body["houseState"] = request.HouseState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "CreateSpace",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSpaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建小区空间，含分区，楼栋，单元，房屋等
         *
         * @param request CreateSpaceRequest
         * @param headers CreateSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSpaceResponse
         */
        public async Task<CreateSpaceResponse> CreateSpaceWithOptionsAsync(CreateSpaceRequest request, CreateSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingArea))
            {
                body["billingArea"] = request.BillingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildingArea))
            {
                body["buildingArea"] = request.BuildingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Floor))
            {
                body["floor"] = request.Floor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HouseState))
            {
                body["houseState"] = request.HouseState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "CreateSpace",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建小区空间，含分区，楼栋，单元，房屋等
         *
         * @param request CreateSpaceRequest
         * @return CreateSpaceResponse
         */
        public CreateSpaceResponse CreateSpace(CreateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSpaceHeaders headers = new CreateSpaceHeaders();
            return CreateSpaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建小区空间，含分区，楼栋，单元，房屋等
         *
         * @param request CreateSpaceRequest
         * @return CreateSpaceResponse
         */
        public async Task<CreateSpaceResponse> CreateSpaceAsync(CreateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSpaceHeaders headers = new CreateSpaceHeaders();
            return await CreateSpaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除小区公告
         *
         * @param request DeleteResidentBlackBoardRequest
         * @param headers DeleteResidentBlackBoardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResidentBlackBoardResponse
         */
        public DeleteResidentBlackBoardResponse DeleteResidentBlackBoardWithOptions(DeleteResidentBlackBoardRequest request, DeleteResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                query["blackboardId"] = request.BlackboardId;
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
                Action = "DeleteResidentBlackBoard",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/blackboards",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResidentBlackBoardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除小区公告
         *
         * @param request DeleteResidentBlackBoardRequest
         * @param headers DeleteResidentBlackBoardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResidentBlackBoardResponse
         */
        public async Task<DeleteResidentBlackBoardResponse> DeleteResidentBlackBoardWithOptionsAsync(DeleteResidentBlackBoardRequest request, DeleteResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                query["blackboardId"] = request.BlackboardId;
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
                Action = "DeleteResidentBlackBoard",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/blackboards",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResidentBlackBoardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除小区公告
         *
         * @param request DeleteResidentBlackBoardRequest
         * @return DeleteResidentBlackBoardResponse
         */
        public DeleteResidentBlackBoardResponse DeleteResidentBlackBoard(DeleteResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentBlackBoardHeaders headers = new DeleteResidentBlackBoardHeaders();
            return DeleteResidentBlackBoardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除小区公告
         *
         * @param request DeleteResidentBlackBoardRequest
         * @return DeleteResidentBlackBoardResponse
         */
        public async Task<DeleteResidentBlackBoardResponse> DeleteResidentBlackBoardAsync(DeleteResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentBlackBoardHeaders headers = new DeleteResidentBlackBoardHeaders();
            return await DeleteResidentBlackBoardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除组户信息
         *
         * @param request DeleteResidentDepartmentRequest
         * @param headers DeleteResidentDepartmentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResidentDepartmentResponse
         */
        public DeleteResidentDepartmentResponse DeleteResidentDepartmentWithOptions(DeleteResidentDepartmentRequest request, DeleteResidentDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
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
                Action = "DeleteResidentDepartment",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/departments",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResidentDepartmentResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除组户信息
         *
         * @param request DeleteResidentDepartmentRequest
         * @param headers DeleteResidentDepartmentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResidentDepartmentResponse
         */
        public async Task<DeleteResidentDepartmentResponse> DeleteResidentDepartmentWithOptionsAsync(DeleteResidentDepartmentRequest request, DeleteResidentDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
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
                Action = "DeleteResidentDepartment",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/departments",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResidentDepartmentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除组户信息
         *
         * @param request DeleteResidentDepartmentRequest
         * @return DeleteResidentDepartmentResponse
         */
        public DeleteResidentDepartmentResponse DeleteResidentDepartment(DeleteResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentDepartmentHeaders headers = new DeleteResidentDepartmentHeaders();
            return DeleteResidentDepartmentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除组户信息
         *
         * @param request DeleteResidentDepartmentRequest
         * @return DeleteResidentDepartmentResponse
         */
        public async Task<DeleteResidentDepartmentResponse> DeleteResidentDepartmentAsync(DeleteResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentDepartmentHeaders headers = new DeleteResidentDepartmentHeaders();
            return await DeleteResidentDepartmentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除小区空间，含分区，楼栋，单元，房屋
         *
         * @param request DeleteSpaceRequest
         * @param headers DeleteSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSpaceResponse
         */
        public DeleteSpaceResponse DeleteSpaceWithOptions(DeleteSpaceRequest request, DeleteSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
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
                Action = "DeleteSpace",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSpaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除小区空间，含分区，楼栋，单元，房屋
         *
         * @param request DeleteSpaceRequest
         * @param headers DeleteSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSpaceResponse
         */
        public async Task<DeleteSpaceResponse> DeleteSpaceWithOptionsAsync(DeleteSpaceRequest request, DeleteSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
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
                Action = "DeleteSpace",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除小区空间，含分区，楼栋，单元，房屋
         *
         * @param request DeleteSpaceRequest
         * @return DeleteSpaceResponse
         */
        public DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
            return DeleteSpaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除小区空间，含分区，楼栋，单元，房屋
         *
         * @param request DeleteSpaceRequest
         * @return DeleteSpaceResponse
         */
        public async Task<DeleteSpaceResponse> DeleteSpaceAsync(DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
            return await DeleteSpaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取指定群的openConversationId
         *
         * @param request GetConversationIdRequest
         * @param headers GetConversationIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConversationIdResponse
         */
        public GetConversationIdResponse GetConversationIdWithOptions(GetConversationIdRequest request, GetConversationIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                query["chatId"] = request.ChatId;
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
                Action = "GetConversationId",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/conversations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取指定群的openConversationId
         *
         * @param request GetConversationIdRequest
         * @param headers GetConversationIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConversationIdResponse
         */
        public async Task<GetConversationIdResponse> GetConversationIdWithOptionsAsync(GetConversationIdRequest request, GetConversationIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                query["chatId"] = request.ChatId;
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
                Action = "GetConversationId",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/conversations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定群的openConversationId
         *
         * @param request GetConversationIdRequest
         * @return GetConversationIdResponse
         */
        public GetConversationIdResponse GetConversationId(GetConversationIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationIdHeaders headers = new GetConversationIdHeaders();
            return GetConversationIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取指定群的openConversationId
         *
         * @param request GetConversationIdRequest
         * @return GetConversationIdResponse
         */
        public async Task<GetConversationIdResponse> GetConversationIdAsync(GetConversationIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationIdHeaders headers = new GetConversationIdHeaders();
            return await GetConversationIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取组织的行业类型
         *
         * @param headers GetIndustryTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIndustryTypeResponse
         */
        public GetIndustryTypeResponse GetIndustryTypeWithOptions(GetIndustryTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetIndustryType",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/organizations/industryTypes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndustryTypeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取组织的行业类型
         *
         * @param headers GetIndustryTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIndustryTypeResponse
         */
        public async Task<GetIndustryTypeResponse> GetIndustryTypeWithOptionsAsync(GetIndustryTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetIndustryType",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/organizations/industryTypes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndustryTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取组织的行业类型
         *
         * @return GetIndustryTypeResponse
         */
        public GetIndustryTypeResponse GetIndustryType()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIndustryTypeHeaders headers = new GetIndustryTypeHeaders();
            return GetIndustryTypeWithOptions(headers, runtime);
        }

        /**
         * @summary 获取组织的行业类型
         *
         * @return GetIndustryTypeResponse
         */
        public async Task<GetIndustryTypeResponse> GetIndustryTypeAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIndustryTypeHeaders headers = new GetIndustryTypeHeaders();
            return await GetIndustryTypeWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取物业公司信息
         *
         * @param request GetPropertyInfoRequest
         * @param headers GetPropertyInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPropertyInfoResponse
         */
        public GetPropertyInfoResponse GetPropertyInfoWithOptions(GetPropertyInfoRequest request, GetPropertyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyCorpId))
            {
                query["propertyCorpId"] = request.PropertyCorpId;
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
                Action = "GetPropertyInfo",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/propertyInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPropertyInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取物业公司信息
         *
         * @param request GetPropertyInfoRequest
         * @param headers GetPropertyInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPropertyInfoResponse
         */
        public async Task<GetPropertyInfoResponse> GetPropertyInfoWithOptionsAsync(GetPropertyInfoRequest request, GetPropertyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyCorpId))
            {
                query["propertyCorpId"] = request.PropertyCorpId;
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
                Action = "GetPropertyInfo",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/propertyInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPropertyInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取物业公司信息
         *
         * @param request GetPropertyInfoRequest
         * @return GetPropertyInfoResponse
         */
        public GetPropertyInfoResponse GetPropertyInfo(GetPropertyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPropertyInfoHeaders headers = new GetPropertyInfoHeaders();
            return GetPropertyInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取物业公司信息
         *
         * @param request GetPropertyInfoRequest
         * @return GetPropertyInfoResponse
         */
        public async Task<GetPropertyInfoResponse> GetPropertyInfoAsync(GetPropertyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPropertyInfoHeaders headers = new GetPropertyInfoHeaders();
            return await GetPropertyInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取小区信息
         *
         * @param request GetResidentInfoRequest
         * @param headers GetResidentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResidentInfoResponse
         */
        public GetResidentInfoResponse GetResidentInfoWithOptions(GetResidentInfoRequest request, GetResidentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                query["residentCorpId"] = request.ResidentCorpId;
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
                Action = "GetResidentInfo",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/residentInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResidentInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取小区信息
         *
         * @param request GetResidentInfoRequest
         * @param headers GetResidentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResidentInfoResponse
         */
        public async Task<GetResidentInfoResponse> GetResidentInfoWithOptionsAsync(GetResidentInfoRequest request, GetResidentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                query["residentCorpId"] = request.ResidentCorpId;
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
                Action = "GetResidentInfo",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/residentInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResidentInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取小区信息
         *
         * @param request GetResidentInfoRequest
         * @return GetResidentInfoResponse
         */
        public GetResidentInfoResponse GetResidentInfo(GetResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentInfoHeaders headers = new GetResidentInfoHeaders();
            return GetResidentInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取小区信息
         *
         * @param request GetResidentInfoRequest
         * @return GetResidentInfoResponse
         */
        public async Task<GetResidentInfoResponse> GetResidentInfoAsync(GetResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentInfoHeaders headers = new GetResidentInfoHeaders();
            return await GetResidentInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取小区人员信息，包括居民和物业人员
         *
         * @param request GetResidentMembersInfoRequest
         * @param headers GetResidentMembersInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResidentMembersInfoResponse
         */
        public GetResidentMembersInfoResponse GetResidentMembersInfoWithOptions(GetResidentMembersInfoRequest request, GetResidentMembersInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCropId))
            {
                body["residentCropId"] = request.ResidentCropId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
                Action = "GetResidentMembersInfo",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/residences/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResidentMembersInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取小区人员信息，包括居民和物业人员
         *
         * @param request GetResidentMembersInfoRequest
         * @param headers GetResidentMembersInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResidentMembersInfoResponse
         */
        public async Task<GetResidentMembersInfoResponse> GetResidentMembersInfoWithOptionsAsync(GetResidentMembersInfoRequest request, GetResidentMembersInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCropId))
            {
                body["residentCropId"] = request.ResidentCropId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
                Action = "GetResidentMembersInfo",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/residences/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResidentMembersInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取小区人员信息，包括居民和物业人员
         *
         * @param request GetResidentMembersInfoRequest
         * @return GetResidentMembersInfoResponse
         */
        public GetResidentMembersInfoResponse GetResidentMembersInfo(GetResidentMembersInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentMembersInfoHeaders headers = new GetResidentMembersInfoHeaders();
            return GetResidentMembersInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取小区人员信息，包括居民和物业人员
         *
         * @param request GetResidentMembersInfoRequest
         * @return GetResidentMembersInfoResponse
         */
        public async Task<GetResidentMembersInfoResponse> GetResidentMembersInfoAsync(GetResidentMembersInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentMembersInfoHeaders headers = new GetResidentMembersInfoHeaders();
            return await GetResidentMembersInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据类型获取部门id
         *
         * @param request GetSpaceIdByTypeRequest
         * @param headers GetSpaceIdByTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpaceIdByTypeResponse
         */
        public GetSpaceIdByTypeResponse GetSpaceIdByTypeWithOptions(GetSpaceIdByTypeRequest request, GetSpaceIdByTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentType))
            {
                query["departmentType"] = request.DepartmentType;
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
                Action = "GetSpaceIdByType",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces/types",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceIdByTypeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据类型获取部门id
         *
         * @param request GetSpaceIdByTypeRequest
         * @param headers GetSpaceIdByTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpaceIdByTypeResponse
         */
        public async Task<GetSpaceIdByTypeResponse> GetSpaceIdByTypeWithOptionsAsync(GetSpaceIdByTypeRequest request, GetSpaceIdByTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentType))
            {
                query["departmentType"] = request.DepartmentType;
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
                Action = "GetSpaceIdByType",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces/types",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceIdByTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据类型获取部门id
         *
         * @param request GetSpaceIdByTypeRequest
         * @return GetSpaceIdByTypeResponse
         */
        public GetSpaceIdByTypeResponse GetSpaceIdByType(GetSpaceIdByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceIdByTypeHeaders headers = new GetSpaceIdByTypeHeaders();
            return GetSpaceIdByTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据类型获取部门id
         *
         * @param request GetSpaceIdByTypeRequest
         * @return GetSpaceIdByTypeResponse
         */
        public async Task<GetSpaceIdByTypeResponse> GetSpaceIdByTypeAsync(GetSpaceIdByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceIdByTypeHeaders headers = new GetSpaceIdByTypeHeaders();
            return await GetSpaceIdByTypeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取空间信息
         *
         * @param request GetSpacesInfoRequest
         * @param headers GetSpacesInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpacesInfoResponse
         */
        public GetSpacesInfoResponse GetSpacesInfoWithOptions(GetSpacesInfoRequest request, GetSpacesInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferIds))
            {
                body["referIds"] = request.ReferIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                body["residentCorpId"] = request.ResidentCorpId;
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
                Action = "GetSpacesInfo",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpacesInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取空间信息
         *
         * @param request GetSpacesInfoRequest
         * @param headers GetSpacesInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpacesInfoResponse
         */
        public async Task<GetSpacesInfoResponse> GetSpacesInfoWithOptionsAsync(GetSpacesInfoRequest request, GetSpacesInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferIds))
            {
                body["referIds"] = request.ReferIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                body["residentCorpId"] = request.ResidentCorpId;
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
                Action = "GetSpacesInfo",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpacesInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取空间信息
         *
         * @param request GetSpacesInfoRequest
         * @return GetSpacesInfoResponse
         */
        public GetSpacesInfoResponse GetSpacesInfo(GetSpacesInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpacesInfoHeaders headers = new GetSpacesInfoHeaders();
            return GetSpacesInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取空间信息
         *
         * @param request GetSpacesInfoRequest
         * @return GetSpacesInfoResponse
         */
        public async Task<GetSpacesInfoResponse> GetSpacesInfoAsync(GetSpacesInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpacesInfoHeaders headers = new GetSpacesInfoHeaders();
            return await GetSpacesInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取行业角色下的用户列表
         *
         * @param request ListIndustryRoleUsersRequest
         * @param headers ListIndustryRoleUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIndustryRoleUsersResponse
         */
        public ListIndustryRoleUsersResponse ListIndustryRoleUsersWithOptions(ListIndustryRoleUsersRequest request, ListIndustryRoleUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                query["tagCode"] = request.TagCode;
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
                Action = "ListIndustryRoleUsers",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/industryRoles/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndustryRoleUsersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取行业角色下的用户列表
         *
         * @param request ListIndustryRoleUsersRequest
         * @param headers ListIndustryRoleUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIndustryRoleUsersResponse
         */
        public async Task<ListIndustryRoleUsersResponse> ListIndustryRoleUsersWithOptionsAsync(ListIndustryRoleUsersRequest request, ListIndustryRoleUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                query["tagCode"] = request.TagCode;
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
                Action = "ListIndustryRoleUsers",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/industryRoles/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndustryRoleUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取行业角色下的用户列表
         *
         * @param request ListIndustryRoleUsersRequest
         * @return ListIndustryRoleUsersResponse
         */
        public ListIndustryRoleUsersResponse ListIndustryRoleUsers(ListIndustryRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListIndustryRoleUsersHeaders headers = new ListIndustryRoleUsersHeaders();
            return ListIndustryRoleUsersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取行业角色下的用户列表
         *
         * @param request ListIndustryRoleUsersRequest
         * @return ListIndustryRoleUsersResponse
         */
        public async Task<ListIndustryRoleUsersResponse> ListIndustryRoleUsersAsync(ListIndustryRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListIndustryRoleUsersHeaders headers = new ListIndustryRoleUsersHeaders();
            return await ListIndustryRoleUsersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询组织维度配置的的积分规则
         *
         * @param request ListPointRulesRequest
         * @param headers ListPointRulesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPointRulesResponse
         */
        public ListPointRulesResponse ListPointRulesWithOptions(ListPointRulesRequest request, ListPointRulesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
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
                Action = "ListPointRules",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/points/rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPointRulesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询组织维度配置的的积分规则
         *
         * @param request ListPointRulesRequest
         * @param headers ListPointRulesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPointRulesResponse
         */
        public async Task<ListPointRulesResponse> ListPointRulesWithOptionsAsync(ListPointRulesRequest request, ListPointRulesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
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
                Action = "ListPointRules",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/points/rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPointRulesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询组织维度配置的的积分规则
         *
         * @param request ListPointRulesRequest
         * @return ListPointRulesResponse
         */
        public ListPointRulesResponse ListPointRules(ListPointRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPointRulesHeaders headers = new ListPointRulesHeaders();
            return ListPointRulesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询组织维度配置的的积分规则
         *
         * @param request ListPointRulesRequest
         * @return ListPointRulesResponse
         */
        public async Task<ListPointRulesResponse> ListPointRulesAsync(ListPointRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPointRulesHeaders headers = new ListPointRulesHeaders();
            return await ListPointRulesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取子空间信息
         *
         * @param request ListSubSpaceRequest
         * @param headers ListSubSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubSpaceResponse
         */
        public ListSubSpaceResponse ListSubSpaceWithOptions(ListSubSpaceRequest request, ListSubSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferId))
            {
                query["referId"] = request.ReferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                query["residentCorpId"] = request.ResidentCorpId;
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
                Action = "ListSubSpace",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces/subSpaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubSpaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取子空间信息
         *
         * @param request ListSubSpaceRequest
         * @param headers ListSubSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubSpaceResponse
         */
        public async Task<ListSubSpaceResponse> ListSubSpaceWithOptionsAsync(ListSubSpaceRequest request, ListSubSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferId))
            {
                query["referId"] = request.ReferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                query["residentCorpId"] = request.ResidentCorpId;
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
                Action = "ListSubSpace",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces/subSpaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取子空间信息
         *
         * @param request ListSubSpaceRequest
         * @return ListSubSpaceResponse
         */
        public ListSubSpaceResponse ListSubSpace(ListSubSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubSpaceHeaders headers = new ListSubSpaceHeaders();
            return ListSubSpaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取子空间信息
         *
         * @param request ListSubSpaceRequest
         * @return ListSubSpaceResponse
         */
        public async Task<ListSubSpaceResponse> ListSubSpaceAsync(ListSubSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubSpaceHeaders headers = new ListSubSpaceHeaders();
            return await ListSubSpaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取未确认加入组织的用户
         *
         * @param request ListUncheckUsersRequest
         * @param headers ListUncheckUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUncheckUsersResponse
         */
        public ListUncheckUsersResponse ListUncheckUsersWithOptions(ListUncheckUsersRequest request, ListUncheckUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
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
                Action = "ListUncheckUsers",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/organizations/noJoinUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUncheckUsersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取未确认加入组织的用户
         *
         * @param request ListUncheckUsersRequest
         * @param headers ListUncheckUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUncheckUsersResponse
         */
        public async Task<ListUncheckUsersResponse> ListUncheckUsersWithOptionsAsync(ListUncheckUsersRequest request, ListUncheckUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
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
                Action = "ListUncheckUsers",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/organizations/noJoinUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUncheckUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取未确认加入组织的用户
         *
         * @param request ListUncheckUsersRequest
         * @return ListUncheckUsersResponse
         */
        public ListUncheckUsersResponse ListUncheckUsers(ListUncheckUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUncheckUsersHeaders headers = new ListUncheckUsersHeaders();
            return ListUncheckUsersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取未确认加入组织的用户
         *
         * @param request ListUncheckUsersRequest
         * @return ListUncheckUsersResponse
         */
        public async Task<ListUncheckUsersResponse> ListUncheckUsersAsync(ListUncheckUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUncheckUsersHeaders headers = new ListUncheckUsersHeaders();
            return await ListUncheckUsersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户行业化角色
         *
         * @param request ListUserIndustryRolesRequest
         * @param headers ListUserIndustryRolesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserIndustryRolesResponse
         */
        public ListUserIndustryRolesResponse ListUserIndustryRolesWithOptions(ListUserIndustryRolesRequest request, ListUserIndustryRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListUserIndustryRoles",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/users/industryRoles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserIndustryRolesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户行业化角色
         *
         * @param request ListUserIndustryRolesRequest
         * @param headers ListUserIndustryRolesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserIndustryRolesResponse
         */
        public async Task<ListUserIndustryRolesResponse> ListUserIndustryRolesWithOptionsAsync(ListUserIndustryRolesRequest request, ListUserIndustryRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListUserIndustryRoles",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/users/industryRoles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserIndustryRolesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户行业化角色
         *
         * @param request ListUserIndustryRolesRequest
         * @return ListUserIndustryRolesResponse
         */
        public ListUserIndustryRolesResponse ListUserIndustryRoles(ListUserIndustryRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserIndustryRolesHeaders headers = new ListUserIndustryRolesHeaders();
            return ListUserIndustryRolesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户行业化角色
         *
         * @param request ListUserIndustryRolesRequest
         * @return ListUserIndustryRolesResponse
         */
        public async Task<ListUserIndustryRolesResponse> ListUserIndustryRolesAsync(ListUserIndustryRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserIndustryRolesHeaders headers = new ListUserIndustryRolesHeaders();
            return await ListUserIndustryRolesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询数字区县居民积分流水
         *
         * @param request PagePointHistoryRequest
         * @param headers PagePointHistoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PagePointHistoryResponse
         */
        public PagePointHistoryResponse PagePointHistoryWithOptions(PagePointHistoryRequest request, PagePointHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "PagePointHistory",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/points/records",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PagePointHistoryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询数字区县居民积分流水
         *
         * @param request PagePointHistoryRequest
         * @param headers PagePointHistoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PagePointHistoryResponse
         */
        public async Task<PagePointHistoryResponse> PagePointHistoryWithOptionsAsync(PagePointHistoryRequest request, PagePointHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "PagePointHistory",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/points/records",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PagePointHistoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询数字区县居民积分流水
         *
         * @param request PagePointHistoryRequest
         * @return PagePointHistoryResponse
         */
        public PagePointHistoryResponse PagePointHistory(PagePointHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagePointHistoryHeaders headers = new PagePointHistoryHeaders();
            return PagePointHistoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询数字区县居民积分流水
         *
         * @param request PagePointHistoryRequest
         * @return PagePointHistoryResponse
         */
        public async Task<PagePointHistoryResponse> PagePointHistoryAsync(PagePointHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagePointHistoryHeaders headers = new PagePointHistoryHeaders();
            return await PagePointHistoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 从空间中删除人员
         *
         * @param request RemoveResidentMemberRequest
         * @param headers RemoveResidentMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveResidentMemberResponse
         */
        public RemoveResidentMemberResponse RemoveResidentMemberWithOptions(RemoveResidentMemberRequest request, RemoveResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "RemoveResidentMember",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveResidentMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 从空间中删除人员
         *
         * @param request RemoveResidentMemberRequest
         * @param headers RemoveResidentMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveResidentMemberResponse
         */
        public async Task<RemoveResidentMemberResponse> RemoveResidentMemberWithOptionsAsync(RemoveResidentMemberRequest request, RemoveResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "RemoveResidentMember",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveResidentMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 从空间中删除人员
         *
         * @param request RemoveResidentMemberRequest
         * @return RemoveResidentMemberResponse
         */
        public RemoveResidentMemberResponse RemoveResidentMember(RemoveResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentMemberHeaders headers = new RemoveResidentMemberHeaders();
            return RemoveResidentMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 从空间中删除人员
         *
         * @param request RemoveResidentMemberRequest
         * @return RemoveResidentMemberResponse
         */
        public async Task<RemoveResidentMemberResponse> RemoveResidentMemberAsync(RemoveResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentMemberHeaders headers = new RemoveResidentMemberHeaders();
            return await RemoveResidentMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 从户内移除居民
         *
         * @param request RemoveResidentUserRequest
         * @param headers RemoveResidentUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveResidentUserResponse
         */
        public RemoveResidentUserResponse RemoveResidentUserWithOptions(RemoveResidentUserRequest request, RemoveResidentUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
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
                Action = "RemoveResidentUser",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/users/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveResidentUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 从户内移除居民
         *
         * @param request RemoveResidentUserRequest
         * @param headers RemoveResidentUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveResidentUserResponse
         */
        public async Task<RemoveResidentUserResponse> RemoveResidentUserWithOptionsAsync(RemoveResidentUserRequest request, RemoveResidentUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
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
                Action = "RemoveResidentUser",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/users/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveResidentUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 从户内移除居民
         *
         * @param request RemoveResidentUserRequest
         * @return RemoveResidentUserResponse
         */
        public RemoveResidentUserResponse RemoveResidentUser(RemoveResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentUserHeaders headers = new RemoveResidentUserHeaders();
            return RemoveResidentUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 从户内移除居民
         *
         * @param request RemoveResidentUserRequest
         * @return RemoveResidentUserResponse
         */
        public async Task<RemoveResidentUserResponse> RemoveResidentUserAsync(RemoveResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentUserHeaders headers = new RemoveResidentUserHeaders();
            return await RemoveResidentUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 搜索指定人员
         *
         * @param request SearchResidentRequest
         * @param headers SearchResidentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchResidentResponse
         */
        public SearchResidentResponse SearchResidentWithOptions(SearchResidentRequest request, SearchResidentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCropId))
            {
                query["residentCropId"] = request.ResidentCropId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchWord))
            {
                query["searchWord"] = request.SearchWord;
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
                Action = "SearchResident",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/residences",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResidentResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 搜索指定人员
         *
         * @param request SearchResidentRequest
         * @param headers SearchResidentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchResidentResponse
         */
        public async Task<SearchResidentResponse> SearchResidentWithOptionsAsync(SearchResidentRequest request, SearchResidentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCropId))
            {
                query["residentCropId"] = request.ResidentCropId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchWord))
            {
                query["searchWord"] = request.SearchWord;
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
                Action = "SearchResident",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/residences",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResidentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 搜索指定人员
         *
         * @param request SearchResidentRequest
         * @return SearchResidentResponse
         */
        public SearchResidentResponse SearchResident(SearchResidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchResidentHeaders headers = new SearchResidentHeaders();
            return SearchResidentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 搜索指定人员
         *
         * @param request SearchResidentRequest
         * @return SearchResidentResponse
         */
        public async Task<SearchResidentResponse> SearchResidentAsync(SearchResidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchResidentHeaders headers = new SearchResidentHeaders();
            return await SearchResidentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新组信息
         *
         * @param request UpdateResideceGroupRequest
         * @param headers UpdateResideceGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResideceGroupResponse
         */
        public UpdateResideceGroupResponse UpdateResideceGroupWithOptions(UpdateResideceGroupRequest request, UpdateResideceGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
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
                Action = "UpdateResideceGroup",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/departments/updateResideceGroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResideceGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新组信息
         *
         * @param request UpdateResideceGroupRequest
         * @param headers UpdateResideceGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResideceGroupResponse
         */
        public async Task<UpdateResideceGroupResponse> UpdateResideceGroupWithOptionsAsync(UpdateResideceGroupRequest request, UpdateResideceGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
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
                Action = "UpdateResideceGroup",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/departments/updateResideceGroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResideceGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新组信息
         *
         * @param request UpdateResideceGroupRequest
         * @return UpdateResideceGroupResponse
         */
        public UpdateResideceGroupResponse UpdateResideceGroup(UpdateResideceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResideceGroupHeaders headers = new UpdateResideceGroupHeaders();
            return UpdateResideceGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新组信息
         *
         * @param request UpdateResideceGroupRequest
         * @return UpdateResideceGroupResponse
         */
        public async Task<UpdateResideceGroupResponse> UpdateResideceGroupAsync(UpdateResideceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResideceGroupHeaders headers = new UpdateResideceGroupHeaders();
            return await UpdateResideceGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新户信息
         *
         * @param request UpdateResidenceRequest
         * @param headers UpdateResidenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResidenceResponse
         */
        public UpdateResidenceResponse UpdateResidenceWithOptions(UpdateResidenceRequest request, UpdateResidenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destitute))
            {
                query["destitute"] = request.Destitute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grid))
            {
                query["grid"] = request.Grid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomeTel))
            {
                query["homeTel"] = request.HomeTel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDepartmentId))
            {
                query["parentDepartmentId"] = request.ParentDepartmentId;
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
                Action = "UpdateResidence",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/departments/updateResidece",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResidenceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新户信息
         *
         * @param request UpdateResidenceRequest
         * @param headers UpdateResidenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResidenceResponse
         */
        public async Task<UpdateResidenceResponse> UpdateResidenceWithOptionsAsync(UpdateResidenceRequest request, UpdateResidenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destitute))
            {
                query["destitute"] = request.Destitute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grid))
            {
                query["grid"] = request.Grid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomeTel))
            {
                query["homeTel"] = request.HomeTel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDepartmentId))
            {
                query["parentDepartmentId"] = request.ParentDepartmentId;
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
                Action = "UpdateResidence",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/departments/updateResidece",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResidenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新户信息
         *
         * @param request UpdateResidenceRequest
         * @return UpdateResidenceResponse
         */
        public UpdateResidenceResponse UpdateResidence(UpdateResidenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidenceHeaders headers = new UpdateResidenceHeaders();
            return UpdateResidenceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新户信息
         *
         * @param request UpdateResidenceRequest
         * @return UpdateResidenceResponse
         */
        public async Task<UpdateResidenceResponse> UpdateResidenceAsync(UpdateResidenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidenceHeaders headers = new UpdateResidenceHeaders();
            return await UpdateResidenceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新小区公告
         *
         * @param request UpdateResidentBlackBoardRequest
         * @param headers UpdateResidentBlackBoardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResidentBlackBoardResponse
         */
        public UpdateResidentBlackBoardResponse UpdateResidentBlackBoardWithOptions(UpdateResidentBlackBoardRequest request, UpdateResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                body["blackboardId"] = request.BlackboardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                body["context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "UpdateResidentBlackBoard",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/blackboards",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResidentBlackBoardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新小区公告
         *
         * @param request UpdateResidentBlackBoardRequest
         * @param headers UpdateResidentBlackBoardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResidentBlackBoardResponse
         */
        public async Task<UpdateResidentBlackBoardResponse> UpdateResidentBlackBoardWithOptionsAsync(UpdateResidentBlackBoardRequest request, UpdateResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                body["blackboardId"] = request.BlackboardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                body["context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "UpdateResidentBlackBoard",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/blackboards",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResidentBlackBoardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新小区公告
         *
         * @param request UpdateResidentBlackBoardRequest
         * @return UpdateResidentBlackBoardResponse
         */
        public UpdateResidentBlackBoardResponse UpdateResidentBlackBoard(UpdateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentBlackBoardHeaders headers = new UpdateResidentBlackBoardHeaders();
            return UpdateResidentBlackBoardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新小区公告
         *
         * @param request UpdateResidentBlackBoardRequest
         * @return UpdateResidentBlackBoardResponse
         */
        public async Task<UpdateResidentBlackBoardResponse> UpdateResidentBlackBoardAsync(UpdateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentBlackBoardHeaders headers = new UpdateResidentBlackBoardHeaders();
            return await UpdateResidentBlackBoardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新小区信息
         *
         * @param request UpdateResidentInfoRequest
         * @param headers UpdateResidentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResidentInfoResponse
         */
        public UpdateResidentInfoResponse UpdateResidentInfoWithOptions(UpdateResidentInfoRequest request, UpdateResidentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildingArea))
            {
                body["buildingArea"] = request.BuildingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityName))
            {
                body["cityName"] = request.CityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityType))
            {
                body["communityType"] = request.CommunityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountyName))
            {
                body["countyName"] = request.CountyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvName))
            {
                body["provName"] = request.ProvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                body["telephone"] = request.Telephone;
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
                Action = "UpdateResidentInfo",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/residences",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResidentInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新小区信息
         *
         * @param request UpdateResidentInfoRequest
         * @param headers UpdateResidentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResidentInfoResponse
         */
        public async Task<UpdateResidentInfoResponse> UpdateResidentInfoWithOptionsAsync(UpdateResidentInfoRequest request, UpdateResidentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildingArea))
            {
                body["buildingArea"] = request.BuildingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityName))
            {
                body["cityName"] = request.CityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityType))
            {
                body["communityType"] = request.CommunityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountyName))
            {
                body["countyName"] = request.CountyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvName))
            {
                body["provName"] = request.ProvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                body["telephone"] = request.Telephone;
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
                Action = "UpdateResidentInfo",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/residences",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResidentInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新小区信息
         *
         * @param request UpdateResidentInfoRequest
         * @return UpdateResidentInfoResponse
         */
        public UpdateResidentInfoResponse UpdateResidentInfo(UpdateResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentInfoHeaders headers = new UpdateResidentInfoHeaders();
            return UpdateResidentInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新小区信息
         *
         * @param request UpdateResidentInfoRequest
         * @return UpdateResidentInfoResponse
         */
        public async Task<UpdateResidentInfoResponse> UpdateResidentInfoAsync(UpdateResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentInfoHeaders headers = new UpdateResidentInfoHeaders();
            return await UpdateResidentInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新小区成员
         *
         * @param request UpdateResidentMemberRequest
         * @param headers UpdateResidentMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResidentMemberResponse
         */
        public UpdateResidentMemberResponse UpdateResidentMemberWithOptions(UpdateResidentMemberRequest request, UpdateResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentUpdateInfo))
            {
                body["residentUpdateInfo"] = request.ResidentUpdateInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "UpdateResidentMember",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResidentMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新小区成员
         *
         * @param request UpdateResidentMemberRequest
         * @param headers UpdateResidentMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResidentMemberResponse
         */
        public async Task<UpdateResidentMemberResponse> UpdateResidentMemberWithOptionsAsync(UpdateResidentMemberRequest request, UpdateResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentUpdateInfo))
            {
                body["residentUpdateInfo"] = request.ResidentUpdateInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "UpdateResidentMember",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResidentMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新小区成员
         *
         * @param request UpdateResidentMemberRequest
         * @return UpdateResidentMemberResponse
         */
        public UpdateResidentMemberResponse UpdateResidentMember(UpdateResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentMemberHeaders headers = new UpdateResidentMemberHeaders();
            return UpdateResidentMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新小区成员
         *
         * @param request UpdateResidentMemberRequest
         * @return UpdateResidentMemberResponse
         */
        public async Task<UpdateResidentMemberResponse> UpdateResidentMemberAsync(UpdateResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentMemberHeaders headers = new UpdateResidentMemberHeaders();
            return await UpdateResidentMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新居民信息
         *
         * @param request UpdateResidentUserRequest
         * @param headers UpdateResidentUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResidentUserResponse
         */
        public UpdateResidentUserResponse UpdateResidentUserWithOptions(UpdateResidentUserRequest request, UpdateResidentUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtField))
            {
                query["extField"] = request.ExtField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRetainOldDept))
            {
                query["isRetainOldDept"] = request.IsRetainOldDept;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldDepartmentId))
            {
                query["oldDepartmentId"] = request.OldDepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateType))
            {
                query["relateType"] = request.RelateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
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
                Action = "UpdateResidentUser",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/users",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResidentUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新居民信息
         *
         * @param request UpdateResidentUserRequest
         * @param headers UpdateResidentUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResidentUserResponse
         */
        public async Task<UpdateResidentUserResponse> UpdateResidentUserWithOptionsAsync(UpdateResidentUserRequest request, UpdateResidentUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtField))
            {
                query["extField"] = request.ExtField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRetainOldDept))
            {
                query["isRetainOldDept"] = request.IsRetainOldDept;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldDepartmentId))
            {
                query["oldDepartmentId"] = request.OldDepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateType))
            {
                query["relateType"] = request.RelateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
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
                Action = "UpdateResidentUser",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/users",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResidentUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新居民信息
         *
         * @param request UpdateResidentUserRequest
         * @return UpdateResidentUserResponse
         */
        public UpdateResidentUserResponse UpdateResidentUser(UpdateResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentUserHeaders headers = new UpdateResidentUserHeaders();
            return UpdateResidentUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新居民信息
         *
         * @param request UpdateResidentUserRequest
         * @return UpdateResidentUserResponse
         */
        public async Task<UpdateResidentUserResponse> UpdateResidentUserAsync(UpdateResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentUserHeaders headers = new UpdateResidentUserHeaders();
            return await UpdateResidentUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新小区空间，含分区，楼栋，单元，房屋等信息
         *
         * @param request UpdateSpaceRequest
         * @param headers UpdateSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSpaceResponse
         */
        public UpdateSpaceResponse UpdateSpaceWithOptions(UpdateSpaceRequest request, UpdateSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceInfoVOList))
            {
                body["spaceInfoVOList"] = request.SpaceInfoVOList;
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
                Action = "UpdateSpace",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSpaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新小区空间，含分区，楼栋，单元，房屋等信息
         *
         * @param request UpdateSpaceRequest
         * @param headers UpdateSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSpaceResponse
         */
        public async Task<UpdateSpaceResponse> UpdateSpaceWithOptionsAsync(UpdateSpaceRequest request, UpdateSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceInfoVOList))
            {
                body["spaceInfoVOList"] = request.SpaceInfoVOList;
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
                Action = "UpdateSpace",
                Version = "resident_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/resident/spaces",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新小区空间，含分区，楼栋，单元，房屋等信息
         *
         * @param request UpdateSpaceRequest
         * @return UpdateSpaceResponse
         */
        public UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSpaceHeaders headers = new UpdateSpaceHeaders();
            return UpdateSpaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新小区空间，含分区，楼栋，单元，房屋等信息
         *
         * @param request UpdateSpaceRequest
         * @return UpdateSpaceResponse
         */
        public async Task<UpdateSpaceResponse> UpdateSpaceAsync(UpdateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSpaceHeaders headers = new UpdateSpaceHeaders();
            return await UpdateSpaceWithOptionsAsync(request, headers, runtime);
        }

    }
}
