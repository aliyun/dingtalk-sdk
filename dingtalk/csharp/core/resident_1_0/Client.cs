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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
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
        /// <para>增加积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddPointRequest
        /// </param>
        /// <param name="headers">
        /// AddPointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddPointResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddPointRequest
        /// </param>
        /// <param name="headers">
        /// AddPointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddPointResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddPointRequest
        /// </param>
        /// 
        /// <returns>
        /// AddPointResponse
        /// </returns>
        public AddPointResponse AddPoint(AddPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPointHeaders headers = new AddPointHeaders();
            return AddPointWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddPointRequest
        /// </param>
        /// 
        /// <returns>
        /// AddPointResponse
        /// </returns>
        public async Task<AddPointResponse> AddPointAsync(AddPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPointHeaders headers = new AddPointHeaders();
            return await AddPointWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加组户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentDepartmentRequest
        /// </param>
        /// <param name="headers">
        /// AddResidentDepartmentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddResidentDepartmentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加组户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentDepartmentRequest
        /// </param>
        /// <param name="headers">
        /// AddResidentDepartmentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddResidentDepartmentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加组户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddResidentDepartmentResponse
        /// </returns>
        public AddResidentDepartmentResponse AddResidentDepartment(AddResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentDepartmentHeaders headers = new AddResidentDepartmentHeaders();
            return AddResidentDepartmentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加组户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddResidentDepartmentResponse
        /// </returns>
        public async Task<AddResidentDepartmentResponse> AddResidentDepartmentAsync(AddResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentDepartmentHeaders headers = new AddResidentDepartmentHeaders();
            return await AddResidentDepartmentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加小区成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentMemberRequest
        /// </param>
        /// <param name="headers">
        /// AddResidentMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddResidentMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加小区成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentMemberRequest
        /// </param>
        /// <param name="headers">
        /// AddResidentMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddResidentMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加小区成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddResidentMemberResponse
        /// </returns>
        public AddResidentMemberResponse AddResidentMember(AddResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentMemberHeaders headers = new AddResidentMemberHeaders();
            return AddResidentMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加小区成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddResidentMemberResponse
        /// </returns>
        public async Task<AddResidentMemberResponse> AddResidentMemberAsync(AddResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentMemberHeaders headers = new AddResidentMemberHeaders();
            return await AddResidentMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增居民</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentUsersRequest
        /// </param>
        /// <param name="headers">
        /// AddResidentUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddResidentUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增居民</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentUsersRequest
        /// </param>
        /// <param name="headers">
        /// AddResidentUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddResidentUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增居民</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddResidentUsersResponse
        /// </returns>
        public AddResidentUsersResponse AddResidentUsers(AddResidentUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentUsersHeaders headers = new AddResidentUsersHeaders();
            return AddResidentUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增居民</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddResidentUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddResidentUsersResponse
        /// </returns>
        public async Task<AddResidentUsersResponse> AddResidentUsersAsync(AddResidentUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentUsersHeaders headers = new AddResidentUsersHeaders();
            return await AddResidentUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResidentBlackBoardRequest
        /// </param>
        /// <param name="headers">
        /// CreateResidentBlackBoardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResidentBlackBoardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResidentBlackBoardRequest
        /// </param>
        /// <param name="headers">
        /// CreateResidentBlackBoardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResidentBlackBoardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResidentBlackBoardRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResidentBlackBoardResponse
        /// </returns>
        public CreateResidentBlackBoardResponse CreateResidentBlackBoard(CreateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateResidentBlackBoardHeaders headers = new CreateResidentBlackBoardHeaders();
            return CreateResidentBlackBoardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResidentBlackBoardRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResidentBlackBoardResponse
        /// </returns>
        public async Task<CreateResidentBlackBoardResponse> CreateResidentBlackBoardAsync(CreateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateResidentBlackBoardHeaders headers = new CreateResidentBlackBoardHeaders();
            return await CreateResidentBlackBoardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小区空间，含分区，楼栋，单元，房屋等</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSpaceRequest
        /// </param>
        /// <param name="headers">
        /// CreateSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSpaceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小区空间，含分区，楼栋，单元，房屋等</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSpaceRequest
        /// </param>
        /// <param name="headers">
        /// CreateSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSpaceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小区空间，含分区，楼栋，单元，房屋等</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSpaceResponse
        /// </returns>
        public CreateSpaceResponse CreateSpace(CreateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSpaceHeaders headers = new CreateSpaceHeaders();
            return CreateSpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小区空间，含分区，楼栋，单元，房屋等</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSpaceResponse
        /// </returns>
        public async Task<CreateSpaceResponse> CreateSpaceAsync(CreateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSpaceHeaders headers = new CreateSpaceHeaders();
            return await CreateSpaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResidentBlackBoardRequest
        /// </param>
        /// <param name="headers">
        /// DeleteResidentBlackBoardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResidentBlackBoardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResidentBlackBoardRequest
        /// </param>
        /// <param name="headers">
        /// DeleteResidentBlackBoardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResidentBlackBoardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResidentBlackBoardRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResidentBlackBoardResponse
        /// </returns>
        public DeleteResidentBlackBoardResponse DeleteResidentBlackBoard(DeleteResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentBlackBoardHeaders headers = new DeleteResidentBlackBoardHeaders();
            return DeleteResidentBlackBoardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResidentBlackBoardRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResidentBlackBoardResponse
        /// </returns>
        public async Task<DeleteResidentBlackBoardResponse> DeleteResidentBlackBoardAsync(DeleteResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentBlackBoardHeaders headers = new DeleteResidentBlackBoardHeaders();
            return await DeleteResidentBlackBoardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除组户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResidentDepartmentRequest
        /// </param>
        /// <param name="headers">
        /// DeleteResidentDepartmentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResidentDepartmentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除组户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResidentDepartmentRequest
        /// </param>
        /// <param name="headers">
        /// DeleteResidentDepartmentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResidentDepartmentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除组户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResidentDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResidentDepartmentResponse
        /// </returns>
        public DeleteResidentDepartmentResponse DeleteResidentDepartment(DeleteResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentDepartmentHeaders headers = new DeleteResidentDepartmentHeaders();
            return DeleteResidentDepartmentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除组户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResidentDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResidentDepartmentResponse
        /// </returns>
        public async Task<DeleteResidentDepartmentResponse> DeleteResidentDepartmentAsync(DeleteResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentDepartmentHeaders headers = new DeleteResidentDepartmentHeaders();
            return await DeleteResidentDepartmentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小区空间，含分区，楼栋，单元，房屋</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSpaceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSpaceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小区空间，含分区，楼栋，单元，房屋</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSpaceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSpaceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小区空间，含分区，楼栋，单元，房屋</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSpaceResponse
        /// </returns>
        public DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
            return DeleteSpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除小区空间，含分区，楼栋，单元，房屋</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSpaceResponse
        /// </returns>
        public async Task<DeleteSpaceResponse> DeleteSpaceAsync(DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
            return await DeleteSpaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定群的openConversationId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationIdRequest
        /// </param>
        /// <param name="headers">
        /// GetConversationIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConversationIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定群的openConversationId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationIdRequest
        /// </param>
        /// <param name="headers">
        /// GetConversationIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConversationIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定群的openConversationId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConversationIdResponse
        /// </returns>
        public GetConversationIdResponse GetConversationId(GetConversationIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationIdHeaders headers = new GetConversationIdHeaders();
            return GetConversationIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定群的openConversationId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConversationIdResponse
        /// </returns>
        public async Task<GetConversationIdResponse> GetConversationIdAsync(GetConversationIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationIdHeaders headers = new GetConversationIdHeaders();
            return await GetConversationIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织的行业类型</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetIndustryTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndustryTypeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织的行业类型</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetIndustryTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndustryTypeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织的行业类型</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIndustryTypeResponse
        /// </returns>
        public GetIndustryTypeResponse GetIndustryType()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIndustryTypeHeaders headers = new GetIndustryTypeHeaders();
            return GetIndustryTypeWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织的行业类型</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIndustryTypeResponse
        /// </returns>
        public async Task<GetIndustryTypeResponse> GetIndustryTypeAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIndustryTypeHeaders headers = new GetIndustryTypeHeaders();
            return await GetIndustryTypeWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取物业公司信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPropertyInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetPropertyInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPropertyInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取物业公司信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPropertyInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetPropertyInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPropertyInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取物业公司信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPropertyInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPropertyInfoResponse
        /// </returns>
        public GetPropertyInfoResponse GetPropertyInfo(GetPropertyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPropertyInfoHeaders headers = new GetPropertyInfoHeaders();
            return GetPropertyInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取物业公司信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPropertyInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPropertyInfoResponse
        /// </returns>
        public async Task<GetPropertyInfoResponse> GetPropertyInfoAsync(GetPropertyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPropertyInfoHeaders headers = new GetPropertyInfoHeaders();
            return await GetPropertyInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小区信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResidentInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetResidentInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResidentInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小区信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResidentInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetResidentInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResidentInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小区信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResidentInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResidentInfoResponse
        /// </returns>
        public GetResidentInfoResponse GetResidentInfo(GetResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentInfoHeaders headers = new GetResidentInfoHeaders();
            return GetResidentInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小区信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResidentInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResidentInfoResponse
        /// </returns>
        public async Task<GetResidentInfoResponse> GetResidentInfoAsync(GetResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentInfoHeaders headers = new GetResidentInfoHeaders();
            return await GetResidentInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小区人员信息，包括居民和物业人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResidentMembersInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetResidentMembersInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResidentMembersInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小区人员信息，包括居民和物业人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResidentMembersInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetResidentMembersInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResidentMembersInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小区人员信息，包括居民和物业人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResidentMembersInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResidentMembersInfoResponse
        /// </returns>
        public GetResidentMembersInfoResponse GetResidentMembersInfo(GetResidentMembersInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentMembersInfoHeaders headers = new GetResidentMembersInfoHeaders();
            return GetResidentMembersInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小区人员信息，包括居民和物业人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResidentMembersInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResidentMembersInfoResponse
        /// </returns>
        public async Task<GetResidentMembersInfoResponse> GetResidentMembersInfoAsync(GetResidentMembersInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentMembersInfoHeaders headers = new GetResidentMembersInfoHeaders();
            return await GetResidentMembersInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据类型获取部门id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceIdByTypeRequest
        /// </param>
        /// <param name="headers">
        /// GetSpaceIdByTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceIdByTypeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据类型获取部门id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceIdByTypeRequest
        /// </param>
        /// <param name="headers">
        /// GetSpaceIdByTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceIdByTypeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据类型获取部门id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceIdByTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceIdByTypeResponse
        /// </returns>
        public GetSpaceIdByTypeResponse GetSpaceIdByType(GetSpaceIdByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceIdByTypeHeaders headers = new GetSpaceIdByTypeHeaders();
            return GetSpaceIdByTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据类型获取部门id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceIdByTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceIdByTypeResponse
        /// </returns>
        public async Task<GetSpaceIdByTypeResponse> GetSpaceIdByTypeAsync(GetSpaceIdByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceIdByTypeHeaders headers = new GetSpaceIdByTypeHeaders();
            return await GetSpaceIdByTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpacesInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetSpacesInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpacesInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpacesInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetSpacesInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpacesInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpacesInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpacesInfoResponse
        /// </returns>
        public GetSpacesInfoResponse GetSpacesInfo(GetSpacesInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpacesInfoHeaders headers = new GetSpacesInfoHeaders();
            return GetSpacesInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpacesInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpacesInfoResponse
        /// </returns>
        public async Task<GetSpacesInfoResponse> GetSpacesInfoAsync(GetSpacesInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpacesInfoHeaders headers = new GetSpacesInfoHeaders();
            return await GetSpacesInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取行业角色下的用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIndustryRoleUsersRequest
        /// </param>
        /// <param name="headers">
        /// ListIndustryRoleUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndustryRoleUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取行业角色下的用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIndustryRoleUsersRequest
        /// </param>
        /// <param name="headers">
        /// ListIndustryRoleUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndustryRoleUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取行业角色下的用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIndustryRoleUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIndustryRoleUsersResponse
        /// </returns>
        public ListIndustryRoleUsersResponse ListIndustryRoleUsers(ListIndustryRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListIndustryRoleUsersHeaders headers = new ListIndustryRoleUsersHeaders();
            return ListIndustryRoleUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取行业角色下的用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIndustryRoleUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIndustryRoleUsersResponse
        /// </returns>
        public async Task<ListIndustryRoleUsersResponse> ListIndustryRoleUsersAsync(ListIndustryRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListIndustryRoleUsersHeaders headers = new ListIndustryRoleUsersHeaders();
            return await ListIndustryRoleUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织维度配置的的积分规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPointRulesRequest
        /// </param>
        /// <param name="headers">
        /// ListPointRulesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPointRulesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织维度配置的的积分规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPointRulesRequest
        /// </param>
        /// <param name="headers">
        /// ListPointRulesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPointRulesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织维度配置的的积分规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPointRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPointRulesResponse
        /// </returns>
        public ListPointRulesResponse ListPointRules(ListPointRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPointRulesHeaders headers = new ListPointRulesHeaders();
            return ListPointRulesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织维度配置的的积分规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPointRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPointRulesResponse
        /// </returns>
        public async Task<ListPointRulesResponse> ListPointRulesAsync(ListPointRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPointRulesHeaders headers = new ListPointRulesHeaders();
            return await ListPointRulesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取子空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubSpaceRequest
        /// </param>
        /// <param name="headers">
        /// ListSubSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubSpaceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取子空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubSpaceRequest
        /// </param>
        /// <param name="headers">
        /// ListSubSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubSpaceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取子空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubSpaceResponse
        /// </returns>
        public ListSubSpaceResponse ListSubSpace(ListSubSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubSpaceHeaders headers = new ListSubSpaceHeaders();
            return ListSubSpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取子空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubSpaceResponse
        /// </returns>
        public async Task<ListSubSpaceResponse> ListSubSpaceAsync(ListSubSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubSpaceHeaders headers = new ListSubSpaceHeaders();
            return await ListSubSpaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取未确认加入组织的用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUncheckUsersRequest
        /// </param>
        /// <param name="headers">
        /// ListUncheckUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUncheckUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取未确认加入组织的用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUncheckUsersRequest
        /// </param>
        /// <param name="headers">
        /// ListUncheckUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUncheckUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取未确认加入组织的用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUncheckUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUncheckUsersResponse
        /// </returns>
        public ListUncheckUsersResponse ListUncheckUsers(ListUncheckUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUncheckUsersHeaders headers = new ListUncheckUsersHeaders();
            return ListUncheckUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取未确认加入组织的用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUncheckUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUncheckUsersResponse
        /// </returns>
        public async Task<ListUncheckUsersResponse> ListUncheckUsersAsync(ListUncheckUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUncheckUsersHeaders headers = new ListUncheckUsersHeaders();
            return await ListUncheckUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户行业化角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserIndustryRolesRequest
        /// </param>
        /// <param name="headers">
        /// ListUserIndustryRolesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserIndustryRolesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户行业化角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserIndustryRolesRequest
        /// </param>
        /// <param name="headers">
        /// ListUserIndustryRolesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserIndustryRolesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户行业化角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserIndustryRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserIndustryRolesResponse
        /// </returns>
        public ListUserIndustryRolesResponse ListUserIndustryRoles(ListUserIndustryRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserIndustryRolesHeaders headers = new ListUserIndustryRolesHeaders();
            return ListUserIndustryRolesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户行业化角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserIndustryRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserIndustryRolesResponse
        /// </returns>
        public async Task<ListUserIndustryRolesResponse> ListUserIndustryRolesAsync(ListUserIndustryRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserIndustryRolesHeaders headers = new ListUserIndustryRolesHeaders();
            return await ListUserIndustryRolesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字区县居民积分流水</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PagePointHistoryRequest
        /// </param>
        /// <param name="headers">
        /// PagePointHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PagePointHistoryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字区县居民积分流水</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PagePointHistoryRequest
        /// </param>
        /// <param name="headers">
        /// PagePointHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PagePointHistoryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字区县居民积分流水</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PagePointHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// PagePointHistoryResponse
        /// </returns>
        public PagePointHistoryResponse PagePointHistory(PagePointHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagePointHistoryHeaders headers = new PagePointHistoryHeaders();
            return PagePointHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字区县居民积分流水</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PagePointHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// PagePointHistoryResponse
        /// </returns>
        public async Task<PagePointHistoryResponse> PagePointHistoryAsync(PagePointHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagePointHistoryHeaders headers = new PagePointHistoryHeaders();
            return await PagePointHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从空间中删除人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveResidentMemberRequest
        /// </param>
        /// <param name="headers">
        /// RemoveResidentMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveResidentMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从空间中删除人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveResidentMemberRequest
        /// </param>
        /// <param name="headers">
        /// RemoveResidentMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveResidentMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从空间中删除人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveResidentMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveResidentMemberResponse
        /// </returns>
        public RemoveResidentMemberResponse RemoveResidentMember(RemoveResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentMemberHeaders headers = new RemoveResidentMemberHeaders();
            return RemoveResidentMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从空间中删除人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveResidentMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveResidentMemberResponse
        /// </returns>
        public async Task<RemoveResidentMemberResponse> RemoveResidentMemberAsync(RemoveResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentMemberHeaders headers = new RemoveResidentMemberHeaders();
            return await RemoveResidentMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从户内移除居民</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveResidentUserRequest
        /// </param>
        /// <param name="headers">
        /// RemoveResidentUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveResidentUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从户内移除居民</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveResidentUserRequest
        /// </param>
        /// <param name="headers">
        /// RemoveResidentUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveResidentUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从户内移除居民</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveResidentUserRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveResidentUserResponse
        /// </returns>
        public RemoveResidentUserResponse RemoveResidentUser(RemoveResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentUserHeaders headers = new RemoveResidentUserHeaders();
            return RemoveResidentUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从户内移除居民</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveResidentUserRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveResidentUserResponse
        /// </returns>
        public async Task<RemoveResidentUserResponse> RemoveResidentUserAsync(RemoveResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentUserHeaders headers = new RemoveResidentUserHeaders();
            return await RemoveResidentUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索指定人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchResidentRequest
        /// </param>
        /// <param name="headers">
        /// SearchResidentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchResidentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索指定人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchResidentRequest
        /// </param>
        /// <param name="headers">
        /// SearchResidentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchResidentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索指定人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchResidentRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchResidentResponse
        /// </returns>
        public SearchResidentResponse SearchResident(SearchResidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchResidentHeaders headers = new SearchResidentHeaders();
            return SearchResidentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索指定人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchResidentRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchResidentResponse
        /// </returns>
        public async Task<SearchResidentResponse> SearchResidentAsync(SearchResidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchResidentHeaders headers = new SearchResidentHeaders();
            return await SearchResidentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResideceGroupRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResideceGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResideceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResideceGroupRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResideceGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResideceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResideceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResideceGroupResponse
        /// </returns>
        public UpdateResideceGroupResponse UpdateResideceGroup(UpdateResideceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResideceGroupHeaders headers = new UpdateResideceGroupHeaders();
            return UpdateResideceGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResideceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResideceGroupResponse
        /// </returns>
        public async Task<UpdateResideceGroupResponse> UpdateResideceGroupAsync(UpdateResideceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResideceGroupHeaders headers = new UpdateResideceGroupHeaders();
            return await UpdateResideceGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidenceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResidenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidenceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidenceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResidenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidenceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidenceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidenceResponse
        /// </returns>
        public UpdateResidenceResponse UpdateResidence(UpdateResidenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidenceHeaders headers = new UpdateResidenceHeaders();
            return UpdateResidenceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidenceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidenceResponse
        /// </returns>
        public async Task<UpdateResidenceResponse> UpdateResidenceAsync(UpdateResidenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidenceHeaders headers = new UpdateResidenceHeaders();
            return await UpdateResidenceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentBlackBoardRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResidentBlackBoardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentBlackBoardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentBlackBoardRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResidentBlackBoardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentBlackBoardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentBlackBoardRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentBlackBoardResponse
        /// </returns>
        public UpdateResidentBlackBoardResponse UpdateResidentBlackBoard(UpdateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentBlackBoardHeaders headers = new UpdateResidentBlackBoardHeaders();
            return UpdateResidentBlackBoardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentBlackBoardRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentBlackBoardResponse
        /// </returns>
        public async Task<UpdateResidentBlackBoardResponse> UpdateResidentBlackBoardAsync(UpdateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentBlackBoardHeaders headers = new UpdateResidentBlackBoardHeaders();
            return await UpdateResidentBlackBoardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResidentInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResidentInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentInfoResponse
        /// </returns>
        public UpdateResidentInfoResponse UpdateResidentInfo(UpdateResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentInfoHeaders headers = new UpdateResidentInfoHeaders();
            return UpdateResidentInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentInfoResponse
        /// </returns>
        public async Task<UpdateResidentInfoResponse> UpdateResidentInfoAsync(UpdateResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentInfoHeaders headers = new UpdateResidentInfoHeaders();
            return await UpdateResidentInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentMemberRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResidentMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentMemberRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResidentMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentMemberResponse
        /// </returns>
        public UpdateResidentMemberResponse UpdateResidentMember(UpdateResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentMemberHeaders headers = new UpdateResidentMemberHeaders();
            return UpdateResidentMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentMemberResponse
        /// </returns>
        public async Task<UpdateResidentMemberResponse> UpdateResidentMemberAsync(UpdateResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentMemberHeaders headers = new UpdateResidentMemberHeaders();
            return await UpdateResidentMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新居民信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentUserRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResidentUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新居民信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentUserRequest
        /// </param>
        /// <param name="headers">
        /// UpdateResidentUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新居民信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentUserResponse
        /// </returns>
        public UpdateResidentUserResponse UpdateResidentUser(UpdateResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentUserHeaders headers = new UpdateResidentUserHeaders();
            return UpdateResidentUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新居民信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResidentUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResidentUserResponse
        /// </returns>
        public async Task<UpdateResidentUserResponse> UpdateResidentUserAsync(UpdateResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentUserHeaders headers = new UpdateResidentUserHeaders();
            return await UpdateResidentUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区空间，含分区，楼栋，单元，房屋等信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSpaceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSpaceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区空间，含分区，楼栋，单元，房屋等信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSpaceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSpaceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区空间，含分区，楼栋，单元，房屋等信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSpaceResponse
        /// </returns>
        public UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSpaceHeaders headers = new UpdateSpaceHeaders();
            return UpdateSpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新小区空间，含分区，楼栋，单元，房屋等信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSpaceResponse
        /// </returns>
        public async Task<UpdateSpaceResponse> UpdateSpaceAsync(UpdateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSpaceHeaders headers = new UpdateSpaceHeaders();
            return await UpdateSpaceWithOptionsAsync(request, headers, runtime);
        }

    }
}
