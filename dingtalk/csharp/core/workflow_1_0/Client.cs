// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0
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
        /// <para>授权下载审批钉盘文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddApproveDentryAuthRequest
        /// </param>
        /// <param name="headers">
        /// AddApproveDentryAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddApproveDentryAuthResponse
        /// </returns>
        public AddApproveDentryAuthResponse AddApproveDentryAuthWithOptions(AddApproveDentryAuthRequest request, AddApproveDentryAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfos))
            {
                body["fileInfos"] = request.FileInfos;
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
                Action = "AddApproveDentryAuth",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/spaces/files/authDownload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddApproveDentryAuthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权下载审批钉盘文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddApproveDentryAuthRequest
        /// </param>
        /// <param name="headers">
        /// AddApproveDentryAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddApproveDentryAuthResponse
        /// </returns>
        public async Task<AddApproveDentryAuthResponse> AddApproveDentryAuthWithOptionsAsync(AddApproveDentryAuthRequest request, AddApproveDentryAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfos))
            {
                body["fileInfos"] = request.FileInfos;
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
                Action = "AddApproveDentryAuth",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/spaces/files/authDownload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddApproveDentryAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权下载审批钉盘文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddApproveDentryAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// AddApproveDentryAuthResponse
        /// </returns>
        public AddApproveDentryAuthResponse AddApproveDentryAuth(AddApproveDentryAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddApproveDentryAuthHeaders headers = new AddApproveDentryAuthHeaders();
            return AddApproveDentryAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权下载审批钉盘文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddApproveDentryAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// AddApproveDentryAuthResponse
        /// </returns>
        public async Task<AddApproveDentryAuthResponse> AddApproveDentryAuthAsync(AddApproveDentryAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddApproveDentryAuthHeaders headers = new AddApproveDentryAuthHeaders();
            return await AddApproveDentryAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加审批评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddProcessInstanceCommentRequest
        /// </param>
        /// <param name="headers">
        /// AddProcessInstanceCommentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddProcessInstanceCommentResponse
        /// </returns>
        public AddProcessInstanceCommentResponse AddProcessInstanceCommentWithOptions(AddProcessInstanceCommentRequest request, AddProcessInstanceCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommentUserId))
            {
                body["commentUserId"] = request.CommentUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                body["file"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddProcessInstanceComment",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/comments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProcessInstanceCommentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加审批评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddProcessInstanceCommentRequest
        /// </param>
        /// <param name="headers">
        /// AddProcessInstanceCommentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddProcessInstanceCommentResponse
        /// </returns>
        public async Task<AddProcessInstanceCommentResponse> AddProcessInstanceCommentWithOptionsAsync(AddProcessInstanceCommentRequest request, AddProcessInstanceCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommentUserId))
            {
                body["commentUserId"] = request.CommentUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                body["file"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddProcessInstanceComment",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/comments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProcessInstanceCommentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加审批评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddProcessInstanceCommentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddProcessInstanceCommentResponse
        /// </returns>
        public AddProcessInstanceCommentResponse AddProcessInstanceComment(AddProcessInstanceCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProcessInstanceCommentHeaders headers = new AddProcessInstanceCommentHeaders();
            return AddProcessInstanceCommentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加审批评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddProcessInstanceCommentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddProcessInstanceCommentResponse
        /// </returns>
        public async Task<AddProcessInstanceCommentResponse> AddProcessInstanceCommentAsync(AddProcessInstanceCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProcessInstanceCommentHeaders headers = new AddProcessInstanceCommentHeaders();
            return await AddProcessInstanceCommentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>归档审批实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ArchiveProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// ArchiveProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ArchiveProcessInstanceResponse
        /// </returns>
        public ArchiveProcessInstanceResponse ArchiveProcessInstanceWithOptions(ArchiveProcessInstanceRequest request, ArchiveProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSystem))
            {
                body["isSystem"] = request.IsSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ArchiveProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/archive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ArchiveProcessInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>归档审批实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ArchiveProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// ArchiveProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ArchiveProcessInstanceResponse
        /// </returns>
        public async Task<ArchiveProcessInstanceResponse> ArchiveProcessInstanceWithOptionsAsync(ArchiveProcessInstanceRequest request, ArchiveProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSystem))
            {
                body["isSystem"] = request.IsSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ArchiveProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/archive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ArchiveProcessInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>归档审批实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ArchiveProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ArchiveProcessInstanceResponse
        /// </returns>
        public ArchiveProcessInstanceResponse ArchiveProcessInstance(ArchiveProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ArchiveProcessInstanceHeaders headers = new ArchiveProcessInstanceHeaders();
            return ArchiveProcessInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>归档审批实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ArchiveProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ArchiveProcessInstanceResponse
        /// </returns>
        public async Task<ArchiveProcessInstanceResponse> ArchiveProcessInstanceAsync(ArchiveProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ArchiveProcessInstanceHeaders headers = new ArchiveProcessInstanceHeaders();
            return await ArchiveProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意或拒绝审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchExecuteProcessInstancesRequest
        /// </param>
        /// <param name="headers">
        /// BatchExecuteProcessInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchExecuteProcessInstancesResponse
        /// </returns>
        public BatchExecuteProcessInstancesResponse BatchExecuteProcessInstancesWithOptions(BatchExecuteProcessInstancesRequest request, BatchExecuteProcessInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionerUserId))
            {
                body["actionerUserId"] = request.ActionerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                body["result"] = request.Result;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskInfoList))
            {
                body["taskInfoList"] = request.TaskInfoList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchExecuteProcessInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/batchExecute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchExecuteProcessInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意或拒绝审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchExecuteProcessInstancesRequest
        /// </param>
        /// <param name="headers">
        /// BatchExecuteProcessInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchExecuteProcessInstancesResponse
        /// </returns>
        public async Task<BatchExecuteProcessInstancesResponse> BatchExecuteProcessInstancesWithOptionsAsync(BatchExecuteProcessInstancesRequest request, BatchExecuteProcessInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionerUserId))
            {
                body["actionerUserId"] = request.ActionerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                body["result"] = request.Result;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskInfoList))
            {
                body["taskInfoList"] = request.TaskInfoList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchExecuteProcessInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/batchExecute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchExecuteProcessInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意或拒绝审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchExecuteProcessInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchExecuteProcessInstancesResponse
        /// </returns>
        public BatchExecuteProcessInstancesResponse BatchExecuteProcessInstances(BatchExecuteProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchExecuteProcessInstancesHeaders headers = new BatchExecuteProcessInstancesHeaders();
            return BatchExecuteProcessInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意或拒绝审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchExecuteProcessInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchExecuteProcessInstancesResponse
        /// </returns>
        public async Task<BatchExecuteProcessInstancesResponse> BatchExecuteProcessInstancesAsync(BatchExecuteProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchExecuteProcessInstancesHeaders headers = new BatchExecuteProcessInstancesHeaders();
            return await BatchExecuteProcessInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量流程审批任务转交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchTasksRedirectRequest
        /// </param>
        /// <param name="headers">
        /// BatchTasksRedirectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchTasksRedirectResponse
        /// </returns>
        public BatchTasksRedirectResponse BatchTasksRedirectWithOptions(BatchTasksRedirectRequest request, BatchTasksRedirectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandoverUserId))
            {
                body["handoverUserId"] = request.HandoverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                body["managerUserId"] = request.ManagerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["taskIds"] = request.TaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransfereeUserId))
            {
                body["transfereeUserId"] = request.TransfereeUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchTasksRedirect",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/tasks/batchRedirect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchTasksRedirectResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量流程审批任务转交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchTasksRedirectRequest
        /// </param>
        /// <param name="headers">
        /// BatchTasksRedirectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchTasksRedirectResponse
        /// </returns>
        public async Task<BatchTasksRedirectResponse> BatchTasksRedirectWithOptionsAsync(BatchTasksRedirectRequest request, BatchTasksRedirectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandoverUserId))
            {
                body["handoverUserId"] = request.HandoverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                body["managerUserId"] = request.ManagerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["taskIds"] = request.TaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransfereeUserId))
            {
                body["transfereeUserId"] = request.TransfereeUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchTasksRedirect",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/tasks/batchRedirect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchTasksRedirectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量流程审批任务转交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchTasksRedirectRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchTasksRedirectResponse
        /// </returns>
        public BatchTasksRedirectResponse BatchTasksRedirect(BatchTasksRedirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchTasksRedirectHeaders headers = new BatchTasksRedirectHeaders();
            return BatchTasksRedirectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量流程审批任务转交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchTasksRedirectRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchTasksRedirectResponse
        /// </returns>
        public async Task<BatchTasksRedirectResponse> BatchTasksRedirectAsync(BatchTasksRedirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchTasksRedirectHeaders headers = new BatchTasksRedirectHeaders();
            return await BatchTasksRedirectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateProcessInstanceResponse
        /// </returns>
        public BatchUpdateProcessInstanceResponse BatchUpdateProcessInstanceWithOptions(BatchUpdateProcessInstanceRequest request, BatchUpdateProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateProcessInstanceRequests))
            {
                body["updateProcessInstanceRequests"] = request.UpdateProcessInstanceRequests;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchUpdateProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/instances/batch",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateProcessInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateProcessInstanceResponse
        /// </returns>
        public async Task<BatchUpdateProcessInstanceResponse> BatchUpdateProcessInstanceWithOptionsAsync(BatchUpdateProcessInstanceRequest request, BatchUpdateProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateProcessInstanceRequests))
            {
                body["updateProcessInstanceRequests"] = request.UpdateProcessInstanceRequests;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchUpdateProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/instances/batch",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateProcessInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateProcessInstanceResponse
        /// </returns>
        public BatchUpdateProcessInstanceResponse BatchUpdateProcessInstance(BatchUpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateProcessInstanceHeaders headers = new BatchUpdateProcessInstanceHeaders();
            return BatchUpdateProcessInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateProcessInstanceResponse
        /// </returns>
        public async Task<BatchUpdateProcessInstanceResponse> BatchUpdateProcessInstanceAsync(BatchUpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateProcessInstanceHeaders headers = new BatchUpdateProcessInstanceHeaders();
            return await BatchUpdateProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消流程中心待处理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelIntegratedTaskRequest
        /// </param>
        /// <param name="headers">
        /// CancelIntegratedTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelIntegratedTaskResponse
        /// </returns>
        public CancelIntegratedTaskResponse CancelIntegratedTaskWithOptions(CancelIntegratedTaskRequest request, CancelIntegratedTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityIds))
            {
                body["activityIds"] = request.ActivityIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CancelIntegratedTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/tasks/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelIntegratedTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消流程中心待处理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelIntegratedTaskRequest
        /// </param>
        /// <param name="headers">
        /// CancelIntegratedTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelIntegratedTaskResponse
        /// </returns>
        public async Task<CancelIntegratedTaskResponse> CancelIntegratedTaskWithOptionsAsync(CancelIntegratedTaskRequest request, CancelIntegratedTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityIds))
            {
                body["activityIds"] = request.ActivityIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CancelIntegratedTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/tasks/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelIntegratedTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消流程中心待处理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelIntegratedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelIntegratedTaskResponse
        /// </returns>
        public CancelIntegratedTaskResponse CancelIntegratedTask(CancelIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelIntegratedTaskHeaders headers = new CancelIntegratedTaskHeaders();
            return CancelIntegratedTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消流程中心待处理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelIntegratedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelIntegratedTaskResponse
        /// </returns>
        public async Task<CancelIntegratedTaskResponse> CancelIntegratedTaskAsync(CancelIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelIntegratedTaskHeaders headers = new CancelIntegratedTaskHeaders();
            return await CancelIntegratedTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清理审批数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CleanProcessDataRequest
        /// </param>
        /// <param name="headers">
        /// CleanProcessDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CleanProcessDataResponse
        /// </returns>
        public CleanProcessDataResponse CleanProcessDataWithOptions(CleanProcessDataRequest request, CleanProcessDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CleanProcessData",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/clean",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CleanProcessDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清理审批数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CleanProcessDataRequest
        /// </param>
        /// <param name="headers">
        /// CleanProcessDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CleanProcessDataResponse
        /// </returns>
        public async Task<CleanProcessDataResponse> CleanProcessDataWithOptionsAsync(CleanProcessDataRequest request, CleanProcessDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CleanProcessData",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/clean",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CleanProcessDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清理审批数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CleanProcessDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CleanProcessDataResponse
        /// </returns>
        public CleanProcessDataResponse CleanProcessData(CleanProcessDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CleanProcessDataHeaders headers = new CleanProcessDataHeaders();
            return CleanProcessDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清理审批数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CleanProcessDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CleanProcessDataResponse
        /// </returns>
        public async Task<CleanProcessDataResponse> CleanProcessDataAsync(CleanProcessDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CleanProcessDataHeaders headers = new CleanProcessDataHeaders();
            return await CleanProcessDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制审批流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyProcessRequest
        /// </param>
        /// <param name="headers">
        /// CopyProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyProcessResponse
        /// </returns>
        public CopyProcessResponse CopyProcessWithOptions(CopyProcessRequest request, CopyProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CopyOptions))
            {
                body["copyOptions"] = request.CopyOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCorpId))
            {
                body["sourceCorpId"] = request.SourceCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProcessVOList))
            {
                body["sourceProcessVOList"] = request.SourceProcessVOList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CopyProcess",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyProcessResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制审批流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyProcessRequest
        /// </param>
        /// <param name="headers">
        /// CopyProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyProcessResponse
        /// </returns>
        public async Task<CopyProcessResponse> CopyProcessWithOptionsAsync(CopyProcessRequest request, CopyProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CopyOptions))
            {
                body["copyOptions"] = request.CopyOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCorpId))
            {
                body["sourceCorpId"] = request.SourceCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProcessVOList))
            {
                body["sourceProcessVOList"] = request.SourceProcessVOList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CopyProcess",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyProcessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制审批流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyProcessResponse
        /// </returns>
        public CopyProcessResponse CopyProcess(CopyProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyProcessHeaders headers = new CopyProcessHeaders();
            return CopyProcessWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制审批流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyProcessResponse
        /// </returns>
        public async Task<CopyProcessResponse> CopyProcessAsync(CopyProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyProcessHeaders headers = new CopyProcessHeaders();
            return await CopyProcessWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心待处理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIntegratedTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateIntegratedTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIntegratedTaskResponse
        /// </returns>
        public CreateIntegratedTaskResponse CreateIntegratedTaskWithOptions(CreateIntegratedTaskRequest request, CreateIntegratedTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConfig))
            {
                body["featureConfig"] = request.FeatureConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tasks))
            {
                body["tasks"] = request.Tasks;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateIntegratedTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntegratedTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心待处理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIntegratedTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateIntegratedTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIntegratedTaskResponse
        /// </returns>
        public async Task<CreateIntegratedTaskResponse> CreateIntegratedTaskWithOptionsAsync(CreateIntegratedTaskRequest request, CreateIntegratedTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConfig))
            {
                body["featureConfig"] = request.FeatureConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tasks))
            {
                body["tasks"] = request.Tasks;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateIntegratedTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntegratedTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心待处理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIntegratedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIntegratedTaskResponse
        /// </returns>
        public CreateIntegratedTaskResponse CreateIntegratedTask(CreateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateIntegratedTaskHeaders headers = new CreateIntegratedTaskHeaders();
            return CreateIntegratedTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心待处理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIntegratedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIntegratedTaskResponse
        /// </returns>
        public async Task<CreateIntegratedTaskResponse> CreateIntegratedTaskAsync(CreateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateIntegratedTaskHeaders headers = new CreateIntegratedTaskHeaders();
            return await CreateIntegratedTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDirRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDirHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirResponse
        /// </returns>
        public DeleteDirResponse DeleteDirWithOptions(DeleteDirRequest request, DeleteDirHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirId))
            {
                query["dirId"] = request.DirId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                query["operateUserId"] = request.OperateUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DeleteDir",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/directories",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDirResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDirRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDirHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirResponse
        /// </returns>
        public async Task<DeleteDirResponse> DeleteDirWithOptionsAsync(DeleteDirRequest request, DeleteDirHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirId))
            {
                query["dirId"] = request.DirId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                query["operateUserId"] = request.OperateUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DeleteDir",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/directories",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDirResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDirRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirResponse
        /// </returns>
        public DeleteDirResponse DeleteDir(DeleteDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDirHeaders headers = new DeleteDirHeaders();
            return DeleteDirWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDirRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirResponse
        /// </returns>
        public async Task<DeleteDirResponse> DeleteDirAsync(DeleteDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDirHeaders headers = new DeleteDirHeaders();
            return await DeleteDirWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProcessRequest
        /// </param>
        /// <param name="headers">
        /// DeleteProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProcessResponse
        /// </returns>
        public DeleteProcessResponse DeleteProcessWithOptions(DeleteProcessRequest request, DeleteProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanRunningTask))
            {
                query["cleanRunningTask"] = request.CleanRunningTask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DeleteProcess",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/schemas",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProcessResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProcessRequest
        /// </param>
        /// <param name="headers">
        /// DeleteProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProcessResponse
        /// </returns>
        public async Task<DeleteProcessResponse> DeleteProcessWithOptionsAsync(DeleteProcessRequest request, DeleteProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanRunningTask))
            {
                query["cleanRunningTask"] = request.CleanRunningTask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DeleteProcess",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/schemas",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProcessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProcessResponse
        /// </returns>
        public DeleteProcessResponse DeleteProcess(DeleteProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProcessHeaders headers = new DeleteProcessHeaders();
            return DeleteProcessWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProcessResponse
        /// </returns>
        public async Task<DeleteProcessResponse> DeleteProcessAsync(DeleteProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProcessHeaders headers = new DeleteProcessHeaders();
            return await DeleteProcessWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同意或拒绝审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteProcessInstanceResponse
        /// </returns>
        public ExecuteProcessInstanceResponse ExecuteProcessInstanceWithOptions(ExecuteProcessInstanceRequest request, ExecuteProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionerUserId))
            {
                body["actionerUserId"] = request.ActionerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                body["file"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                body["result"] = request.Result;
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
                Action = "ExecuteProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteProcessInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同意或拒绝审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteProcessInstanceResponse
        /// </returns>
        public async Task<ExecuteProcessInstanceResponse> ExecuteProcessInstanceWithOptionsAsync(ExecuteProcessInstanceRequest request, ExecuteProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionerUserId))
            {
                body["actionerUserId"] = request.ActionerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                body["file"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                body["result"] = request.Result;
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
                Action = "ExecuteProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteProcessInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同意或拒绝审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteProcessInstanceResponse
        /// </returns>
        public ExecuteProcessInstanceResponse ExecuteProcessInstance(ExecuteProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteProcessInstanceHeaders headers = new ExecuteProcessInstanceHeaders();
            return ExecuteProcessInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同意或拒绝审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteProcessInstanceResponse
        /// </returns>
        public async Task<ExecuteProcessInstanceResponse> ExecuteProcessInstanceAsync(ExecuteProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteProcessInstanceHeaders headers = new ExecuteProcessInstanceHeaders();
            return await ExecuteProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新审批表单模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FormCreateRequest
        /// </param>
        /// <param name="headers">
        /// FormCreateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FormCreateResponse
        /// </returns>
        public FormCreateResponse FormCreateWithOptions(FormCreateRequest request, FormCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponents))
            {
                body["formComponents"] = request.FormComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                body["templateConfig"] = request.TemplateConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "FormCreate",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FormCreateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新审批表单模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FormCreateRequest
        /// </param>
        /// <param name="headers">
        /// FormCreateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FormCreateResponse
        /// </returns>
        public async Task<FormCreateResponse> FormCreateWithOptionsAsync(FormCreateRequest request, FormCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponents))
            {
                body["formComponents"] = request.FormComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                body["templateConfig"] = request.TemplateConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "FormCreate",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FormCreateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新审批表单模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FormCreateRequest
        /// </param>
        /// 
        /// <returns>
        /// FormCreateResponse
        /// </returns>
        public FormCreateResponse FormCreate(FormCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FormCreateHeaders headers = new FormCreateHeaders();
            return FormCreateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新审批表单模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FormCreateRequest
        /// </param>
        /// 
        /// <returns>
        /// FormCreateResponse
        /// </returns>
        public async Task<FormCreateResponse> FormCreateAsync(FormCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FormCreateHeaders headers = new FormCreateHeaders();
            return await FormCreateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批钉盘空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttachmentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// GetAttachmentSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentSpaceResponse
        /// </returns>
        public GetAttachmentSpaceResponse GetAttachmentSpaceWithOptions(GetAttachmentSpaceRequest request, GetAttachmentSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
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
                Action = "GetAttachmentSpace",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/spaces/infos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachmentSpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批钉盘空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttachmentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// GetAttachmentSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentSpaceResponse
        /// </returns>
        public async Task<GetAttachmentSpaceResponse> GetAttachmentSpaceWithOptionsAsync(GetAttachmentSpaceRequest request, GetAttachmentSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
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
                Action = "GetAttachmentSpace",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/spaces/infos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachmentSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批钉盘空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttachmentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentSpaceResponse
        /// </returns>
        public GetAttachmentSpaceResponse GetAttachmentSpace(GetAttachmentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachmentSpaceHeaders headers = new GetAttachmentSpaceHeaders();
            return GetAttachmentSpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批钉盘空间信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttachmentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentSpaceResponse
        /// </returns>
        public async Task<GetAttachmentSpaceResponse> GetAttachmentSpaceAsync(GetAttachmentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachmentSpaceHeaders headers = new GetAttachmentSpaceHeaders();
            return await GetAttachmentSpaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已设置为条件的表单组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConditionFormComponentRequest
        /// </param>
        /// <param name="headers">
        /// GetConditionFormComponentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConditionFormComponentResponse
        /// </returns>
        public GetConditionFormComponentResponse GetConditionFormComponentWithOptions(GetConditionFormComponentRequest request, GetConditionFormComponentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetConditionFormComponent",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/conditions/components",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConditionFormComponentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已设置为条件的表单组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConditionFormComponentRequest
        /// </param>
        /// <param name="headers">
        /// GetConditionFormComponentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConditionFormComponentResponse
        /// </returns>
        public async Task<GetConditionFormComponentResponse> GetConditionFormComponentWithOptionsAsync(GetConditionFormComponentRequest request, GetConditionFormComponentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetConditionFormComponent",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/conditions/components",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConditionFormComponentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已设置为条件的表单组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConditionFormComponentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConditionFormComponentResponse
        /// </returns>
        public GetConditionFormComponentResponse GetConditionFormComponent(GetConditionFormComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConditionFormComponentHeaders headers = new GetConditionFormComponentHeaders();
            return GetConditionFormComponentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已设置为条件的表单组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConditionFormComponentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConditionFormComponentResponse
        /// </returns>
        public async Task<GetConditionFormComponentResponse> GetConditionFormComponentAsync(GetConditionFormComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConditionFormComponentHeaders headers = new GetConditionFormComponentHeaders();
            return await GetConditionFormComponentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM所有流程code</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCrmProcCodesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCrmProcCodesResponse
        /// </returns>
        public GetCrmProcCodesResponse GetCrmProcCodesWithOptions(GetCrmProcCodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCrmProcCodes",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/crm/processes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrmProcCodesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM所有流程code</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCrmProcCodesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCrmProcCodesResponse
        /// </returns>
        public async Task<GetCrmProcCodesResponse> GetCrmProcCodesWithOptionsAsync(GetCrmProcCodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCrmProcCodes",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/crm/processes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrmProcCodesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM所有流程code</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCrmProcCodesResponse
        /// </returns>
        public GetCrmProcCodesResponse GetCrmProcCodes()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmProcCodesHeaders headers = new GetCrmProcCodesHeaders();
            return GetCrmProcCodesWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM所有流程code</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCrmProcCodesResponse
        /// </returns>
        public async Task<GetCrmProcCodesResponse> GetCrmProcCodesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmProcCodesHeaders headers = new GetCrmProcCodesHeaders();
            return await GetCrmProcCodesWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单字段修改历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFieldModifiedHistoryRequest
        /// </param>
        /// <param name="headers">
        /// GetFieldModifiedHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFieldModifiedHistoryResponse
        /// </returns>
        public GetFieldModifiedHistoryResponse GetFieldModifiedHistoryWithOptions(GetFieldModifiedHistoryRequest request, GetFieldModifiedHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldId))
            {
                body["fieldId"] = request.FieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFieldModifiedHistory",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/fields/modifiedRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFieldModifiedHistoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单字段修改历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFieldModifiedHistoryRequest
        /// </param>
        /// <param name="headers">
        /// GetFieldModifiedHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFieldModifiedHistoryResponse
        /// </returns>
        public async Task<GetFieldModifiedHistoryResponse> GetFieldModifiedHistoryWithOptionsAsync(GetFieldModifiedHistoryRequest request, GetFieldModifiedHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldId))
            {
                body["fieldId"] = request.FieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFieldModifiedHistory",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/fields/modifiedRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFieldModifiedHistoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单字段修改历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFieldModifiedHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFieldModifiedHistoryResponse
        /// </returns>
        public GetFieldModifiedHistoryResponse GetFieldModifiedHistory(GetFieldModifiedHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFieldModifiedHistoryHeaders headers = new GetFieldModifiedHistoryHeaders();
            return GetFieldModifiedHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单字段修改历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFieldModifiedHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFieldModifiedHistoryResponse
        /// </returns>
        public async Task<GetFieldModifiedHistoryResponse> GetFieldModifiedHistoryAsync(GetFieldModifiedHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFieldModifiedHistoryHeaders headers = new GetFieldModifiedHistoryHeaders();
            return await GetFieldModifiedHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手写签名的下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHandSignDownloadUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetHandSignDownloadUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHandSignDownloadUrlResponse
        /// </returns>
        public GetHandSignDownloadUrlResponse GetHandSignDownloadUrlWithOptions(GetHandSignDownloadUrlRequest request, GetHandSignDownloadUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandSignToken))
            {
                body["handSignToken"] = request.HandSignToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetHandSignDownloadUrl",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/handSigns/downloadUrls/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHandSignDownloadUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手写签名的下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHandSignDownloadUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetHandSignDownloadUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHandSignDownloadUrlResponse
        /// </returns>
        public async Task<GetHandSignDownloadUrlResponse> GetHandSignDownloadUrlWithOptionsAsync(GetHandSignDownloadUrlRequest request, GetHandSignDownloadUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandSignToken))
            {
                body["handSignToken"] = request.HandSignToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetHandSignDownloadUrl",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/handSigns/downloadUrls/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHandSignDownloadUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手写签名的下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHandSignDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHandSignDownloadUrlResponse
        /// </returns>
        public GetHandSignDownloadUrlResponse GetHandSignDownloadUrl(GetHandSignDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHandSignDownloadUrlHeaders headers = new GetHandSignDownloadUrlHeaders();
            return GetHandSignDownloadUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取手写签名的下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHandSignDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHandSignDownloadUrlResponse
        /// </returns>
        public async Task<GetHandSignDownloadUrlResponse> GetHandSignDownloadUrlAsync(GetHandSignDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHandSignDownloadUrlHeaders headers = new GetHandSignDownloadUrlHeaders();
            return await GetHandSignDownloadUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前企业所有可管理的表单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetManageProcessByStaffIdRequest
        /// </param>
        /// <param name="headers">
        /// GetManageProcessByStaffIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetManageProcessByStaffIdResponse
        /// </returns>
        public GetManageProcessByStaffIdResponse GetManageProcessByStaffIdWithOptions(GetManageProcessByStaffIdRequest request, GetManageProcessByStaffIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetManageProcessByStaffId",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/managements/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetManageProcessByStaffIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前企业所有可管理的表单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetManageProcessByStaffIdRequest
        /// </param>
        /// <param name="headers">
        /// GetManageProcessByStaffIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetManageProcessByStaffIdResponse
        /// </returns>
        public async Task<GetManageProcessByStaffIdResponse> GetManageProcessByStaffIdWithOptionsAsync(GetManageProcessByStaffIdRequest request, GetManageProcessByStaffIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetManageProcessByStaffId",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/managements/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetManageProcessByStaffIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前企业所有可管理的表单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetManageProcessByStaffIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetManageProcessByStaffIdResponse
        /// </returns>
        public GetManageProcessByStaffIdResponse GetManageProcessByStaffId(GetManageProcessByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetManageProcessByStaffIdHeaders headers = new GetManageProcessByStaffIdHeaders();
            return GetManageProcessByStaffIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前企业所有可管理的表单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetManageProcessByStaffIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetManageProcessByStaffIdResponse
        /// </returns>
        public async Task<GetManageProcessByStaffIdResponse> GetManageProcessByStaffIdAsync(GetManageProcessByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetManageProcessByStaffIdHeaders headers = new GetManageProcessByStaffIdHeaders();
            return await GetManageProcessByStaffIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessCodeByNameRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessCodeByNameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessCodeByNameResponse
        /// </returns>
        public GetProcessCodeByNameResponse GetProcessCodeByNameWithOptions(GetProcessCodeByNameRequest request, GetProcessCodeByNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetProcessCodeByName",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/schemaNames/processCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessCodeByNameResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessCodeByNameRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessCodeByNameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessCodeByNameResponse
        /// </returns>
        public async Task<GetProcessCodeByNameResponse> GetProcessCodeByNameWithOptionsAsync(GetProcessCodeByNameRequest request, GetProcessCodeByNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetProcessCodeByName",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/schemaNames/processCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessCodeByNameResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessCodeByNameRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessCodeByNameResponse
        /// </returns>
        public GetProcessCodeByNameResponse GetProcessCodeByName(GetProcessCodeByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessCodeByNameHeaders headers = new GetProcessCodeByNameHeaders();
            return GetProcessCodeByNameWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessCodeByNameRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessCodeByNameResponse
        /// </returns>
        public async Task<GetProcessCodeByNameResponse> GetProcessCodeByNameAsync(GetProcessCodeByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessCodeByNameHeaders headers = new GetProcessCodeByNameHeaders();
            return await GetProcessCodeByNameWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessConfigRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessConfigResponse
        /// </returns>
        public GetProcessConfigResponse GetProcessConfigWithOptions(GetProcessConfigRequest request, GetProcessConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcCode))
            {
                query["procCode"] = request.ProcCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetProcessConfig",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/crm/processes/configurations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessConfigRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessConfigResponse
        /// </returns>
        public async Task<GetProcessConfigResponse> GetProcessConfigWithOptionsAsync(GetProcessConfigRequest request, GetProcessConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcCode))
            {
                query["procCode"] = request.ProcCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetProcessConfig",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/crm/processes/configurations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessConfigResponse
        /// </returns>
        public GetProcessConfigResponse GetProcessConfig(GetProcessConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessConfigHeaders headers = new GetProcessConfigHeaders();
            return GetProcessConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessConfigResponse
        /// </returns>
        public async Task<GetProcessConfigResponse> GetProcessConfigAsync(GetProcessConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessConfigHeaders headers = new GetProcessConfigHeaders();
            return await GetProcessConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个审批实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessInstanceResponse
        /// </returns>
        public GetProcessInstanceResponse GetProcessInstanceWithOptions(GetProcessInstanceRequest request, GetProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个审批实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessInstanceResponse
        /// </returns>
        public async Task<GetProcessInstanceResponse> GetProcessInstanceWithOptionsAsync(GetProcessInstanceRequest request, GetProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个审批实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessInstanceResponse
        /// </returns>
        public GetProcessInstanceResponse GetProcessInstance(GetProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessInstanceHeaders headers = new GetProcessInstanceHeaders();
            return GetProcessInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个审批实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessInstanceResponse
        /// </returns>
        public async Task<GetProcessInstanceResponse> GetProcessInstanceAsync(GetProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessInstanceHeaders headers = new GetProcessInstanceHeaders();
            return await GetProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessInstanceWithExtraRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessInstanceWithExtraHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessInstanceWithExtraResponse
        /// </returns>
        public GetProcessInstanceWithExtraResponse GetProcessInstanceWithExtraWithOptions(GetProcessInstanceWithExtraRequest request, GetProcessInstanceWithExtraHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetProcessInstanceWithExtra",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessInstanceWithExtraResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessInstanceWithExtraRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessInstanceWithExtraHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessInstanceWithExtraResponse
        /// </returns>
        public async Task<GetProcessInstanceWithExtraResponse> GetProcessInstanceWithExtraWithOptionsAsync(GetProcessInstanceWithExtraRequest request, GetProcessInstanceWithExtraHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetProcessInstanceWithExtra",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessInstanceWithExtraResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessInstanceWithExtraRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessInstanceWithExtraResponse
        /// </returns>
        public GetProcessInstanceWithExtraResponse GetProcessInstanceWithExtra(GetProcessInstanceWithExtraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessInstanceWithExtraHeaders headers = new GetProcessInstanceWithExtraHeaders();
            return GetProcessInstanceWithExtraWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessInstanceWithExtraRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessInstanceWithExtraResponse
        /// </returns>
        public async Task<GetProcessInstanceWithExtraResponse> GetProcessInstanceWithExtraAsync(GetProcessInstanceWithExtraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessInstanceWithExtraHeaders headers = new GetProcessInstanceWithExtraHeaders();
            return await GetProcessInstanceWithExtraWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模版code列表批量查询模板最新表单和流程配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSchemaAndProcessconfigBatchllyRequest
        /// </param>
        /// <param name="headers">
        /// GetSchemaAndProcessconfigBatchllyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSchemaAndProcessconfigBatchllyResponse
        /// </returns>
        public GetSchemaAndProcessconfigBatchllyResponse GetSchemaAndProcessconfigBatchllyWithOptions(GetSchemaAndProcessconfigBatchllyRequest tmpReq, GetSchemaAndProcessconfigBatchllyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSchemaAndProcessconfigBatchllyShrinkRequest request = new GetSchemaAndProcessconfigBatchllyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProcessCodes))
            {
                request.ProcessCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProcessCodes, "processCodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodesShrink))
            {
                query["processCodes"] = request.ProcessCodesShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSchemaAndProcessconfigBatchlly",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/templates/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSchemaAndProcessconfigBatchllyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模版code列表批量查询模板最新表单和流程配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSchemaAndProcessconfigBatchllyRequest
        /// </param>
        /// <param name="headers">
        /// GetSchemaAndProcessconfigBatchllyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSchemaAndProcessconfigBatchllyResponse
        /// </returns>
        public async Task<GetSchemaAndProcessconfigBatchllyResponse> GetSchemaAndProcessconfigBatchllyWithOptionsAsync(GetSchemaAndProcessconfigBatchllyRequest tmpReq, GetSchemaAndProcessconfigBatchllyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSchemaAndProcessconfigBatchllyShrinkRequest request = new GetSchemaAndProcessconfigBatchllyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProcessCodes))
            {
                request.ProcessCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProcessCodes, "processCodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodesShrink))
            {
                query["processCodes"] = request.ProcessCodesShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSchemaAndProcessconfigBatchlly",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/templates/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSchemaAndProcessconfigBatchllyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模版code列表批量查询模板最新表单和流程配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSchemaAndProcessconfigBatchllyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSchemaAndProcessconfigBatchllyResponse
        /// </returns>
        public GetSchemaAndProcessconfigBatchllyResponse GetSchemaAndProcessconfigBatchlly(GetSchemaAndProcessconfigBatchllyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSchemaAndProcessconfigBatchllyHeaders headers = new GetSchemaAndProcessconfigBatchllyHeaders();
            return GetSchemaAndProcessconfigBatchllyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模版code列表批量查询模板最新表单和流程配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSchemaAndProcessconfigBatchllyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSchemaAndProcessconfigBatchllyResponse
        /// </returns>
        public async Task<GetSchemaAndProcessconfigBatchllyResponse> GetSchemaAndProcessconfigBatchllyAsync(GetSchemaAndProcessconfigBatchllyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSchemaAndProcessconfigBatchllyHeaders headers = new GetSchemaAndProcessconfigBatchllyHeaders();
            return await GetSchemaAndProcessconfigBatchllyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权预览审批附件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceWithDownloadAuthRequest
        /// </param>
        /// <param name="headers">
        /// GetSpaceWithDownloadAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceWithDownloadAuthResponse
        /// </returns>
        public GetSpaceWithDownloadAuthResponse GetSpaceWithDownloadAuthWithOptions(GetSpaceWithDownloadAuthRequest request, GetSpaceWithDownloadAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIdList))
            {
                body["fileIdList"] = request.FileIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithCommentAttatchment))
            {
                body["withCommentAttatchment"] = request.WithCommentAttatchment;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSpaceWithDownloadAuth",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/spaces/authPreview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceWithDownloadAuthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权预览审批附件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceWithDownloadAuthRequest
        /// </param>
        /// <param name="headers">
        /// GetSpaceWithDownloadAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceWithDownloadAuthResponse
        /// </returns>
        public async Task<GetSpaceWithDownloadAuthResponse> GetSpaceWithDownloadAuthWithOptionsAsync(GetSpaceWithDownloadAuthRequest request, GetSpaceWithDownloadAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIdList))
            {
                body["fileIdList"] = request.FileIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithCommentAttatchment))
            {
                body["withCommentAttatchment"] = request.WithCommentAttatchment;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSpaceWithDownloadAuth",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/spaces/authPreview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceWithDownloadAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权预览审批附件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceWithDownloadAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceWithDownloadAuthResponse
        /// </returns>
        public GetSpaceWithDownloadAuthResponse GetSpaceWithDownloadAuth(GetSpaceWithDownloadAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceWithDownloadAuthHeaders headers = new GetSpaceWithDownloadAuthHeaders();
            return GetSpaceWithDownloadAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权预览审批附件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpaceWithDownloadAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpaceWithDownloadAuthResponse
        /// </returns>
        public async Task<GetSpaceWithDownloadAuthResponse> GetSpaceWithDownloadAuthAsync(GetSpaceWithDownloadAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceWithDownloadAuthHeaders headers = new GetSpaceWithDownloadAuthHeaders();
            return await GetSpaceWithDownloadAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户待审批数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTodoTaskSumRequest
        /// </param>
        /// <param name="headers">
        /// GetUserTodoTaskSumHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserTodoTaskSumResponse
        /// </returns>
        public GetUserTodoTaskSumResponse GetUserTodoTaskSumWithOptions(GetUserTodoTaskSumRequest request, GetUserTodoTaskSumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUserTodoTaskSum",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/todoTasks/numbers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserTodoTaskSumResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户待审批数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTodoTaskSumRequest
        /// </param>
        /// <param name="headers">
        /// GetUserTodoTaskSumHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserTodoTaskSumResponse
        /// </returns>
        public async Task<GetUserTodoTaskSumResponse> GetUserTodoTaskSumWithOptionsAsync(GetUserTodoTaskSumRequest request, GetUserTodoTaskSumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUserTodoTaskSum",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/todoTasks/numbers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserTodoTaskSumResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户待审批数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTodoTaskSumRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserTodoTaskSumResponse
        /// </returns>
        public GetUserTodoTaskSumResponse GetUserTodoTaskSum(GetUserTodoTaskSumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserTodoTaskSumHeaders headers = new GetUserTodoTaskSumHeaders();
            return GetUserTodoTaskSumWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户待审批数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTodoTaskSumRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserTodoTaskSumResponse
        /// </returns>
        public async Task<GetUserTodoTaskSumResponse> GetUserTodoTaskSumAsync(GetUserTodoTaskSumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserTodoTaskSumHeaders headers = new GetUserTodoTaskSumHeaders();
            return await GetUserTodoTaskSumWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户钉盘空间权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantCspaceAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// GrantCspaceAuthorizationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantCspaceAuthorizationResponse
        /// </returns>
        public GrantCspaceAuthorizationResponse GrantCspaceAuthorizationWithOptions(GrantCspaceAuthorizationRequest request, GrantCspaceAuthorizationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                body["durationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "GrantCspaceAuthorization",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/spaces/authorize",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<GrantCspaceAuthorizationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户钉盘空间权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantCspaceAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// GrantCspaceAuthorizationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantCspaceAuthorizationResponse
        /// </returns>
        public async Task<GrantCspaceAuthorizationResponse> GrantCspaceAuthorizationWithOptionsAsync(GrantCspaceAuthorizationRequest request, GrantCspaceAuthorizationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                body["durationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "GrantCspaceAuthorization",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/spaces/authorize",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<GrantCspaceAuthorizationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户钉盘空间权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantCspaceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantCspaceAuthorizationResponse
        /// </returns>
        public GrantCspaceAuthorizationResponse GrantCspaceAuthorization(GrantCspaceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantCspaceAuthorizationHeaders headers = new GrantCspaceAuthorizationHeaders();
            return GrantCspaceAuthorizationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户钉盘空间权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantCspaceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantCspaceAuthorizationResponse
        /// </returns>
        public async Task<GrantCspaceAuthorizationResponse> GrantCspaceAuthorizationAsync(GrantCspaceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantCspaceAuthorizationHeaders headers = new GrantCspaceAuthorizationHeaders();
            return await GrantCspaceAuthorizationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载审批附件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantProcessInstanceForDownloadFileRequest
        /// </param>
        /// <param name="headers">
        /// GrantProcessInstanceForDownloadFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantProcessInstanceForDownloadFileResponse
        /// </returns>
        public GrantProcessInstanceForDownloadFileResponse GrantProcessInstanceForDownloadFileWithOptions(GrantProcessInstanceForDownloadFileRequest request, GrantProcessInstanceForDownloadFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithCommentAttatchment))
            {
                body["withCommentAttatchment"] = request.WithCommentAttatchment;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GrantProcessInstanceForDownloadFile",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/spaces/files/urls/download",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantProcessInstanceForDownloadFileResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载审批附件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantProcessInstanceForDownloadFileRequest
        /// </param>
        /// <param name="headers">
        /// GrantProcessInstanceForDownloadFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantProcessInstanceForDownloadFileResponse
        /// </returns>
        public async Task<GrantProcessInstanceForDownloadFileResponse> GrantProcessInstanceForDownloadFileWithOptionsAsync(GrantProcessInstanceForDownloadFileRequest request, GrantProcessInstanceForDownloadFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithCommentAttatchment))
            {
                body["withCommentAttatchment"] = request.WithCommentAttatchment;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GrantProcessInstanceForDownloadFile",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/spaces/files/urls/download",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantProcessInstanceForDownloadFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载审批附件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantProcessInstanceForDownloadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantProcessInstanceForDownloadFileResponse
        /// </returns>
        public GrantProcessInstanceForDownloadFileResponse GrantProcessInstanceForDownloadFile(GrantProcessInstanceForDownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantProcessInstanceForDownloadFileHeaders headers = new GrantProcessInstanceForDownloadFileHeaders();
            return GrantProcessInstanceForDownloadFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载审批附件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantProcessInstanceForDownloadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantProcessInstanceForDownloadFileResponse
        /// </returns>
        public async Task<GrantProcessInstanceForDownloadFileResponse> GrantProcessInstanceForDownloadFileAsync(GrantProcessInstanceForDownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantProcessInstanceForDownloadFileHeaders headers = new GrantProcessInstanceForDownloadFileHeaders();
            return await GrantProcessInstanceForDownloadFileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertOrUpdateDirRequest
        /// </param>
        /// <param name="headers">
        /// InsertOrUpdateDirHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertOrUpdateDirResponse
        /// </returns>
        public InsertOrUpdateDirResponse InsertOrUpdateDirWithOptions(InsertOrUpdateDirRequest request, InsertOrUpdateDirHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizGroup))
            {
                body["bizGroup"] = request.BizGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name18n))
            {
                body["name18n"] = request.Name18n;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InsertOrUpdateDir",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/directories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertOrUpdateDirResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertOrUpdateDirRequest
        /// </param>
        /// <param name="headers">
        /// InsertOrUpdateDirHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertOrUpdateDirResponse
        /// </returns>
        public async Task<InsertOrUpdateDirResponse> InsertOrUpdateDirWithOptionsAsync(InsertOrUpdateDirRequest request, InsertOrUpdateDirHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizGroup))
            {
                body["bizGroup"] = request.BizGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name18n))
            {
                body["name18n"] = request.Name18n;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InsertOrUpdateDir",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/directories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertOrUpdateDirResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertOrUpdateDirRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertOrUpdateDirResponse
        /// </returns>
        public InsertOrUpdateDirResponse InsertOrUpdateDir(InsertOrUpdateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertOrUpdateDirHeaders headers = new InsertOrUpdateDirHeaders();
            return InsertOrUpdateDirWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertOrUpdateDirRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertOrUpdateDirResponse
        /// </returns>
        public async Task<InsertOrUpdateDirResponse> InsertOrUpdateDirAsync(InsertOrUpdateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertOrUpdateDirHeaders headers = new InsertOrUpdateDirHeaders();
            return await InsertOrUpdateDirWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用安装</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// <param name="headers">
        /// InstallAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public InstallAppResponse InstallAppWithOptions(InstallAppRequest request, InstallAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizGroup))
            {
                body["bizGroup"] = request.BizGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallOption))
            {
                body["installOption"] = request.InstallOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDirName))
            {
                body["sourceDirName"] = request.SourceDirName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InstallApp",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/apps/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAppResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用安装</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// <param name="headers">
        /// InstallAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public async Task<InstallAppResponse> InstallAppWithOptionsAsync(InstallAppRequest request, InstallAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizGroup))
            {
                body["bizGroup"] = request.BizGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallOption))
            {
                body["installOption"] = request.InstallOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDirName))
            {
                body["sourceDirName"] = request.SourceDirName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InstallApp",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/apps/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用安装</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public InstallAppResponse InstallApp(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallAppHeaders headers = new InstallAppHeaders();
            return InstallAppWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用安装</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public async Task<InstallAppResponse> InstallAppAsync(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallAppHeaders headers = new InstallAppHeaders();
            return await InstallAppWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批实例ID列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProcessInstanceIdsRequest
        /// </param>
        /// <param name="headers">
        /// ListProcessInstanceIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProcessInstanceIdsResponse
        /// </returns>
        public ListProcessInstanceIdsResponse ListProcessInstanceIdsWithOptions(ListProcessInstanceIdsRequest request, ListProcessInstanceIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                body["statuses"] = request.Statuses;
            }
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
                Action = "ListProcessInstanceIds",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/instanceIds/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProcessInstanceIdsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批实例ID列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProcessInstanceIdsRequest
        /// </param>
        /// <param name="headers">
        /// ListProcessInstanceIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProcessInstanceIdsResponse
        /// </returns>
        public async Task<ListProcessInstanceIdsResponse> ListProcessInstanceIdsWithOptionsAsync(ListProcessInstanceIdsRequest request, ListProcessInstanceIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                body["statuses"] = request.Statuses;
            }
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
                Action = "ListProcessInstanceIds",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/instanceIds/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProcessInstanceIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批实例ID列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProcessInstanceIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProcessInstanceIdsResponse
        /// </returns>
        public ListProcessInstanceIdsResponse ListProcessInstanceIds(ListProcessInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProcessInstanceIdsHeaders headers = new ListProcessInstanceIdsHeaders();
            return ListProcessInstanceIdsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批实例ID列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProcessInstanceIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProcessInstanceIdsResponse
        /// </returns>
        public async Task<ListProcessInstanceIdsResponse> ListProcessInstanceIdsAsync(ListProcessInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProcessInstanceIdsHeaders headers = new ListProcessInstanceIdsHeaders();
            return await ListProcessInstanceIdsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户待办事项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTodoWorkRecordsRequest
        /// </param>
        /// <param name="headers">
        /// ListTodoWorkRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTodoWorkRecordsResponse
        /// </returns>
        public ListTodoWorkRecordsResponse ListTodoWorkRecordsWithOptions(ListTodoWorkRecordsRequest request, ListTodoWorkRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
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
                Action = "ListTodoWorkRecords",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/workRecords/todoTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTodoWorkRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户待办事项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTodoWorkRecordsRequest
        /// </param>
        /// <param name="headers">
        /// ListTodoWorkRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTodoWorkRecordsResponse
        /// </returns>
        public async Task<ListTodoWorkRecordsResponse> ListTodoWorkRecordsWithOptionsAsync(ListTodoWorkRecordsRequest request, ListTodoWorkRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
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
                Action = "ListTodoWorkRecords",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/workRecords/todoTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTodoWorkRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户待办事项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTodoWorkRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTodoWorkRecordsResponse
        /// </returns>
        public ListTodoWorkRecordsResponse ListTodoWorkRecords(ListTodoWorkRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTodoWorkRecordsHeaders headers = new ListTodoWorkRecordsHeaders();
            return ListTodoWorkRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户待办事项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTodoWorkRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTodoWorkRecordsResponse
        /// </returns>
        public async Task<ListTodoWorkRecordsResponse> ListTodoWorkRecordsAsync(ListTodoWorkRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTodoWorkRecordsHeaders headers = new ListTodoWorkRecordsHeaders();
            return await ListTodoWorkRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定用户可见的审批表单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserVisibleBpmsProcessesRequest
        /// </param>
        /// <param name="headers">
        /// ListUserVisibleBpmsProcessesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleBpmsProcessesResponse
        /// </returns>
        public ListUserVisibleBpmsProcessesResponse ListUserVisibleBpmsProcessesWithOptions(ListUserVisibleBpmsProcessesRequest request, ListUserVisibleBpmsProcessesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListUserVisibleBpmsProcesses",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/userVisibilities/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserVisibleBpmsProcessesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定用户可见的审批表单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserVisibleBpmsProcessesRequest
        /// </param>
        /// <param name="headers">
        /// ListUserVisibleBpmsProcessesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleBpmsProcessesResponse
        /// </returns>
        public async Task<ListUserVisibleBpmsProcessesResponse> ListUserVisibleBpmsProcessesWithOptionsAsync(ListUserVisibleBpmsProcessesRequest request, ListUserVisibleBpmsProcessesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListUserVisibleBpmsProcesses",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/userVisibilities/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserVisibleBpmsProcessesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定用户可见的审批表单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserVisibleBpmsProcessesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleBpmsProcessesResponse
        /// </returns>
        public ListUserVisibleBpmsProcessesResponse ListUserVisibleBpmsProcesses(ListUserVisibleBpmsProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserVisibleBpmsProcessesHeaders headers = new ListUserVisibleBpmsProcessesHeaders();
            return ListUserVisibleBpmsProcessesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定用户可见的审批表单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserVisibleBpmsProcessesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleBpmsProcessesResponse
        /// </returns>
        public async Task<ListUserVisibleBpmsProcessesResponse> ListUserVisibleBpmsProcessesAsync(ListUserVisibleBpmsProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserVisibleBpmsProcessesHeaders headers = new ListUserVisibleBpmsProcessesHeaders();
            return await ListUserVisibleBpmsProcessesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PagesExportInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PagesExportInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PagesExportInstancesResponse
        /// </returns>
        public PagesExportInstancesResponse PagesExportInstancesWithOptions(PagesExportInstancesRequest request, PagesExportInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeInMills))
            {
                query["endTimeInMills"] = request.EndTimeInMills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeInMills))
            {
                query["startTimeInMills"] = request.StartTimeInMills;
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
                Action = "PagesExportInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/instances/datas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PagesExportInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PagesExportInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PagesExportInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PagesExportInstancesResponse
        /// </returns>
        public async Task<PagesExportInstancesResponse> PagesExportInstancesWithOptionsAsync(PagesExportInstancesRequest request, PagesExportInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeInMills))
            {
                query["endTimeInMills"] = request.EndTimeInMills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeInMills))
            {
                query["startTimeInMills"] = request.StartTimeInMills;
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
                Action = "PagesExportInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/instances/datas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PagesExportInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PagesExportInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PagesExportInstancesResponse
        /// </returns>
        public PagesExportInstancesResponse PagesExportInstances(PagesExportInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagesExportInstancesHeaders headers = new PagesExportInstancesHeaders();
            return PagesExportInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PagesExportInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PagesExportInstancesResponse
        /// </returns>
        public async Task<PagesExportInstancesResponse> PagesExportInstancesAsync(PagesExportInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagesExportInstancesHeaders headers = new PagesExportInstancesHeaders();
            return await PagesExportInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权下载审批钉盘文件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumAddApproveDentryAuthRequest
        /// </param>
        /// <param name="headers">
        /// PremiumAddApproveDentryAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumAddApproveDentryAuthResponse
        /// </returns>
        public PremiumAddApproveDentryAuthResponse PremiumAddApproveDentryAuthWithOptions(PremiumAddApproveDentryAuthRequest request, PremiumAddApproveDentryAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfos))
            {
                body["fileInfos"] = request.FileInfos;
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
                Action = "PremiumAddApproveDentryAuth",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/spaces/files/authDownload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumAddApproveDentryAuthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权下载审批钉盘文件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumAddApproveDentryAuthRequest
        /// </param>
        /// <param name="headers">
        /// PremiumAddApproveDentryAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumAddApproveDentryAuthResponse
        /// </returns>
        public async Task<PremiumAddApproveDentryAuthResponse> PremiumAddApproveDentryAuthWithOptionsAsync(PremiumAddApproveDentryAuthRequest request, PremiumAddApproveDentryAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfos))
            {
                body["fileInfos"] = request.FileInfos;
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
                Action = "PremiumAddApproveDentryAuth",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/spaces/files/authDownload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumAddApproveDentryAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权下载审批钉盘文件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumAddApproveDentryAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumAddApproveDentryAuthResponse
        /// </returns>
        public PremiumAddApproveDentryAuthResponse PremiumAddApproveDentryAuth(PremiumAddApproveDentryAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumAddApproveDentryAuthHeaders headers = new PremiumAddApproveDentryAuthHeaders();
            return PremiumAddApproveDentryAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权下载审批钉盘文件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumAddApproveDentryAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumAddApproveDentryAuthResponse
        /// </returns>
        public async Task<PremiumAddApproveDentryAuthResponse> PremiumAddApproveDentryAuthAsync(PremiumAddApproveDentryAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumAddApproveDentryAuthHeaders headers = new PremiumAddApproveDentryAuthHeaders();
            return await PremiumAddApproveDentryAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意或拒绝审批任务(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumBatchExecuteProcessInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumBatchExecuteProcessInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumBatchExecuteProcessInstancesResponse
        /// </returns>
        public PremiumBatchExecuteProcessInstancesResponse PremiumBatchExecuteProcessInstancesWithOptions(PremiumBatchExecuteProcessInstancesRequest request, PremiumBatchExecuteProcessInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionerUserId))
            {
                body["actionerUserId"] = request.ActionerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                body["result"] = request.Result;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskInfoList))
            {
                body["taskInfoList"] = request.TaskInfoList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumBatchExecuteProcessInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/batchExecute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumBatchExecuteProcessInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意或拒绝审批任务(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumBatchExecuteProcessInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumBatchExecuteProcessInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumBatchExecuteProcessInstancesResponse
        /// </returns>
        public async Task<PremiumBatchExecuteProcessInstancesResponse> PremiumBatchExecuteProcessInstancesWithOptionsAsync(PremiumBatchExecuteProcessInstancesRequest request, PremiumBatchExecuteProcessInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionerUserId))
            {
                body["actionerUserId"] = request.ActionerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                body["result"] = request.Result;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskInfoList))
            {
                body["taskInfoList"] = request.TaskInfoList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumBatchExecuteProcessInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/batchExecute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumBatchExecuteProcessInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意或拒绝审批任务(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumBatchExecuteProcessInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumBatchExecuteProcessInstancesResponse
        /// </returns>
        public PremiumBatchExecuteProcessInstancesResponse PremiumBatchExecuteProcessInstances(PremiumBatchExecuteProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumBatchExecuteProcessInstancesHeaders headers = new PremiumBatchExecuteProcessInstancesHeaders();
            return PremiumBatchExecuteProcessInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意或拒绝审批任务(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumBatchExecuteProcessInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumBatchExecuteProcessInstancesResponse
        /// </returns>
        public async Task<PremiumBatchExecuteProcessInstancesResponse> PremiumBatchExecuteProcessInstancesAsync(PremiumBatchExecuteProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumBatchExecuteProcessInstancesHeaders headers = new PremiumBatchExecuteProcessInstancesHeaders();
            return await PremiumBatchExecuteProcessInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务分组(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumDelDirRequest
        /// </param>
        /// <param name="headers">
        /// PremiumDelDirHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumDelDirResponse
        /// </returns>
        public PremiumDelDirResponse PremiumDelDirWithOptions(PremiumDelDirRequest request, PremiumDelDirHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirId))
            {
                query["dirId"] = request.DirId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                query["operateUserId"] = request.OperateUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "PremiumDelDir",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/directories",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumDelDirResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务分组(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumDelDirRequest
        /// </param>
        /// <param name="headers">
        /// PremiumDelDirHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumDelDirResponse
        /// </returns>
        public async Task<PremiumDelDirResponse> PremiumDelDirWithOptionsAsync(PremiumDelDirRequest request, PremiumDelDirHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirId))
            {
                query["dirId"] = request.DirId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                query["operateUserId"] = request.OperateUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "PremiumDelDir",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/directories",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumDelDirResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务分组(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumDelDirRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumDelDirResponse
        /// </returns>
        public PremiumDelDirResponse PremiumDelDir(PremiumDelDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumDelDirHeaders headers = new PremiumDelDirHeaders();
            return PremiumDelDirWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务分组(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumDelDirRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumDelDirResponse
        /// </returns>
        public async Task<PremiumDelDirResponse> PremiumDelDirAsync(PremiumDelDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumDelDirHeaders headers = new PremiumDelDirHeaders();
            return await PremiumDelDirWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumDeleteFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumDeleteFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumDeleteFormInstanceResponse
        /// </returns>
        public PremiumDeleteFormInstanceResponse PremiumDeleteFormInstanceWithOptions(PremiumDeleteFormInstanceRequest request, PremiumDeleteFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIds))
            {
                body["formInstanceIds"] = request.FormInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
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
                Action = "PremiumDeleteFormInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/formInstances/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumDeleteFormInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumDeleteFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumDeleteFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumDeleteFormInstanceResponse
        /// </returns>
        public async Task<PremiumDeleteFormInstanceResponse> PremiumDeleteFormInstanceWithOptionsAsync(PremiumDeleteFormInstanceRequest request, PremiumDeleteFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIds))
            {
                body["formInstanceIds"] = request.FormInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
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
                Action = "PremiumDeleteFormInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/formInstances/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumDeleteFormInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumDeleteFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumDeleteFormInstanceResponse
        /// </returns>
        public PremiumDeleteFormInstanceResponse PremiumDeleteFormInstance(PremiumDeleteFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumDeleteFormInstanceHeaders headers = new PremiumDeleteFormInstanceHeaders();
            return PremiumDeleteFormInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumDeleteFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumDeleteFormInstanceResponse
        /// </returns>
        public async Task<PremiumDeleteFormInstanceResponse> PremiumDeleteFormInstanceAsync(PremiumDeleteFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumDeleteFormInstanceHeaders headers = new PremiumDeleteFormInstanceHeaders();
            return await PremiumDeleteFormInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批钉盘空间信息(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetAttachmentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetAttachmentSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetAttachmentSpaceResponse
        /// </returns>
        public PremiumGetAttachmentSpaceResponse PremiumGetAttachmentSpaceWithOptions(PremiumGetAttachmentSpaceRequest request, PremiumGetAttachmentSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
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
                Action = "PremiumGetAttachmentSpace",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/spaces/infos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetAttachmentSpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批钉盘空间信息(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetAttachmentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetAttachmentSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetAttachmentSpaceResponse
        /// </returns>
        public async Task<PremiumGetAttachmentSpaceResponse> PremiumGetAttachmentSpaceWithOptionsAsync(PremiumGetAttachmentSpaceRequest request, PremiumGetAttachmentSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
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
                Action = "PremiumGetAttachmentSpace",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/spaces/infos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetAttachmentSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批钉盘空间信息(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetAttachmentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetAttachmentSpaceResponse
        /// </returns>
        public PremiumGetAttachmentSpaceResponse PremiumGetAttachmentSpace(PremiumGetAttachmentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetAttachmentSpaceHeaders headers = new PremiumGetAttachmentSpaceHeaders();
            return PremiumGetAttachmentSpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批钉盘空间信息(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetAttachmentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetAttachmentSpaceResponse
        /// </returns>
        public async Task<PremiumGetAttachmentSpaceResponse> PremiumGetAttachmentSpaceAsync(PremiumGetAttachmentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetAttachmentSpaceHeaders headers = new PremiumGetAttachmentSpaceHeaders();
            return await PremiumGetAttachmentSpaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心已处理任务列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetDoneTasksRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetDoneTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetDoneTasksResponse
        /// </returns>
        public PremiumGetDoneTasksResponse PremiumGetDoneTasksWithOptions(PremiumGetDoneTasksRequest request, PremiumGetDoneTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "PremiumGetDoneTasks",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/doneTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetDoneTasksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心已处理任务列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetDoneTasksRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetDoneTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetDoneTasksResponse
        /// </returns>
        public async Task<PremiumGetDoneTasksResponse> PremiumGetDoneTasksWithOptionsAsync(PremiumGetDoneTasksRequest request, PremiumGetDoneTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "PremiumGetDoneTasks",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/doneTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetDoneTasksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心已处理任务列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetDoneTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetDoneTasksResponse
        /// </returns>
        public PremiumGetDoneTasksResponse PremiumGetDoneTasks(PremiumGetDoneTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetDoneTasksHeaders headers = new PremiumGetDoneTasksHeaders();
            return PremiumGetDoneTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心已处理任务列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetDoneTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetDoneTasksResponse
        /// </returns>
        public async Task<PremiumGetDoneTasksResponse> PremiumGetDoneTasksAsync(PremiumGetDoneTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetDoneTasksHeaders headers = new PremiumGetDoneTasksHeaders();
            return await PremiumGetDoneTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取字段修改历史(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFieldModifiedHistoryRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetFieldModifiedHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFieldModifiedHistoryResponse
        /// </returns>
        public PremiumGetFieldModifiedHistoryResponse PremiumGetFieldModifiedHistoryWithOptions(PremiumGetFieldModifiedHistoryRequest request, PremiumGetFieldModifiedHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldId))
            {
                body["fieldId"] = request.FieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumGetFieldModifiedHistory",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processes/fields/modifiedRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetFieldModifiedHistoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取字段修改历史(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFieldModifiedHistoryRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetFieldModifiedHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFieldModifiedHistoryResponse
        /// </returns>
        public async Task<PremiumGetFieldModifiedHistoryResponse> PremiumGetFieldModifiedHistoryWithOptionsAsync(PremiumGetFieldModifiedHistoryRequest request, PremiumGetFieldModifiedHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldId))
            {
                body["fieldId"] = request.FieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumGetFieldModifiedHistory",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processes/fields/modifiedRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetFieldModifiedHistoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取字段修改历史(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFieldModifiedHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFieldModifiedHistoryResponse
        /// </returns>
        public PremiumGetFieldModifiedHistoryResponse PremiumGetFieldModifiedHistory(PremiumGetFieldModifiedHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetFieldModifiedHistoryHeaders headers = new PremiumGetFieldModifiedHistoryHeaders();
            return PremiumGetFieldModifiedHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取字段修改历史(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFieldModifiedHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFieldModifiedHistoryResponse
        /// </returns>
        public async Task<PremiumGetFieldModifiedHistoryResponse> PremiumGetFieldModifiedHistoryAsync(PremiumGetFieldModifiedHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetFieldModifiedHistoryHeaders headers = new PremiumGetFieldModifiedHistoryHeaders();
            return await PremiumGetFieldModifiedHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个数据表单实例详情(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormInstanceResponse
        /// </returns>
        public PremiumGetFormInstanceResponse PremiumGetFormInstanceWithOptions(PremiumGetFormInstanceRequest request, PremiumGetFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                query["formInstanceId"] = request.FormInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "PremiumGetFormInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/formInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetFormInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个数据表单实例详情(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormInstanceResponse
        /// </returns>
        public async Task<PremiumGetFormInstanceResponse> PremiumGetFormInstanceWithOptionsAsync(PremiumGetFormInstanceRequest request, PremiumGetFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                query["formInstanceId"] = request.FormInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "PremiumGetFormInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/formInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetFormInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个数据表单实例详情(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormInstanceResponse
        /// </returns>
        public PremiumGetFormInstanceResponse PremiumGetFormInstance(PremiumGetFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetFormInstanceHeaders headers = new PremiumGetFormInstanceHeaders();
            return PremiumGetFormInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个数据表单实例详情(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormInstanceResponse
        /// </returns>
        public async Task<PremiumGetFormInstanceResponse> PremiumGetFormInstanceAsync(PremiumGetFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetFormInstanceHeaders headers = new PremiumGetFormInstanceHeaders();
            return await PremiumGetFormInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据formCode分页获取数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetFormInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormInstancesResponse
        /// </returns>
        public PremiumGetFormInstancesResponse PremiumGetFormInstancesWithOptions(PremiumGetFormInstancesRequest request, PremiumGetFormInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
            }
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
                Action = "PremiumGetFormInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/formInstances/pages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetFormInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据formCode分页获取数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetFormInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormInstancesResponse
        /// </returns>
        public async Task<PremiumGetFormInstancesResponse> PremiumGetFormInstancesWithOptionsAsync(PremiumGetFormInstancesRequest request, PremiumGetFormInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
            }
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
                Action = "PremiumGetFormInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/formInstances/pages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetFormInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据formCode分页获取数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormInstancesResponse
        /// </returns>
        public PremiumGetFormInstancesResponse PremiumGetFormInstances(PremiumGetFormInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetFormInstancesHeaders headers = new PremiumGetFormInstancesHeaders();
            return PremiumGetFormInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据formCode分页获取数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormInstancesResponse
        /// </returns>
        public async Task<PremiumGetFormInstancesResponse> PremiumGetFormInstancesAsync(PremiumGetFormInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetFormInstancesHeaders headers = new PremiumGetFormInstancesHeaders();
            return await PremiumGetFormInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过formCode获取数据表单schema(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormSchemaRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetFormSchemaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormSchemaResponse
        /// </returns>
        public PremiumGetFormSchemaResponse PremiumGetFormSchemaWithOptions(PremiumGetFormSchemaRequest request, PremiumGetFormSchemaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "PremiumGetFormSchema",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/schema/formCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetFormSchemaResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过formCode获取数据表单schema(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormSchemaRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetFormSchemaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormSchemaResponse
        /// </returns>
        public async Task<PremiumGetFormSchemaResponse> PremiumGetFormSchemaWithOptionsAsync(PremiumGetFormSchemaRequest request, PremiumGetFormSchemaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "PremiumGetFormSchema",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/schema/formCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetFormSchemaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过formCode获取数据表单schema(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormSchemaResponse
        /// </returns>
        public PremiumGetFormSchemaResponse PremiumGetFormSchema(PremiumGetFormSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetFormSchemaHeaders headers = new PremiumGetFormSchemaHeaders();
            return PremiumGetFormSchemaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过formCode获取数据表单schema(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetFormSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetFormSchemaResponse
        /// </returns>
        public async Task<PremiumGetFormSchemaResponse> PremiumGetFormSchemaAsync(PremiumGetFormSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetFormSchemaHeaders headers = new PremiumGetFormSchemaHeaders();
            return await PremiumGetFormSchemaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心我收到的实例列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetNoticedInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetNoticedInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetNoticedInstancesResponse
        /// </returns>
        public PremiumGetNoticedInstancesResponse PremiumGetNoticedInstancesWithOptions(PremiumGetNoticedInstancesRequest request, PremiumGetNoticedInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "PremiumGetNoticedInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/noticedInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetNoticedInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心我收到的实例列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetNoticedInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetNoticedInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetNoticedInstancesResponse
        /// </returns>
        public async Task<PremiumGetNoticedInstancesResponse> PremiumGetNoticedInstancesWithOptionsAsync(PremiumGetNoticedInstancesRequest request, PremiumGetNoticedInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "PremiumGetNoticedInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/noticedInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetNoticedInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心我收到的实例列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetNoticedInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetNoticedInstancesResponse
        /// </returns>
        public PremiumGetNoticedInstancesResponse PremiumGetNoticedInstances(PremiumGetNoticedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetNoticedInstancesHeaders headers = new PremiumGetNoticedInstancesHeaders();
            return PremiumGetNoticedInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心我收到的实例列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetNoticedInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetNoticedInstancesResponse
        /// </returns>
        public async Task<PremiumGetNoticedInstancesResponse> PremiumGetNoticedInstancesAsync(PremiumGetNoticedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetNoticedInstancesHeaders headers = new PremiumGetNoticedInstancesHeaders();
            return await PremiumGetNoticedInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据processCode分页获取审批流程数据(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetProcessInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetProcessInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetProcessInstancesResponse
        /// </returns>
        public PremiumGetProcessInstancesResponse PremiumGetProcessInstancesWithOptions(PremiumGetProcessInstancesRequest request, PremiumGetProcessInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeInMills))
            {
                query["endTimeInMills"] = request.EndTimeInMills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeInMills))
            {
                query["startTimeInMills"] = request.StartTimeInMills;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "PremiumGetProcessInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processes/pages/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetProcessInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据processCode分页获取审批流程数据(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetProcessInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetProcessInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetProcessInstancesResponse
        /// </returns>
        public async Task<PremiumGetProcessInstancesResponse> PremiumGetProcessInstancesWithOptionsAsync(PremiumGetProcessInstancesRequest request, PremiumGetProcessInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeInMills))
            {
                query["endTimeInMills"] = request.EndTimeInMills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeInMills))
            {
                query["startTimeInMills"] = request.StartTimeInMills;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "PremiumGetProcessInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processes/pages/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetProcessInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据processCode分页获取审批流程数据(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetProcessInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetProcessInstancesResponse
        /// </returns>
        public PremiumGetProcessInstancesResponse PremiumGetProcessInstances(PremiumGetProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetProcessInstancesHeaders headers = new PremiumGetProcessInstancesHeaders();
            return PremiumGetProcessInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据processCode分页获取审批流程数据(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetProcessInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetProcessInstancesResponse
        /// </returns>
        public async Task<PremiumGetProcessInstancesResponse> PremiumGetProcessInstancesAsync(PremiumGetProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetProcessInstancesHeaders headers = new PremiumGetProcessInstancesHeaders();
            return await PremiumGetProcessInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权预览审批附件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetSpaceWithDownloadAuthRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetSpaceWithDownloadAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetSpaceWithDownloadAuthResponse
        /// </returns>
        public PremiumGetSpaceWithDownloadAuthResponse PremiumGetSpaceWithDownloadAuthWithOptions(PremiumGetSpaceWithDownloadAuthRequest request, PremiumGetSpaceWithDownloadAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIdList))
            {
                body["fileIdList"] = request.FileIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithCommentAttatchment))
            {
                body["withCommentAttatchment"] = request.WithCommentAttatchment;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumGetSpaceWithDownloadAuth",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/spaces/authPreview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetSpaceWithDownloadAuthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权预览审批附件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetSpaceWithDownloadAuthRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetSpaceWithDownloadAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetSpaceWithDownloadAuthResponse
        /// </returns>
        public async Task<PremiumGetSpaceWithDownloadAuthResponse> PremiumGetSpaceWithDownloadAuthWithOptionsAsync(PremiumGetSpaceWithDownloadAuthRequest request, PremiumGetSpaceWithDownloadAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIdList))
            {
                body["fileIdList"] = request.FileIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithCommentAttatchment))
            {
                body["withCommentAttatchment"] = request.WithCommentAttatchment;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumGetSpaceWithDownloadAuth",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/spaces/authPreview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetSpaceWithDownloadAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权预览审批附件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetSpaceWithDownloadAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetSpaceWithDownloadAuthResponse
        /// </returns>
        public PremiumGetSpaceWithDownloadAuthResponse PremiumGetSpaceWithDownloadAuth(PremiumGetSpaceWithDownloadAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetSpaceWithDownloadAuthHeaders headers = new PremiumGetSpaceWithDownloadAuthHeaders();
            return PremiumGetSpaceWithDownloadAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权预览审批附件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetSpaceWithDownloadAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetSpaceWithDownloadAuthResponse
        /// </returns>
        public async Task<PremiumGetSpaceWithDownloadAuthResponse> PremiumGetSpaceWithDownloadAuthAsync(PremiumGetSpaceWithDownloadAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetSpaceWithDownloadAuthHeaders headers = new PremiumGetSpaceWithDownloadAuthHeaders();
            return await PremiumGetSpaceWithDownloadAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心已发起实例列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetSubmittedInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetSubmittedInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetSubmittedInstancesResponse
        /// </returns>
        public PremiumGetSubmittedInstancesResponse PremiumGetSubmittedInstancesWithOptions(PremiumGetSubmittedInstancesRequest request, PremiumGetSubmittedInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "PremiumGetSubmittedInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/submittedInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetSubmittedInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心已发起实例列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetSubmittedInstancesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetSubmittedInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetSubmittedInstancesResponse
        /// </returns>
        public async Task<PremiumGetSubmittedInstancesResponse> PremiumGetSubmittedInstancesWithOptionsAsync(PremiumGetSubmittedInstancesRequest request, PremiumGetSubmittedInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "PremiumGetSubmittedInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/submittedInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetSubmittedInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心已发起实例列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetSubmittedInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetSubmittedInstancesResponse
        /// </returns>
        public PremiumGetSubmittedInstancesResponse PremiumGetSubmittedInstances(PremiumGetSubmittedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetSubmittedInstancesHeaders headers = new PremiumGetSubmittedInstancesHeaders();
            return PremiumGetSubmittedInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心已发起实例列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetSubmittedInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetSubmittedInstancesResponse
        /// </returns>
        public async Task<PremiumGetSubmittedInstancesResponse> PremiumGetSubmittedInstancesAsync(PremiumGetSubmittedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetSubmittedInstancesHeaders headers = new PremiumGetSubmittedInstancesHeaders();
            return await PremiumGetSubmittedInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心待处理任务列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetTodoTasksRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetTodoTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetTodoTasksResponse
        /// </returns>
        public PremiumGetTodoTasksResponse PremiumGetTodoTasksWithOptions(PremiumGetTodoTasksRequest request, PremiumGetTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateBefore))
            {
                query["createBefore"] = request.CreateBefore;
            }
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
                Action = "PremiumGetTodoTasks",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/todoTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetTodoTasksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心待处理任务列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetTodoTasksRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGetTodoTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetTodoTasksResponse
        /// </returns>
        public async Task<PremiumGetTodoTasksResponse> PremiumGetTodoTasksWithOptionsAsync(PremiumGetTodoTasksRequest request, PremiumGetTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateBefore))
            {
                query["createBefore"] = request.CreateBefore;
            }
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
                Action = "PremiumGetTodoTasks",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/todoTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGetTodoTasksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心待处理任务列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetTodoTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetTodoTasksResponse
        /// </returns>
        public PremiumGetTodoTasksResponse PremiumGetTodoTasks(PremiumGetTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetTodoTasksHeaders headers = new PremiumGetTodoTasksHeaders();
            return PremiumGetTodoTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批中心待处理任务列表(OA高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGetTodoTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGetTodoTasksResponse
        /// </returns>
        public async Task<PremiumGetTodoTasksResponse> PremiumGetTodoTasksAsync(PremiumGetTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetTodoTasksHeaders headers = new PremiumGetTodoTasksHeaders();
            return await PremiumGetTodoTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载审批附件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGrantProcessInstanceForDownloadFileRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGrantProcessInstanceForDownloadFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGrantProcessInstanceForDownloadFileResponse
        /// </returns>
        public PremiumGrantProcessInstanceForDownloadFileResponse PremiumGrantProcessInstanceForDownloadFileWithOptions(PremiumGrantProcessInstanceForDownloadFileRequest request, PremiumGrantProcessInstanceForDownloadFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithCommentAttatchment))
            {
                body["withCommentAttatchment"] = request.WithCommentAttatchment;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumGrantProcessInstanceForDownloadFile",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/spaces/files/urls/download",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGrantProcessInstanceForDownloadFileResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载审批附件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGrantProcessInstanceForDownloadFileRequest
        /// </param>
        /// <param name="headers">
        /// PremiumGrantProcessInstanceForDownloadFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumGrantProcessInstanceForDownloadFileResponse
        /// </returns>
        public async Task<PremiumGrantProcessInstanceForDownloadFileResponse> PremiumGrantProcessInstanceForDownloadFileWithOptionsAsync(PremiumGrantProcessInstanceForDownloadFileRequest request, PremiumGrantProcessInstanceForDownloadFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithCommentAttatchment))
            {
                body["withCommentAttatchment"] = request.WithCommentAttatchment;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumGrantProcessInstanceForDownloadFile",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances/spaces/files/urls/download",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumGrantProcessInstanceForDownloadFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载审批附件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGrantProcessInstanceForDownloadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGrantProcessInstanceForDownloadFileResponse
        /// </returns>
        public PremiumGrantProcessInstanceForDownloadFileResponse PremiumGrantProcessInstanceForDownloadFile(PremiumGrantProcessInstanceForDownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGrantProcessInstanceForDownloadFileHeaders headers = new PremiumGrantProcessInstanceForDownloadFileHeaders();
            return PremiumGrantProcessInstanceForDownloadFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载审批附件(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumGrantProcessInstanceForDownloadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumGrantProcessInstanceForDownloadFileResponse
        /// </returns>
        public async Task<PremiumGrantProcessInstanceForDownloadFileResponse> PremiumGrantProcessInstanceForDownloadFileAsync(PremiumGrantProcessInstanceForDownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGrantProcessInstanceForDownloadFileHeaders headers = new PremiumGrantProcessInstanceForDownloadFileHeaders();
            return await PremiumGrantProcessInstanceForDownloadFileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新分组(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumInsertOrUpdateDirRequest
        /// </param>
        /// <param name="headers">
        /// PremiumInsertOrUpdateDirHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumInsertOrUpdateDirResponse
        /// </returns>
        public PremiumInsertOrUpdateDirResponse PremiumInsertOrUpdateDirWithOptions(PremiumInsertOrUpdateDirRequest request, PremiumInsertOrUpdateDirHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizGroup))
            {
                body["bizGroup"] = request.BizGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name18n))
            {
                body["name18n"] = request.Name18n;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumInsertOrUpdateDir",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/directories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumInsertOrUpdateDirResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新分组(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumInsertOrUpdateDirRequest
        /// </param>
        /// <param name="headers">
        /// PremiumInsertOrUpdateDirHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumInsertOrUpdateDirResponse
        /// </returns>
        public async Task<PremiumInsertOrUpdateDirResponse> PremiumInsertOrUpdateDirWithOptionsAsync(PremiumInsertOrUpdateDirRequest request, PremiumInsertOrUpdateDirHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizGroup))
            {
                body["bizGroup"] = request.BizGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name18n))
            {
                body["name18n"] = request.Name18n;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumInsertOrUpdateDir",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/directories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumInsertOrUpdateDirResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新分组(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumInsertOrUpdateDirRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumInsertOrUpdateDirResponse
        /// </returns>
        public PremiumInsertOrUpdateDirResponse PremiumInsertOrUpdateDir(PremiumInsertOrUpdateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumInsertOrUpdateDirHeaders headers = new PremiumInsertOrUpdateDirHeaders();
            return PremiumInsertOrUpdateDirWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新分组(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumInsertOrUpdateDirRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumInsertOrUpdateDirResponse
        /// </returns>
        public async Task<PremiumInsertOrUpdateDirResponse> PremiumInsertOrUpdateDirAsync(PremiumInsertOrUpdateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumInsertOrUpdateDirHeaders headers = new PremiumInsertOrUpdateDirHeaders();
            return await PremiumInsertOrUpdateDirWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流程转交待处理任务查询(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumQueryTodoTasksByManagerRequest
        /// </param>
        /// <param name="headers">
        /// PremiumQueryTodoTasksByManagerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumQueryTodoTasksByManagerResponse
        /// </returns>
        public PremiumQueryTodoTasksByManagerResponse PremiumQueryTodoTasksByManagerWithOptions(PremiumQueryTodoTasksByManagerRequest request, PremiumQueryTodoTasksByManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionerUserId))
            {
                query["actionerUserId"] = request.ActionerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
            }
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
                Action = "PremiumQueryTodoTasksByManager",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/tasks/todoTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumQueryTodoTasksByManagerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流程转交待处理任务查询(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumQueryTodoTasksByManagerRequest
        /// </param>
        /// <param name="headers">
        /// PremiumQueryTodoTasksByManagerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumQueryTodoTasksByManagerResponse
        /// </returns>
        public async Task<PremiumQueryTodoTasksByManagerResponse> PremiumQueryTodoTasksByManagerWithOptionsAsync(PremiumQueryTodoTasksByManagerRequest request, PremiumQueryTodoTasksByManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionerUserId))
            {
                query["actionerUserId"] = request.ActionerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
            }
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
                Action = "PremiumQueryTodoTasksByManager",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/tasks/todoTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumQueryTodoTasksByManagerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流程转交待处理任务查询(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumQueryTodoTasksByManagerRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumQueryTodoTasksByManagerResponse
        /// </returns>
        public PremiumQueryTodoTasksByManagerResponse PremiumQueryTodoTasksByManager(PremiumQueryTodoTasksByManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumQueryTodoTasksByManagerHeaders headers = new PremiumQueryTodoTasksByManagerHeaders();
            return PremiumQueryTodoTasksByManagerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流程转交待处理任务查询(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumQueryTodoTasksByManagerRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumQueryTodoTasksByManagerResponse
        /// </returns>
        public async Task<PremiumQueryTodoTasksByManagerResponse> PremiumQueryTodoTasksByManagerAsync(PremiumQueryTodoTasksByManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumQueryTodoTasksByManagerHeaders headers = new PremiumQueryTodoTasksByManagerHeaders();
            return await PremiumQueryTodoTasksByManagerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量流程审批任务转交(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumRedirectTasksByManagerRequest
        /// </param>
        /// <param name="headers">
        /// PremiumRedirectTasksByManagerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumRedirectTasksByManagerResponse
        /// </returns>
        public PremiumRedirectTasksByManagerResponse PremiumRedirectTasksByManagerWithOptions(PremiumRedirectTasksByManagerRequest request, PremiumRedirectTasksByManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandoverUserId))
            {
                body["handoverUserId"] = request.HandoverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                body["managerUserId"] = request.ManagerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["taskIds"] = request.TaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransfereeUserId))
            {
                body["transfereeUserId"] = request.TransfereeUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumRedirectTasksByManager",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/tasks/batchRedirect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumRedirectTasksByManagerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量流程审批任务转交(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumRedirectTasksByManagerRequest
        /// </param>
        /// <param name="headers">
        /// PremiumRedirectTasksByManagerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumRedirectTasksByManagerResponse
        /// </returns>
        public async Task<PremiumRedirectTasksByManagerResponse> PremiumRedirectTasksByManagerWithOptionsAsync(PremiumRedirectTasksByManagerRequest request, PremiumRedirectTasksByManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandoverUserId))
            {
                body["handoverUserId"] = request.HandoverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                body["managerUserId"] = request.ManagerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["taskIds"] = request.TaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransfereeUserId))
            {
                body["transfereeUserId"] = request.TransfereeUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumRedirectTasksByManager",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/tasks/batchRedirect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumRedirectTasksByManagerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量流程审批任务转交(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumRedirectTasksByManagerRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumRedirectTasksByManagerResponse
        /// </returns>
        public PremiumRedirectTasksByManagerResponse PremiumRedirectTasksByManager(PremiumRedirectTasksByManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumRedirectTasksByManagerHeaders headers = new PremiumRedirectTasksByManagerHeaders();
            return PremiumRedirectTasksByManagerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量流程审批任务转交(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumRedirectTasksByManagerRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumRedirectTasksByManagerResponse
        /// </returns>
        public async Task<PremiumRedirectTasksByManagerResponse> PremiumRedirectTasksByManagerAsync(PremiumRedirectTasksByManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumRedirectTasksByManagerHeaders headers = new PremiumRedirectTasksByManagerHeaders();
            return await PremiumRedirectTasksByManagerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新数据表单模板(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveFormRequest
        /// </param>
        /// <param name="headers">
        /// PremiumSaveFormHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveFormResponse
        /// </returns>
        public PremiumSaveFormResponse PremiumSaveFormWithOptions(PremiumSaveFormRequest request, PremiumSaveFormHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponents))
            {
                body["formComponents"] = request.FormComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
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
                Action = "PremiumSaveForm",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumSaveFormResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新数据表单模板(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveFormRequest
        /// </param>
        /// <param name="headers">
        /// PremiumSaveFormHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveFormResponse
        /// </returns>
        public async Task<PremiumSaveFormResponse> PremiumSaveFormWithOptionsAsync(PremiumSaveFormRequest request, PremiumSaveFormHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponents))
            {
                body["formComponents"] = request.FormComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
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
                Action = "PremiumSaveForm",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumSaveFormResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新数据表单模板(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveFormRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveFormResponse
        /// </returns>
        public PremiumSaveFormResponse PremiumSaveForm(PremiumSaveFormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveFormHeaders headers = new PremiumSaveFormHeaders();
            return PremiumSaveFormWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新数据表单模板(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveFormRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveFormResponse
        /// </returns>
        public async Task<PremiumSaveFormResponse> PremiumSaveFormAsync(PremiumSaveFormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveFormHeaders headers = new PremiumSaveFormHeaders();
            return await PremiumSaveFormWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumSaveFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveFormInstanceResponse
        /// </returns>
        public PremiumSaveFormInstanceResponse PremiumSaveFormInstanceWithOptions(PremiumSaveFormInstanceRequest request, PremiumSaveFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValueList))
            {
                body["formComponentValueList"] = request.FormComponentValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorUserId))
            {
                body["originatorUserId"] = request.OriginatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumSaveFormInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/formInstances/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumSaveFormInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumSaveFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveFormInstanceResponse
        /// </returns>
        public async Task<PremiumSaveFormInstanceResponse> PremiumSaveFormInstanceWithOptionsAsync(PremiumSaveFormInstanceRequest request, PremiumSaveFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValueList))
            {
                body["formComponentValueList"] = request.FormComponentValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorUserId))
            {
                body["originatorUserId"] = request.OriginatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumSaveFormInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/formInstances/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumSaveFormInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveFormInstanceResponse
        /// </returns>
        public PremiumSaveFormInstanceResponse PremiumSaveFormInstance(PremiumSaveFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveFormInstanceHeaders headers = new PremiumSaveFormInstanceHeaders();
            return PremiumSaveFormInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveFormInstanceResponse
        /// </returns>
        public async Task<PremiumSaveFormInstanceResponse> PremiumSaveFormInstanceAsync(PremiumSaveFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveFormInstanceHeaders headers = new PremiumSaveFormInstanceHeaders();
            return await PremiumSaveFormInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新流程中心外部集成模板(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedProcessRequest
        /// </param>
        /// <param name="headers">
        /// PremiumSaveIntegratedProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedProcessResponse
        /// </returns>
        public PremiumSaveIntegratedProcessResponse PremiumSaveIntegratedProcessWithOptions(PremiumSaveIntegratedProcessRequest request, PremiumSaveIntegratedProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponents))
            {
                body["formComponents"] = request.FormComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessFeatureConfig))
            {
                body["processFeatureConfig"] = request.ProcessFeatureConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                body["templateConfig"] = request.TemplateConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumSaveIntegratedProcess",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/schemas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumSaveIntegratedProcessResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新流程中心外部集成模板(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedProcessRequest
        /// </param>
        /// <param name="headers">
        /// PremiumSaveIntegratedProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedProcessResponse
        /// </returns>
        public async Task<PremiumSaveIntegratedProcessResponse> PremiumSaveIntegratedProcessWithOptionsAsync(PremiumSaveIntegratedProcessRequest request, PremiumSaveIntegratedProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponents))
            {
                body["formComponents"] = request.FormComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessFeatureConfig))
            {
                body["processFeatureConfig"] = request.ProcessFeatureConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                body["templateConfig"] = request.TemplateConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumSaveIntegratedProcess",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/schemas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumSaveIntegratedProcessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新流程中心外部集成模板(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedProcessResponse
        /// </returns>
        public PremiumSaveIntegratedProcessResponse PremiumSaveIntegratedProcess(PremiumSaveIntegratedProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedProcessHeaders headers = new PremiumSaveIntegratedProcessHeaders();
            return PremiumSaveIntegratedProcessWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新流程中心外部集成模板(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedProcessResponse
        /// </returns>
        public async Task<PremiumSaveIntegratedProcessResponse> PremiumSaveIntegratedProcessAsync(PremiumSaveIntegratedProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedProcessHeaders headers = new PremiumSaveIntegratedProcessHeaders();
            return await PremiumSaveIntegratedProcessWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心外部集成实例(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumSaveIntegratedProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedProcessInstanceResponse
        /// </returns>
        public PremiumSaveIntegratedProcessInstanceResponse PremiumSaveIntegratedProcessInstanceWithOptions(PremiumSaveIntegratedProcessInstanceRequest request, PremiumSaveIntegratedProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizData))
            {
                body["bizData"] = request.BizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValueList))
            {
                body["formComponentValueList"] = request.FormComponentValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notifiers))
            {
                body["notifiers"] = request.Notifiers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorUserId))
            {
                body["originatorUserId"] = request.OriginatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumSaveIntegratedProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumSaveIntegratedProcessInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心外部集成实例(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumSaveIntegratedProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedProcessInstanceResponse
        /// </returns>
        public async Task<PremiumSaveIntegratedProcessInstanceResponse> PremiumSaveIntegratedProcessInstanceWithOptionsAsync(PremiumSaveIntegratedProcessInstanceRequest request, PremiumSaveIntegratedProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizData))
            {
                body["bizData"] = request.BizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValueList))
            {
                body["formComponentValueList"] = request.FormComponentValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notifiers))
            {
                body["notifiers"] = request.Notifiers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorUserId))
            {
                body["originatorUserId"] = request.OriginatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumSaveIntegratedProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumSaveIntegratedProcessInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心外部集成实例(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedProcessInstanceResponse
        /// </returns>
        public PremiumSaveIntegratedProcessInstanceResponse PremiumSaveIntegratedProcessInstance(PremiumSaveIntegratedProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedProcessInstanceHeaders headers = new PremiumSaveIntegratedProcessInstanceHeaders();
            return PremiumSaveIntegratedProcessInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心外部集成实例(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedProcessInstanceResponse
        /// </returns>
        public async Task<PremiumSaveIntegratedProcessInstanceResponse> PremiumSaveIntegratedProcessInstanceAsync(PremiumSaveIntegratedProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedProcessInstanceHeaders headers = new PremiumSaveIntegratedProcessInstanceHeaders();
            return await PremiumSaveIntegratedProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心外部集成待处理任务(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedTaskRequest
        /// </param>
        /// <param name="headers">
        /// PremiumSaveIntegratedTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedTaskResponse
        /// </returns>
        public PremiumSaveIntegratedTaskResponse PremiumSaveIntegratedTaskWithOptions(PremiumSaveIntegratedTaskRequest request, PremiumSaveIntegratedTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConfig))
            {
                body["featureConfig"] = request.FeatureConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tasks))
            {
                body["tasks"] = request.Tasks;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumSaveIntegratedTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumSaveIntegratedTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心外部集成待处理任务(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedTaskRequest
        /// </param>
        /// <param name="headers">
        /// PremiumSaveIntegratedTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedTaskResponse
        /// </returns>
        public async Task<PremiumSaveIntegratedTaskResponse> PremiumSaveIntegratedTaskWithOptionsAsync(PremiumSaveIntegratedTaskRequest request, PremiumSaveIntegratedTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConfig))
            {
                body["featureConfig"] = request.FeatureConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tasks))
            {
                body["tasks"] = request.Tasks;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumSaveIntegratedTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processCentres/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumSaveIntegratedTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心外部集成待处理任务(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedTaskResponse
        /// </returns>
        public PremiumSaveIntegratedTaskResponse PremiumSaveIntegratedTask(PremiumSaveIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedTaskHeaders headers = new PremiumSaveIntegratedTaskHeaders();
            return PremiumSaveIntegratedTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程中心外部集成待处理任务(高级版专享接口)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumSaveIntegratedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumSaveIntegratedTaskResponse
        /// </returns>
        public async Task<PremiumSaveIntegratedTaskResponse> PremiumSaveIntegratedTaskAsync(PremiumSaveIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedTaskHeaders headers = new PremiumSaveIntegratedTaskHeaders();
            return await PremiumSaveIntegratedTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumUpdateFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumUpdateFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumUpdateFormInstanceResponse
        /// </returns>
        public PremiumUpdateFormInstanceResponse PremiumUpdateFormInstanceWithOptions(PremiumUpdateFormInstanceRequest request, PremiumUpdateFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValueList))
            {
                body["formComponentValueList"] = request.FormComponentValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIds))
            {
                body["formInstanceIds"] = request.FormInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorUserId))
            {
                body["originatorUserId"] = request.OriginatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumUpdateFormInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/formInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumUpdateFormInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumUpdateFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// PremiumUpdateFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumUpdateFormInstanceResponse
        /// </returns>
        public async Task<PremiumUpdateFormInstanceResponse> PremiumUpdateFormInstanceWithOptionsAsync(PremiumUpdateFormInstanceRequest request, PremiumUpdateFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValueList))
            {
                body["formComponentValueList"] = request.FormComponentValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIds))
            {
                body["formInstanceIds"] = request.FormInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorUserId))
            {
                body["originatorUserId"] = request.OriginatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumUpdateFormInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/dataForms/formInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumUpdateFormInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumUpdateFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumUpdateFormInstanceResponse
        /// </returns>
        public PremiumUpdateFormInstanceResponse PremiumUpdateFormInstance(PremiumUpdateFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumUpdateFormInstanceHeaders headers = new PremiumUpdateFormInstanceHeaders();
            return PremiumUpdateFormInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表单实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumUpdateFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumUpdateFormInstanceResponse
        /// </returns>
        public async Task<PremiumUpdateFormInstanceResponse> PremiumUpdateFormInstanceAsync(PremiumUpdateFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumUpdateFormInstanceHeaders headers = new PremiumUpdateFormInstanceHeaders();
            return await PremiumUpdateFormInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新审批实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumUpdateProcessInstanceVariablesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumUpdateProcessInstanceVariablesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumUpdateProcessInstanceVariablesResponse
        /// </returns>
        public PremiumUpdateProcessInstanceVariablesResponse PremiumUpdateProcessInstanceVariablesWithOptions(PremiumUpdateProcessInstanceVariablesRequest request, PremiumUpdateProcessInstanceVariablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumUpdateProcessInstanceVariables",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumUpdateProcessInstanceVariablesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新审批实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumUpdateProcessInstanceVariablesRequest
        /// </param>
        /// <param name="headers">
        /// PremiumUpdateProcessInstanceVariablesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PremiumUpdateProcessInstanceVariablesResponse
        /// </returns>
        public async Task<PremiumUpdateProcessInstanceVariablesResponse> PremiumUpdateProcessInstanceVariablesWithOptionsAsync(PremiumUpdateProcessInstanceVariablesRequest request, PremiumUpdateProcessInstanceVariablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PremiumUpdateProcessInstanceVariables",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/premium/processInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PremiumUpdateProcessInstanceVariablesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新审批实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumUpdateProcessInstanceVariablesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumUpdateProcessInstanceVariablesResponse
        /// </returns>
        public PremiumUpdateProcessInstanceVariablesResponse PremiumUpdateProcessInstanceVariables(PremiumUpdateProcessInstanceVariablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumUpdateProcessInstanceVariablesHeaders headers = new PremiumUpdateProcessInstanceVariablesHeaders();
            return PremiumUpdateProcessInstanceVariablesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新审批实例(OA高级版专享)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PremiumUpdateProcessInstanceVariablesRequest
        /// </param>
        /// 
        /// <returns>
        /// PremiumUpdateProcessInstanceVariablesResponse
        /// </returns>
        public async Task<PremiumUpdateProcessInstanceVariablesResponse> PremiumUpdateProcessInstanceVariablesAsync(PremiumUpdateProcessInstanceVariablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumUpdateProcessInstanceVariablesHeaders headers = new PremiumUpdateProcessInstanceVariablesHeaders();
            return await PremiumUpdateProcessInstanceVariablesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>审批流程预测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessForecastRequest
        /// </param>
        /// <param name="headers">
        /// ProcessForecastHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProcessForecastResponse
        /// </returns>
        public ProcessForecastResponse ProcessForecastWithOptions(ProcessForecastRequest request, ProcessForecastHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValues))
            {
                body["formComponentValues"] = request.FormComponentValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
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
                Action = "ProcessForecast",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/forecast",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessForecastResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>审批流程预测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessForecastRequest
        /// </param>
        /// <param name="headers">
        /// ProcessForecastHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProcessForecastResponse
        /// </returns>
        public async Task<ProcessForecastResponse> ProcessForecastWithOptionsAsync(ProcessForecastRequest request, ProcessForecastHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValues))
            {
                body["formComponentValues"] = request.FormComponentValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
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
                Action = "ProcessForecast",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/forecast",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessForecastResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>审批流程预测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessForecastRequest
        /// </param>
        /// 
        /// <returns>
        /// ProcessForecastResponse
        /// </returns>
        public ProcessForecastResponse ProcessForecast(ProcessForecastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessForecastHeaders headers = new ProcessForecastHeaders();
            return ProcessForecastWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>审批流程预测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessForecastRequest
        /// </param>
        /// 
        /// <returns>
        /// ProcessForecastResponse
        /// </returns>
        public async Task<ProcessForecastResponse> ProcessForecastAsync(ProcessForecastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessForecastHeaders headers = new ProcessForecastHeaders();
            return await ProcessForecastWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据processCode分页获取表单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllFormInstancesRequest
        /// </param>
        /// <param name="headers">
        /// QueryAllFormInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllFormInstancesResponse
        /// </returns>
        public QueryAllFormInstancesResponse QueryAllFormInstancesWithOptions(QueryAllFormInstancesRequest request, QueryAllFormInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
            }
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
                Action = "QueryAllFormInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms/pages/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllFormInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据processCode分页获取表单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllFormInstancesRequest
        /// </param>
        /// <param name="headers">
        /// QueryAllFormInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllFormInstancesResponse
        /// </returns>
        public async Task<QueryAllFormInstancesResponse> QueryAllFormInstancesWithOptionsAsync(QueryAllFormInstancesRequest request, QueryAllFormInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
            }
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
                Action = "QueryAllFormInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms/pages/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllFormInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据processCode分页获取表单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllFormInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllFormInstancesResponse
        /// </returns>
        public QueryAllFormInstancesResponse QueryAllFormInstances(QueryAllFormInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllFormInstancesHeaders headers = new QueryAllFormInstancesHeaders();
            return QueryAllFormInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据processCode分页获取表单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllFormInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllFormInstancesResponse
        /// </returns>
        public async Task<QueryAllFormInstancesResponse> QueryAllFormInstancesAsync(QueryAllFormInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllFormInstancesHeaders headers = new QueryAllFormInstancesHeaders();
            return await QueryAllFormInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询审批流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllProcessInstancesRequest
        /// </param>
        /// <param name="headers">
        /// QueryAllProcessInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllProcessInstancesResponse
        /// </returns>
        public QueryAllProcessInstancesResponse QueryAllProcessInstancesWithOptions(QueryAllProcessInstancesRequest request, QueryAllProcessInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeInMills))
            {
                query["endTimeInMills"] = request.EndTimeInMills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeInMills))
            {
                query["startTimeInMills"] = request.StartTimeInMills;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryAllProcessInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/pages/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllProcessInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询审批流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllProcessInstancesRequest
        /// </param>
        /// <param name="headers">
        /// QueryAllProcessInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllProcessInstancesResponse
        /// </returns>
        public async Task<QueryAllProcessInstancesResponse> QueryAllProcessInstancesWithOptionsAsync(QueryAllProcessInstancesRequest request, QueryAllProcessInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeInMills))
            {
                query["endTimeInMills"] = request.EndTimeInMills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeInMills))
            {
                query["startTimeInMills"] = request.StartTimeInMills;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryAllProcessInstances",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/pages/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllProcessInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询审批流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllProcessInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllProcessInstancesResponse
        /// </returns>
        public QueryAllProcessInstancesResponse QueryAllProcessInstances(QueryAllProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllProcessInstancesHeaders headers = new QueryAllProcessInstancesHeaders();
            return QueryAllProcessInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询审批流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllProcessInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllProcessInstancesResponse
        /// </returns>
        public async Task<QueryAllProcessInstancesResponse> QueryAllProcessInstancesAsync(QueryAllProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllProcessInstancesHeaders headers = new QueryAllProcessInstancesHeaders();
            return await QueryAllProcessInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据业务标识查询表单描述信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFormByBizTypeRequest
        /// </param>
        /// <param name="headers">
        /// QueryFormByBizTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFormByBizTypeResponse
        /// </returns>
        public QueryFormByBizTypeResponse QueryFormByBizTypeWithOptions(QueryFormByBizTypeRequest request, QueryFormByBizTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                body["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypes))
            {
                body["bizTypes"] = request.BizTypes;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryFormByBizType",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms/forminfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFormByBizTypeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据业务标识查询表单描述信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFormByBizTypeRequest
        /// </param>
        /// <param name="headers">
        /// QueryFormByBizTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFormByBizTypeResponse
        /// </returns>
        public async Task<QueryFormByBizTypeResponse> QueryFormByBizTypeWithOptionsAsync(QueryFormByBizTypeRequest request, QueryFormByBizTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                body["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypes))
            {
                body["bizTypes"] = request.BizTypes;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryFormByBizType",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms/forminfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFormByBizTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据业务标识查询表单描述信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFormByBizTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFormByBizTypeResponse
        /// </returns>
        public QueryFormByBizTypeResponse QueryFormByBizType(QueryFormByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormByBizTypeHeaders headers = new QueryFormByBizTypeHeaders();
            return QueryFormByBizTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据业务标识查询表单描述信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFormByBizTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFormByBizTypeResponse
        /// </returns>
        public async Task<QueryFormByBizTypeResponse> QueryFormByBizTypeAsync(QueryFormByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormByBizTypeHeaders headers = new QueryFormByBizTypeHeaders();
            return await QueryFormByBizTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据表单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// QueryFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFormInstanceResponse
        /// </returns>
        public QueryFormInstanceResponse QueryFormInstanceWithOptions(QueryFormInstanceRequest request, QueryFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                query["formInstanceId"] = request.FormInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryFormInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFormInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据表单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// QueryFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFormInstanceResponse
        /// </returns>
        public async Task<QueryFormInstanceResponse> QueryFormInstanceWithOptionsAsync(QueryFormInstanceRequest request, QueryFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                query["formInstanceId"] = request.FormInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryFormInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFormInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据表单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFormInstanceResponse
        /// </returns>
        public QueryFormInstanceResponse QueryFormInstance(QueryFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormInstanceHeaders headers = new QueryFormInstanceHeaders();
            return QueryFormInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据表单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFormInstanceResponse
        /// </returns>
        public async Task<QueryFormInstanceResponse> QueryFormInstanceAsync(QueryFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormInstanceHeaders headers = new QueryFormInstanceHeaders();
            return await QueryFormInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询通过流程中心集成的OA审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIntegratedTodoTaskRequest
        /// </param>
        /// <param name="headers">
        /// QueryIntegratedTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIntegratedTodoTaskResponse
        /// </returns>
        public QueryIntegratedTodoTaskResponse QueryIntegratedTodoTaskWithOptions(QueryIntegratedTodoTaskRequest request, QueryIntegratedTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateBefore))
            {
                query["createBefore"] = request.CreateBefore;
            }
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
                Action = "QueryIntegratedTodoTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/todoTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntegratedTodoTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询通过流程中心集成的OA审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIntegratedTodoTaskRequest
        /// </param>
        /// <param name="headers">
        /// QueryIntegratedTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIntegratedTodoTaskResponse
        /// </returns>
        public async Task<QueryIntegratedTodoTaskResponse> QueryIntegratedTodoTaskWithOptionsAsync(QueryIntegratedTodoTaskRequest request, QueryIntegratedTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateBefore))
            {
                query["createBefore"] = request.CreateBefore;
            }
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
                Action = "QueryIntegratedTodoTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/todoTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntegratedTodoTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询通过流程中心集成的OA审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIntegratedTodoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIntegratedTodoTaskResponse
        /// </returns>
        public QueryIntegratedTodoTaskResponse QueryIntegratedTodoTask(QueryIntegratedTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryIntegratedTodoTaskHeaders headers = new QueryIntegratedTodoTaskHeaders();
            return QueryIntegratedTodoTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询通过流程中心集成的OA审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIntegratedTodoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIntegratedTodoTaskResponse
        /// </returns>
        public async Task<QueryIntegratedTodoTaskResponse> QueryIntegratedTodoTaskAsync(QueryIntegratedTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryIntegratedTodoTaskHeaders headers = new QueryIntegratedTodoTaskHeaders();
            return await QueryIntegratedTodoTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据业务标识查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessByBizCategoryIdRequest
        /// </param>
        /// <param name="headers">
        /// QueryProcessByBizCategoryIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessByBizCategoryIdResponse
        /// </returns>
        public QueryProcessByBizCategoryIdResponse QueryProcessByBizCategoryIdWithOptions(QueryProcessByBizCategoryIdRequest request, QueryProcessByBizCategoryIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
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
                Action = "QueryProcessByBizCategoryId",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/categories/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProcessByBizCategoryIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据业务标识查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessByBizCategoryIdRequest
        /// </param>
        /// <param name="headers">
        /// QueryProcessByBizCategoryIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessByBizCategoryIdResponse
        /// </returns>
        public async Task<QueryProcessByBizCategoryIdResponse> QueryProcessByBizCategoryIdWithOptionsAsync(QueryProcessByBizCategoryIdRequest request, QueryProcessByBizCategoryIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
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
                Action = "QueryProcessByBizCategoryId",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processes/categories/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProcessByBizCategoryIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据业务标识查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessByBizCategoryIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessByBizCategoryIdResponse
        /// </returns>
        public QueryProcessByBizCategoryIdResponse QueryProcessByBizCategoryId(QueryProcessByBizCategoryIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessByBizCategoryIdHeaders headers = new QueryProcessByBizCategoryIdHeaders();
            return QueryProcessByBizCategoryIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据业务标识查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessByBizCategoryIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessByBizCategoryIdResponse
        /// </returns>
        public async Task<QueryProcessByBizCategoryIdResponse> QueryProcessByBizCategoryIdAsync(QueryProcessByBizCategoryIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessByBizCategoryIdHeaders headers = new QueryProcessByBizCategoryIdHeaders();
            return await QueryProcessByBizCategoryIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>蓝凌获取schema和流程信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySchemaAndProcessRequest
        /// </param>
        /// <param name="headers">
        /// QuerySchemaAndProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySchemaAndProcessResponse
        /// </returns>
        public QuerySchemaAndProcessResponse QuerySchemaAndProcessWithOptions(QuerySchemaAndProcessRequest request, QuerySchemaAndProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QuerySchemaAndProcess",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms/schemaAndProcess",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySchemaAndProcessResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>蓝凌获取schema和流程信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySchemaAndProcessRequest
        /// </param>
        /// <param name="headers">
        /// QuerySchemaAndProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySchemaAndProcessResponse
        /// </returns>
        public async Task<QuerySchemaAndProcessResponse> QuerySchemaAndProcessWithOptionsAsync(QuerySchemaAndProcessRequest request, QuerySchemaAndProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QuerySchemaAndProcess",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms/schemaAndProcess",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySchemaAndProcessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>蓝凌获取schema和流程信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySchemaAndProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySchemaAndProcessResponse
        /// </returns>
        public QuerySchemaAndProcessResponse QuerySchemaAndProcess(QuerySchemaAndProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaAndProcessHeaders headers = new QuerySchemaAndProcessHeaders();
            return QuerySchemaAndProcessWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>蓝凌获取schema和流程信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySchemaAndProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySchemaAndProcessResponse
        /// </returns>
        public async Task<QuerySchemaAndProcessResponse> QuerySchemaAndProcessAsync(QuerySchemaAndProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaAndProcessHeaders headers = new QuerySchemaAndProcessHeaders();
            return await QuerySchemaAndProcessWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过 processCode 获取表单 schema 信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySchemaByProcessCodeRequest
        /// </param>
        /// <param name="headers">
        /// QuerySchemaByProcessCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySchemaByProcessCodeResponse
        /// </returns>
        public QuerySchemaByProcessCodeResponse QuerySchemaByProcessCodeWithOptions(QuerySchemaByProcessCodeRequest request, QuerySchemaByProcessCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QuerySchemaByProcessCode",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms/schemas/processCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySchemaByProcessCodeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过 processCode 获取表单 schema 信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySchemaByProcessCodeRequest
        /// </param>
        /// <param name="headers">
        /// QuerySchemaByProcessCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySchemaByProcessCodeResponse
        /// </returns>
        public async Task<QuerySchemaByProcessCodeResponse> QuerySchemaByProcessCodeWithOptionsAsync(QuerySchemaByProcessCodeRequest request, QuerySchemaByProcessCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUuid))
            {
                query["appUuid"] = request.AppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QuerySchemaByProcessCode",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/forms/schemas/processCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySchemaByProcessCodeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过 processCode 获取表单 schema 信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySchemaByProcessCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySchemaByProcessCodeResponse
        /// </returns>
        public QuerySchemaByProcessCodeResponse QuerySchemaByProcessCode(QuerySchemaByProcessCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaByProcessCodeHeaders headers = new QuerySchemaByProcessCodeHeaders();
            return QuerySchemaByProcessCodeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过 processCode 获取表单 schema 信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySchemaByProcessCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySchemaByProcessCodeResponse
        /// </returns>
        public async Task<QuerySchemaByProcessCodeResponse> QuerySchemaByProcessCodeAsync(QuerySchemaByProcessCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaByProcessCodeHeaders headers = new QuerySchemaByProcessCodeHeaders();
            return await QuerySchemaByProcessCodeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转交OA审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RedirectWorkflowTaskRequest
        /// </param>
        /// <param name="headers">
        /// RedirectWorkflowTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RedirectWorkflowTaskResponse
        /// </returns>
        public RedirectWorkflowTaskResponse RedirectWorkflowTaskWithOptions(RedirectWorkflowTaskRequest request, RedirectWorkflowTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionName))
            {
                body["actionName"] = request.ActionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                body["file"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToUserId))
            {
                body["toUserId"] = request.ToUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RedirectWorkflowTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/tasks/redirect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RedirectWorkflowTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转交OA审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RedirectWorkflowTaskRequest
        /// </param>
        /// <param name="headers">
        /// RedirectWorkflowTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RedirectWorkflowTaskResponse
        /// </returns>
        public async Task<RedirectWorkflowTaskResponse> RedirectWorkflowTaskWithOptionsAsync(RedirectWorkflowTaskRequest request, RedirectWorkflowTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionName))
            {
                body["actionName"] = request.ActionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                body["file"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToUserId))
            {
                body["toUserId"] = request.ToUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RedirectWorkflowTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/tasks/redirect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RedirectWorkflowTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转交OA审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RedirectWorkflowTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RedirectWorkflowTaskResponse
        /// </returns>
        public RedirectWorkflowTaskResponse RedirectWorkflowTask(RedirectWorkflowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RedirectWorkflowTaskHeaders headers = new RedirectWorkflowTaskHeaders();
            return RedirectWorkflowTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>转交OA审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RedirectWorkflowTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RedirectWorkflowTaskResponse
        /// </returns>
        public async Task<RedirectWorkflowTaskResponse> RedirectWorkflowTaskAsync(RedirectWorkflowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RedirectWorkflowTaskHeaders headers = new RedirectWorkflowTaskHeaders();
            return await RedirectWorkflowTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveIntegratedInstanceRequest
        /// </param>
        /// <param name="headers">
        /// SaveIntegratedInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveIntegratedInstanceResponse
        /// </returns>
        public SaveIntegratedInstanceResponse SaveIntegratedInstanceWithOptions(SaveIntegratedInstanceRequest request, SaveIntegratedInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizData))
            {
                body["bizData"] = request.BizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConfig))
            {
                body["featureConfig"] = request.FeatureConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValueList))
            {
                body["formComponentValueList"] = request.FormComponentValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notifiers))
            {
                body["notifiers"] = request.Notifiers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorUserId))
            {
                body["originatorUserId"] = request.OriginatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveIntegratedInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveIntegratedInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveIntegratedInstanceRequest
        /// </param>
        /// <param name="headers">
        /// SaveIntegratedInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveIntegratedInstanceResponse
        /// </returns>
        public async Task<SaveIntegratedInstanceResponse> SaveIntegratedInstanceWithOptionsAsync(SaveIntegratedInstanceRequest request, SaveIntegratedInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizData))
            {
                body["bizData"] = request.BizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConfig))
            {
                body["featureConfig"] = request.FeatureConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValueList))
            {
                body["formComponentValueList"] = request.FormComponentValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notifiers))
            {
                body["notifiers"] = request.Notifiers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorUserId))
            {
                body["originatorUserId"] = request.OriginatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveIntegratedInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveIntegratedInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveIntegratedInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveIntegratedInstanceResponse
        /// </returns>
        public SaveIntegratedInstanceResponse SaveIntegratedInstance(SaveIntegratedInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveIntegratedInstanceHeaders headers = new SaveIntegratedInstanceHeaders();
            return SaveIntegratedInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveIntegratedInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveIntegratedInstanceResponse
        /// </returns>
        public async Task<SaveIntegratedInstanceResponse> SaveIntegratedInstanceAsync(SaveIntegratedInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveIntegratedInstanceHeaders headers = new SaveIntegratedInstanceHeaders();
            return await SaveIntegratedInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新审批模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveProcessRequest
        /// </param>
        /// <param name="headers">
        /// SaveProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveProcessResponse
        /// </returns>
        public SaveProcessResponse SaveProcessWithOptions(SaveProcessRequest request, SaveProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponents))
            {
                body["formComponents"] = request.FormComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessFeatureConfig))
            {
                body["processFeatureConfig"] = request.ProcessFeatureConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                body["templateConfig"] = request.TemplateConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveProcess",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/schemas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveProcessResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新审批模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveProcessRequest
        /// </param>
        /// <param name="headers">
        /// SaveProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveProcessResponse
        /// </returns>
        public async Task<SaveProcessResponse> SaveProcessWithOptionsAsync(SaveProcessRequest request, SaveProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponents))
            {
                body["formComponents"] = request.FormComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessFeatureConfig))
            {
                body["processFeatureConfig"] = request.ProcessFeatureConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                body["templateConfig"] = request.TemplateConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveProcess",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/schemas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveProcessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新审批模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveProcessResponse
        /// </returns>
        public SaveProcessResponse SaveProcess(SaveProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveProcessHeaders headers = new SaveProcessHeaders();
            return SaveProcessWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新审批模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveProcessResponse
        /// </returns>
        public async Task<SaveProcessResponse> SaveProcessAsync(SaveProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveProcessHeaders headers = new SaveProcessHeaders();
            return await SaveProcessWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建审批实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// StartProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartProcessInstanceResponse
        /// </returns>
        public StartProcessInstanceResponse StartProcessInstanceWithOptions(StartProcessInstanceRequest request, StartProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Approvers))
            {
                body["approvers"] = request.Approvers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CcList))
            {
                body["ccList"] = request.CcList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CcPosition))
            {
                body["ccPosition"] = request.CcPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValues))
            {
                body["formComponentValues"] = request.FormComponentValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorUserId))
            {
                body["originatorUserId"] = request.OriginatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSelectActioners))
            {
                body["targetSelectActioners"] = request.TargetSelectActioners;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "StartProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartProcessInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建审批实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// StartProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartProcessInstanceResponse
        /// </returns>
        public async Task<StartProcessInstanceResponse> StartProcessInstanceWithOptionsAsync(StartProcessInstanceRequest request, StartProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Approvers))
            {
                body["approvers"] = request.Approvers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CcList))
            {
                body["ccList"] = request.CcList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CcPosition))
            {
                body["ccPosition"] = request.CcPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormComponentValues))
            {
                body["formComponentValues"] = request.FormComponentValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorUserId))
            {
                body["originatorUserId"] = request.OriginatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSelectActioners))
            {
                body["targetSelectActioners"] = request.TargetSelectActioners;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "StartProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartProcessInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建审批实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartProcessInstanceResponse
        /// </returns>
        public StartProcessInstanceResponse StartProcessInstance(StartProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartProcessInstanceHeaders headers = new StartProcessInstanceHeaders();
            return StartProcessInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建审批实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartProcessInstanceResponse
        /// </returns>
        public async Task<StartProcessInstanceResponse> StartProcessInstanceAsync(StartProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartProcessInstanceHeaders headers = new StartProcessInstanceHeaders();
            return await StartProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销审批实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// TerminateProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateProcessInstanceResponse
        /// </returns>
        public TerminateProcessInstanceResponse TerminateProcessInstanceWithOptions(TerminateProcessInstanceRequest request, TerminateProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSystem))
            {
                body["isSystem"] = request.IsSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingUserId))
            {
                body["operatingUserId"] = request.OperatingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TerminateProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/terminate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateProcessInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销审批实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// TerminateProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateProcessInstanceResponse
        /// </returns>
        public async Task<TerminateProcessInstanceResponse> TerminateProcessInstanceWithOptionsAsync(TerminateProcessInstanceRequest request, TerminateProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSystem))
            {
                body["isSystem"] = request.IsSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingUserId))
            {
                body["operatingUserId"] = request.OperatingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TerminateProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processInstances/terminate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateProcessInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销审批实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateProcessInstanceResponse
        /// </returns>
        public TerminateProcessInstanceResponse TerminateProcessInstance(TerminateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TerminateProcessInstanceHeaders headers = new TerminateProcessInstanceHeaders();
            return TerminateProcessInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销审批实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateProcessInstanceResponse
        /// </returns>
        public async Task<TerminateProcessInstanceResponse> TerminateProcessInstanceAsync(TerminateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TerminateProcessInstanceHeaders headers = new TerminateProcessInstanceHeaders();
            return await TerminateProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流程转交待处理任务查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TodoTasksRequest
        /// </param>
        /// <param name="headers">
        /// TodoTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TodoTasksResponse
        /// </returns>
        public TodoTasksResponse TodoTasksWithOptions(TodoTasksRequest request, TodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionerUserId))
            {
                query["actionerUserId"] = request.ActionerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
            }
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
                Action = "TodoTasks",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/tasks/todoTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TodoTasksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流程转交待处理任务查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TodoTasksRequest
        /// </param>
        /// <param name="headers">
        /// TodoTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TodoTasksResponse
        /// </returns>
        public async Task<TodoTasksResponse> TodoTasksWithOptionsAsync(TodoTasksRequest request, TodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionerUserId))
            {
                query["actionerUserId"] = request.ActionerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
            }
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
                Action = "TodoTasks",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/tasks/todoTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TodoTasksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流程转交待处理任务查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TodoTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// TodoTasksResponse
        /// </returns>
        public TodoTasksResponse TodoTasks(TodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TodoTasksHeaders headers = new TodoTasksHeaders();
            return TodoTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流程转交待处理任务查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TodoTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// TodoTasksResponse
        /// </returns>
        public async Task<TodoTasksResponse> TodoTasksAsync(TodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TodoTasksHeaders headers = new TodoTasksHeaders();
            return await TodoTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程中心任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIntegratedTaskRequest
        /// </param>
        /// <param name="headers">
        /// UpdateIntegratedTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIntegratedTaskResponse
        /// </returns>
        public UpdateIntegratedTaskResponse UpdateIntegratedTaskWithOptions(UpdateIntegratedTaskRequest request, UpdateIntegratedTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tasks))
            {
                body["tasks"] = request.Tasks;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateIntegratedTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/tasks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIntegratedTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程中心任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIntegratedTaskRequest
        /// </param>
        /// <param name="headers">
        /// UpdateIntegratedTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIntegratedTaskResponse
        /// </returns>
        public async Task<UpdateIntegratedTaskResponse> UpdateIntegratedTaskWithOptionsAsync(UpdateIntegratedTaskRequest request, UpdateIntegratedTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tasks))
            {
                body["tasks"] = request.Tasks;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateIntegratedTask",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/tasks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIntegratedTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程中心任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIntegratedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIntegratedTaskResponse
        /// </returns>
        public UpdateIntegratedTaskResponse UpdateIntegratedTask(UpdateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIntegratedTaskHeaders headers = new UpdateIntegratedTaskHeaders();
            return UpdateIntegratedTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程中心任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIntegratedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIntegratedTaskResponse
        /// </returns>
        public async Task<UpdateIntegratedTaskResponse> UpdateIntegratedTaskAsync(UpdateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIntegratedTaskHeaders headers = new UpdateIntegratedTaskHeaders();
            return await UpdateIntegratedTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProcessInstanceResponse
        /// </returns>
        public UpdateProcessInstanceResponse UpdateProcessInstanceWithOptions(UpdateProcessInstanceRequest request, UpdateProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notifiers))
            {
                body["notifiers"] = request.Notifiers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                body["result"] = request.Result;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProcessInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProcessInstanceResponse
        /// </returns>
        public async Task<UpdateProcessInstanceResponse> UpdateProcessInstanceWithOptionsAsync(UpdateProcessInstanceRequest request, UpdateProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notifiers))
            {
                body["notifiers"] = request.Notifiers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                body["result"] = request.Result;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateProcessInstance",
                Version = "workflow_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workflow/processCentres/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProcessInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProcessInstanceResponse
        /// </returns>
        public UpdateProcessInstanceResponse UpdateProcessInstance(UpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProcessInstanceHeaders headers = new UpdateProcessInstanceHeaders();
            return UpdateProcessInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProcessInstanceResponse
        /// </returns>
        public async Task<UpdateProcessInstanceResponse> UpdateProcessInstanceAsync(UpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProcessInstanceHeaders headers = new UpdateProcessInstanceHeaders();
            return await UpdateProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

    }
}
