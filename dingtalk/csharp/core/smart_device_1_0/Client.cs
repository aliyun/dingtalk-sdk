// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0
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
        /// <para>添加硬件视频会议参会人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDeviceVideoConferenceMembersRequest
        /// </param>
        /// <param name="headers">
        /// AddDeviceVideoConferenceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDeviceVideoConferenceMembersResponse
        /// </returns>
        public AddDeviceVideoConferenceMembersResponse AddDeviceVideoConferenceMembersWithOptions(string deviceId, string conferenceId, AddDeviceVideoConferenceMembersRequest request, AddDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddDeviceVideoConferenceMembers",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddDeviceVideoConferenceMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加硬件视频会议参会人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDeviceVideoConferenceMembersRequest
        /// </param>
        /// <param name="headers">
        /// AddDeviceVideoConferenceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDeviceVideoConferenceMembersResponse
        /// </returns>
        public async Task<AddDeviceVideoConferenceMembersResponse> AddDeviceVideoConferenceMembersWithOptionsAsync(string deviceId, string conferenceId, AddDeviceVideoConferenceMembersRequest request, AddDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddDeviceVideoConferenceMembers",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddDeviceVideoConferenceMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加硬件视频会议参会人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDeviceVideoConferenceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDeviceVideoConferenceMembersResponse
        /// </returns>
        public AddDeviceVideoConferenceMembersResponse AddDeviceVideoConferenceMembers(string deviceId, string conferenceId, AddDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddDeviceVideoConferenceMembersHeaders headers = new AddDeviceVideoConferenceMembersHeaders();
            return AddDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加硬件视频会议参会人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDeviceVideoConferenceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDeviceVideoConferenceMembersResponse
        /// </returns>
        public async Task<AddDeviceVideoConferenceMembersResponse> AddDeviceVideoConferenceMembersAsync(string deviceId, string conferenceId, AddDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddDeviceVideoConferenceMembersHeaders headers = new AddDeviceVideoConferenceMembersHeaders();
            return await AddDeviceVideoConferenceMembersWithOptionsAsync(deviceId, conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建硬件视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceVideoConferenceRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeviceVideoConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceVideoConferenceResponse
        /// </returns>
        public CreateDeviceVideoConferenceResponse CreateDeviceVideoConferenceWithOptions(string deviceId, CreateDeviceVideoConferenceRequest request, CreateDeviceVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateDeviceVideoConference",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeviceVideoConferenceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建硬件视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceVideoConferenceRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeviceVideoConferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceVideoConferenceResponse
        /// </returns>
        public async Task<CreateDeviceVideoConferenceResponse> CreateDeviceVideoConferenceWithOptionsAsync(string deviceId, CreateDeviceVideoConferenceRequest request, CreateDeviceVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateDeviceVideoConference",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeviceVideoConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建硬件视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceVideoConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceVideoConferenceResponse
        /// </returns>
        public CreateDeviceVideoConferenceResponse CreateDeviceVideoConference(string deviceId, CreateDeviceVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceVideoConferenceHeaders headers = new CreateDeviceVideoConferenceHeaders();
            return CreateDeviceVideoConferenceWithOptions(deviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建硬件视频会议</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceVideoConferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceVideoConferenceResponse
        /// </returns>
        public async Task<CreateDeviceVideoConferenceResponse> CreateDeviceVideoConferenceAsync(string deviceId, CreateDeviceVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceVideoConferenceHeaders headers = new CreateDeviceVideoConferenceHeaders();
            return await CreateDeviceVideoConferenceWithOptionsAsync(deviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出设备数据任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExportDeviceStatisticTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateExportDeviceStatisticTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExportDeviceStatisticTaskResponse
        /// </returns>
        public CreateExportDeviceStatisticTaskResponse CreateExportDeviceStatisticTaskWithOptions(CreateExportDeviceStatisticTaskRequest request, CreateExportDeviceStatisticTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiSheetTemplateId))
            {
                body["aiSheetTemplateId"] = request.AiSheetTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorCorpId))
            {
                body["creatorCorpId"] = request.CreatorCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateExportDeviceStatisticTask",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/statistic/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExportDeviceStatisticTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出设备数据任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExportDeviceStatisticTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateExportDeviceStatisticTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExportDeviceStatisticTaskResponse
        /// </returns>
        public async Task<CreateExportDeviceStatisticTaskResponse> CreateExportDeviceStatisticTaskWithOptionsAsync(CreateExportDeviceStatisticTaskRequest request, CreateExportDeviceStatisticTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiSheetTemplateId))
            {
                body["aiSheetTemplateId"] = request.AiSheetTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorCorpId))
            {
                body["creatorCorpId"] = request.CreatorCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateExportDeviceStatisticTask",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/statistic/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExportDeviceStatisticTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出设备数据任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExportDeviceStatisticTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExportDeviceStatisticTaskResponse
        /// </returns>
        public CreateExportDeviceStatisticTaskResponse CreateExportDeviceStatisticTask(CreateExportDeviceStatisticTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateExportDeviceStatisticTaskHeaders headers = new CreateExportDeviceStatisticTaskHeaders();
            return CreateExportDeviceStatisticTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出设备数据任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExportDeviceStatisticTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExportDeviceStatisticTaskResponse
        /// </returns>
        public async Task<CreateExportDeviceStatisticTaskResponse> CreateExportDeviceStatisticTaskAsync(CreateExportDeviceStatisticTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateExportDeviceStatisticTaskHeaders headers = new CreateExportDeviceStatisticTaskHeaders();
            return await CreateExportDeviceStatisticTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于企业员工照片为终端提取人脸识别特征</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExtractFacialFeatureRequest
        /// </param>
        /// <param name="headers">
        /// ExtractFacialFeatureHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExtractFacialFeatureResponse
        /// </returns>
        public ExtractFacialFeatureResponse ExtractFacialFeatureWithOptions(ExtractFacialFeatureRequest request, ExtractFacialFeatureHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExtractFacialFeature",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/faceRecognitions/features/extract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractFacialFeatureResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于企业员工照片为终端提取人脸识别特征</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExtractFacialFeatureRequest
        /// </param>
        /// <param name="headers">
        /// ExtractFacialFeatureHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExtractFacialFeatureResponse
        /// </returns>
        public async Task<ExtractFacialFeatureResponse> ExtractFacialFeatureWithOptionsAsync(ExtractFacialFeatureRequest request, ExtractFacialFeatureHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExtractFacialFeature",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/faceRecognitions/features/extract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractFacialFeatureResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于企业员工照片为终端提取人脸识别特征</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExtractFacialFeatureRequest
        /// </param>
        /// 
        /// <returns>
        /// ExtractFacialFeatureResponse
        /// </returns>
        public ExtractFacialFeatureResponse ExtractFacialFeature(ExtractFacialFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExtractFacialFeatureHeaders headers = new ExtractFacialFeatureHeaders();
            return ExtractFacialFeatureWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于企业员工照片为终端提取人脸识别特征</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExtractFacialFeatureRequest
        /// </param>
        /// 
        /// <returns>
        /// ExtractFacialFeatureResponse
        /// </returns>
        public async Task<ExtractFacialFeatureResponse> ExtractFacialFeatureAsync(ExtractFacialFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExtractFacialFeatureHeaders headers = new ExtractFacialFeatureHeaders();
            return await ExtractFacialFeatureWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>踢出硬件视频会议参会人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickDeviceVideoConferenceMembersRequest
        /// </param>
        /// <param name="headers">
        /// KickDeviceVideoConferenceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KickDeviceVideoConferenceMembersResponse
        /// </returns>
        public KickDeviceVideoConferenceMembersResponse KickDeviceVideoConferenceMembersWithOptions(string deviceId, string conferenceId, KickDeviceVideoConferenceMembersRequest request, KickDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "KickDeviceVideoConferenceMembers",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members/batchDelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<KickDeviceVideoConferenceMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>踢出硬件视频会议参会人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickDeviceVideoConferenceMembersRequest
        /// </param>
        /// <param name="headers">
        /// KickDeviceVideoConferenceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KickDeviceVideoConferenceMembersResponse
        /// </returns>
        public async Task<KickDeviceVideoConferenceMembersResponse> KickDeviceVideoConferenceMembersWithOptionsAsync(string deviceId, string conferenceId, KickDeviceVideoConferenceMembersRequest request, KickDeviceVideoConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "KickDeviceVideoConferenceMembers",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members/batchDelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<KickDeviceVideoConferenceMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>踢出硬件视频会议参会人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickDeviceVideoConferenceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// KickDeviceVideoConferenceMembersResponse
        /// </returns>
        public KickDeviceVideoConferenceMembersResponse KickDeviceVideoConferenceMembers(string deviceId, string conferenceId, KickDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            KickDeviceVideoConferenceMembersHeaders headers = new KickDeviceVideoConferenceMembersHeaders();
            return KickDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>踢出硬件视频会议参会人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickDeviceVideoConferenceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// KickDeviceVideoConferenceMembersResponse
        /// </returns>
        public async Task<KickDeviceVideoConferenceMembersResponse> KickDeviceVideoConferenceMembersAsync(string deviceId, string conferenceId, KickDeviceVideoConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            KickDeviceVideoConferenceMembersHeaders headers = new KickDeviceVideoConferenceMembersHeaders();
            return await KickDeviceVideoConferenceMembersWithOptionsAsync(deviceId, conferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更智能考勤机设备管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MachineManagerUpdateRequest
        /// </param>
        /// <param name="headers">
        /// MachineManagerUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MachineManagerUpdateResponse
        /// </returns>
        public MachineManagerUpdateResponse MachineManagerUpdateWithOptions(MachineManagerUpdateRequest request, MachineManagerUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtmManagerRightMap))
            {
                body["atmManagerRightMap"] = request.AtmManagerRightMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeDeptIds))
            {
                body["scopeDeptIds"] = request.ScopeDeptIds;
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
                Action = "MachineManagerUpdate",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/atmachines/managers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<MachineManagerUpdateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更智能考勤机设备管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MachineManagerUpdateRequest
        /// </param>
        /// <param name="headers">
        /// MachineManagerUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MachineManagerUpdateResponse
        /// </returns>
        public async Task<MachineManagerUpdateResponse> MachineManagerUpdateWithOptionsAsync(MachineManagerUpdateRequest request, MachineManagerUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtmManagerRightMap))
            {
                body["atmManagerRightMap"] = request.AtmManagerRightMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeDeptIds))
            {
                body["scopeDeptIds"] = request.ScopeDeptIds;
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
                Action = "MachineManagerUpdate",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/atmachines/managers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<MachineManagerUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更智能考勤机设备管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MachineManagerUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// MachineManagerUpdateResponse
        /// </returns>
        public MachineManagerUpdateResponse MachineManagerUpdate(MachineManagerUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MachineManagerUpdateHeaders headers = new MachineManagerUpdateHeaders();
            return MachineManagerUpdateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更智能考勤机设备管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MachineManagerUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// MachineManagerUpdateResponse
        /// </returns>
        public async Task<MachineManagerUpdateResponse> MachineManagerUpdateAsync(MachineManagerUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MachineManagerUpdateHeaders headers = new MachineManagerUpdateHeaders();
            return await MachineManagerUpdateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更智能考勤机员工</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MachineUsersUpdateRequest
        /// </param>
        /// <param name="headers">
        /// MachineUsersUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MachineUsersUpdateResponse
        /// </returns>
        public MachineUsersUpdateResponse MachineUsersUpdateWithOptions(MachineUsersUpdateRequest request, MachineUsersUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddDeptIds))
            {
                body["addDeptIds"] = request.AddDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddUserIds))
            {
                body["addUserIds"] = request.AddUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelDeptIds))
            {
                body["delDeptIds"] = request.DelDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelUserIds))
            {
                body["delUserIds"] = request.DelUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DevIds))
            {
                body["devIds"] = request.DevIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                body["deviceIds"] = request.DeviceIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MachineUsersUpdate",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/atmachines/users",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<MachineUsersUpdateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更智能考勤机员工</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MachineUsersUpdateRequest
        /// </param>
        /// <param name="headers">
        /// MachineUsersUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MachineUsersUpdateResponse
        /// </returns>
        public async Task<MachineUsersUpdateResponse> MachineUsersUpdateWithOptionsAsync(MachineUsersUpdateRequest request, MachineUsersUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddDeptIds))
            {
                body["addDeptIds"] = request.AddDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddUserIds))
            {
                body["addUserIds"] = request.AddUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelDeptIds))
            {
                body["delDeptIds"] = request.DelDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelUserIds))
            {
                body["delUserIds"] = request.DelUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DevIds))
            {
                body["devIds"] = request.DevIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                body["deviceIds"] = request.DeviceIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MachineUsersUpdate",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/atmachines/users",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<MachineUsersUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更智能考勤机员工</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MachineUsersUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// MachineUsersUpdateResponse
        /// </returns>
        public MachineUsersUpdateResponse MachineUsersUpdate(MachineUsersUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MachineUsersUpdateHeaders headers = new MachineUsersUpdateHeaders();
            return MachineUsersUpdateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更智能考勤机员工</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MachineUsersUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// MachineUsersUpdateResponse
        /// </returns>
        public async Task<MachineUsersUpdateResponse> MachineUsersUpdateAsync(MachineUsersUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MachineUsersUpdateHeaders headers = new MachineUsersUpdateHeaders();
            return await MachineUsersUpdateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询硬件视频会议预约信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryDeviceVideoConferenceBookHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceVideoConferenceBookResponse
        /// </returns>
        public QueryDeviceVideoConferenceBookResponse QueryDeviceVideoConferenceBookWithOptions(string deviceId, string bookId, QueryDeviceVideoConferenceBookHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryDeviceVideoConferenceBook",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/books/" + bookId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceVideoConferenceBookResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询硬件视频会议预约信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryDeviceVideoConferenceBookHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceVideoConferenceBookResponse
        /// </returns>
        public async Task<QueryDeviceVideoConferenceBookResponse> QueryDeviceVideoConferenceBookWithOptionsAsync(string deviceId, string bookId, QueryDeviceVideoConferenceBookHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryDeviceVideoConferenceBook",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/devices/" + deviceId + "/books/" + bookId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceVideoConferenceBookResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询硬件视频会议预约信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryDeviceVideoConferenceBookResponse
        /// </returns>
        public QueryDeviceVideoConferenceBookResponse QueryDeviceVideoConferenceBook(string deviceId, string bookId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceVideoConferenceBookHeaders headers = new QueryDeviceVideoConferenceBookHeaders();
            return QueryDeviceVideoConferenceBookWithOptions(deviceId, bookId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询硬件视频会议预约信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryDeviceVideoConferenceBookResponse
        /// </returns>
        public async Task<QueryDeviceVideoConferenceBookResponse> QueryDeviceVideoConferenceBookAsync(string deviceId, string bookId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceVideoConferenceBookHeaders headers = new QueryDeviceVideoConferenceBookHeaders();
            return await QueryDeviceVideoConferenceBookWithOptionsAsync(deviceId, bookId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文生图开放接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TextToImageRequest
        /// </param>
        /// <param name="headers">
        /// TextToImageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TextToImageResponse
        /// </returns>
        public TextToImageResponse TextToImageWithOptions(TextToImageRequest request, TextToImageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureNum))
            {
                body["pictureNum"] = request.PictureNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureSize))
            {
                body["pictureSize"] = request.PictureSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TextToImage",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/textToImages/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextToImageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文生图开放接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TextToImageRequest
        /// </param>
        /// <param name="headers">
        /// TextToImageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TextToImageResponse
        /// </returns>
        public async Task<TextToImageResponse> TextToImageWithOptionsAsync(TextToImageRequest request, TextToImageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureNum))
            {
                body["pictureNum"] = request.PictureNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureSize))
            {
                body["pictureSize"] = request.PictureSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TextToImage",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/textToImages/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextToImageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文生图开放接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TextToImageRequest
        /// </param>
        /// 
        /// <returns>
        /// TextToImageResponse
        /// </returns>
        public TextToImageResponse TextToImage(TextToImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TextToImageHeaders headers = new TextToImageHeaders();
            return TextToImageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文生图开放接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TextToImageRequest
        /// </param>
        /// 
        /// <returns>
        /// TextToImageResponse
        /// </returns>
        public async Task<TextToImageResponse> TextToImageAsync(TextToImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TextToImageHeaders headers = new TextToImageHeaders();
            return await TextToImageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新导出设备数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExportDeviceStatisticRequest
        /// </param>
        /// <param name="headers">
        /// UpdateExportDeviceStatisticHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExportDeviceStatisticResponse
        /// </returns>
        public UpdateExportDeviceStatisticResponse UpdateExportDeviceStatisticWithOptions(UpdateExportDeviceStatisticRequest request, UpdateExportDeviceStatisticHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorCorpId))
            {
                body["creatorCorpId"] = request.CreatorCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateExportDeviceStatistic",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/statistic",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExportDeviceStatisticResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新导出设备数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExportDeviceStatisticRequest
        /// </param>
        /// <param name="headers">
        /// UpdateExportDeviceStatisticHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExportDeviceStatisticResponse
        /// </returns>
        public async Task<UpdateExportDeviceStatisticResponse> UpdateExportDeviceStatisticWithOptionsAsync(UpdateExportDeviceStatisticRequest request, UpdateExportDeviceStatisticHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorCorpId))
            {
                body["creatorCorpId"] = request.CreatorCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateExportDeviceStatistic",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/statistic",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExportDeviceStatisticResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新导出设备数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExportDeviceStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExportDeviceStatisticResponse
        /// </returns>
        public UpdateExportDeviceStatisticResponse UpdateExportDeviceStatistic(UpdateExportDeviceStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateExportDeviceStatisticHeaders headers = new UpdateExportDeviceStatisticHeaders();
            return UpdateExportDeviceStatisticWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新导出设备数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExportDeviceStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExportDeviceStatisticResponse
        /// </returns>
        public async Task<UpdateExportDeviceStatisticResponse> UpdateExportDeviceStatisticAsync(UpdateExportDeviceStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateExportDeviceStatisticHeaders headers = new UpdateExportDeviceStatisticHeaders();
            return await UpdateExportDeviceStatisticWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>音频复刻</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceCloneRequest
        /// </param>
        /// <param name="headers">
        /// VoiceCloneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VoiceCloneResponse
        /// </returns>
        public VoiceCloneResponse VoiceCloneWithOptions(VoiceCloneRequest request, VoiceCloneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                body["voiceId"] = request.VoiceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "VoiceClone",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/voices/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceCloneResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>音频复刻</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceCloneRequest
        /// </param>
        /// <param name="headers">
        /// VoiceCloneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VoiceCloneResponse
        /// </returns>
        public async Task<VoiceCloneResponse> VoiceCloneWithOptionsAsync(VoiceCloneRequest request, VoiceCloneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                body["voiceId"] = request.VoiceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "VoiceClone",
                Version = "smartDevice_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/smartDevice/voices/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceCloneResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>音频复刻</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceCloneRequest
        /// </param>
        /// 
        /// <returns>
        /// VoiceCloneResponse
        /// </returns>
        public VoiceCloneResponse VoiceClone(VoiceCloneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            VoiceCloneHeaders headers = new VoiceCloneHeaders();
            return VoiceCloneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>音频复刻</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceCloneRequest
        /// </param>
        /// 
        /// <returns>
        /// VoiceCloneResponse
        /// </returns>
        public async Task<VoiceCloneResponse> VoiceCloneAsync(VoiceCloneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            VoiceCloneHeaders headers = new VoiceCloneHeaders();
            return await VoiceCloneWithOptionsAsync(request, headers, runtime);
        }

    }
}
