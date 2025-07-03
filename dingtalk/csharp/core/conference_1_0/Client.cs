// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkconference_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0
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
        /// <para>增加闪记权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRecordPermissionRequest
        /// </param>
        /// <param name="headers">
        /// AddRecordPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRecordPermissionResponse
        /// </returns>
        public AddRecordPermissionResponse AddRecordPermissionWithOptions(string conferenceId, AddRecordPermissionRequest request, AddRecordPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
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
                Action = "AddRecordPermission",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/flashMinutes/recordPermissions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRecordPermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加闪记权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRecordPermissionRequest
        /// </param>
        /// <param name="headers">
        /// AddRecordPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRecordPermissionResponse
        /// </returns>
        public async Task<AddRecordPermissionResponse> AddRecordPermissionWithOptionsAsync(string conferenceId, AddRecordPermissionRequest request, AddRecordPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
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
                Action = "AddRecordPermission",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/flashMinutes/recordPermissions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRecordPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加闪记权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRecordPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRecordPermissionResponse
        /// </returns>
        public AddRecordPermissionResponse AddRecordPermission(string conferenceId, AddRecordPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRecordPermissionHeaders headers = new AddRecordPermissionHeaders();
            return AddRecordPermissionWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加闪记权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRecordPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRecordPermissionResponse
        /// </returns>
        public async Task<AddRecordPermissionResponse> AddRecordPermissionAsync(string conferenceId, AddRecordPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRecordPermissionHeaders headers = new AddRecordPermissionHeaders();
            return await AddRecordPermissionWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelScheduleConferenceRequest
        /// </param>
        /// <param name="headers">
        /// CancelScheduleConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelScheduleConferenceResponse
        /// </returns>
        public CancelScheduleConferenceResponse CancelScheduleConferenceWithOptions(CancelScheduleConferenceRequest request, CancelScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
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
                Action = "CancelScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelScheduleConferenceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelScheduleConferenceRequest
        /// </param>
        /// <param name="headers">
        /// CancelScheduleConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelScheduleConferenceResponse
        /// </returns>
        public async Task<CancelScheduleConferenceResponse> CancelScheduleConferenceWithOptionsAsync(CancelScheduleConferenceRequest request, CancelScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
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
                Action = "CancelScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelScheduleConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelScheduleConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelScheduleConferenceResponse
        /// </returns>
        public CancelScheduleConferenceResponse CancelScheduleConference(CancelScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelScheduleConferenceHeaders headers = new CancelScheduleConferenceHeaders();
            return CancelScheduleConferenceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelScheduleConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelScheduleConferenceResponse
        /// </returns>
        public async Task<CancelScheduleConferenceResponse> CancelScheduleConferenceAsync(CancelScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelScheduleConferenceHeaders headers = new CancelScheduleConferenceHeaders();
            return await CancelScheduleConferenceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseVideoConferenceRequest
        /// </param>
        /// <param name="headers">
        /// CloseVideoConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseVideoConferenceResponse
        /// </returns>
        public CloseVideoConferenceResponse CloseVideoConferenceWithOptions(string conferenceId, CloseVideoConferenceRequest request, CloseVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "CloseVideoConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseVideoConferenceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseVideoConferenceRequest
        /// </param>
        /// <param name="headers">
        /// CloseVideoConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseVideoConferenceResponse
        /// </returns>
        public async Task<CloseVideoConferenceResponse> CloseVideoConferenceWithOptionsAsync(string conferenceId, CloseVideoConferenceRequest request, CloseVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "CloseVideoConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseVideoConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseVideoConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseVideoConferenceResponse
        /// </returns>
        public CloseVideoConferenceResponse CloseVideoConference(string conferenceId, CloseVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseVideoConferenceHeaders headers = new CloseVideoConferenceHeaders();
            return CloseVideoConferenceWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseVideoConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseVideoConferenceResponse
        /// </returns>
        public async Task<CloseVideoConferenceResponse> CloseVideoConferenceAsync(string conferenceId, CloseVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseVideoConferenceHeaders headers = new CloseVideoConferenceHeaders();
            return await CloseVideoConferenceWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置联席主持人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CohostsRequest
        /// </param>
        /// <param name="headers">
        /// CohostsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CohostsResponse
        /// </returns>
        public CohostsResponse CohostsWithOptions(string conferenceId, CohostsRequest request, CohostsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
                Action = "Cohosts",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/coHosts/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CohostsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置联席主持人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CohostsRequest
        /// </param>
        /// <param name="headers">
        /// CohostsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CohostsResponse
        /// </returns>
        public async Task<CohostsResponse> CohostsWithOptionsAsync(string conferenceId, CohostsRequest request, CohostsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
                Action = "Cohosts",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/coHosts/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CohostsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置联席主持人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CohostsRequest
        /// </param>
        /// 
        /// <returns>
        /// CohostsResponse
        /// </returns>
        public CohostsResponse Cohosts(string conferenceId, CohostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CohostsHeaders headers = new CohostsHeaders();
            return CohostsWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置联席主持人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CohostsRequest
        /// </param>
        /// 
        /// <returns>
        /// CohostsResponse
        /// </returns>
        public async Task<CohostsResponse> CohostsAsync(string conferenceId, CohostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CohostsHeaders headers = new CohostsHeaders();
            return await CohostsWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建专属短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomShortLinkRequest
        /// </param>
        /// <param name="headers">
        /// CreateCustomShortLinkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomShortLinkResponse
        /// </returns>
        public CreateCustomShortLinkResponse CreateCustomShortLinkWithOptions(CreateCustomShortLinkRequest request, CreateCustomShortLinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtensionAppBizData))
            {
                body["extensionAppBizData"] = request.ExtensionAppBizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseExtensionApp))
            {
                body["useExtensionApp"] = request.UseExtensionApp;
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
                Action = "CreateCustomShortLink",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/customShortLinks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomShortLinkResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建专属短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomShortLinkRequest
        /// </param>
        /// <param name="headers">
        /// CreateCustomShortLinkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomShortLinkResponse
        /// </returns>
        public async Task<CreateCustomShortLinkResponse> CreateCustomShortLinkWithOptionsAsync(CreateCustomShortLinkRequest request, CreateCustomShortLinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtensionAppBizData))
            {
                body["extensionAppBizData"] = request.ExtensionAppBizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseExtensionApp))
            {
                body["useExtensionApp"] = request.UseExtensionApp;
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
                Action = "CreateCustomShortLink",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/customShortLinks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomShortLinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建专属短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomShortLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomShortLinkResponse
        /// </returns>
        public CreateCustomShortLinkResponse CreateCustomShortLink(CreateCustomShortLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomShortLinkHeaders headers = new CreateCustomShortLinkHeaders();
            return CreateCustomShortLinkWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建专属短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomShortLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomShortLinkResponse
        /// </returns>
        public async Task<CreateCustomShortLinkResponse> CreateCustomShortLinkAsync(CreateCustomShortLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomShortLinkHeaders headers = new CreateCustomShortLinkHeaders();
            return await CreateCustomShortLinkWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduleConferenceRequest
        /// </param>
        /// <param name="headers">
        /// CreateScheduleConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleConferenceResponse
        /// </returns>
        public CreateScheduleConferenceResponse CreateScheduleConferenceWithOptions(CreateScheduleConferenceRequest request, CreateScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfSettingModel))
            {
                body["scheduleConfSettingModel"] = request.ScheduleConfSettingModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "CreateScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduleConferenceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduleConferenceRequest
        /// </param>
        /// <param name="headers">
        /// CreateScheduleConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleConferenceResponse
        /// </returns>
        public async Task<CreateScheduleConferenceResponse> CreateScheduleConferenceWithOptionsAsync(CreateScheduleConferenceRequest request, CreateScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfSettingModel))
            {
                body["scheduleConfSettingModel"] = request.ScheduleConfSettingModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "CreateScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduleConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduleConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleConferenceResponse
        /// </returns>
        public CreateScheduleConferenceResponse CreateScheduleConference(CreateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScheduleConferenceHeaders headers = new CreateScheduleConferenceHeaders();
            return CreateScheduleConferenceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduleConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleConferenceResponse
        /// </returns>
        public async Task<CreateScheduleConferenceResponse> CreateScheduleConferenceAsync(CreateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScheduleConferenceHeaders headers = new CreateScheduleConferenceHeaders();
            return await CreateScheduleConferenceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoConferenceRequest
        /// </param>
        /// <param name="headers">
        /// CreateVideoConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoConferenceResponse
        /// </returns>
        public CreateVideoConferenceResponse CreateVideoConferenceWithOptions(CreateVideoConferenceRequest request, CreateVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfTitle))
            {
                body["confTitle"] = request.ConfTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteCaller))
            {
                body["inviteCaller"] = request.InviteCaller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteUserIds))
            {
                body["inviteUserIds"] = request.InviteUserIds;
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
                Action = "CreateVideoConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoConferenceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoConferenceRequest
        /// </param>
        /// <param name="headers">
        /// CreateVideoConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoConferenceResponse
        /// </returns>
        public async Task<CreateVideoConferenceResponse> CreateVideoConferenceWithOptionsAsync(CreateVideoConferenceRequest request, CreateVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfTitle))
            {
                body["confTitle"] = request.ConfTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteCaller))
            {
                body["inviteCaller"] = request.InviteCaller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteUserIds))
            {
                body["inviteUserIds"] = request.InviteUserIds;
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
                Action = "CreateVideoConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoConferenceResponse
        /// </returns>
        public CreateVideoConferenceResponse CreateVideoConference(CreateVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVideoConferenceHeaders headers = new CreateVideoConferenceHeaders();
            return CreateVideoConferenceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoConferenceResponse
        /// </returns>
        public async Task<CreateVideoConferenceResponse> CreateVideoConferenceAsync(CreateVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVideoConferenceHeaders headers = new CreateVideoConferenceHeaders();
            return await CreateVideoConferenceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置全员看他</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FocusRequest
        /// </param>
        /// <param name="headers">
        /// FocusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FocusResponse
        /// </returns>
        public FocusResponse FocusWithOptions(string conferenceId, FocusRequest request, FocusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
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
                Action = "Focus",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/focus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FocusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置全员看他</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FocusRequest
        /// </param>
        /// <param name="headers">
        /// FocusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FocusResponse
        /// </returns>
        public async Task<FocusResponse> FocusWithOptionsAsync(string conferenceId, FocusRequest request, FocusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
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
                Action = "Focus",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/focus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FocusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置全员看他</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FocusRequest
        /// </param>
        /// 
        /// <returns>
        /// FocusResponse
        /// </returns>
        public FocusResponse Focus(string conferenceId, FocusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FocusHeaders headers = new FocusHeaders();
            return FocusWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置全员看他</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FocusRequest
        /// </param>
        /// 
        /// <returns>
        /// FocusResponse
        /// </returns>
        public async Task<FocusResponse> FocusAsync(string conferenceId, FocusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FocusHeaders headers = new FocusHeaders();
            return await FocusWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成会议闪记文档的下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateFlashMinutesDocumentUrlRequest
        /// </param>
        /// <param name="headers">
        /// GenerateFlashMinutesDocumentUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateFlashMinutesDocumentUrlResponse
        /// </returns>
        public GenerateFlashMinutesDocumentUrlResponse GenerateFlashMinutesDocumentUrlWithOptions(string conferenceId, GenerateFlashMinutesDocumentUrlRequest request, GenerateFlashMinutesDocumentUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["expireTime"] = request.ExpireTime;
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
                Action = "GenerateFlashMinutesDocumentUrl",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/flashMinutes/document/generate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateFlashMinutesDocumentUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成会议闪记文档的下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateFlashMinutesDocumentUrlRequest
        /// </param>
        /// <param name="headers">
        /// GenerateFlashMinutesDocumentUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateFlashMinutesDocumentUrlResponse
        /// </returns>
        public async Task<GenerateFlashMinutesDocumentUrlResponse> GenerateFlashMinutesDocumentUrlWithOptionsAsync(string conferenceId, GenerateFlashMinutesDocumentUrlRequest request, GenerateFlashMinutesDocumentUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["expireTime"] = request.ExpireTime;
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
                Action = "GenerateFlashMinutesDocumentUrl",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/flashMinutes/document/generate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateFlashMinutesDocumentUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成会议闪记文档的下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateFlashMinutesDocumentUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateFlashMinutesDocumentUrlResponse
        /// </returns>
        public GenerateFlashMinutesDocumentUrlResponse GenerateFlashMinutesDocumentUrl(string conferenceId, GenerateFlashMinutesDocumentUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateFlashMinutesDocumentUrlHeaders headers = new GenerateFlashMinutesDocumentUrlHeaders();
            return GenerateFlashMinutesDocumentUrlWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成会议闪记文档的下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateFlashMinutesDocumentUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateFlashMinutesDocumentUrlResponse
        /// </returns>
        public async Task<GenerateFlashMinutesDocumentUrlResponse> GenerateFlashMinutesDocumentUrlAsync(string conferenceId, GenerateFlashMinutesDocumentUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateFlashMinutesDocumentUrlHeaders headers = new GenerateFlashMinutesDocumentUrlHeaders();
            return await GenerateFlashMinutesDocumentUrlWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId获取指定音视频会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfDataByConferenceIdRequest
        /// </param>
        /// <param name="headers">
        /// GetConfDataByConferenceIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfDataByConferenceIdResponse
        /// </returns>
        public GetConfDataByConferenceIdResponse GetConfDataByConferenceIdWithOptions(string conferenceId, GetConfDataByConferenceIdRequest request, GetConfDataByConferenceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealData))
            {
                query["realData"] = request.RealData;
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
                Action = "GetConfDataByConferenceId",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfDataByConferenceIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId获取指定音视频会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfDataByConferenceIdRequest
        /// </param>
        /// <param name="headers">
        /// GetConfDataByConferenceIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfDataByConferenceIdResponse
        /// </returns>
        public async Task<GetConfDataByConferenceIdResponse> GetConfDataByConferenceIdWithOptionsAsync(string conferenceId, GetConfDataByConferenceIdRequest request, GetConfDataByConferenceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealData))
            {
                query["realData"] = request.RealData;
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
                Action = "GetConfDataByConferenceId",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfDataByConferenceIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId获取指定音视频会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfDataByConferenceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfDataByConferenceIdResponse
        /// </returns>
        public GetConfDataByConferenceIdResponse GetConfDataByConferenceId(string conferenceId, GetConfDataByConferenceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfDataByConferenceIdHeaders headers = new GetConfDataByConferenceIdHeaders();
            return GetConfDataByConferenceIdWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId获取指定音视频会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfDataByConferenceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfDataByConferenceIdResponse
        /// </returns>
        public async Task<GetConfDataByConferenceIdResponse> GetConfDataByConferenceIdAsync(string conferenceId, GetConfDataByConferenceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfDataByConferenceIdHeaders headers = new GetConfDataByConferenceIdHeaders();
            return await GetConfDataByConferenceIdWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId获取指定音视频会议成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfDetailDataRequest
        /// </param>
        /// <param name="headers">
        /// GetConfDetailDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfDetailDataResponse
        /// </returns>
        public GetConfDetailDataResponse GetConfDetailDataWithOptions(string conferenceId, GetConfDetailDataRequest request, GetConfDetailDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nick))
            {
                query["nick"] = request.Nick;
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
                Action = "GetConfDetailData",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfDetailDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId获取指定音视频会议成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfDetailDataRequest
        /// </param>
        /// <param name="headers">
        /// GetConfDetailDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfDetailDataResponse
        /// </returns>
        public async Task<GetConfDetailDataResponse> GetConfDetailDataWithOptionsAsync(string conferenceId, GetConfDetailDataRequest request, GetConfDetailDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nick))
            {
                query["nick"] = request.Nick;
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
                Action = "GetConfDetailData",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfDetailDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId获取指定音视频会议成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfDetailDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfDetailDataResponse
        /// </returns>
        public GetConfDetailDataResponse GetConfDetailData(string conferenceId, GetConfDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfDetailDataHeaders headers = new GetConfDetailDataHeaders();
            return GetConfDetailDataWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId获取指定音视频会议成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfDetailDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfDetailDataResponse
        /// </returns>
        public async Task<GetConfDetailDataResponse> GetConfDetailDataAsync(string conferenceId, GetConfDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfDetailDataHeaders headers = new GetConfDetailDataHeaders();
            return await GetConfDetailDataWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音视频会议列表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryConfDataListRequest
        /// </param>
        /// <param name="headers">
        /// GetHistoryConfDataListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryConfDataListResponse
        /// </returns>
        public GetHistoryConfDataListResponse GetHistoryConfDataListWithOptions(GetHistoryConfDataListRequest request, GetHistoryConfDataListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorNike))
            {
                query["creatorNike"] = request.CreatorNike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeType))
            {
                query["freeType"] = request.FreeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealData))
            {
                query["realData"] = request.RealData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
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
                Action = "GetHistoryConfDataList",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/histories/dataLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryConfDataListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音视频会议列表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryConfDataListRequest
        /// </param>
        /// <param name="headers">
        /// GetHistoryConfDataListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryConfDataListResponse
        /// </returns>
        public async Task<GetHistoryConfDataListResponse> GetHistoryConfDataListWithOptionsAsync(GetHistoryConfDataListRequest request, GetHistoryConfDataListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorNike))
            {
                query["creatorNike"] = request.CreatorNike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeType))
            {
                query["freeType"] = request.FreeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealData))
            {
                query["realData"] = request.RealData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
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
                Action = "GetHistoryConfDataList",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/histories/dataLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryConfDataListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音视频会议列表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryConfDataListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryConfDataListResponse
        /// </returns>
        public GetHistoryConfDataListResponse GetHistoryConfDataList(GetHistoryConfDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHistoryConfDataListHeaders headers = new GetHistoryConfDataListHeaders();
            return GetHistoryConfDataListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音视频会议列表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryConfDataListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryConfDataListResponse
        /// </returns>
        public async Task<GetHistoryConfDataListResponse> GetHistoryConfDataListAsync(GetHistoryConfDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHistoryConfDataListHeaders headers = new GetHistoryConfDataListHeaders();
            return await GetHistoryConfDataListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId和unionId获取最新会议质量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserLastMetricRequest
        /// </param>
        /// <param name="headers">
        /// GetUserLastMetricHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserLastMetricResponse
        /// </returns>
        public GetUserLastMetricResponse GetUserLastMetricWithOptions(string conferenceId, GetUserLastMetricRequest request, GetUserLastMetricHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionIdList))
            {
                body["unionIdList"] = request.UnionIdList;
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
                Action = "GetUserLastMetric",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/lastMetricDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserLastMetricResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId和unionId获取最新会议质量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserLastMetricRequest
        /// </param>
        /// <param name="headers">
        /// GetUserLastMetricHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserLastMetricResponse
        /// </returns>
        public async Task<GetUserLastMetricResponse> GetUserLastMetricWithOptionsAsync(string conferenceId, GetUserLastMetricRequest request, GetUserLastMetricHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionIdList))
            {
                body["unionIdList"] = request.UnionIdList;
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
                Action = "GetUserLastMetric",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/lastMetricDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserLastMetricResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId和unionId获取最新会议质量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserLastMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserLastMetricResponse
        /// </returns>
        public GetUserLastMetricResponse GetUserLastMetric(string conferenceId, GetUserLastMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserLastMetricHeaders headers = new GetUserLastMetricHeaders();
            return GetUserLastMetricWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId和unionId获取最新会议质量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserLastMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserLastMetricResponse
        /// </returns>
        public async Task<GetUserLastMetricResponse> GetUserLastMetricAsync(string conferenceId, GetUserLastMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserLastMetricHeaders headers = new GetUserLastMetricHeaders();
            return await GetUserLastMetricWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId和unionId获取指定音视频会议人员的会议质量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserMetricDataRequest
        /// </param>
        /// <param name="headers">
        /// GetUserMetricDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserMetricDataResponse
        /// </returns>
        public GetUserMetricDataResponse GetUserMetricDataWithOptions(string conferenceId, GetUserMetricDataRequest request, GetUserMetricDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                Action = "GetUserMetricData",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/metricDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserMetricDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId和unionId获取指定音视频会议人员的会议质量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserMetricDataRequest
        /// </param>
        /// <param name="headers">
        /// GetUserMetricDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserMetricDataResponse
        /// </returns>
        public async Task<GetUserMetricDataResponse> GetUserMetricDataWithOptionsAsync(string conferenceId, GetUserMetricDataRequest request, GetUserMetricDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                Action = "GetUserMetricData",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/metricDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserMetricDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId和unionId获取指定音视频会议人员的会议质量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserMetricDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserMetricDataResponse
        /// </returns>
        public GetUserMetricDataResponse GetUserMetricData(string conferenceId, GetUserMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserMetricDataHeaders headers = new GetUserMetricDataHeaders();
            return GetUserMetricDataWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过conferenceId和unionId获取指定音视频会议人员的会议质量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserMetricDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserMetricDataResponse
        /// </returns>
        public async Task<GetUserMetricDataResponse> GetUserMetricDataAsync(string conferenceId, GetUserMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserMetricDataHeaders headers = new GetUserMetricDataHeaders();
            return await GetUserMetricDataWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>邀请其他人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InviteUsersRequest
        /// </param>
        /// <param name="headers">
        /// InviteUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InviteUsersResponse
        /// </returns>
        public InviteUsersResponse InviteUsersWithOptions(string conferenceId, InviteUsersRequest request, InviteUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteeList))
            {
                body["inviteeList"] = request.InviteeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneInviteeList))
            {
                body["phoneInviteeList"] = request.PhoneInviteeList;
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
                Action = "InviteUsers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/users/invite",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteUsersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>邀请其他人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InviteUsersRequest
        /// </param>
        /// <param name="headers">
        /// InviteUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InviteUsersResponse
        /// </returns>
        public async Task<InviteUsersResponse> InviteUsersWithOptionsAsync(string conferenceId, InviteUsersRequest request, InviteUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteeList))
            {
                body["inviteeList"] = request.InviteeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneInviteeList))
            {
                body["phoneInviteeList"] = request.PhoneInviteeList;
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
                Action = "InviteUsers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/users/invite",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>邀请其他人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InviteUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// InviteUsersResponse
        /// </returns>
        public InviteUsersResponse InviteUsers(string conferenceId, InviteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InviteUsersHeaders headers = new InviteUsersHeaders();
            return InviteUsersWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>邀请其他人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InviteUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// InviteUsersResponse
        /// </returns>
        public async Task<InviteUsersResponse> InviteUsersAsync(string conferenceId, InviteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InviteUsersHeaders headers = new InviteUsersHeaders();
            return await InviteUsersWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议踢出成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickMembersRequest
        /// </param>
        /// <param name="headers">
        /// KickMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KickMembersResponse
        /// </returns>
        public KickMembersResponse KickMembersWithOptions(string conferenceId, KickMembersRequest request, KickMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbiddenRejoin))
            {
                body["forbiddenRejoin"] = request.ForbiddenRejoin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
                Action = "KickMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members/kick",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<KickMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议踢出成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickMembersRequest
        /// </param>
        /// <param name="headers">
        /// KickMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KickMembersResponse
        /// </returns>
        public async Task<KickMembersResponse> KickMembersWithOptionsAsync(string conferenceId, KickMembersRequest request, KickMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbiddenRejoin))
            {
                body["forbiddenRejoin"] = request.ForbiddenRejoin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
                Action = "KickMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members/kick",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<KickMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议踢出成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// KickMembersResponse
        /// </returns>
        public KickMembersResponse KickMembers(string conferenceId, KickMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            KickMembersHeaders headers = new KickMembersHeaders();
            return KickMembersWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议踢出成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// KickMembersResponse
        /// </returns>
        public async Task<KickMembersResponse> KickMembersAsync(string conferenceId, KickMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            KickMembersHeaders headers = new KickMembersHeaders();
            return await KickMembersWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>锁定会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LockConferenceRequest
        /// </param>
        /// <param name="headers">
        /// LockConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LockConferenceResponse
        /// </returns>
        public LockConferenceResponse LockConferenceWithOptions(string conferenceId, LockConferenceRequest request, LockConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
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
                Action = "LockConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/lock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockConferenceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>锁定会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LockConferenceRequest
        /// </param>
        /// <param name="headers">
        /// LockConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LockConferenceResponse
        /// </returns>
        public async Task<LockConferenceResponse> LockConferenceWithOptionsAsync(string conferenceId, LockConferenceRequest request, LockConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
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
                Action = "LockConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/lock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>锁定会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LockConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// LockConferenceResponse
        /// </returns>
        public LockConferenceResponse LockConference(string conferenceId, LockConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LockConferenceHeaders headers = new LockConferenceHeaders();
            return LockConferenceWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>锁定会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LockConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// LockConferenceResponse
        /// </returns>
        public async Task<LockConferenceResponse> LockConferenceAsync(string conferenceId, LockConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LockConferenceHeaders headers = new LockConferenceHeaders();
            return await LockConferenceWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议全员静音或解除静音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MuteAllRequest
        /// </param>
        /// <param name="headers">
        /// MuteAllHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MuteAllResponse
        /// </returns>
        public MuteAllResponse MuteAllWithOptions(string conferenceId, MuteAllRequest request, MuteAllHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceMute))
            {
                body["forceMute"] = request.ForceMute;
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
                Action = "MuteAll",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/allMembers/mute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MuteAllResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议全员静音或解除静音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MuteAllRequest
        /// </param>
        /// <param name="headers">
        /// MuteAllHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MuteAllResponse
        /// </returns>
        public async Task<MuteAllResponse> MuteAllWithOptionsAsync(string conferenceId, MuteAllRequest request, MuteAllHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceMute))
            {
                body["forceMute"] = request.ForceMute;
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
                Action = "MuteAll",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/allMembers/mute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MuteAllResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议全员静音或解除静音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MuteAllRequest
        /// </param>
        /// 
        /// <returns>
        /// MuteAllResponse
        /// </returns>
        public MuteAllResponse MuteAll(string conferenceId, MuteAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MuteAllHeaders headers = new MuteAllHeaders();
            return MuteAllWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议全员静音或解除静音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MuteAllRequest
        /// </param>
        /// 
        /// <returns>
        /// MuteAllResponse
        /// </returns>
        public async Task<MuteAllResponse> MuteAllAsync(string conferenceId, MuteAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MuteAllHeaders headers = new MuteAllHeaders();
            return await MuteAllWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定人员静音或取消静音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MuteMembersRequest
        /// </param>
        /// <param name="headers">
        /// MuteMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MuteMembersResponse
        /// </returns>
        public MuteMembersResponse MuteMembersWithOptions(string conferenceId, MuteMembersRequest request, MuteMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
                Action = "MuteMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members/mute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MuteMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定人员静音或取消静音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MuteMembersRequest
        /// </param>
        /// <param name="headers">
        /// MuteMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MuteMembersResponse
        /// </returns>
        public async Task<MuteMembersResponse> MuteMembersWithOptionsAsync(string conferenceId, MuteMembersRequest request, MuteMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
                Action = "MuteMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members/mute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MuteMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定人员静音或取消静音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MuteMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// MuteMembersResponse
        /// </returns>
        public MuteMembersResponse MuteMembers(string conferenceId, MuteMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MuteMembersHeaders headers = new MuteMembersHeaders();
            return MuteMembersWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定人员静音或取消静音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MuteMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// MuteMembersResponse
        /// </returns>
        public async Task<MuteMembersResponse> MuteMembersAsync(string conferenceId, MuteMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MuteMembersHeaders headers = new MuteMembersHeaders();
            return await MuteMembersWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制文本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordTextRequest
        /// </param>
        /// <param name="headers">
        /// QueryCloudRecordTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordTextResponse
        /// </returns>
        public QueryCloudRecordTextResponse QueryCloudRecordTextWithOptions(string conferenceId, QueryCloudRecordTextRequest request, QueryCloudRecordTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
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
                Action = "QueryCloudRecordText",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getTexts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordTextResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制文本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordTextRequest
        /// </param>
        /// <param name="headers">
        /// QueryCloudRecordTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordTextResponse
        /// </returns>
        public async Task<QueryCloudRecordTextResponse> QueryCloudRecordTextWithOptionsAsync(string conferenceId, QueryCloudRecordTextRequest request, QueryCloudRecordTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
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
                Action = "QueryCloudRecordText",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getTexts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordTextResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制文本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordTextRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordTextResponse
        /// </returns>
        public QueryCloudRecordTextResponse QueryCloudRecordText(string conferenceId, QueryCloudRecordTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordTextHeaders headers = new QueryCloudRecordTextHeaders();
            return QueryCloudRecordTextWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制文本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordTextRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordTextResponse
        /// </returns>
        public async Task<QueryCloudRecordTextResponse> QueryCloudRecordTextAsync(string conferenceId, QueryCloudRecordTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordTextHeaders headers = new QueryCloudRecordTextHeaders();
            return await QueryCloudRecordTextWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制视频</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordVideoRequest
        /// </param>
        /// <param name="headers">
        /// QueryCloudRecordVideoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordVideoResponse
        /// </returns>
        public QueryCloudRecordVideoResponse QueryCloudRecordVideoWithOptions(string conferenceId, QueryCloudRecordVideoRequest request, QueryCloudRecordVideoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryCloudRecordVideo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getVideos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制视频</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordVideoRequest
        /// </param>
        /// <param name="headers">
        /// QueryCloudRecordVideoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordVideoResponse
        /// </returns>
        public async Task<QueryCloudRecordVideoResponse> QueryCloudRecordVideoWithOptionsAsync(string conferenceId, QueryCloudRecordVideoRequest request, QueryCloudRecordVideoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryCloudRecordVideo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getVideos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制视频</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordVideoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordVideoResponse
        /// </returns>
        public QueryCloudRecordVideoResponse QueryCloudRecordVideo(string conferenceId, QueryCloudRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoHeaders headers = new QueryCloudRecordVideoHeaders();
            return QueryCloudRecordVideoWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制视频</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordVideoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordVideoResponse
        /// </returns>
        public async Task<QueryCloudRecordVideoResponse> QueryCloudRecordVideoAsync(string conferenceId, QueryCloudRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoHeaders headers = new QueryCloudRecordVideoHeaders();
            return await QueryCloudRecordVideoWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordVideoPlayInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryCloudRecordVideoPlayInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordVideoPlayInfoResponse
        /// </returns>
        public QueryCloudRecordVideoPlayInfoResponse QueryCloudRecordVideoPlayInfoWithOptions(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request, QueryCloudRecordVideoPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
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
                Action = "QueryCloudRecordVideoPlayInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/videos/getPlayInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoPlayInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordVideoPlayInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryCloudRecordVideoPlayInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordVideoPlayInfoResponse
        /// </returns>
        public async Task<QueryCloudRecordVideoPlayInfoResponse> QueryCloudRecordVideoPlayInfoWithOptionsAsync(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request, QueryCloudRecordVideoPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
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
                Action = "QueryCloudRecordVideoPlayInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/videos/getPlayInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoPlayInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordVideoPlayInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordVideoPlayInfoResponse
        /// </returns>
        public QueryCloudRecordVideoPlayInfoResponse QueryCloudRecordVideoPlayInfo(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoPlayInfoHeaders headers = new QueryCloudRecordVideoPlayInfoHeaders();
            return QueryCloudRecordVideoPlayInfoWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCloudRecordVideoPlayInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCloudRecordVideoPlayInfoResponse
        /// </returns>
        public async Task<QueryCloudRecordVideoPlayInfoResponse> QueryCloudRecordVideoPlayInfoAsync(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoPlayInfoHeaders headers = new QueryCloudRecordVideoPlayInfoHeaders();
            return await QueryCloudRecordVideoPlayInfoWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频会议信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryConferenceInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceInfoResponse
        /// </returns>
        public QueryConferenceInfoResponse QueryConferenceInfoWithOptions(string conferenceId, QueryConferenceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryConferenceInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频会议信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryConferenceInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceInfoResponse
        /// </returns>
        public async Task<QueryConferenceInfoResponse> QueryConferenceInfoWithOptionsAsync(string conferenceId, QueryConferenceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryConferenceInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频会议信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryConferenceInfoResponse
        /// </returns>
        public QueryConferenceInfoResponse QueryConferenceInfo(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoHeaders headers = new QueryConferenceInfoHeaders();
            return QueryConferenceInfoWithOptions(conferenceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频会议信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryConferenceInfoResponse
        /// </returns>
        public async Task<QueryConferenceInfoResponse> QueryConferenceInfoAsync(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoHeaders headers = new QueryConferenceInfoHeaders();
            return await QueryConferenceInfoWithOptionsAsync(conferenceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询视频会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceInfoBatchRequest
        /// </param>
        /// <param name="headers">
        /// QueryConferenceInfoBatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceInfoBatchResponse
        /// </returns>
        public QueryConferenceInfoBatchResponse QueryConferenceInfoBatchWithOptions(QueryConferenceInfoBatchRequest request, QueryConferenceInfoBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceIdList))
            {
                body["conferenceIdList"] = request.ConferenceIdList;
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
                Action = "QueryConferenceInfoBatch",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoBatchResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询视频会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceInfoBatchRequest
        /// </param>
        /// <param name="headers">
        /// QueryConferenceInfoBatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceInfoBatchResponse
        /// </returns>
        public async Task<QueryConferenceInfoBatchResponse> QueryConferenceInfoBatchWithOptionsAsync(QueryConferenceInfoBatchRequest request, QueryConferenceInfoBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceIdList))
            {
                body["conferenceIdList"] = request.ConferenceIdList;
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
                Action = "QueryConferenceInfoBatch",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoBatchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询视频会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceInfoBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceInfoBatchResponse
        /// </returns>
        public QueryConferenceInfoBatchResponse QueryConferenceInfoBatch(QueryConferenceInfoBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoBatchHeaders headers = new QueryConferenceInfoBatchHeaders();
            return QueryConferenceInfoBatchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询视频会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceInfoBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceInfoBatchResponse
        /// </returns>
        public async Task<QueryConferenceInfoBatchResponse> QueryConferenceInfoBatchAsync(QueryConferenceInfoBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoBatchHeaders headers = new QueryConferenceInfoBatchHeaders();
            return await QueryConferenceInfoBatchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据会议号查询会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceInfoByRoomCodeRequest
        /// </param>
        /// <param name="headers">
        /// QueryConferenceInfoByRoomCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceInfoByRoomCodeResponse
        /// </returns>
        public QueryConferenceInfoByRoomCodeResponse QueryConferenceInfoByRoomCodeWithOptions(string roomCode, QueryConferenceInfoByRoomCodeRequest request, QueryConferenceInfoByRoomCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryConferenceInfoByRoomCode",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/roomCodes/" + roomCode + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoByRoomCodeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据会议号查询会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceInfoByRoomCodeRequest
        /// </param>
        /// <param name="headers">
        /// QueryConferenceInfoByRoomCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceInfoByRoomCodeResponse
        /// </returns>
        public async Task<QueryConferenceInfoByRoomCodeResponse> QueryConferenceInfoByRoomCodeWithOptionsAsync(string roomCode, QueryConferenceInfoByRoomCodeRequest request, QueryConferenceInfoByRoomCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryConferenceInfoByRoomCode",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/roomCodes/" + roomCode + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoByRoomCodeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据会议号查询会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceInfoByRoomCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceInfoByRoomCodeResponse
        /// </returns>
        public QueryConferenceInfoByRoomCodeResponse QueryConferenceInfoByRoomCode(string roomCode, QueryConferenceInfoByRoomCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoByRoomCodeHeaders headers = new QueryConferenceInfoByRoomCodeHeaders();
            return QueryConferenceInfoByRoomCodeWithOptions(roomCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据会议号查询会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceInfoByRoomCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceInfoByRoomCodeResponse
        /// </returns>
        public async Task<QueryConferenceInfoByRoomCodeResponse> QueryConferenceInfoByRoomCodeAsync(string roomCode, QueryConferenceInfoByRoomCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoByRoomCodeHeaders headers = new QueryConferenceInfoByRoomCodeHeaders();
            return await QueryConferenceInfoByRoomCodeWithOptionsAsync(roomCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频会议成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceMembersRequest
        /// </param>
        /// <param name="headers">
        /// QueryConferenceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceMembersResponse
        /// </returns>
        public QueryConferenceMembersResponse QueryConferenceMembersWithOptions(string conferenceId, QueryConferenceMembersRequest request, QueryConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryConferenceMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频会议成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceMembersRequest
        /// </param>
        /// <param name="headers">
        /// QueryConferenceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceMembersResponse
        /// </returns>
        public async Task<QueryConferenceMembersResponse> QueryConferenceMembersWithOptionsAsync(string conferenceId, QueryConferenceMembersRequest request, QueryConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryConferenceMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频会议成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceMembersResponse
        /// </returns>
        public QueryConferenceMembersResponse QueryConferenceMembers(string conferenceId, QueryConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceMembersHeaders headers = new QueryConferenceMembersHeaders();
            return QueryConferenceMembersWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频会议成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConferenceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConferenceMembersResponse
        /// </returns>
        public async Task<QueryConferenceMembersResponse> QueryConferenceMembersAsync(string conferenceId, QueryConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceMembersHeaders headers = new QueryConferenceMembersHeaders();
            return await QueryConferenceMembersWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制摘要请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFlashMinutesSummaryRequest
        /// </param>
        /// <param name="headers">
        /// QueryFlashMinutesSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFlashMinutesSummaryResponse
        /// </returns>
        public QueryFlashMinutesSummaryResponse QueryFlashMinutesSummaryWithOptions(string conferenceId, QueryFlashMinutesSummaryRequest request, QueryFlashMinutesSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecorderUnionId))
            {
                query["recorderUnionId"] = request.RecorderUnionId;
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
                Action = "QueryFlashMinutesSummary",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/flashMinutes/summaries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFlashMinutesSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制摘要请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFlashMinutesSummaryRequest
        /// </param>
        /// <param name="headers">
        /// QueryFlashMinutesSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFlashMinutesSummaryResponse
        /// </returns>
        public async Task<QueryFlashMinutesSummaryResponse> QueryFlashMinutesSummaryWithOptionsAsync(string conferenceId, QueryFlashMinutesSummaryRequest request, QueryFlashMinutesSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecorderUnionId))
            {
                query["recorderUnionId"] = request.RecorderUnionId;
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
                Action = "QueryFlashMinutesSummary",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/flashMinutes/summaries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFlashMinutesSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制摘要请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFlashMinutesSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFlashMinutesSummaryResponse
        /// </returns>
        public QueryFlashMinutesSummaryResponse QueryFlashMinutesSummary(string conferenceId, QueryFlashMinutesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFlashMinutesSummaryHeaders headers = new QueryFlashMinutesSummaryHeaders();
            return QueryFlashMinutesSummaryWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云录制摘要请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFlashMinutesSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFlashMinutesSummaryResponse
        /// </returns>
        public async Task<QueryFlashMinutesSummaryResponse> QueryFlashMinutesSummaryAsync(string conferenceId, QueryFlashMinutesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFlashMinutesSummaryHeaders headers = new QueryFlashMinutesSummaryHeaders();
            return await QueryFlashMinutesSummaryWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记的音频信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesAudioRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesAudioHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesAudioResponse
        /// </returns>
        public QueryMinutesAudioResponse QueryMinutesAudioWithOptions(string conferenceId, QueryMinutesAudioRequest request, QueryMinutesAudioHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryMinutesAudio",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/audioInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesAudioResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记的音频信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesAudioRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesAudioHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesAudioResponse
        /// </returns>
        public async Task<QueryMinutesAudioResponse> QueryMinutesAudioWithOptionsAsync(string conferenceId, QueryMinutesAudioRequest request, QueryMinutesAudioHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryMinutesAudio",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/audioInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesAudioResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记的音频信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesAudioRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesAudioResponse
        /// </returns>
        public QueryMinutesAudioResponse QueryMinutesAudio(string conferenceId, QueryMinutesAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesAudioHeaders headers = new QueryMinutesAudioHeaders();
            return QueryMinutesAudioWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记的音频信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesAudioRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesAudioResponse
        /// </returns>
        public async Task<QueryMinutesAudioResponse> QueryMinutesAudioAsync(string conferenceId, QueryMinutesAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesAudioHeaders headers = new QueryMinutesAudioHeaders();
            return await QueryMinutesAudioWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记智能纪要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesSummaryRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesSummaryResponse
        /// </returns>
        public QueryMinutesSummaryResponse QueryMinutesSummaryWithOptions(string conferenceId, QueryMinutesSummaryRequest request, QueryMinutesSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTypeList))
            {
                body["summaryTypeList"] = request.SummaryTypeList;
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
                Action = "QueryMinutesSummary",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/summaries/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记智能纪要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesSummaryRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesSummaryResponse
        /// </returns>
        public async Task<QueryMinutesSummaryResponse> QueryMinutesSummaryWithOptionsAsync(string conferenceId, QueryMinutesSummaryRequest request, QueryMinutesSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTypeList))
            {
                body["summaryTypeList"] = request.SummaryTypeList;
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
                Action = "QueryMinutesSummary",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/summaries/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记智能纪要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesSummaryResponse
        /// </returns>
        public QueryMinutesSummaryResponse QueryMinutesSummary(string conferenceId, QueryMinutesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesSummaryHeaders headers = new QueryMinutesSummaryHeaders();
            return QueryMinutesSummaryWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记智能纪要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesSummaryResponse
        /// </returns>
        public async Task<QueryMinutesSummaryResponse> QueryMinutesSummaryAsync(string conferenceId, QueryMinutesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesSummaryHeaders headers = new QueryMinutesSummaryHeaders();
            return await QueryMinutesSummaryWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记文本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTextRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTextResponse
        /// </returns>
        public QueryMinutesTextResponse QueryMinutesTextWithOptions(string conferenceId, QueryMinutesTextRequest request, QueryMinutesTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "QueryMinutesText",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/textInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesTextResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记文本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTextRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTextResponse
        /// </returns>
        public async Task<QueryMinutesTextResponse> QueryMinutesTextWithOptionsAsync(string conferenceId, QueryMinutesTextRequest request, QueryMinutesTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "QueryMinutesText",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/textInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesTextResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记文本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTextRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTextResponse
        /// </returns>
        public QueryMinutesTextResponse QueryMinutesText(string conferenceId, QueryMinutesTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesTextHeaders headers = new QueryMinutesTextHeaders();
            return QueryMinutesTextWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会议闪记文本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTextRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTextResponse
        /// </returns>
        public async Task<QueryMinutesTextResponse> QueryMinutesTextAsync(string conferenceId, QueryMinutesTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesTextHeaders headers = new QueryMinutesTextHeaders();
            return await QueryMinutesTextWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业进行中会议列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgConferenceListRequest
        /// </param>
        /// <param name="headers">
        /// QueryOrgConferenceListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgConferenceListResponse
        /// </returns>
        public QueryOrgConferenceListResponse QueryOrgConferenceListWithOptions(QueryOrgConferenceListRequest request, QueryOrgConferenceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryOrgConferenceList",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/orgConferences",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgConferenceListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业进行中会议列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgConferenceListRequest
        /// </param>
        /// <param name="headers">
        /// QueryOrgConferenceListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgConferenceListResponse
        /// </returns>
        public async Task<QueryOrgConferenceListResponse> QueryOrgConferenceListWithOptionsAsync(QueryOrgConferenceListRequest request, QueryOrgConferenceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryOrgConferenceList",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/orgConferences",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgConferenceListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业进行中会议列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgConferenceListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgConferenceListResponse
        /// </returns>
        public QueryOrgConferenceListResponse QueryOrgConferenceList(QueryOrgConferenceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgConferenceListHeaders headers = new QueryOrgConferenceListHeaders();
            return QueryOrgConferenceListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业进行中会议列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgConferenceListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgConferenceListResponse
        /// </returns>
        public async Task<QueryOrgConferenceListResponse> QueryOrgConferenceListAsync(QueryOrgConferenceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgConferenceListHeaders headers = new QueryOrgConferenceListHeaders();
            return await QueryOrgConferenceListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecordMinutesUrlRequest
        /// </param>
        /// <param name="headers">
        /// QueryRecordMinutesUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRecordMinutesUrlResponse
        /// </returns>
        public QueryRecordMinutesUrlResponse QueryRecordMinutesUrlWithOptions(string conferenceId, QueryRecordMinutesUrlRequest request, QueryRecordMinutesUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecorderUnionId))
            {
                query["recorderUnionId"] = request.RecorderUnionId;
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
                Action = "QueryRecordMinutesUrl",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/flashMinutes/recordUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordMinutesUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecordMinutesUrlRequest
        /// </param>
        /// <param name="headers">
        /// QueryRecordMinutesUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRecordMinutesUrlResponse
        /// </returns>
        public async Task<QueryRecordMinutesUrlResponse> QueryRecordMinutesUrlWithOptionsAsync(string conferenceId, QueryRecordMinutesUrlRequest request, QueryRecordMinutesUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecorderUnionId))
            {
                query["recorderUnionId"] = request.RecorderUnionId;
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
                Action = "QueryRecordMinutesUrl",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/flashMinutes/recordUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordMinutesUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecordMinutesUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRecordMinutesUrlResponse
        /// </returns>
        public QueryRecordMinutesUrlResponse QueryRecordMinutesUrl(string conferenceId, QueryRecordMinutesUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRecordMinutesUrlHeaders headers = new QueryRecordMinutesUrlHeaders();
            return QueryRecordMinutesUrlWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecordMinutesUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRecordMinutesUrlResponse
        /// </returns>
        public async Task<QueryRecordMinutesUrlResponse> QueryRecordMinutesUrlAsync(string conferenceId, QueryRecordMinutesUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRecordMinutesUrlHeaders headers = new QueryRecordMinutesUrlHeaders();
            return await QueryRecordMinutesUrlWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfSettingsRequest
        /// </param>
        /// <param name="headers">
        /// QueryScheduleConfSettingsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfSettingsResponse
        /// </returns>
        public QueryScheduleConfSettingsResponse QueryScheduleConfSettingsWithOptions(QueryScheduleConfSettingsRequest request, QueryScheduleConfSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                query["scheduleConferenceId"] = request.ScheduleConferenceId;
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
                Action = "QueryScheduleConfSettings",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConfSettingsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfSettingsRequest
        /// </param>
        /// <param name="headers">
        /// QueryScheduleConfSettingsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfSettingsResponse
        /// </returns>
        public async Task<QueryScheduleConfSettingsResponse> QueryScheduleConfSettingsWithOptionsAsync(QueryScheduleConfSettingsRequest request, QueryScheduleConfSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                query["scheduleConferenceId"] = request.ScheduleConferenceId;
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
                Action = "QueryScheduleConfSettings",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConfSettingsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfSettingsResponse
        /// </returns>
        public QueryScheduleConfSettingsResponse QueryScheduleConfSettings(QueryScheduleConfSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConfSettingsHeaders headers = new QueryScheduleConfSettingsHeaders();
            return QueryScheduleConfSettingsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfSettingsResponse
        /// </returns>
        public async Task<QueryScheduleConfSettingsResponse> QueryScheduleConfSettingsAsync(QueryScheduleConfSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConfSettingsHeaders headers = new QueryScheduleConfSettingsHeaders();
            return await QueryScheduleConfSettingsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConferenceRequest
        /// </param>
        /// <param name="headers">
        /// QueryScheduleConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConferenceResponse
        /// </returns>
        public QueryScheduleConferenceResponse QueryScheduleConferenceWithOptions(string scheduleConferenceId, QueryScheduleConferenceRequest request, QueryScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUnionId))
            {
                query["requestUnionId"] = request.RequestUnionId;
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
                Action = "QueryScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/" + scheduleConferenceId + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConferenceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConferenceRequest
        /// </param>
        /// <param name="headers">
        /// QueryScheduleConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConferenceResponse
        /// </returns>
        public async Task<QueryScheduleConferenceResponse> QueryScheduleConferenceWithOptionsAsync(string scheduleConferenceId, QueryScheduleConferenceRequest request, QueryScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUnionId))
            {
                query["requestUnionId"] = request.RequestUnionId;
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
                Action = "QueryScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/" + scheduleConferenceId + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConferenceResponse
        /// </returns>
        public QueryScheduleConferenceResponse QueryScheduleConference(string scheduleConferenceId, QueryScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConferenceHeaders headers = new QueryScheduleConferenceHeaders();
            return QueryScheduleConferenceWithOptions(scheduleConferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConferenceResponse
        /// </returns>
        public async Task<QueryScheduleConferenceResponse> QueryScheduleConferenceAsync(string scheduleConferenceId, QueryScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConferenceHeaders headers = new QueryScheduleConferenceHeaders();
            return await QueryScheduleConferenceWithOptionsAsync(scheduleConferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConferenceInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryScheduleConferenceInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConferenceInfoResponse
        /// </returns>
        public QueryScheduleConferenceInfoResponse QueryScheduleConferenceInfoWithOptions(string scheduleConferenceId, QueryScheduleConferenceInfoRequest request, QueryScheduleConferenceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryScheduleConferenceInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/scheduleConferences/" + scheduleConferenceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConferenceInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConferenceInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryScheduleConferenceInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConferenceInfoResponse
        /// </returns>
        public async Task<QueryScheduleConferenceInfoResponse> QueryScheduleConferenceInfoWithOptionsAsync(string scheduleConferenceId, QueryScheduleConferenceInfoRequest request, QueryScheduleConferenceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryScheduleConferenceInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/scheduleConferences/" + scheduleConferenceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConferenceInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConferenceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConferenceInfoResponse
        /// </returns>
        public QueryScheduleConferenceInfoResponse QueryScheduleConferenceInfo(string scheduleConferenceId, QueryScheduleConferenceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConferenceInfoHeaders headers = new QueryScheduleConferenceInfoHeaders();
            return QueryScheduleConferenceInfoWithOptions(scheduleConferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConferenceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConferenceInfoResponse
        /// </returns>
        public async Task<QueryScheduleConferenceInfoResponse> QueryScheduleConferenceInfoAsync(string scheduleConferenceId, QueryScheduleConferenceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConferenceInfoHeaders headers = new QueryScheduleConferenceInfoHeaders();
            return await QueryScheduleConferenceInfoWithOptionsAsync(scheduleConferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户进行中会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserOnGoingConferenceRequest
        /// </param>
        /// <param name="headers">
        /// QueryUserOnGoingConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserOnGoingConferenceResponse
        /// </returns>
        public QueryUserOnGoingConferenceResponse QueryUserOnGoingConferenceWithOptions(QueryUserOnGoingConferenceRequest request, QueryUserOnGoingConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryUserOnGoingConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/users/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserOnGoingConferenceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户进行中会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserOnGoingConferenceRequest
        /// </param>
        /// <param name="headers">
        /// QueryUserOnGoingConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserOnGoingConferenceResponse
        /// </returns>
        public async Task<QueryUserOnGoingConferenceResponse> QueryUserOnGoingConferenceWithOptionsAsync(QueryUserOnGoingConferenceRequest request, QueryUserOnGoingConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryUserOnGoingConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/users/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserOnGoingConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户进行中会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserOnGoingConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserOnGoingConferenceResponse
        /// </returns>
        public QueryUserOnGoingConferenceResponse QueryUserOnGoingConference(QueryUserOnGoingConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserOnGoingConferenceHeaders headers = new QueryUserOnGoingConferenceHeaders();
            return QueryUserOnGoingConferenceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户进行中会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserOnGoingConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserOnGoingConferenceResponse
        /// </returns>
        public async Task<QueryUserOnGoingConferenceResponse> QueryUserOnGoingConferenceAsync(QueryUserOnGoingConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserOnGoingConferenceHeaders headers = new QueryUserOnGoingConferenceHeaders();
            return await QueryUserOnGoingConferenceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议字幕事件订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSubtitleEventRequest
        /// </param>
        /// <param name="headers">
        /// SetSubtitleEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSubtitleEventResponse
        /// </returns>
        public SetSubtitleEventResponse SetSubtitleEventWithOptions(string conferenceId, SetSubtitleEventRequest request, SetSubtitleEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
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
                Action = "SetSubtitleEvent",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/subtitleEvents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSubtitleEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议字幕事件订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSubtitleEventRequest
        /// </param>
        /// <param name="headers">
        /// SetSubtitleEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSubtitleEventResponse
        /// </returns>
        public async Task<SetSubtitleEventResponse> SetSubtitleEventWithOptionsAsync(string conferenceId, SetSubtitleEventRequest request, SetSubtitleEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
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
                Action = "SetSubtitleEvent",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/subtitleEvents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSubtitleEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议字幕事件订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSubtitleEventRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSubtitleEventResponse
        /// </returns>
        public SetSubtitleEventResponse SetSubtitleEvent(string conferenceId, SetSubtitleEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetSubtitleEventHeaders headers = new SetSubtitleEventHeaders();
            return SetSubtitleEventWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议字幕事件订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSubtitleEventRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSubtitleEventResponse
        /// </returns>
        public async Task<SetSubtitleEventResponse> SetSubtitleEventAsync(string conferenceId, SetSubtitleEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetSubtitleEventHeaders headers = new SetSubtitleEventHeaders();
            return await SetSubtitleEventWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启云录制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudRecordRequest
        /// </param>
        /// <param name="headers">
        /// StartCloudRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCloudRecordResponse
        /// </returns>
        public StartCloudRecordResponse StartCloudRecordWithOptions(string conferenceId, StartCloudRecordRequest request, StartCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
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
                Action = "StartCloudRecord",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudRecordResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启云录制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudRecordRequest
        /// </param>
        /// <param name="headers">
        /// StartCloudRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCloudRecordResponse
        /// </returns>
        public async Task<StartCloudRecordResponse> StartCloudRecordWithOptionsAsync(string conferenceId, StartCloudRecordRequest request, StartCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
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
                Action = "StartCloudRecord",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启云录制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCloudRecordResponse
        /// </returns>
        public StartCloudRecordResponse StartCloudRecord(string conferenceId, StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudRecordHeaders headers = new StartCloudRecordHeaders();
            return StartCloudRecordWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启云录制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCloudRecordResponse
        /// </returns>
        public async Task<StartCloudRecordResponse> StartCloudRecordAsync(string conferenceId, StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudRecordHeaders headers = new StartCloudRecordHeaders();
            return await StartCloudRecordWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启会议闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartMinutesRequest
        /// </param>
        /// <param name="headers">
        /// StartMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartMinutesResponse
        /// </returns>
        public StartMinutesResponse StartMinutesWithOptions(string conferenceId, StartMinutesRequest request, StartMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordAudio))
            {
                body["recordAudio"] = request.RecordAudio;
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
                Action = "StartMinutes",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMinutesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启会议闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartMinutesRequest
        /// </param>
        /// <param name="headers">
        /// StartMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartMinutesResponse
        /// </returns>
        public async Task<StartMinutesResponse> StartMinutesWithOptionsAsync(string conferenceId, StartMinutesRequest request, StartMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordAudio))
            {
                body["recordAudio"] = request.RecordAudio;
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
                Action = "StartMinutes",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMinutesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启会议闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// StartMinutesResponse
        /// </returns>
        public StartMinutesResponse StartMinutes(string conferenceId, StartMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartMinutesHeaders headers = new StartMinutesHeaders();
            return StartMinutesWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启会议闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// StartMinutesResponse
        /// </returns>
        public async Task<StartMinutesResponse> StartMinutesAsync(string conferenceId, StartMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartMinutesHeaders headers = new StartMinutesHeaders();
            return await StartMinutesWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议开始直播推流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartStreamOutRequest
        /// </param>
        /// <param name="headers">
        /// StartStreamOutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartStreamOutResponse
        /// </returns>
        public StartStreamOutResponse StartStreamOutWithOptions(string conferenceId, StartStreamOutRequest request, StartStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedHostJoin))
            {
                body["needHostJoin"] = request.NeedHostJoin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamName))
            {
                body["streamName"] = request.StreamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamUrlList))
            {
                body["streamUrlList"] = request.StreamUrlList;
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
                Action = "StartStreamOut",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartStreamOutResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议开始直播推流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartStreamOutRequest
        /// </param>
        /// <param name="headers">
        /// StartStreamOutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartStreamOutResponse
        /// </returns>
        public async Task<StartStreamOutResponse> StartStreamOutWithOptionsAsync(string conferenceId, StartStreamOutRequest request, StartStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedHostJoin))
            {
                body["needHostJoin"] = request.NeedHostJoin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamName))
            {
                body["streamName"] = request.StreamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamUrlList))
            {
                body["streamUrlList"] = request.StreamUrlList;
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
                Action = "StartStreamOut",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartStreamOutResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议开始直播推流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartStreamOutRequest
        /// </param>
        /// 
        /// <returns>
        /// StartStreamOutResponse
        /// </returns>
        public StartStreamOutResponse StartStreamOut(string conferenceId, StartStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartStreamOutHeaders headers = new StartStreamOutHeaders();
            return StartStreamOutWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议开始直播推流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartStreamOutRequest
        /// </param>
        /// 
        /// <returns>
        /// StartStreamOutResponse
        /// </returns>
        public async Task<StartStreamOutResponse> StartStreamOutAsync(string conferenceId, StartStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartStreamOutHeaders headers = new StartStreamOutHeaders();
            return await StartStreamOutWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭云录制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudRecordRequest
        /// </param>
        /// <param name="headers">
        /// StopCloudRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCloudRecordResponse
        /// </returns>
        public StopCloudRecordResponse StopCloudRecordWithOptions(string conferenceId, StopCloudRecordRequest request, StopCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StopCloudRecord",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudRecordResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭云录制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudRecordRequest
        /// </param>
        /// <param name="headers">
        /// StopCloudRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCloudRecordResponse
        /// </returns>
        public async Task<StopCloudRecordResponse> StopCloudRecordWithOptionsAsync(string conferenceId, StopCloudRecordRequest request, StopCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StopCloudRecord",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭云录制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCloudRecordResponse
        /// </returns>
        public StopCloudRecordResponse StopCloudRecord(string conferenceId, StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudRecordHeaders headers = new StopCloudRecordHeaders();
            return StopCloudRecordWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭云录制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCloudRecordResponse
        /// </returns>
        public async Task<StopCloudRecordResponse> StopCloudRecordAsync(string conferenceId, StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudRecordHeaders headers = new StopCloudRecordHeaders();
            return await StopCloudRecordWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停会议闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopMinutesRequest
        /// </param>
        /// <param name="headers">
        /// StopMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopMinutesResponse
        /// </returns>
        public StopMinutesResponse StopMinutesWithOptions(string conferenceId, StopMinutesRequest request, StopMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StopMinutes",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMinutesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停会议闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopMinutesRequest
        /// </param>
        /// <param name="headers">
        /// StopMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopMinutesResponse
        /// </returns>
        public async Task<StopMinutesResponse> StopMinutesWithOptionsAsync(string conferenceId, StopMinutesRequest request, StopMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StopMinutes",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMinutesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停会议闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// StopMinutesResponse
        /// </returns>
        public StopMinutesResponse StopMinutes(string conferenceId, StopMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopMinutesHeaders headers = new StopMinutesHeaders();
            return StopMinutesWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停会议闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// StopMinutesResponse
        /// </returns>
        public async Task<StopMinutesResponse> StopMinutesAsync(string conferenceId, StopMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopMinutesHeaders headers = new StopMinutesHeaders();
            return await StopMinutesWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议停止直播推流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopStreamOutRequest
        /// </param>
        /// <param name="headers">
        /// StopStreamOutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopStreamOutResponse
        /// </returns>
        public StopStreamOutResponse StopStreamOutWithOptions(string conferenceId, StopStreamOutRequest request, StopStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopAllStream))
            {
                body["stopAllStream"] = request.StopAllStream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamId))
            {
                body["streamId"] = request.StreamId;
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
                Action = "StopStreamOut",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopStreamOutResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议停止直播推流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopStreamOutRequest
        /// </param>
        /// <param name="headers">
        /// StopStreamOutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopStreamOutResponse
        /// </returns>
        public async Task<StopStreamOutResponse> StopStreamOutWithOptionsAsync(string conferenceId, StopStreamOutRequest request, StopStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopAllStream))
            {
                body["stopAllStream"] = request.StopAllStream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamId))
            {
                body["streamId"] = request.StreamId;
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
                Action = "StopStreamOut",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopStreamOutResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议停止直播推流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopStreamOutRequest
        /// </param>
        /// 
        /// <returns>
        /// StopStreamOutResponse
        /// </returns>
        public StopStreamOutResponse StopStreamOut(string conferenceId, StopStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopStreamOutHeaders headers = new StopStreamOutHeaders();
            return StopStreamOutWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会议停止直播推流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopStreamOutRequest
        /// </param>
        /// 
        /// <returns>
        /// StopStreamOutResponse
        /// </returns>
        public async Task<StopStreamOutResponse> StopStreamOutAsync(string conferenceId, StopStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopStreamOutHeaders headers = new StopStreamOutHeaders();
            return await StopStreamOutWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新预约会议设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleConfSettingsRequest
        /// </param>
        /// <param name="headers">
        /// UpdateScheduleConfSettingsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleConfSettingsResponse
        /// </returns>
        public UpdateScheduleConfSettingsResponse UpdateScheduleConfSettingsWithOptions(UpdateScheduleConfSettingsRequest request, UpdateScheduleConfSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfSettingModel))
            {
                body["scheduleConfSettingModel"] = request.ScheduleConfSettingModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
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
                Action = "UpdateScheduleConfSettings",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/settings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleConfSettingsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新预约会议设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleConfSettingsRequest
        /// </param>
        /// <param name="headers">
        /// UpdateScheduleConfSettingsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleConfSettingsResponse
        /// </returns>
        public async Task<UpdateScheduleConfSettingsResponse> UpdateScheduleConfSettingsWithOptionsAsync(UpdateScheduleConfSettingsRequest request, UpdateScheduleConfSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfSettingModel))
            {
                body["scheduleConfSettingModel"] = request.ScheduleConfSettingModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
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
                Action = "UpdateScheduleConfSettings",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/settings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleConfSettingsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新预约会议设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleConfSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleConfSettingsResponse
        /// </returns>
        public UpdateScheduleConfSettingsResponse UpdateScheduleConfSettings(UpdateScheduleConfSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduleConfSettingsHeaders headers = new UpdateScheduleConfSettingsHeaders();
            return UpdateScheduleConfSettingsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新预约会议设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleConfSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleConfSettingsResponse
        /// </returns>
        public async Task<UpdateScheduleConfSettingsResponse> UpdateScheduleConfSettingsAsync(UpdateScheduleConfSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduleConfSettingsHeaders headers = new UpdateScheduleConfSettingsHeaders();
            return await UpdateScheduleConfSettingsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleConferenceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateScheduleConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleConferenceResponse
        /// </returns>
        public UpdateScheduleConferenceResponse UpdateScheduleConferenceWithOptions(UpdateScheduleConferenceRequest request, UpdateScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "UpdateScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleConferenceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleConferenceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateScheduleConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleConferenceResponse
        /// </returns>
        public async Task<UpdateScheduleConferenceResponse> UpdateScheduleConferenceWithOptionsAsync(UpdateScheduleConferenceRequest request, UpdateScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "UpdateScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleConferenceResponse
        /// </returns>
        public UpdateScheduleConferenceResponse UpdateScheduleConference(UpdateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduleConferenceHeaders headers = new UpdateScheduleConferenceHeaders();
            return UpdateScheduleConferenceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新预约会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleConferenceResponse
        /// </returns>
        public async Task<UpdateScheduleConferenceResponse> UpdateScheduleConferenceAsync(UpdateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduleConferenceHeaders headers = new UpdateScheduleConferenceHeaders();
            return await UpdateScheduleConferenceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议额外信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// UpdateVideoConferenceExtInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoConferenceExtInfoResponse
        /// </returns>
        public UpdateVideoConferenceExtInfoResponse UpdateVideoConferenceExtInfoWithOptions(string conferenceId, UpdateVideoConferenceExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateVideoConferenceExtInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/extInfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoConferenceExtInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议额外信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// UpdateVideoConferenceExtInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoConferenceExtInfoResponse
        /// </returns>
        public async Task<UpdateVideoConferenceExtInfoResponse> UpdateVideoConferenceExtInfoWithOptionsAsync(string conferenceId, UpdateVideoConferenceExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateVideoConferenceExtInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/extInfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoConferenceExtInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议额外信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// UpdateVideoConferenceExtInfoResponse
        /// </returns>
        public UpdateVideoConferenceExtInfoResponse UpdateVideoConferenceExtInfo(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVideoConferenceExtInfoHeaders headers = new UpdateVideoConferenceExtInfoHeaders();
            return UpdateVideoConferenceExtInfoWithOptions(conferenceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会议额外信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// UpdateVideoConferenceExtInfoResponse
        /// </returns>
        public async Task<UpdateVideoConferenceExtInfoResponse> UpdateVideoConferenceExtInfoAsync(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVideoConferenceExtInfoHeaders headers = new UpdateVideoConferenceExtInfoHeaders();
            return await UpdateVideoConferenceExtInfoWithOptionsAsync(conferenceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议中的会议属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoConferenceSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateVideoConferenceSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoConferenceSettingResponse
        /// </returns>
        public UpdateVideoConferenceSettingResponse UpdateVideoConferenceSettingWithOptions(string conferenceId, UpdateVideoConferenceSettingRequest request, UpdateVideoConferenceSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUnmuteSelf))
            {
                body["allowUnmuteSelf"] = request.AllowUnmuteSelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTransferHost))
            {
                body["autoTransferHost"] = request.AutoTransferHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbiddenShareScreen))
            {
                body["forbiddenShareScreen"] = request.ForbiddenShareScreen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockConference))
            {
                body["lockConference"] = request.LockConference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteAll))
            {
                body["muteAll"] = request.MuteAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyInternalEmployeesJoin))
            {
                body["onlyInternalEmployeesJoin"] = request.OnlyInternalEmployeesJoin;
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
                Action = "UpdateVideoConferenceSetting",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoConferenceSettingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议中的会议属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoConferenceSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateVideoConferenceSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoConferenceSettingResponse
        /// </returns>
        public async Task<UpdateVideoConferenceSettingResponse> UpdateVideoConferenceSettingWithOptionsAsync(string conferenceId, UpdateVideoConferenceSettingRequest request, UpdateVideoConferenceSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUnmuteSelf))
            {
                body["allowUnmuteSelf"] = request.AllowUnmuteSelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTransferHost))
            {
                body["autoTransferHost"] = request.AutoTransferHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbiddenShareScreen))
            {
                body["forbiddenShareScreen"] = request.ForbiddenShareScreen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockConference))
            {
                body["lockConference"] = request.LockConference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteAll))
            {
                body["muteAll"] = request.MuteAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyInternalEmployeesJoin))
            {
                body["onlyInternalEmployeesJoin"] = request.OnlyInternalEmployeesJoin;
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
                Action = "UpdateVideoConferenceSetting",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoConferenceSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议中的会议属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoConferenceSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoConferenceSettingResponse
        /// </returns>
        public UpdateVideoConferenceSettingResponse UpdateVideoConferenceSetting(string conferenceId, UpdateVideoConferenceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVideoConferenceSettingHeaders headers = new UpdateVideoConferenceSettingHeaders();
            return UpdateVideoConferenceSettingWithOptions(conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会议中的会议属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoConferenceSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoConferenceSettingResponse
        /// </returns>
        public async Task<UpdateVideoConferenceSettingResponse> UpdateVideoConferenceSettingAsync(string conferenceId, UpdateVideoConferenceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVideoConferenceSettingHeaders headers = new UpdateVideoConferenceSettingHeaders();
            return await UpdateVideoConferenceSettingWithOptionsAsync(conferenceId, request, headers, runtime);
        }

    }
}
