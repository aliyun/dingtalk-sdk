// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkminutes_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0
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
        /// <para>批量获取闪记详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetMinutesDetailsRequest
        /// </param>
        /// <param name="headers">
        /// BatchGetMinutesDetailsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMinutesDetailsResponse
        /// </returns>
        public BatchGetMinutesDetailsResponse BatchGetMinutesDetailsWithOptions(BatchGetMinutesDetailsRequest request, BatchGetMinutesDetailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuids))
            {
                body["taskUuids"] = request.TaskUuids;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchGetMinutesDetails",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetMinutesDetailsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取闪记详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetMinutesDetailsRequest
        /// </param>
        /// <param name="headers">
        /// BatchGetMinutesDetailsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMinutesDetailsResponse
        /// </returns>
        public async Task<BatchGetMinutesDetailsResponse> BatchGetMinutesDetailsWithOptionsAsync(BatchGetMinutesDetailsRequest request, BatchGetMinutesDetailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuids))
            {
                body["taskUuids"] = request.TaskUuids;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchGetMinutesDetails",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetMinutesDetailsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取闪记详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetMinutesDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMinutesDetailsResponse
        /// </returns>
        public BatchGetMinutesDetailsResponse BatchGetMinutesDetails(BatchGetMinutesDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetMinutesDetailsHeaders headers = new BatchGetMinutesDetailsHeaders();
            return BatchGetMinutesDetailsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取闪记详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetMinutesDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMinutesDetailsResponse
        /// </returns>
        public async Task<BatchGetMinutesDetailsResponse> BatchGetMinutesDetailsAsync(BatchGetMinutesDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetMinutesDetailsHeaders headers = new BatchGetMinutesDetailsHeaders();
            return await BatchGetMinutesDetailsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从上传的媒体文件创建闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMinutesByUploadFileRequest
        /// </param>
        /// <param name="headers">
        /// CreateMinutesByUploadFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMinutesByUploadFileResponse
        /// </returns>
        public CreateMinutesByUploadFileResponse CreateMinutesByUploadFileWithOptions(CreateMinutesByUploadFileRequest request, CreateMinutesByUploadFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                body["creatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaFileUrl))
            {
                body["mediaFileUrl"] = request.MediaFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                body["mediaType"] = request.MediaType;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMinutesByUploadFile",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/createMinutesByUploadFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMinutesByUploadFileResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从上传的媒体文件创建闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMinutesByUploadFileRequest
        /// </param>
        /// <param name="headers">
        /// CreateMinutesByUploadFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMinutesByUploadFileResponse
        /// </returns>
        public async Task<CreateMinutesByUploadFileResponse> CreateMinutesByUploadFileWithOptionsAsync(CreateMinutesByUploadFileRequest request, CreateMinutesByUploadFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                body["creatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaFileUrl))
            {
                body["mediaFileUrl"] = request.MediaFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                body["mediaType"] = request.MediaType;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMinutesByUploadFile",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/createMinutesByUploadFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMinutesByUploadFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从上传的媒体文件创建闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMinutesByUploadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMinutesByUploadFileResponse
        /// </returns>
        public CreateMinutesByUploadFileResponse CreateMinutesByUploadFile(CreateMinutesByUploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMinutesByUploadFileHeaders headers = new CreateMinutesByUploadFileHeaders();
            return CreateMinutesByUploadFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从上传的媒体文件创建闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMinutesByUploadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMinutesByUploadFileResponse
        /// </returns>
        public async Task<CreateMinutesByUploadFileResponse> CreateMinutesByUploadFileAsync(CreateMinutesByUploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMinutesByUploadFileHeaders headers = new CreateMinutesByUploadFileHeaders();
            return await CreateMinutesByUploadFileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建DingTalkA1小助理分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmartDeviceAiSummaryRequest
        /// </param>
        /// <param name="headers">
        /// CreateSmartDeviceAiSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmartDeviceAiSummaryResponse
        /// </returns>
        public CreateSmartDeviceAiSummaryResponse CreateSmartDeviceAiSummaryWithOptions(CreateSmartDeviceAiSummaryRequest request, CreateSmartDeviceAiSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvContext))
            {
                body["isvContext"] = request.IsvContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenFileId))
            {
                body["openFileId"] = request.OpenFileId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateSmartDeviceAiSummary",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/smartdevice/aisummary/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmartDeviceAiSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建DingTalkA1小助理分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmartDeviceAiSummaryRequest
        /// </param>
        /// <param name="headers">
        /// CreateSmartDeviceAiSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmartDeviceAiSummaryResponse
        /// </returns>
        public async Task<CreateSmartDeviceAiSummaryResponse> CreateSmartDeviceAiSummaryWithOptionsAsync(CreateSmartDeviceAiSummaryRequest request, CreateSmartDeviceAiSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvContext))
            {
                body["isvContext"] = request.IsvContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenFileId))
            {
                body["openFileId"] = request.OpenFileId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateSmartDeviceAiSummary",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/smartdevice/aisummary/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmartDeviceAiSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建DingTalkA1小助理分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmartDeviceAiSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmartDeviceAiSummaryResponse
        /// </returns>
        public CreateSmartDeviceAiSummaryResponse CreateSmartDeviceAiSummary(CreateSmartDeviceAiSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSmartDeviceAiSummaryHeaders headers = new CreateSmartDeviceAiSummaryHeaders();
            return CreateSmartDeviceAiSummaryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建DingTalkA1小助理分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmartDeviceAiSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmartDeviceAiSummaryResponse
        /// </returns>
        public async Task<CreateSmartDeviceAiSummaryResponse> CreateSmartDeviceAiSummaryAsync(CreateSmartDeviceAiSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSmartDeviceAiSummaryHeaders headers = new CreateSmartDeviceAiSummaryHeaders();
            return await CreateSmartDeviceAiSummaryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMinutesRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMinutesResponse
        /// </returns>
        public DeleteMinutesResponse DeleteMinutesWithOptions(string taskUuid, DeleteMinutesRequest request, DeleteMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMinutesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMinutesRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMinutesResponse
        /// </returns>
        public async Task<DeleteMinutesResponse> DeleteMinutesWithOptionsAsync(string taskUuid, DeleteMinutesRequest request, DeleteMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMinutesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMinutesResponse
        /// </returns>
        public DeleteMinutesResponse DeleteMinutes(string taskUuid, DeleteMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMinutesHeaders headers = new DeleteMinutesHeaders();
            return DeleteMinutesWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMinutesResponse
        /// </returns>
        public async Task<DeleteMinutesResponse> DeleteMinutesAsync(string taskUuid, DeleteMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMinutesHeaders headers = new DeleteMinutesHeaders();
            return await DeleteMinutesWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出闪记任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportMinutesTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// ExportMinutesTaskResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportMinutesTaskResultResponse
        /// </returns>
        public ExportMinutesTaskResultResponse ExportMinutesTaskResultWithOptions(ExportMinutesTaskResultRequest request, ExportMinutesTaskResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryExportSetting))
            {
                body["summaryExportSetting"] = request.SummaryExportSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                body["taskUuid"] = request.TaskUuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExportMinutesTaskResult",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/minutesTask/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportMinutesTaskResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出闪记任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportMinutesTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// ExportMinutesTaskResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportMinutesTaskResultResponse
        /// </returns>
        public async Task<ExportMinutesTaskResultResponse> ExportMinutesTaskResultWithOptionsAsync(ExportMinutesTaskResultRequest request, ExportMinutesTaskResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryExportSetting))
            {
                body["summaryExportSetting"] = request.SummaryExportSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                body["taskUuid"] = request.TaskUuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExportMinutesTaskResult",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/minutesTask/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportMinutesTaskResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出闪记任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportMinutesTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportMinutesTaskResultResponse
        /// </returns>
        public ExportMinutesTaskResultResponse ExportMinutesTaskResult(ExportMinutesTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExportMinutesTaskResultHeaders headers = new ExportMinutesTaskResultHeaders();
            return ExportMinutesTaskResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出闪记任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportMinutesTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportMinutesTaskResultResponse
        /// </returns>
        public async Task<ExportMinutesTaskResultResponse> ExportMinutesTaskResultAsync(ExportMinutesTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExportMinutesTaskResultHeaders headers = new ExportMinutesTaskResultHeaders();
            return await ExportMinutesTaskResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GenerateSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateSummaryResponse
        /// </returns>
        public GenerateSummaryResponse GenerateSummaryWithOptions(string taskUuid, GenerateSummaryRequest request, GenerateSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiyTemplateVersion))
            {
                body["diyTemplateVersion"] = request.DiyTemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTemplateId))
            {
                body["summaryTemplateId"] = request.SummaryTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTemplateType))
            {
                body["summaryTemplateType"] = request.SummaryTemplateType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GenerateSummary",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GenerateSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateSummaryResponse
        /// </returns>
        public async Task<GenerateSummaryResponse> GenerateSummaryWithOptionsAsync(string taskUuid, GenerateSummaryRequest request, GenerateSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiyTemplateVersion))
            {
                body["diyTemplateVersion"] = request.DiyTemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTemplateId))
            {
                body["summaryTemplateId"] = request.SummaryTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTemplateType))
            {
                body["summaryTemplateType"] = request.SummaryTemplateType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GenerateSummary",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateSummaryResponse
        /// </returns>
        public GenerateSummaryResponse GenerateSummary(string taskUuid, GenerateSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateSummaryHeaders headers = new GenerateSummaryHeaders();
            return GenerateSummaryWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateSummaryResponse
        /// </returns>
        public async Task<GenerateSummaryResponse> GenerateSummaryAsync(string taskUuid, GenerateSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateSummaryHeaders headers = new GenerateSummaryHeaders();
            return await GenerateSummaryWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenQueryMinutesSummaryRequest
        /// </param>
        /// <param name="headers">
        /// OpenQueryMinutesSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenQueryMinutesSummaryResponse
        /// </returns>
        public OpenQueryMinutesSummaryResponse OpenQueryMinutesSummaryWithOptions(OpenQueryMinutesSummaryRequest request, OpenQueryMinutesSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                query["taskUuid"] = request.TaskUuid;
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
                Action = "OpenQueryMinutesSummary",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryMinutesSummary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenQueryMinutesSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenQueryMinutesSummaryRequest
        /// </param>
        /// <param name="headers">
        /// OpenQueryMinutesSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenQueryMinutesSummaryResponse
        /// </returns>
        public async Task<OpenQueryMinutesSummaryResponse> OpenQueryMinutesSummaryWithOptionsAsync(OpenQueryMinutesSummaryRequest request, OpenQueryMinutesSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                query["taskUuid"] = request.TaskUuid;
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
                Action = "OpenQueryMinutesSummary",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryMinutesSummary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenQueryMinutesSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenQueryMinutesSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenQueryMinutesSummaryResponse
        /// </returns>
        public OpenQueryMinutesSummaryResponse OpenQueryMinutesSummary(OpenQueryMinutesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenQueryMinutesSummaryHeaders headers = new OpenQueryMinutesSummaryHeaders();
            return OpenQueryMinutesSummaryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenQueryMinutesSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenQueryMinutesSummaryResponse
        /// </returns>
        public async Task<OpenQueryMinutesSummaryResponse> OpenQueryMinutesSummaryAsync(OpenQueryMinutesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenQueryMinutesSummaryHeaders headers = new OpenQueryMinutesSummaryHeaders();
            return await OpenQueryMinutesSummaryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪会、文档等来源的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBizMinutesRequest
        /// </param>
        /// <param name="headers">
        /// QueryBizMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBizMinutesResponse
        /// </returns>
        public QueryBizMinutesResponse QueryBizMinutesWithOptions(QueryBizMinutesRequest request, QueryBizMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
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
                Action = "QueryBizMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryBizMinutes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizMinutesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪会、文档等来源的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBizMinutesRequest
        /// </param>
        /// <param name="headers">
        /// QueryBizMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBizMinutesResponse
        /// </returns>
        public async Task<QueryBizMinutesResponse> QueryBizMinutesWithOptionsAsync(QueryBizMinutesRequest request, QueryBizMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
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
                Action = "QueryBizMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryBizMinutes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizMinutesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪会、文档等来源的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBizMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBizMinutesResponse
        /// </returns>
        public QueryBizMinutesResponse QueryBizMinutes(QueryBizMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBizMinutesHeaders headers = new QueryBizMinutesHeaders();
            return QueryBizMinutesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪会、文档等来源的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBizMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBizMinutesResponse
        /// </returns>
        public async Task<QueryBizMinutesResponse> QueryBizMinutesAsync(QueryBizMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBizMinutesHeaders headers = new QueryBizMinutesHeaders();
            return await QueryBizMinutesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自己创建的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateMinutesListRequest
        /// </param>
        /// <param name="headers">
        /// QueryCreateMinutesListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateMinutesListResponse
        /// </returns>
        public QueryCreateMinutesListResponse QueryCreateMinutesListWithOptions(QueryCreateMinutesListRequest request, QueryCreateMinutesListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryCreateMinutesList",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/createLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCreateMinutesListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自己创建的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateMinutesListRequest
        /// </param>
        /// <param name="headers">
        /// QueryCreateMinutesListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateMinutesListResponse
        /// </returns>
        public async Task<QueryCreateMinutesListResponse> QueryCreateMinutesListWithOptionsAsync(QueryCreateMinutesListRequest request, QueryCreateMinutesListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryCreateMinutesList",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/createLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCreateMinutesListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自己创建的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateMinutesListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateMinutesListResponse
        /// </returns>
        public QueryCreateMinutesListResponse QueryCreateMinutesList(QueryCreateMinutesListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCreateMinutesListHeaders headers = new QueryCreateMinutesListHeaders();
            return QueryCreateMinutesListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自己创建的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateMinutesListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateMinutesListResponse
        /// </returns>
        public async Task<QueryCreateMinutesListResponse> QueryCreateMinutesListAsync(QueryCreateMinutesListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCreateMinutesListHeaders headers = new QueryCreateMinutesListHeaders();
            return await QueryCreateMinutesListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesBasicInfoResponse
        /// </returns>
        public QueryMinutesBasicInfoResponse QueryMinutesBasicInfoWithOptions(QueryMinutesBasicInfoRequest request, QueryMinutesBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                query["taskUuid"] = request.TaskUuid;
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
                Action = "QueryMinutesBasicInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryMinutesBasicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesBasicInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesBasicInfoResponse
        /// </returns>
        public async Task<QueryMinutesBasicInfoResponse> QueryMinutesBasicInfoWithOptionsAsync(QueryMinutesBasicInfoRequest request, QueryMinutesBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                query["taskUuid"] = request.TaskUuid;
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
                Action = "QueryMinutesBasicInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryMinutesBasicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesBasicInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesBasicInfoResponse
        /// </returns>
        public QueryMinutesBasicInfoResponse QueryMinutesBasicInfo(QueryMinutesBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesBasicInfoHeaders headers = new QueryMinutesBasicInfoHeaders();
            return QueryMinutesBasicInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesBasicInfoResponse
        /// </returns>
        public async Task<QueryMinutesBasicInfoResponse> QueryMinutesBasicInfoAsync(QueryMinutesBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesBasicInfoHeaders headers = new QueryMinutesBasicInfoHeaders();
            return await QueryMinutesBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询听记智能章节列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesChaptersRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesChaptersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesChaptersResponse
        /// </returns>
        public QueryMinutesChaptersResponse QueryMinutesChaptersWithOptions(string taskUuid, QueryMinutesChaptersRequest request, QueryMinutesChaptersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMinutesChapters",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/chapters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesChaptersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询听记智能章节列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesChaptersRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesChaptersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesChaptersResponse
        /// </returns>
        public async Task<QueryMinutesChaptersResponse> QueryMinutesChaptersWithOptionsAsync(string taskUuid, QueryMinutesChaptersRequest request, QueryMinutesChaptersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMinutesChapters",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/chapters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesChaptersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询听记智能章节列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesChaptersRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesChaptersResponse
        /// </returns>
        public QueryMinutesChaptersResponse QueryMinutesChapters(string taskUuid, QueryMinutesChaptersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesChaptersHeaders headers = new QueryMinutesChaptersHeaders();
            return QueryMinutesChaptersWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询听记智能章节列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesChaptersRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesChaptersResponse
        /// </returns>
        public async Task<QueryMinutesChaptersResponse> QueryMinutesChaptersAsync(string taskUuid, QueryMinutesChaptersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesChaptersHeaders headers = new QueryMinutesChaptersHeaders();
            return await QueryMinutesChaptersWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记关键字</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesKeywordRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesKeywordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesKeywordResponse
        /// </returns>
        public QueryMinutesKeywordResponse QueryMinutesKeywordWithOptions(string taskUuid, QueryMinutesKeywordRequest request, QueryMinutesKeywordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMinutesKeyword",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/keywords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesKeywordResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记关键字</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesKeywordRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesKeywordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesKeywordResponse
        /// </returns>
        public async Task<QueryMinutesKeywordResponse> QueryMinutesKeywordWithOptionsAsync(string taskUuid, QueryMinutesKeywordRequest request, QueryMinutesKeywordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMinutesKeyword",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/keywords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesKeywordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记关键字</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesKeywordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesKeywordResponse
        /// </returns>
        public QueryMinutesKeywordResponse QueryMinutesKeyword(string taskUuid, QueryMinutesKeywordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesKeywordHeaders headers = new QueryMinutesKeywordHeaders();
            return QueryMinutesKeywordWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记关键字</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesKeywordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesKeywordResponse
        /// </returns>
        public async Task<QueryMinutesKeywordResponse> QueryMinutesKeywordAsync(string taskUuid, QueryMinutesKeywordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesKeywordHeaders headers = new QueryMinutesKeywordHeaders();
            return await QueryMinutesKeywordWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记媒体播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesPlayInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesPlayInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesPlayInfoResponse
        /// </returns>
        public QueryMinutesPlayInfoResponse QueryMinutesPlayInfoWithOptions(string taskUuid, QueryMinutesPlayInfoRequest request, QueryMinutesPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMinutesPlayInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/playInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesPlayInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记媒体播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesPlayInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesPlayInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesPlayInfoResponse
        /// </returns>
        public async Task<QueryMinutesPlayInfoResponse> QueryMinutesPlayInfoWithOptionsAsync(string taskUuid, QueryMinutesPlayInfoRequest request, QueryMinutesPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMinutesPlayInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/playInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesPlayInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记媒体播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesPlayInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesPlayInfoResponse
        /// </returns>
        public QueryMinutesPlayInfoResponse QueryMinutesPlayInfo(string taskUuid, QueryMinutesPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesPlayInfoHeaders headers = new QueryMinutesPlayInfoHeaders();
            return QueryMinutesPlayInfoWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记媒体播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesPlayInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesPlayInfoResponse
        /// </returns>
        public async Task<QueryMinutesPlayInfoResponse> QueryMinutesPlayInfoAsync(string taskUuid, QueryMinutesPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesPlayInfoHeaders headers = new QueryMinutesPlayInfoHeaders();
            return await QueryMinutesPlayInfoWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取与我共享闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesShareListRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesShareListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesShareListResponse
        /// </returns>
        public QueryMinutesShareListResponse QueryMinutesShareListWithOptions(QueryMinutesShareListRequest request, QueryMinutesShareListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["scene"] = request.Scene;
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
                Action = "QueryMinutesShareList",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/shareLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesShareListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取与我共享闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesShareListRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesShareListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesShareListResponse
        /// </returns>
        public async Task<QueryMinutesShareListResponse> QueryMinutesShareListWithOptionsAsync(QueryMinutesShareListRequest request, QueryMinutesShareListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["scene"] = request.Scene;
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
                Action = "QueryMinutesShareList",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/shareLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesShareListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取与我共享闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesShareListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesShareListResponse
        /// </returns>
        public QueryMinutesShareListResponse QueryMinutesShareList(QueryMinutesShareListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesShareListHeaders headers = new QueryMinutesShareListHeaders();
            return QueryMinutesShareListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取与我共享闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesShareListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesShareListResponse
        /// </returns>
        public async Task<QueryMinutesShareListResponse> QueryMinutesShareListAsync(QueryMinutesShareListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesShareListHeaders headers = new QueryMinutesShareListHeaders();
            return await QueryMinutesShareListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesStatusResponse
        /// </returns>
        public QueryMinutesStatusResponse QueryMinutesStatusWithOptions(string taskUuid, QueryMinutesStatusRequest request, QueryMinutesStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMinutesStatus",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/taskStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesStatusResponse
        /// </returns>
        public async Task<QueryMinutesStatusResponse> QueryMinutesStatusWithOptionsAsync(string taskUuid, QueryMinutesStatusRequest request, QueryMinutesStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMinutesStatus",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/taskStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesStatusResponse
        /// </returns>
        public QueryMinutesStatusResponse QueryMinutesStatus(string taskUuid, QueryMinutesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesStatusHeaders headers = new QueryMinutesStatusHeaders();
            return QueryMinutesStatusWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesStatusResponse
        /// </returns>
        public async Task<QueryMinutesStatusResponse> QueryMinutesStatusAsync(string taskUuid, QueryMinutesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesStatusHeaders headers = new QueryMinutesStatusHeaders();
            return await QueryMinutesStatusWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记转写文本内容</para>
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
        public QueryMinutesTextResponse QueryMinutesTextWithOptions(string taskUuid, QueryMinutesTextRequest request, QueryMinutesTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/textInfos",
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
        /// <para>查询闪记转写文本内容</para>
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
        public async Task<QueryMinutesTextResponse> QueryMinutesTextWithOptionsAsync(string taskUuid, QueryMinutesTextRequest request, QueryMinutesTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/textInfos",
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
        /// <para>查询闪记转写文本内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTextRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTextResponse
        /// </returns>
        public QueryMinutesTextResponse QueryMinutesText(string taskUuid, QueryMinutesTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesTextHeaders headers = new QueryMinutesTextHeaders();
            return QueryMinutesTextWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记转写文本内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTextRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTextResponse
        /// </returns>
        public async Task<QueryMinutesTextResponse> QueryMinutesTextAsync(string taskUuid, QueryMinutesTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesTextHeaders headers = new QueryMinutesTextHeaders();
            return await QueryMinutesTextWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTodoRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesTodoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTodoResponse
        /// </returns>
        public QueryMinutesTodoResponse QueryMinutesTodoWithOptions(string taskUuid, QueryMinutesTodoRequest request, QueryMinutesTodoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMinutesTodo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/todos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesTodoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTodoRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesTodoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTodoResponse
        /// </returns>
        public async Task<QueryMinutesTodoResponse> QueryMinutesTodoWithOptionsAsync(string taskUuid, QueryMinutesTodoRequest request, QueryMinutesTodoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMinutesTodo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/todos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesTodoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTodoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTodoResponse
        /// </returns>
        public QueryMinutesTodoResponse QueryMinutesTodo(string taskUuid, QueryMinutesTodoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesTodoHeaders headers = new QueryMinutesTodoHeaders();
            return QueryMinutesTodoWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTodoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTodoResponse
        /// </returns>
        public async Task<QueryMinutesTodoResponse> QueryMinutesTodoAsync(string taskUuid, QueryMinutesTodoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesTodoHeaders headers = new QueryMinutesTodoHeaders();
            return await QueryMinutesTodoWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业所有自定义纪要模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgDiyTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// QueryOrgDiyTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgDiyTemplatesResponse
        /// </returns>
        public QueryOrgDiyTemplatesResponse QueryOrgDiyTemplatesWithOptions(QueryOrgDiyTemplatesRequest request, QueryOrgDiyTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryOrgDiyTemplates",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/diyTemplates/orgDeclared",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgDiyTemplatesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业所有自定义纪要模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgDiyTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// QueryOrgDiyTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgDiyTemplatesResponse
        /// </returns>
        public async Task<QueryOrgDiyTemplatesResponse> QueryOrgDiyTemplatesWithOptionsAsync(QueryOrgDiyTemplatesRequest request, QueryOrgDiyTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryOrgDiyTemplates",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/diyTemplates/orgDeclared",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgDiyTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业所有自定义纪要模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgDiyTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgDiyTemplatesResponse
        /// </returns>
        public QueryOrgDiyTemplatesResponse QueryOrgDiyTemplates(QueryOrgDiyTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgDiyTemplatesHeaders headers = new QueryOrgDiyTemplatesHeaders();
            return QueryOrgDiyTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业所有自定义纪要模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgDiyTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgDiyTemplatesResponse
        /// </returns>
        public async Task<QueryOrgDiyTemplatesResponse> QueryOrgDiyTemplatesAsync(QueryOrgDiyTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgDiyTemplatesHeaders headers = new QueryOrgDiyTemplatesHeaders();
            return await QueryOrgDiyTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfMinutesRequest
        /// </param>
        /// <param name="headers">
        /// QueryScheduleConfMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfMinutesResponse
        /// </returns>
        public QueryScheduleConfMinutesResponse QueryScheduleConfMinutesWithOptions(string scheduleConferenceId, QueryScheduleConfMinutesRequest request, QueryScheduleConfMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["eventId"] = request.EventId;
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
                Action = "QueryScheduleConfMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/scheduleConference/" + scheduleConferenceId + "/minutes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConfMinutesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfMinutesRequest
        /// </param>
        /// <param name="headers">
        /// QueryScheduleConfMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfMinutesResponse
        /// </returns>
        public async Task<QueryScheduleConfMinutesResponse> QueryScheduleConfMinutesWithOptionsAsync(string scheduleConferenceId, QueryScheduleConfMinutesRequest request, QueryScheduleConfMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["eventId"] = request.EventId;
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
                Action = "QueryScheduleConfMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/scheduleConference/" + scheduleConferenceId + "/minutes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConfMinutesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfMinutesResponse
        /// </returns>
        public QueryScheduleConfMinutesResponse QueryScheduleConfMinutes(string scheduleConferenceId, QueryScheduleConfMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConfMinutesHeaders headers = new QueryScheduleConfMinutesHeaders();
            return QueryScheduleConfMinutesWithOptions(scheduleConferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfMinutesResponse
        /// </returns>
        public async Task<QueryScheduleConfMinutesResponse> QueryScheduleConfMinutesAsync(string scheduleConferenceId, QueryScheduleConfMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConfMinutesHeaders headers = new QueryScheduleConfMinutesHeaders();
            return await QueryScheduleConfMinutesWithOptionsAsync(scheduleConferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DingTalkA1小助理分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySmartDeviceAiSummaryRequest
        /// </param>
        /// <param name="headers">
        /// QuerySmartDeviceAiSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmartDeviceAiSummaryResponse
        /// </returns>
        public QuerySmartDeviceAiSummaryResponse QuerySmartDeviceAiSummaryWithOptions(QuerySmartDeviceAiSummaryRequest request, QuerySmartDeviceAiSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenFileId))
            {
                body["openFileId"] = request.OpenFileId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QuerySmartDeviceAiSummary",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/smartdevice/aisummary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmartDeviceAiSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DingTalkA1小助理分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySmartDeviceAiSummaryRequest
        /// </param>
        /// <param name="headers">
        /// QuerySmartDeviceAiSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmartDeviceAiSummaryResponse
        /// </returns>
        public async Task<QuerySmartDeviceAiSummaryResponse> QuerySmartDeviceAiSummaryWithOptionsAsync(QuerySmartDeviceAiSummaryRequest request, QuerySmartDeviceAiSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenFileId))
            {
                body["openFileId"] = request.OpenFileId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QuerySmartDeviceAiSummary",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/smartdevice/aisummary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmartDeviceAiSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DingTalkA1小助理分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySmartDeviceAiSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmartDeviceAiSummaryResponse
        /// </returns>
        public QuerySmartDeviceAiSummaryResponse QuerySmartDeviceAiSummary(QuerySmartDeviceAiSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySmartDeviceAiSummaryHeaders headers = new QuerySmartDeviceAiSummaryHeaders();
            return QuerySmartDeviceAiSummaryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DingTalkA1小助理分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySmartDeviceAiSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmartDeviceAiSummaryResponse
        /// </returns>
        public async Task<QuerySmartDeviceAiSummaryResponse> QuerySmartDeviceAiSummaryAsync(QuerySmartDeviceAiSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySmartDeviceAiSummaryHeaders headers = new QuerySmartDeviceAiSummaryHeaders();
            return await QuerySmartDeviceAiSummaryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板id查询摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySummaryWithTemplateRequest
        /// </param>
        /// <param name="headers">
        /// QuerySummaryWithTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySummaryWithTemplateResponse
        /// </returns>
        public QuerySummaryWithTemplateResponse QuerySummaryWithTemplateWithOptions(string taskUuid, QuerySummaryWithTemplateRequest request, QuerySummaryWithTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiyTemplateVersion))
            {
                query["diyTemplateVersion"] = request.DiyTemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTemplateId))
            {
                query["summaryTemplateId"] = request.SummaryTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTemplateType))
            {
                query["summaryTemplateType"] = request.SummaryTemplateType;
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
                Action = "QuerySummaryWithTemplate",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/summary/template",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySummaryWithTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板id查询摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySummaryWithTemplateRequest
        /// </param>
        /// <param name="headers">
        /// QuerySummaryWithTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySummaryWithTemplateResponse
        /// </returns>
        public async Task<QuerySummaryWithTemplateResponse> QuerySummaryWithTemplateWithOptionsAsync(string taskUuid, QuerySummaryWithTemplateRequest request, QuerySummaryWithTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiyTemplateVersion))
            {
                query["diyTemplateVersion"] = request.DiyTemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTemplateId))
            {
                query["summaryTemplateId"] = request.SummaryTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTemplateType))
            {
                query["summaryTemplateType"] = request.SummaryTemplateType;
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
                Action = "QuerySummaryWithTemplate",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/summary/template",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySummaryWithTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板id查询摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySummaryWithTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySummaryWithTemplateResponse
        /// </returns>
        public QuerySummaryWithTemplateResponse QuerySummaryWithTemplate(string taskUuid, QuerySummaryWithTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySummaryWithTemplateHeaders headers = new QuerySummaryWithTemplateHeaders();
            return QuerySummaryWithTemplateWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板id查询摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySummaryWithTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySummaryWithTemplateResponse
        /// </returns>
        public async Task<QuerySummaryWithTemplateResponse> QuerySummaryWithTemplateAsync(string taskUuid, QuerySummaryWithTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySummaryWithTemplateHeaders headers = new QuerySummaryWithTemplateHeaders();
            return await QuerySummaryWithTemplateWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上传视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUploadVideoPlayInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryUploadVideoPlayInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUploadVideoPlayInfoResponse
        /// </returns>
        public QueryUploadVideoPlayInfoResponse QueryUploadVideoPlayInfoWithOptions(string videoId, QueryUploadVideoPlayInfoRequest request, QueryUploadVideoPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUploadVideoPlayInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/uploadVideos/" + videoId + "/playInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUploadVideoPlayInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上传视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUploadVideoPlayInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryUploadVideoPlayInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUploadVideoPlayInfoResponse
        /// </returns>
        public async Task<QueryUploadVideoPlayInfoResponse> QueryUploadVideoPlayInfoWithOptionsAsync(string videoId, QueryUploadVideoPlayInfoRequest request, QueryUploadVideoPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUploadVideoPlayInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/uploadVideos/" + videoId + "/playInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUploadVideoPlayInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上传视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUploadVideoPlayInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUploadVideoPlayInfoResponse
        /// </returns>
        public QueryUploadVideoPlayInfoResponse QueryUploadVideoPlayInfo(string videoId, QueryUploadVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUploadVideoPlayInfoHeaders headers = new QueryUploadVideoPlayInfoHeaders();
            return QueryUploadVideoPlayInfoWithOptions(videoId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上传视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUploadVideoPlayInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUploadVideoPlayInfoResponse
        /// </returns>
        public async Task<QueryUploadVideoPlayInfoResponse> QueryUploadVideoPlayInfoAsync(string videoId, QueryUploadVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUploadVideoPlayInfoHeaders headers = new QueryUploadVideoPlayInfoHeaders();
            return await QueryUploadVideoPlayInfoWithOptionsAsync(videoId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可见的企业自定义纪要模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserAvailableDiyTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// QueryUserAvailableDiyTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserAvailableDiyTemplatesResponse
        /// </returns>
        public QueryUserAvailableDiyTemplatesResponse QueryUserAvailableDiyTemplatesWithOptions(QueryUserAvailableDiyTemplatesRequest request, QueryUserAvailableDiyTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserAvailableDiyTemplates",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/diyTemplates/userAvailable",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserAvailableDiyTemplatesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可见的企业自定义纪要模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserAvailableDiyTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// QueryUserAvailableDiyTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserAvailableDiyTemplatesResponse
        /// </returns>
        public async Task<QueryUserAvailableDiyTemplatesResponse> QueryUserAvailableDiyTemplatesWithOptionsAsync(QueryUserAvailableDiyTemplatesRequest request, QueryUserAvailableDiyTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserAvailableDiyTemplates",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/diyTemplates/userAvailable",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserAvailableDiyTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可见的企业自定义纪要模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserAvailableDiyTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserAvailableDiyTemplatesResponse
        /// </returns>
        public QueryUserAvailableDiyTemplatesResponse QueryUserAvailableDiyTemplates(QueryUserAvailableDiyTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserAvailableDiyTemplatesHeaders headers = new QueryUserAvailableDiyTemplatesHeaders();
            return QueryUserAvailableDiyTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可见的企业自定义纪要模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserAvailableDiyTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserAvailableDiyTemplatesResponse
        /// </returns>
        public async Task<QueryUserAvailableDiyTemplatesResponse> QueryUserAvailableDiyTemplatesAsync(QueryUserAvailableDiyTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserAvailableDiyTemplatesHeaders headers = new QueryUserAvailableDiyTemplatesHeaders();
            return await QueryUserAvailableDiyTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定用户对某篇听记的权限</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryUserMinutesPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserMinutesPermissionResponse
        /// </returns>
        public QueryUserMinutesPermissionResponse QueryUserMinutesPermissionWithOptions(string taskUuid, string unionId, QueryUserMinutesPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserMinutesPermission",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/permissions/" + unionId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserMinutesPermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定用户对某篇听记的权限</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryUserMinutesPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserMinutesPermissionResponse
        /// </returns>
        public async Task<QueryUserMinutesPermissionResponse> QueryUserMinutesPermissionWithOptionsAsync(string taskUuid, string unionId, QueryUserMinutesPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserMinutesPermission",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/permissions/" + unionId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserMinutesPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定用户对某篇听记的权限</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryUserMinutesPermissionResponse
        /// </returns>
        public QueryUserMinutesPermissionResponse QueryUserMinutesPermission(string taskUuid, string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserMinutesPermissionHeaders headers = new QueryUserMinutesPermissionHeaders();
            return QueryUserMinutesPermissionWithOptions(taskUuid, unionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定用户对某篇听记的权限</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryUserMinutesPermissionResponse
        /// </returns>
        public async Task<QueryUserMinutesPermissionResponse> QueryUserMinutesPermissionAsync(string taskUuid, string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserMinutesPermissionHeaders headers = new QueryUserMinutesPermissionHeaders();
            return await QueryUserMinutesPermissionWithOptionsAsync(taskUuid, unionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义听记详情页tab</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDetailPageCustomTabRequest
        /// </param>
        /// <param name="headers">
        /// SetDetailPageCustomTabHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDetailPageCustomTabResponse
        /// </returns>
        public SetDetailPageCustomTabResponse SetDetailPageCustomTabWithOptions(string taskUuid, SetDetailPageCustomTabRequest request, SetDetailPageCustomTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTabList))
            {
                body["customTabList"] = request.CustomTabList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetDetailPageCustomTab",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/customTabs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDetailPageCustomTabResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义听记详情页tab</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDetailPageCustomTabRequest
        /// </param>
        /// <param name="headers">
        /// SetDetailPageCustomTabHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDetailPageCustomTabResponse
        /// </returns>
        public async Task<SetDetailPageCustomTabResponse> SetDetailPageCustomTabWithOptionsAsync(string taskUuid, SetDetailPageCustomTabRequest request, SetDetailPageCustomTabHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTabList))
            {
                body["customTabList"] = request.CustomTabList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetDetailPageCustomTab",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/customTabs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDetailPageCustomTabResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义听记详情页tab</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDetailPageCustomTabRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDetailPageCustomTabResponse
        /// </returns>
        public SetDetailPageCustomTabResponse SetDetailPageCustomTab(string taskUuid, SetDetailPageCustomTabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDetailPageCustomTabHeaders headers = new SetDetailPageCustomTabHeaders();
            return SetDetailPageCustomTabWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义听记详情页tab</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDetailPageCustomTabRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDetailPageCustomTabResponse
        /// </returns>
        public async Task<SetDetailPageCustomTabResponse> SetDetailPageCustomTabAsync(string taskUuid, SetDetailPageCustomTabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDetailPageCustomTabHeaders headers = new SetDetailPageCustomTabHeaders();
            return await SetDetailPageCustomTabWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置应用在听记录制页的自定义Tab</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetInProgressCustomTabsRequest
        /// </param>
        /// <param name="headers">
        /// SetInProgressCustomTabsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetInProgressCustomTabsResponse
        /// </returns>
        public SetInProgressCustomTabsResponse SetInProgressCustomTabsWithOptions(SetInProgressCustomTabsRequest request, SetInProgressCustomTabsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTabList))
            {
                body["customTabList"] = request.CustomTabList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetInProgressCustomTabs",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/apps/settings/inProgressTabs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetInProgressCustomTabsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置应用在听记录制页的自定义Tab</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetInProgressCustomTabsRequest
        /// </param>
        /// <param name="headers">
        /// SetInProgressCustomTabsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetInProgressCustomTabsResponse
        /// </returns>
        public async Task<SetInProgressCustomTabsResponse> SetInProgressCustomTabsWithOptionsAsync(SetInProgressCustomTabsRequest request, SetInProgressCustomTabsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTabList))
            {
                body["customTabList"] = request.CustomTabList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetInProgressCustomTabs",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/apps/settings/inProgressTabs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetInProgressCustomTabsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置应用在听记录制页的自定义Tab</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetInProgressCustomTabsRequest
        /// </param>
        /// 
        /// <returns>
        /// SetInProgressCustomTabsResponse
        /// </returns>
        public SetInProgressCustomTabsResponse SetInProgressCustomTabs(SetInProgressCustomTabsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetInProgressCustomTabsHeaders headers = new SetInProgressCustomTabsHeaders();
            return SetInProgressCustomTabsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置应用在听记录制页的自定义Tab</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetInProgressCustomTabsRequest
        /// </param>
        /// 
        /// <returns>
        /// SetInProgressCustomTabsResponse
        /// </returns>
        public async Task<SetInProgressCustomTabsResponse> SetInProgressCustomTabsAsync(SetInProgressCustomTabsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetInProgressCustomTabsHeaders headers = new SetInProgressCustomTabsHeaders();
            return await SetInProgressCustomTabsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置AI纪要待办模块可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetMinutesTodosVisibleRequest
        /// </param>
        /// <param name="headers">
        /// SetMinutesTodosVisibleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetMinutesTodosVisibleResponse
        /// </returns>
        public SetMinutesTodosVisibleResponse SetMinutesTodosVisibleWithOptions(string taskUuid, SetMinutesTodosVisibleRequest request, SetMinutesTodosVisibleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TodosVisible))
            {
                body["todosVisible"] = request.TodosVisible;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetMinutesTodosVisible",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/todosVisible",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetMinutesTodosVisibleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置AI纪要待办模块可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetMinutesTodosVisibleRequest
        /// </param>
        /// <param name="headers">
        /// SetMinutesTodosVisibleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetMinutesTodosVisibleResponse
        /// </returns>
        public async Task<SetMinutesTodosVisibleResponse> SetMinutesTodosVisibleWithOptionsAsync(string taskUuid, SetMinutesTodosVisibleRequest request, SetMinutesTodosVisibleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TodosVisible))
            {
                body["todosVisible"] = request.TodosVisible;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetMinutesTodosVisible",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/todosVisible",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetMinutesTodosVisibleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置AI纪要待办模块可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetMinutesTodosVisibleRequest
        /// </param>
        /// 
        /// <returns>
        /// SetMinutesTodosVisibleResponse
        /// </returns>
        public SetMinutesTodosVisibleResponse SetMinutesTodosVisible(string taskUuid, SetMinutesTodosVisibleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetMinutesTodosVisibleHeaders headers = new SetMinutesTodosVisibleHeaders();
            return SetMinutesTodosVisibleWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置AI纪要待办模块可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetMinutesTodosVisibleRequest
        /// </param>
        /// 
        /// <returns>
        /// SetMinutesTodosVisibleResponse
        /// </returns>
        public async Task<SetMinutesTodosVisibleResponse> SetMinutesTodosVisibleAsync(string taskUuid, SetMinutesTodosVisibleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetMinutesTodosVisibleHeaders headers = new SetMinutesTodosVisibleHeaders();
            return await SetMinutesTodosVisibleWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记标题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMinutesTitleRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMinutesTitleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMinutesTitleResponse
        /// </returns>
        public UpdateMinutesTitleResponse UpdateMinutesTitleWithOptions(string taskUuid, UpdateMinutesTitleRequest request, UpdateMinutesTitleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
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
                Action = "UpdateMinutesTitle",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/titles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMinutesTitleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记标题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMinutesTitleRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMinutesTitleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMinutesTitleResponse
        /// </returns>
        public async Task<UpdateMinutesTitleResponse> UpdateMinutesTitleWithOptionsAsync(string taskUuid, UpdateMinutesTitleRequest request, UpdateMinutesTitleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
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
                Action = "UpdateMinutesTitle",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/titles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMinutesTitleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记标题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMinutesTitleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMinutesTitleResponse
        /// </returns>
        public UpdateMinutesTitleResponse UpdateMinutesTitle(string taskUuid, UpdateMinutesTitleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMinutesTitleHeaders headers = new UpdateMinutesTitleHeaders();
            return UpdateMinutesTitleWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记标题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMinutesTitleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMinutesTitleResponse
        /// </returns>
        public async Task<UpdateMinutesTitleResponse> UpdateMinutesTitleAsync(string taskUuid, UpdateMinutesTitleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMinutesTitleHeaders headers = new UpdateMinutesTitleHeaders();
            return await UpdateMinutesTitleWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionResponse
        /// </returns>
        public UpdatePermissionResponse UpdatePermissionWithOptions(string taskUuid, UpdatePermissionRequest request, UpdatePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberInfoList))
            {
                body["memberInfoList"] = request.MemberInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpType))
            {
                body["opType"] = request.OpType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCode))
            {
                body["roleCode"] = request.RoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSubResourceIds))
            {
                body["roleSubResourceIds"] = request.RoleSubResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareScope))
            {
                body["shareScope"] = request.ShareScope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdatePermission",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/" + taskUuid + "/permission",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionResponse
        /// </returns>
        public async Task<UpdatePermissionResponse> UpdatePermissionWithOptionsAsync(string taskUuid, UpdatePermissionRequest request, UpdatePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberInfoList))
            {
                body["memberInfoList"] = request.MemberInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpType))
            {
                body["opType"] = request.OpType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCode))
            {
                body["roleCode"] = request.RoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSubResourceIds))
            {
                body["roleSubResourceIds"] = request.RoleSubResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareScope))
            {
                body["shareScope"] = request.ShareScope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdatePermission",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/" + taskUuid + "/permission",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionResponse
        /// </returns>
        public UpdatePermissionResponse UpdatePermission(string taskUuid, UpdatePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionHeaders headers = new UpdatePermissionHeaders();
            return UpdatePermissionWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionResponse
        /// </returns>
        public async Task<UpdatePermissionResponse> UpdatePermissionAsync(string taskUuid, UpdatePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionHeaders headers = new UpdatePermissionHeaders();
            return await UpdatePermissionWithOptionsAsync(taskUuid, request, headers, runtime);
        }

    }
}
