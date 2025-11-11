// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdvi_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0
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
        /// <para>获取音频文件下载地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioFileDownloadInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetAudioFileDownloadInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAudioFileDownloadInfoResponse
        /// </returns>
        public GetAudioFileDownloadInfoResponse GetAudioFileDownloadInfoWithOptions(GetAudioFileDownloadInfoRequest request, GetAudioFileDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetAudioFileDownloadInfo",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/device/audio/download",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAudioFileDownloadInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音频文件下载地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioFileDownloadInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetAudioFileDownloadInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAudioFileDownloadInfoResponse
        /// </returns>
        public async Task<GetAudioFileDownloadInfoResponse> GetAudioFileDownloadInfoWithOptionsAsync(GetAudioFileDownloadInfoRequest request, GetAudioFileDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetAudioFileDownloadInfo",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/device/audio/download",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAudioFileDownloadInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音频文件下载地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioFileDownloadInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAudioFileDownloadInfoResponse
        /// </returns>
        public GetAudioFileDownloadInfoResponse GetAudioFileDownloadInfo(GetAudioFileDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAudioFileDownloadInfoHeaders headers = new GetAudioFileDownloadInfoHeaders();
            return GetAudioFileDownloadInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音频文件下载地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioFileDownloadInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAudioFileDownloadInfoResponse
        /// </returns>
        public async Task<GetAudioFileDownloadInfoResponse> GetAudioFileDownloadInfoAsync(GetAudioFileDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAudioFileDownloadInfoHeaders headers = new GetAudioFileDownloadInfoHeaders();
            return await GetAudioFileDownloadInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音频文件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioFileInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetAudioFileInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAudioFileInfoResponse
        /// </returns>
        public GetAudioFileInfoResponse GetAudioFileInfoWithOptions(GetAudioFileInfoRequest request, GetAudioFileInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetAudioFileInfo",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/device/audio/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAudioFileInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音频文件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioFileInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetAudioFileInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAudioFileInfoResponse
        /// </returns>
        public async Task<GetAudioFileInfoResponse> GetAudioFileInfoWithOptionsAsync(GetAudioFileInfoRequest request, GetAudioFileInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetAudioFileInfo",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/device/audio/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAudioFileInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音频文件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioFileInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAudioFileInfoResponse
        /// </returns>
        public GetAudioFileInfoResponse GetAudioFileInfo(GetAudioFileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAudioFileInfoHeaders headers = new GetAudioFileInfoHeaders();
            return GetAudioFileInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音频文件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAudioFileInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAudioFileInfoResponse
        /// </returns>
        public async Task<GetAudioFileInfoResponse> GetAudioFileInfoAsync(GetAudioFileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAudioFileInfoHeaders headers = new GetAudioFileInfoHeaders();
            return await GetAudioFileInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询asr结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAsrTaskRequest
        /// </param>
        /// <param name="headers">
        /// QueryAsrTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAsrTaskResponse
        /// </returns>
        public QueryAsrTaskResponse QueryAsrTaskWithOptions(QueryAsrTaskRequest request, QueryAsrTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
                Action = "QueryAsrTask",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/asr/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAsrTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询asr结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAsrTaskRequest
        /// </param>
        /// <param name="headers">
        /// QueryAsrTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAsrTaskResponse
        /// </returns>
        public async Task<QueryAsrTaskResponse> QueryAsrTaskWithOptionsAsync(QueryAsrTaskRequest request, QueryAsrTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
                Action = "QueryAsrTask",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/asr/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAsrTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询asr结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAsrTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAsrTaskResponse
        /// </returns>
        public QueryAsrTaskResponse QueryAsrTask(QueryAsrTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAsrTaskHeaders headers = new QueryAsrTaskHeaders();
            return QueryAsrTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询asr结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAsrTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAsrTaskResponse
        /// </returns>
        public async Task<QueryAsrTaskResponse> QueryAsrTaskAsync(QueryAsrTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAsrTaskHeaders headers = new QueryAsrTaskHeaders();
            return await QueryAsrTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询指定设备的音频文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAudioFileRequest
        /// </param>
        /// <param name="headers">
        /// QueryAudioFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAudioFileResponse
        /// </returns>
        public QueryAudioFileResponse QueryAudioFileWithOptions(QueryAudioFileRequest request, QueryAudioFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                body["endTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                body["sn"] = request.Sn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                body["startTimestamp"] = request.StartTimestamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryAudioFile",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/device/audio/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAudioFileResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询指定设备的音频文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAudioFileRequest
        /// </param>
        /// <param name="headers">
        /// QueryAudioFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAudioFileResponse
        /// </returns>
        public async Task<QueryAudioFileResponse> QueryAudioFileWithOptionsAsync(QueryAudioFileRequest request, QueryAudioFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                body["endTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                body["sn"] = request.Sn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                body["startTimestamp"] = request.StartTimestamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryAudioFile",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/device/audio/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAudioFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询指定设备的音频文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAudioFileRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAudioFileResponse
        /// </returns>
        public QueryAudioFileResponse QueryAudioFile(QueryAudioFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAudioFileHeaders headers = new QueryAudioFileHeaders();
            return QueryAudioFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询指定设备的音频文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAudioFileRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAudioFileResponse
        /// </returns>
        public async Task<QueryAudioFileResponse> QueryAudioFileAsync(QueryAudioFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAudioFileHeaders headers = new QueryAudioFileHeaders();
            return await QueryAudioFileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryDeviceDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceDetailResponse
        /// </returns>
        public QueryDeviceDetailResponse QueryDeviceDetailWithOptions(QueryDeviceDetailRequest request, QueryDeviceDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnList))
            {
                body["snList"] = request.SnList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryDeviceDetail",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/device/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryDeviceDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceDetailResponse
        /// </returns>
        public async Task<QueryDeviceDetailResponse> QueryDeviceDetailWithOptionsAsync(QueryDeviceDetailRequest request, QueryDeviceDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnList))
            {
                body["snList"] = request.SnList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryDeviceDetail",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/device/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceDetailResponse
        /// </returns>
        public QueryDeviceDetailResponse QueryDeviceDetail(QueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceDetailHeaders headers = new QueryDeviceDetailHeaders();
            return QueryDeviceDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceDetailResponse
        /// </returns>
        public async Task<QueryDeviceDetailResponse> QueryDeviceDetailAsync(QueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceDetailHeaders headers = new QueryDeviceDetailHeaders();
            return await QueryDeviceDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryDeviceStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatusResponse
        /// </returns>
        public QueryDeviceStatusResponse QueryDeviceStatusWithOptions(QueryDeviceStatusRequest request, QueryDeviceStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnList))
            {
                body["snList"] = request.SnList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryDeviceStatus",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/device/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryDeviceStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatusResponse
        /// </returns>
        public async Task<QueryDeviceStatusResponse> QueryDeviceStatusWithOptionsAsync(QueryDeviceStatusRequest request, QueryDeviceStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnList))
            {
                body["snList"] = request.SnList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryDeviceStatus",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/device/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatusResponse
        /// </returns>
        public QueryDeviceStatusResponse QueryDeviceStatus(QueryDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceStatusHeaders headers = new QueryDeviceStatusHeaders();
            return QueryDeviceStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatusResponse
        /// </returns>
        public async Task<QueryDeviceStatusResponse> QueryDeviceStatusAsync(QueryDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceStatusHeaders headers = new QueryDeviceStatusHeaders();
            return await QueryDeviceStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>asr离线任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAsrTaskRequest
        /// </param>
        /// <param name="headers">
        /// SubmitAsrTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAsrTaskResponse
        /// </returns>
        public SubmitAsrTaskResponse SubmitAsrTaskWithOptions(SubmitAsrTaskRequest request, SubmitAsrTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizKey))
            {
                body["bizKey"] = request.BizKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                body["dentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phrases))
            {
                body["phrases"] = request.Phrases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["sourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transcription))
            {
                body["transcription"] = request.Transcription;
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
                Action = "SubmitAsrTask",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/asr/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAsrTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>asr离线任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAsrTaskRequest
        /// </param>
        /// <param name="headers">
        /// SubmitAsrTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAsrTaskResponse
        /// </returns>
        public async Task<SubmitAsrTaskResponse> SubmitAsrTaskWithOptionsAsync(SubmitAsrTaskRequest request, SubmitAsrTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizKey))
            {
                body["bizKey"] = request.BizKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                body["dentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phrases))
            {
                body["phrases"] = request.Phrases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["sourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transcription))
            {
                body["transcription"] = request.Transcription;
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
                Action = "SubmitAsrTask",
                Version = "dvi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dvi/asr/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAsrTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>asr离线任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAsrTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAsrTaskResponse
        /// </returns>
        public SubmitAsrTaskResponse SubmitAsrTask(SubmitAsrTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitAsrTaskHeaders headers = new SubmitAsrTaskHeaders();
            return SubmitAsrTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>asr离线任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAsrTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAsrTaskResponse
        /// </returns>
        public async Task<SubmitAsrTaskResponse> SubmitAsrTaskAsync(SubmitAsrTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitAsrTaskHeaders headers = new SubmitAsrTaskHeaders();
            return await SubmitAsrTaskWithOptionsAsync(request, headers, runtime);
        }

    }
}
