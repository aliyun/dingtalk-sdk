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


        /**
         * @summary 授权下载审批钉盘文件
         *
         * @param request AddApproveDentryAuthRequest
         * @param headers AddApproveDentryAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddApproveDentryAuthResponse
         */
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

        /**
         * @summary 授权下载审批钉盘文件
         *
         * @param request AddApproveDentryAuthRequest
         * @param headers AddApproveDentryAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddApproveDentryAuthResponse
         */
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

        /**
         * @summary 授权下载审批钉盘文件
         *
         * @param request AddApproveDentryAuthRequest
         * @return AddApproveDentryAuthResponse
         */
        public AddApproveDentryAuthResponse AddApproveDentryAuth(AddApproveDentryAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddApproveDentryAuthHeaders headers = new AddApproveDentryAuthHeaders();
            return AddApproveDentryAuthWithOptions(request, headers, runtime);
        }

        /**
         * @summary 授权下载审批钉盘文件
         *
         * @param request AddApproveDentryAuthRequest
         * @return AddApproveDentryAuthResponse
         */
        public async Task<AddApproveDentryAuthResponse> AddApproveDentryAuthAsync(AddApproveDentryAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddApproveDentryAuthHeaders headers = new AddApproveDentryAuthHeaders();
            return await AddApproveDentryAuthWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加审批评论
         *
         * @param request AddProcessInstanceCommentRequest
         * @param headers AddProcessInstanceCommentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddProcessInstanceCommentResponse
         */
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

        /**
         * @summary 添加审批评论
         *
         * @param request AddProcessInstanceCommentRequest
         * @param headers AddProcessInstanceCommentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddProcessInstanceCommentResponse
         */
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

        /**
         * @summary 添加审批评论
         *
         * @param request AddProcessInstanceCommentRequest
         * @return AddProcessInstanceCommentResponse
         */
        public AddProcessInstanceCommentResponse AddProcessInstanceComment(AddProcessInstanceCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProcessInstanceCommentHeaders headers = new AddProcessInstanceCommentHeaders();
            return AddProcessInstanceCommentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加审批评论
         *
         * @param request AddProcessInstanceCommentRequest
         * @return AddProcessInstanceCommentResponse
         */
        public async Task<AddProcessInstanceCommentResponse> AddProcessInstanceCommentAsync(AddProcessInstanceCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProcessInstanceCommentHeaders headers = new AddProcessInstanceCommentHeaders();
            return await AddProcessInstanceCommentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量同意或拒绝审批任务
         *
         * @param request BatchExecuteProcessInstancesRequest
         * @param headers BatchExecuteProcessInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchExecuteProcessInstancesResponse
         */
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

        /**
         * @summary 批量同意或拒绝审批任务
         *
         * @param request BatchExecuteProcessInstancesRequest
         * @param headers BatchExecuteProcessInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchExecuteProcessInstancesResponse
         */
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

        /**
         * @summary 批量同意或拒绝审批任务
         *
         * @param request BatchExecuteProcessInstancesRequest
         * @return BatchExecuteProcessInstancesResponse
         */
        public BatchExecuteProcessInstancesResponse BatchExecuteProcessInstances(BatchExecuteProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchExecuteProcessInstancesHeaders headers = new BatchExecuteProcessInstancesHeaders();
            return BatchExecuteProcessInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量同意或拒绝审批任务
         *
         * @param request BatchExecuteProcessInstancesRequest
         * @return BatchExecuteProcessInstancesResponse
         */
        public async Task<BatchExecuteProcessInstancesResponse> BatchExecuteProcessInstancesAsync(BatchExecuteProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchExecuteProcessInstancesHeaders headers = new BatchExecuteProcessInstancesHeaders();
            return await BatchExecuteProcessInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量流程审批任务转交
         *
         * @param request BatchTasksRedirectRequest
         * @param headers BatchTasksRedirectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchTasksRedirectResponse
         */
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

        /**
         * @summary 批量流程审批任务转交
         *
         * @param request BatchTasksRedirectRequest
         * @param headers BatchTasksRedirectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchTasksRedirectResponse
         */
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

        /**
         * @summary 批量流程审批任务转交
         *
         * @param request BatchTasksRedirectRequest
         * @return BatchTasksRedirectResponse
         */
        public BatchTasksRedirectResponse BatchTasksRedirect(BatchTasksRedirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchTasksRedirectHeaders headers = new BatchTasksRedirectHeaders();
            return BatchTasksRedirectWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量流程审批任务转交
         *
         * @param request BatchTasksRedirectRequest
         * @return BatchTasksRedirectResponse
         */
        public async Task<BatchTasksRedirectResponse> BatchTasksRedirectAsync(BatchTasksRedirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchTasksRedirectHeaders headers = new BatchTasksRedirectHeaders();
            return await BatchTasksRedirectWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量更新实例状态
         *
         * @param request BatchUpdateProcessInstanceRequest
         * @param headers BatchUpdateProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchUpdateProcessInstanceResponse
         */
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

        /**
         * @summary 批量更新实例状态
         *
         * @param request BatchUpdateProcessInstanceRequest
         * @param headers BatchUpdateProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchUpdateProcessInstanceResponse
         */
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

        /**
         * @summary 批量更新实例状态
         *
         * @param request BatchUpdateProcessInstanceRequest
         * @return BatchUpdateProcessInstanceResponse
         */
        public BatchUpdateProcessInstanceResponse BatchUpdateProcessInstance(BatchUpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateProcessInstanceHeaders headers = new BatchUpdateProcessInstanceHeaders();
            return BatchUpdateProcessInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量更新实例状态
         *
         * @param request BatchUpdateProcessInstanceRequest
         * @return BatchUpdateProcessInstanceResponse
         */
        public async Task<BatchUpdateProcessInstanceResponse> BatchUpdateProcessInstanceAsync(BatchUpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateProcessInstanceHeaders headers = new BatchUpdateProcessInstanceHeaders();
            return await BatchUpdateProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量取消流程中心待处理任务
         *
         * @param request CancelIntegratedTaskRequest
         * @param headers CancelIntegratedTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelIntegratedTaskResponse
         */
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

        /**
         * @summary 批量取消流程中心待处理任务
         *
         * @param request CancelIntegratedTaskRequest
         * @param headers CancelIntegratedTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelIntegratedTaskResponse
         */
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

        /**
         * @summary 批量取消流程中心待处理任务
         *
         * @param request CancelIntegratedTaskRequest
         * @return CancelIntegratedTaskResponse
         */
        public CancelIntegratedTaskResponse CancelIntegratedTask(CancelIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelIntegratedTaskHeaders headers = new CancelIntegratedTaskHeaders();
            return CancelIntegratedTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量取消流程中心待处理任务
         *
         * @param request CancelIntegratedTaskRequest
         * @return CancelIntegratedTaskResponse
         */
        public async Task<CancelIntegratedTaskResponse> CancelIntegratedTaskAsync(CancelIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelIntegratedTaskHeaders headers = new CancelIntegratedTaskHeaders();
            return await CancelIntegratedTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 清理审批数据
         *
         * @param request CleanProcessDataRequest
         * @param headers CleanProcessDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CleanProcessDataResponse
         */
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

        /**
         * @summary 清理审批数据
         *
         * @param request CleanProcessDataRequest
         * @param headers CleanProcessDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CleanProcessDataResponse
         */
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

        /**
         * @summary 清理审批数据
         *
         * @param request CleanProcessDataRequest
         * @return CleanProcessDataResponse
         */
        public CleanProcessDataResponse CleanProcessData(CleanProcessDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CleanProcessDataHeaders headers = new CleanProcessDataHeaders();
            return CleanProcessDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 清理审批数据
         *
         * @param request CleanProcessDataRequest
         * @return CleanProcessDataResponse
         */
        public async Task<CleanProcessDataResponse> CleanProcessDataAsync(CleanProcessDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CleanProcessDataHeaders headers = new CleanProcessDataHeaders();
            return await CleanProcessDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 复制审批流
         *
         * @param request CopyProcessRequest
         * @param headers CopyProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyProcessResponse
         */
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

        /**
         * @summary 复制审批流
         *
         * @param request CopyProcessRequest
         * @param headers CopyProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyProcessResponse
         */
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

        /**
         * @summary 复制审批流
         *
         * @param request CopyProcessRequest
         * @return CopyProcessResponse
         */
        public CopyProcessResponse CopyProcess(CopyProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyProcessHeaders headers = new CopyProcessHeaders();
            return CopyProcessWithOptions(request, headers, runtime);
        }

        /**
         * @summary 复制审批流
         *
         * @param request CopyProcessRequest
         * @return CopyProcessResponse
         */
        public async Task<CopyProcessResponse> CopyProcessAsync(CopyProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyProcessHeaders headers = new CopyProcessHeaders();
            return await CopyProcessWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建流程中心待处理任务
         *
         * @param request CreateIntegratedTaskRequest
         * @param headers CreateIntegratedTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIntegratedTaskResponse
         */
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

        /**
         * @summary 创建流程中心待处理任务
         *
         * @param request CreateIntegratedTaskRequest
         * @param headers CreateIntegratedTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIntegratedTaskResponse
         */
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

        /**
         * @summary 创建流程中心待处理任务
         *
         * @param request CreateIntegratedTaskRequest
         * @return CreateIntegratedTaskResponse
         */
        public CreateIntegratedTaskResponse CreateIntegratedTask(CreateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateIntegratedTaskHeaders headers = new CreateIntegratedTaskHeaders();
            return CreateIntegratedTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建流程中心待处理任务
         *
         * @param request CreateIntegratedTaskRequest
         * @return CreateIntegratedTaskResponse
         */
        public async Task<CreateIntegratedTaskResponse> CreateIntegratedTaskAsync(CreateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateIntegratedTaskHeaders headers = new CreateIntegratedTaskHeaders();
            return await CreateIntegratedTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除分组
         *
         * @param request DeleteDirRequest
         * @param headers DeleteDirHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDirResponse
         */
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

        /**
         * @summary 删除分组
         *
         * @param request DeleteDirRequest
         * @param headers DeleteDirHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDirResponse
         */
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

        /**
         * @summary 删除分组
         *
         * @param request DeleteDirRequest
         * @return DeleteDirResponse
         */
        public DeleteDirResponse DeleteDir(DeleteDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDirHeaders headers = new DeleteDirHeaders();
            return DeleteDirWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除分组
         *
         * @param request DeleteDirRequest
         * @return DeleteDirResponse
         */
        public async Task<DeleteDirResponse> DeleteDirAsync(DeleteDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDirHeaders headers = new DeleteDirHeaders();
            return await DeleteDirWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除模板
         *
         * @param request DeleteProcessRequest
         * @param headers DeleteProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProcessResponse
         */
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

        /**
         * @summary 删除模板
         *
         * @param request DeleteProcessRequest
         * @param headers DeleteProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProcessResponse
         */
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

        /**
         * @summary 删除模板
         *
         * @param request DeleteProcessRequest
         * @return DeleteProcessResponse
         */
        public DeleteProcessResponse DeleteProcess(DeleteProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProcessHeaders headers = new DeleteProcessHeaders();
            return DeleteProcessWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除模板
         *
         * @param request DeleteProcessRequest
         * @return DeleteProcessResponse
         */
        public async Task<DeleteProcessResponse> DeleteProcessAsync(DeleteProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProcessHeaders headers = new DeleteProcessHeaders();
            return await DeleteProcessWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 同意或拒绝审批任务
         *
         * @param request ExecuteProcessInstanceRequest
         * @param headers ExecuteProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteProcessInstanceResponse
         */
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

        /**
         * @summary 同意或拒绝审批任务
         *
         * @param request ExecuteProcessInstanceRequest
         * @param headers ExecuteProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteProcessInstanceResponse
         */
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

        /**
         * @summary 同意或拒绝审批任务
         *
         * @param request ExecuteProcessInstanceRequest
         * @return ExecuteProcessInstanceResponse
         */
        public ExecuteProcessInstanceResponse ExecuteProcessInstance(ExecuteProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteProcessInstanceHeaders headers = new ExecuteProcessInstanceHeaders();
            return ExecuteProcessInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 同意或拒绝审批任务
         *
         * @param request ExecuteProcessInstanceRequest
         * @return ExecuteProcessInstanceResponse
         */
        public async Task<ExecuteProcessInstanceResponse> ExecuteProcessInstanceAsync(ExecuteProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteProcessInstanceHeaders headers = new ExecuteProcessInstanceHeaders();
            return await ExecuteProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建或更新审批表单模板
         *
         * @param request FormCreateRequest
         * @param headers FormCreateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FormCreateResponse
         */
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

        /**
         * @summary 创建或更新审批表单模板
         *
         * @param request FormCreateRequest
         * @param headers FormCreateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FormCreateResponse
         */
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

        /**
         * @summary 创建或更新审批表单模板
         *
         * @param request FormCreateRequest
         * @return FormCreateResponse
         */
        public FormCreateResponse FormCreate(FormCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FormCreateHeaders headers = new FormCreateHeaders();
            return FormCreateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建或更新审批表单模板
         *
         * @param request FormCreateRequest
         * @return FormCreateResponse
         */
        public async Task<FormCreateResponse> FormCreateAsync(FormCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FormCreateHeaders headers = new FormCreateHeaders();
            return await FormCreateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取审批钉盘空间信息
         *
         * @param request GetAttachmentSpaceRequest
         * @param headers GetAttachmentSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAttachmentSpaceResponse
         */
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

        /**
         * @summary 获取审批钉盘空间信息
         *
         * @param request GetAttachmentSpaceRequest
         * @param headers GetAttachmentSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAttachmentSpaceResponse
         */
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

        /**
         * @summary 获取审批钉盘空间信息
         *
         * @param request GetAttachmentSpaceRequest
         * @return GetAttachmentSpaceResponse
         */
        public GetAttachmentSpaceResponse GetAttachmentSpace(GetAttachmentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachmentSpaceHeaders headers = new GetAttachmentSpaceHeaders();
            return GetAttachmentSpaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取审批钉盘空间信息
         *
         * @param request GetAttachmentSpaceRequest
         * @return GetAttachmentSpaceResponse
         */
        public async Task<GetAttachmentSpaceResponse> GetAttachmentSpaceAsync(GetAttachmentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachmentSpaceHeaders headers = new GetAttachmentSpaceHeaders();
            return await GetAttachmentSpaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询已设置为条件的表单组件
         *
         * @param request GetConditionFormComponentRequest
         * @param headers GetConditionFormComponentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConditionFormComponentResponse
         */
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

        /**
         * @summary 查询已设置为条件的表单组件
         *
         * @param request GetConditionFormComponentRequest
         * @param headers GetConditionFormComponentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConditionFormComponentResponse
         */
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

        /**
         * @summary 查询已设置为条件的表单组件
         *
         * @param request GetConditionFormComponentRequest
         * @return GetConditionFormComponentResponse
         */
        public GetConditionFormComponentResponse GetConditionFormComponent(GetConditionFormComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConditionFormComponentHeaders headers = new GetConditionFormComponentHeaders();
            return GetConditionFormComponentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询已设置为条件的表单组件
         *
         * @param request GetConditionFormComponentRequest
         * @return GetConditionFormComponentResponse
         */
        public async Task<GetConditionFormComponentResponse> GetConditionFormComponentAsync(GetConditionFormComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConditionFormComponentHeaders headers = new GetConditionFormComponentHeaders();
            return await GetConditionFormComponentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取CRM所有流程code
         *
         * @param headers GetCrmProcCodesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCrmProcCodesResponse
         */
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

        /**
         * @summary 获取CRM所有流程code
         *
         * @param headers GetCrmProcCodesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCrmProcCodesResponse
         */
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

        /**
         * @summary 获取CRM所有流程code
         *
         * @return GetCrmProcCodesResponse
         */
        public GetCrmProcCodesResponse GetCrmProcCodes()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmProcCodesHeaders headers = new GetCrmProcCodesHeaders();
            return GetCrmProcCodesWithOptions(headers, runtime);
        }

        /**
         * @summary 获取CRM所有流程code
         *
         * @return GetCrmProcCodesResponse
         */
        public async Task<GetCrmProcCodesResponse> GetCrmProcCodesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmProcCodesHeaders headers = new GetCrmProcCodesHeaders();
            return await GetCrmProcCodesWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取表单字段修改历史
         *
         * @param request GetFieldModifiedHistoryRequest
         * @param headers GetFieldModifiedHistoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFieldModifiedHistoryResponse
         */
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

        /**
         * @summary 获取表单字段修改历史
         *
         * @param request GetFieldModifiedHistoryRequest
         * @param headers GetFieldModifiedHistoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFieldModifiedHistoryResponse
         */
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

        /**
         * @summary 获取表单字段修改历史
         *
         * @param request GetFieldModifiedHistoryRequest
         * @return GetFieldModifiedHistoryResponse
         */
        public GetFieldModifiedHistoryResponse GetFieldModifiedHistory(GetFieldModifiedHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFieldModifiedHistoryHeaders headers = new GetFieldModifiedHistoryHeaders();
            return GetFieldModifiedHistoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取表单字段修改历史
         *
         * @param request GetFieldModifiedHistoryRequest
         * @return GetFieldModifiedHistoryResponse
         */
        public async Task<GetFieldModifiedHistoryResponse> GetFieldModifiedHistoryAsync(GetFieldModifiedHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFieldModifiedHistoryHeaders headers = new GetFieldModifiedHistoryHeaders();
            return await GetFieldModifiedHistoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取手写签名的下载链接
         *
         * @param request GetHandSignDownloadUrlRequest
         * @param headers GetHandSignDownloadUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHandSignDownloadUrlResponse
         */
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

        /**
         * @summary 获取手写签名的下载链接
         *
         * @param request GetHandSignDownloadUrlRequest
         * @param headers GetHandSignDownloadUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHandSignDownloadUrlResponse
         */
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

        /**
         * @summary 获取手写签名的下载链接
         *
         * @param request GetHandSignDownloadUrlRequest
         * @return GetHandSignDownloadUrlResponse
         */
        public GetHandSignDownloadUrlResponse GetHandSignDownloadUrl(GetHandSignDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHandSignDownloadUrlHeaders headers = new GetHandSignDownloadUrlHeaders();
            return GetHandSignDownloadUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取手写签名的下载链接
         *
         * @param request GetHandSignDownloadUrlRequest
         * @return GetHandSignDownloadUrlResponse
         */
        public async Task<GetHandSignDownloadUrlResponse> GetHandSignDownloadUrlAsync(GetHandSignDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHandSignDownloadUrlHeaders headers = new GetHandSignDownloadUrlHeaders();
            return await GetHandSignDownloadUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取当前企业所有可管理的表单
         *
         * @param request GetManageProcessByStaffIdRequest
         * @param headers GetManageProcessByStaffIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetManageProcessByStaffIdResponse
         */
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

        /**
         * @summary 获取当前企业所有可管理的表单
         *
         * @param request GetManageProcessByStaffIdRequest
         * @param headers GetManageProcessByStaffIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetManageProcessByStaffIdResponse
         */
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

        /**
         * @summary 获取当前企业所有可管理的表单
         *
         * @param request GetManageProcessByStaffIdRequest
         * @return GetManageProcessByStaffIdResponse
         */
        public GetManageProcessByStaffIdResponse GetManageProcessByStaffId(GetManageProcessByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetManageProcessByStaffIdHeaders headers = new GetManageProcessByStaffIdHeaders();
            return GetManageProcessByStaffIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取当前企业所有可管理的表单
         *
         * @param request GetManageProcessByStaffIdRequest
         * @return GetManageProcessByStaffIdResponse
         */
        public async Task<GetManageProcessByStaffIdResponse> GetManageProcessByStaffIdAsync(GetManageProcessByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetManageProcessByStaffIdHeaders headers = new GetManageProcessByStaffIdHeaders();
            return await GetManageProcessByStaffIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取模板code
         *
         * @param request GetProcessCodeByNameRequest
         * @param headers GetProcessCodeByNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProcessCodeByNameResponse
         */
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

        /**
         * @summary 获取模板code
         *
         * @param request GetProcessCodeByNameRequest
         * @param headers GetProcessCodeByNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProcessCodeByNameResponse
         */
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

        /**
         * @summary 获取模板code
         *
         * @param request GetProcessCodeByNameRequest
         * @return GetProcessCodeByNameResponse
         */
        public GetProcessCodeByNameResponse GetProcessCodeByName(GetProcessCodeByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessCodeByNameHeaders headers = new GetProcessCodeByNameHeaders();
            return GetProcessCodeByNameWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取模板code
         *
         * @param request GetProcessCodeByNameRequest
         * @return GetProcessCodeByNameResponse
         */
        public async Task<GetProcessCodeByNameResponse> GetProcessCodeByNameAsync(GetProcessCodeByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessCodeByNameHeaders headers = new GetProcessCodeByNameHeaders();
            return await GetProcessCodeByNameWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取流程配置
         *
         * @param request GetProcessConfigRequest
         * @param headers GetProcessConfigHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProcessConfigResponse
         */
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

        /**
         * @summary 获取流程配置
         *
         * @param request GetProcessConfigRequest
         * @param headers GetProcessConfigHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProcessConfigResponse
         */
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

        /**
         * @summary 获取流程配置
         *
         * @param request GetProcessConfigRequest
         * @return GetProcessConfigResponse
         */
        public GetProcessConfigResponse GetProcessConfig(GetProcessConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessConfigHeaders headers = new GetProcessConfigHeaders();
            return GetProcessConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取流程配置
         *
         * @param request GetProcessConfigRequest
         * @return GetProcessConfigResponse
         */
        public async Task<GetProcessConfigResponse> GetProcessConfigAsync(GetProcessConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessConfigHeaders headers = new GetProcessConfigHeaders();
            return await GetProcessConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取单个审批实例详情
         *
         * @param request GetProcessInstanceRequest
         * @param headers GetProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProcessInstanceResponse
         */
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

        /**
         * @summary 获取单个审批实例详情
         *
         * @param request GetProcessInstanceRequest
         * @param headers GetProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProcessInstanceResponse
         */
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

        /**
         * @summary 获取单个审批实例详情
         *
         * @param request GetProcessInstanceRequest
         * @return GetProcessInstanceResponse
         */
        public GetProcessInstanceResponse GetProcessInstance(GetProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessInstanceHeaders headers = new GetProcessInstanceHeaders();
            return GetProcessInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取单个审批实例详情
         *
         * @param request GetProcessInstanceRequest
         * @return GetProcessInstanceResponse
         */
        public async Task<GetProcessInstanceResponse> GetProcessInstanceAsync(GetProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessInstanceHeaders headers = new GetProcessInstanceHeaders();
            return await GetProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息
         *
         * @param request GetProcessInstanceWithExtraRequest
         * @param headers GetProcessInstanceWithExtraHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProcessInstanceWithExtraResponse
         */
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

        /**
         * @summary 获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息
         *
         * @param request GetProcessInstanceWithExtraRequest
         * @param headers GetProcessInstanceWithExtraHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProcessInstanceWithExtraResponse
         */
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

        /**
         * @summary 获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息
         *
         * @param request GetProcessInstanceWithExtraRequest
         * @return GetProcessInstanceWithExtraResponse
         */
        public GetProcessInstanceWithExtraResponse GetProcessInstanceWithExtra(GetProcessInstanceWithExtraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessInstanceWithExtraHeaders headers = new GetProcessInstanceWithExtraHeaders();
            return GetProcessInstanceWithExtraWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息
         *
         * @param request GetProcessInstanceWithExtraRequest
         * @return GetProcessInstanceWithExtraResponse
         */
        public async Task<GetProcessInstanceWithExtraResponse> GetProcessInstanceWithExtraAsync(GetProcessInstanceWithExtraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessInstanceWithExtraHeaders headers = new GetProcessInstanceWithExtraHeaders();
            return await GetProcessInstanceWithExtraWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据模版code列表批量查询模板最新表单和流程配置
         *
         * @param tmpReq GetSchemaAndProcessconfigBatchllyRequest
         * @param headers GetSchemaAndProcessconfigBatchllyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSchemaAndProcessconfigBatchllyResponse
         */
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

        /**
         * @summary 根据模版code列表批量查询模板最新表单和流程配置
         *
         * @param tmpReq GetSchemaAndProcessconfigBatchllyRequest
         * @param headers GetSchemaAndProcessconfigBatchllyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSchemaAndProcessconfigBatchllyResponse
         */
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

        /**
         * @summary 根据模版code列表批量查询模板最新表单和流程配置
         *
         * @param request GetSchemaAndProcessconfigBatchllyRequest
         * @return GetSchemaAndProcessconfigBatchllyResponse
         */
        public GetSchemaAndProcessconfigBatchllyResponse GetSchemaAndProcessconfigBatchlly(GetSchemaAndProcessconfigBatchllyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSchemaAndProcessconfigBatchllyHeaders headers = new GetSchemaAndProcessconfigBatchllyHeaders();
            return GetSchemaAndProcessconfigBatchllyWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据模版code列表批量查询模板最新表单和流程配置
         *
         * @param request GetSchemaAndProcessconfigBatchllyRequest
         * @return GetSchemaAndProcessconfigBatchllyResponse
         */
        public async Task<GetSchemaAndProcessconfigBatchllyResponse> GetSchemaAndProcessconfigBatchllyAsync(GetSchemaAndProcessconfigBatchllyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSchemaAndProcessconfigBatchllyHeaders headers = new GetSchemaAndProcessconfigBatchllyHeaders();
            return await GetSchemaAndProcessconfigBatchllyWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 授权预览审批附件
         *
         * @param request GetSpaceWithDownloadAuthRequest
         * @param headers GetSpaceWithDownloadAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpaceWithDownloadAuthResponse
         */
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

        /**
         * @summary 授权预览审批附件
         *
         * @param request GetSpaceWithDownloadAuthRequest
         * @param headers GetSpaceWithDownloadAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpaceWithDownloadAuthResponse
         */
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

        /**
         * @summary 授权预览审批附件
         *
         * @param request GetSpaceWithDownloadAuthRequest
         * @return GetSpaceWithDownloadAuthResponse
         */
        public GetSpaceWithDownloadAuthResponse GetSpaceWithDownloadAuth(GetSpaceWithDownloadAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceWithDownloadAuthHeaders headers = new GetSpaceWithDownloadAuthHeaders();
            return GetSpaceWithDownloadAuthWithOptions(request, headers, runtime);
        }

        /**
         * @summary 授权预览审批附件
         *
         * @param request GetSpaceWithDownloadAuthRequest
         * @return GetSpaceWithDownloadAuthResponse
         */
        public async Task<GetSpaceWithDownloadAuthResponse> GetSpaceWithDownloadAuthAsync(GetSpaceWithDownloadAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceWithDownloadAuthHeaders headers = new GetSpaceWithDownloadAuthHeaders();
            return await GetSpaceWithDownloadAuthWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户待审批数量
         *
         * @param request GetUserTodoTaskSumRequest
         * @param headers GetUserTodoTaskSumHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserTodoTaskSumResponse
         */
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

        /**
         * @summary 获取用户待审批数量
         *
         * @param request GetUserTodoTaskSumRequest
         * @param headers GetUserTodoTaskSumHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserTodoTaskSumResponse
         */
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

        /**
         * @summary 获取用户待审批数量
         *
         * @param request GetUserTodoTaskSumRequest
         * @return GetUserTodoTaskSumResponse
         */
        public GetUserTodoTaskSumResponse GetUserTodoTaskSum(GetUserTodoTaskSumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserTodoTaskSumHeaders headers = new GetUserTodoTaskSumHeaders();
            return GetUserTodoTaskSumWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户待审批数量
         *
         * @param request GetUserTodoTaskSumRequest
         * @return GetUserTodoTaskSumResponse
         */
        public async Task<GetUserTodoTaskSumResponse> GetUserTodoTaskSumAsync(GetUserTodoTaskSumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserTodoTaskSumHeaders headers = new GetUserTodoTaskSumHeaders();
            return await GetUserTodoTaskSumWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary  授权用户钉盘空间权限
         *
         * @param request GrantCspaceAuthorizationRequest
         * @param headers GrantCspaceAuthorizationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantCspaceAuthorizationResponse
         */
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

        /**
         * @summary  授权用户钉盘空间权限
         *
         * @param request GrantCspaceAuthorizationRequest
         * @param headers GrantCspaceAuthorizationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantCspaceAuthorizationResponse
         */
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

        /**
         * @summary  授权用户钉盘空间权限
         *
         * @param request GrantCspaceAuthorizationRequest
         * @return GrantCspaceAuthorizationResponse
         */
        public GrantCspaceAuthorizationResponse GrantCspaceAuthorization(GrantCspaceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantCspaceAuthorizationHeaders headers = new GrantCspaceAuthorizationHeaders();
            return GrantCspaceAuthorizationWithOptions(request, headers, runtime);
        }

        /**
         * @summary  授权用户钉盘空间权限
         *
         * @param request GrantCspaceAuthorizationRequest
         * @return GrantCspaceAuthorizationResponse
         */
        public async Task<GrantCspaceAuthorizationResponse> GrantCspaceAuthorizationAsync(GrantCspaceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantCspaceAuthorizationHeaders headers = new GrantCspaceAuthorizationHeaders();
            return await GrantCspaceAuthorizationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 下载审批附件
         *
         * @param request GrantProcessInstanceForDownloadFileRequest
         * @param headers GrantProcessInstanceForDownloadFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantProcessInstanceForDownloadFileResponse
         */
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

        /**
         * @summary 下载审批附件
         *
         * @param request GrantProcessInstanceForDownloadFileRequest
         * @param headers GrantProcessInstanceForDownloadFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantProcessInstanceForDownloadFileResponse
         */
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

        /**
         * @summary 下载审批附件
         *
         * @param request GrantProcessInstanceForDownloadFileRequest
         * @return GrantProcessInstanceForDownloadFileResponse
         */
        public GrantProcessInstanceForDownloadFileResponse GrantProcessInstanceForDownloadFile(GrantProcessInstanceForDownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantProcessInstanceForDownloadFileHeaders headers = new GrantProcessInstanceForDownloadFileHeaders();
            return GrantProcessInstanceForDownloadFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary 下载审批附件
         *
         * @param request GrantProcessInstanceForDownloadFileRequest
         * @return GrantProcessInstanceForDownloadFileResponse
         */
        public async Task<GrantProcessInstanceForDownloadFileResponse> GrantProcessInstanceForDownloadFileAsync(GrantProcessInstanceForDownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantProcessInstanceForDownloadFileHeaders headers = new GrantProcessInstanceForDownloadFileHeaders();
            return await GrantProcessInstanceForDownloadFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建或更新分组
         *
         * @param request InsertOrUpdateDirRequest
         * @param headers InsertOrUpdateDirHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertOrUpdateDirResponse
         */
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

        /**
         * @summary 创建或更新分组
         *
         * @param request InsertOrUpdateDirRequest
         * @param headers InsertOrUpdateDirHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertOrUpdateDirResponse
         */
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

        /**
         * @summary 创建或更新分组
         *
         * @param request InsertOrUpdateDirRequest
         * @return InsertOrUpdateDirResponse
         */
        public InsertOrUpdateDirResponse InsertOrUpdateDir(InsertOrUpdateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertOrUpdateDirHeaders headers = new InsertOrUpdateDirHeaders();
            return InsertOrUpdateDirWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建或更新分组
         *
         * @param request InsertOrUpdateDirRequest
         * @return InsertOrUpdateDirResponse
         */
        public async Task<InsertOrUpdateDirResponse> InsertOrUpdateDirAsync(InsertOrUpdateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertOrUpdateDirHeaders headers = new InsertOrUpdateDirHeaders();
            return await InsertOrUpdateDirWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 应用安装
         *
         * @param request InstallAppRequest
         * @param headers InstallAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallAppResponse
         */
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

        /**
         * @summary 应用安装
         *
         * @param request InstallAppRequest
         * @param headers InstallAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallAppResponse
         */
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

        /**
         * @summary 应用安装
         *
         * @param request InstallAppRequest
         * @return InstallAppResponse
         */
        public InstallAppResponse InstallApp(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallAppHeaders headers = new InstallAppHeaders();
            return InstallAppWithOptions(request, headers, runtime);
        }

        /**
         * @summary 应用安装
         *
         * @param request InstallAppRequest
         * @return InstallAppResponse
         */
        public async Task<InstallAppResponse> InstallAppAsync(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallAppHeaders headers = new InstallAppHeaders();
            return await InstallAppWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取审批实例ID列表
         *
         * @param request ListProcessInstanceIdsRequest
         * @param headers ListProcessInstanceIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProcessInstanceIdsResponse
         */
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

        /**
         * @summary 获取审批实例ID列表
         *
         * @param request ListProcessInstanceIdsRequest
         * @param headers ListProcessInstanceIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProcessInstanceIdsResponse
         */
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

        /**
         * @summary 获取审批实例ID列表
         *
         * @param request ListProcessInstanceIdsRequest
         * @return ListProcessInstanceIdsResponse
         */
        public ListProcessInstanceIdsResponse ListProcessInstanceIds(ListProcessInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProcessInstanceIdsHeaders headers = new ListProcessInstanceIdsHeaders();
            return ListProcessInstanceIdsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取审批实例ID列表
         *
         * @param request ListProcessInstanceIdsRequest
         * @return ListProcessInstanceIdsResponse
         */
        public async Task<ListProcessInstanceIdsResponse> ListProcessInstanceIdsAsync(ListProcessInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProcessInstanceIdsHeaders headers = new ListProcessInstanceIdsHeaders();
            return await ListProcessInstanceIdsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户待办事项
         *
         * @param request ListTodoWorkRecordsRequest
         * @param headers ListTodoWorkRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTodoWorkRecordsResponse
         */
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

        /**
         * @summary 查询用户待办事项
         *
         * @param request ListTodoWorkRecordsRequest
         * @param headers ListTodoWorkRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTodoWorkRecordsResponse
         */
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

        /**
         * @summary 查询用户待办事项
         *
         * @param request ListTodoWorkRecordsRequest
         * @return ListTodoWorkRecordsResponse
         */
        public ListTodoWorkRecordsResponse ListTodoWorkRecords(ListTodoWorkRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTodoWorkRecordsHeaders headers = new ListTodoWorkRecordsHeaders();
            return ListTodoWorkRecordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户待办事项
         *
         * @param request ListTodoWorkRecordsRequest
         * @return ListTodoWorkRecordsResponse
         */
        public async Task<ListTodoWorkRecordsResponse> ListTodoWorkRecordsAsync(ListTodoWorkRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTodoWorkRecordsHeaders headers = new ListTodoWorkRecordsHeaders();
            return await ListTodoWorkRecordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取指定用户可见的审批表单列表
         *
         * @param request ListUserVisibleBpmsProcessesRequest
         * @param headers ListUserVisibleBpmsProcessesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserVisibleBpmsProcessesResponse
         */
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

        /**
         * @summary 获取指定用户可见的审批表单列表
         *
         * @param request ListUserVisibleBpmsProcessesRequest
         * @param headers ListUserVisibleBpmsProcessesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserVisibleBpmsProcessesResponse
         */
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

        /**
         * @summary 获取指定用户可见的审批表单列表
         *
         * @param request ListUserVisibleBpmsProcessesRequest
         * @return ListUserVisibleBpmsProcessesResponse
         */
        public ListUserVisibleBpmsProcessesResponse ListUserVisibleBpmsProcesses(ListUserVisibleBpmsProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserVisibleBpmsProcessesHeaders headers = new ListUserVisibleBpmsProcessesHeaders();
            return ListUserVisibleBpmsProcessesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取指定用户可见的审批表单列表
         *
         * @param request ListUserVisibleBpmsProcessesRequest
         * @return ListUserVisibleBpmsProcessesResponse
         */
        public async Task<ListUserVisibleBpmsProcessesResponse> ListUserVisibleBpmsProcessesAsync(ListUserVisibleBpmsProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserVisibleBpmsProcessesHeaders headers = new ListUserVisibleBpmsProcessesHeaders();
            return await ListUserVisibleBpmsProcessesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页查询实例数据
         *
         * @param request PagesExportInstancesRequest
         * @param headers PagesExportInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PagesExportInstancesResponse
         */
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

        /**
         * @summary 分页查询实例数据
         *
         * @param request PagesExportInstancesRequest
         * @param headers PagesExportInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PagesExportInstancesResponse
         */
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

        /**
         * @summary 分页查询实例数据
         *
         * @param request PagesExportInstancesRequest
         * @return PagesExportInstancesResponse
         */
        public PagesExportInstancesResponse PagesExportInstances(PagesExportInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagesExportInstancesHeaders headers = new PagesExportInstancesHeaders();
            return PagesExportInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页查询实例数据
         *
         * @param request PagesExportInstancesRequest
         * @return PagesExportInstancesResponse
         */
        public async Task<PagesExportInstancesResponse> PagesExportInstancesAsync(PagesExportInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagesExportInstancesHeaders headers = new PagesExportInstancesHeaders();
            return await PagesExportInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量同意或拒绝审批任务(OA高级版专享接口)
         *
         * @param request PremiumBatchExecuteProcessInstancesRequest
         * @param headers PremiumBatchExecuteProcessInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumBatchExecuteProcessInstancesResponse
         */
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

        /**
         * @summary 批量同意或拒绝审批任务(OA高级版专享接口)
         *
         * @param request PremiumBatchExecuteProcessInstancesRequest
         * @param headers PremiumBatchExecuteProcessInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumBatchExecuteProcessInstancesResponse
         */
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

        /**
         * @summary 批量同意或拒绝审批任务(OA高级版专享接口)
         *
         * @param request PremiumBatchExecuteProcessInstancesRequest
         * @return PremiumBatchExecuteProcessInstancesResponse
         */
        public PremiumBatchExecuteProcessInstancesResponse PremiumBatchExecuteProcessInstances(PremiumBatchExecuteProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumBatchExecuteProcessInstancesHeaders headers = new PremiumBatchExecuteProcessInstancesHeaders();
            return PremiumBatchExecuteProcessInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量同意或拒绝审批任务(OA高级版专享接口)
         *
         * @param request PremiumBatchExecuteProcessInstancesRequest
         * @return PremiumBatchExecuteProcessInstancesResponse
         */
        public async Task<PremiumBatchExecuteProcessInstancesResponse> PremiumBatchExecuteProcessInstancesAsync(PremiumBatchExecuteProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumBatchExecuteProcessInstancesHeaders headers = new PremiumBatchExecuteProcessInstancesHeaders();
            return await PremiumBatchExecuteProcessInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除业务分组(高级版专享接口)
         *
         * @param request PremiumDelDirRequest
         * @param headers PremiumDelDirHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumDelDirResponse
         */
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

        /**
         * @summary 删除业务分组(高级版专享接口)
         *
         * @param request PremiumDelDirRequest
         * @param headers PremiumDelDirHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumDelDirResponse
         */
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

        /**
         * @summary 删除业务分组(高级版专享接口)
         *
         * @param request PremiumDelDirRequest
         * @return PremiumDelDirResponse
         */
        public PremiumDelDirResponse PremiumDelDir(PremiumDelDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumDelDirHeaders headers = new PremiumDelDirHeaders();
            return PremiumDelDirWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除业务分组(高级版专享接口)
         *
         * @param request PremiumDelDirRequest
         * @return PremiumDelDirResponse
         */
        public async Task<PremiumDelDirResponse> PremiumDelDirAsync(PremiumDelDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumDelDirHeaders headers = new PremiumDelDirHeaders();
            return await PremiumDelDirWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询审批中心已处理任务列表(OA高级版专享接口)
         *
         * @param request PremiumGetDoneTasksRequest
         * @param headers PremiumGetDoneTasksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetDoneTasksResponse
         */
        public PremiumGetDoneTasksResponse PremiumGetDoneTasksWithOptions(PremiumGetDoneTasksRequest request, PremiumGetDoneTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                query["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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

        /**
         * @summary 查询审批中心已处理任务列表(OA高级版专享接口)
         *
         * @param request PremiumGetDoneTasksRequest
         * @param headers PremiumGetDoneTasksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetDoneTasksResponse
         */
        public async Task<PremiumGetDoneTasksResponse> PremiumGetDoneTasksWithOptionsAsync(PremiumGetDoneTasksRequest request, PremiumGetDoneTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                query["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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

        /**
         * @summary 查询审批中心已处理任务列表(OA高级版专享接口)
         *
         * @param request PremiumGetDoneTasksRequest
         * @return PremiumGetDoneTasksResponse
         */
        public PremiumGetDoneTasksResponse PremiumGetDoneTasks(PremiumGetDoneTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetDoneTasksHeaders headers = new PremiumGetDoneTasksHeaders();
            return PremiumGetDoneTasksWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询审批中心已处理任务列表(OA高级版专享接口)
         *
         * @param request PremiumGetDoneTasksRequest
         * @return PremiumGetDoneTasksResponse
         */
        public async Task<PremiumGetDoneTasksResponse> PremiumGetDoneTasksAsync(PremiumGetDoneTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetDoneTasksHeaders headers = new PremiumGetDoneTasksHeaders();
            return await PremiumGetDoneTasksWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取字段修改历史(高级版专享接口)
         *
         * @param request PremiumGetFieldModifiedHistoryRequest
         * @param headers PremiumGetFieldModifiedHistoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetFieldModifiedHistoryResponse
         */
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

        /**
         * @summary 获取字段修改历史(高级版专享接口)
         *
         * @param request PremiumGetFieldModifiedHistoryRequest
         * @param headers PremiumGetFieldModifiedHistoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetFieldModifiedHistoryResponse
         */
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

        /**
         * @summary 获取字段修改历史(高级版专享接口)
         *
         * @param request PremiumGetFieldModifiedHistoryRequest
         * @return PremiumGetFieldModifiedHistoryResponse
         */
        public PremiumGetFieldModifiedHistoryResponse PremiumGetFieldModifiedHistory(PremiumGetFieldModifiedHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetFieldModifiedHistoryHeaders headers = new PremiumGetFieldModifiedHistoryHeaders();
            return PremiumGetFieldModifiedHistoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取字段修改历史(高级版专享接口)
         *
         * @param request PremiumGetFieldModifiedHistoryRequest
         * @return PremiumGetFieldModifiedHistoryResponse
         */
        public async Task<PremiumGetFieldModifiedHistoryResponse> PremiumGetFieldModifiedHistoryAsync(PremiumGetFieldModifiedHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetFieldModifiedHistoryHeaders headers = new PremiumGetFieldModifiedHistoryHeaders();
            return await PremiumGetFieldModifiedHistoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询审批中心我收到的实例列表(OA高级版专享接口)
         *
         * @param request PremiumGetNoticedInstancesRequest
         * @param headers PremiumGetNoticedInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetNoticedInstancesResponse
         */
        public PremiumGetNoticedInstancesResponse PremiumGetNoticedInstancesWithOptions(PremiumGetNoticedInstancesRequest request, PremiumGetNoticedInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                query["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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

        /**
         * @summary 查询审批中心我收到的实例列表(OA高级版专享接口)
         *
         * @param request PremiumGetNoticedInstancesRequest
         * @param headers PremiumGetNoticedInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetNoticedInstancesResponse
         */
        public async Task<PremiumGetNoticedInstancesResponse> PremiumGetNoticedInstancesWithOptionsAsync(PremiumGetNoticedInstancesRequest request, PremiumGetNoticedInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                query["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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

        /**
         * @summary 查询审批中心我收到的实例列表(OA高级版专享接口)
         *
         * @param request PremiumGetNoticedInstancesRequest
         * @return PremiumGetNoticedInstancesResponse
         */
        public PremiumGetNoticedInstancesResponse PremiumGetNoticedInstances(PremiumGetNoticedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetNoticedInstancesHeaders headers = new PremiumGetNoticedInstancesHeaders();
            return PremiumGetNoticedInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询审批中心我收到的实例列表(OA高级版专享接口)
         *
         * @param request PremiumGetNoticedInstancesRequest
         * @return PremiumGetNoticedInstancesResponse
         */
        public async Task<PremiumGetNoticedInstancesResponse> PremiumGetNoticedInstancesAsync(PremiumGetNoticedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetNoticedInstancesHeaders headers = new PremiumGetNoticedInstancesHeaders();
            return await PremiumGetNoticedInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据processCode分页获取审批流程数据(高级版专享接口)
         *
         * @param request PremiumGetProcessInstancesRequest
         * @param headers PremiumGetProcessInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetProcessInstancesResponse
         */
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

        /**
         * @summary 根据processCode分页获取审批流程数据(高级版专享接口)
         *
         * @param request PremiumGetProcessInstancesRequest
         * @param headers PremiumGetProcessInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetProcessInstancesResponse
         */
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

        /**
         * @summary 根据processCode分页获取审批流程数据(高级版专享接口)
         *
         * @param request PremiumGetProcessInstancesRequest
         * @return PremiumGetProcessInstancesResponse
         */
        public PremiumGetProcessInstancesResponse PremiumGetProcessInstances(PremiumGetProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetProcessInstancesHeaders headers = new PremiumGetProcessInstancesHeaders();
            return PremiumGetProcessInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据processCode分页获取审批流程数据(高级版专享接口)
         *
         * @param request PremiumGetProcessInstancesRequest
         * @return PremiumGetProcessInstancesResponse
         */
        public async Task<PremiumGetProcessInstancesResponse> PremiumGetProcessInstancesAsync(PremiumGetProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetProcessInstancesHeaders headers = new PremiumGetProcessInstancesHeaders();
            return await PremiumGetProcessInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询审批中心已发起实例列表(OA高级版专享接口)
         *
         * @param request PremiumGetSubmittedInstancesRequest
         * @param headers PremiumGetSubmittedInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetSubmittedInstancesResponse
         */
        public PremiumGetSubmittedInstancesResponse PremiumGetSubmittedInstancesWithOptions(PremiumGetSubmittedInstancesRequest request, PremiumGetSubmittedInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                query["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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

        /**
         * @summary 查询审批中心已发起实例列表(OA高级版专享接口)
         *
         * @param request PremiumGetSubmittedInstancesRequest
         * @param headers PremiumGetSubmittedInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetSubmittedInstancesResponse
         */
        public async Task<PremiumGetSubmittedInstancesResponse> PremiumGetSubmittedInstancesWithOptionsAsync(PremiumGetSubmittedInstancesRequest request, PremiumGetSubmittedInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                query["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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

        /**
         * @summary 查询审批中心已发起实例列表(OA高级版专享接口)
         *
         * @param request PremiumGetSubmittedInstancesRequest
         * @return PremiumGetSubmittedInstancesResponse
         */
        public PremiumGetSubmittedInstancesResponse PremiumGetSubmittedInstances(PremiumGetSubmittedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetSubmittedInstancesHeaders headers = new PremiumGetSubmittedInstancesHeaders();
            return PremiumGetSubmittedInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询审批中心已发起实例列表(OA高级版专享接口)
         *
         * @param request PremiumGetSubmittedInstancesRequest
         * @return PremiumGetSubmittedInstancesResponse
         */
        public async Task<PremiumGetSubmittedInstancesResponse> PremiumGetSubmittedInstancesAsync(PremiumGetSubmittedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetSubmittedInstancesHeaders headers = new PremiumGetSubmittedInstancesHeaders();
            return await PremiumGetSubmittedInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询审批中心待处理任务列表(OA高级版专享接口)
         *
         * @param request PremiumGetTodoTasksRequest
         * @param headers PremiumGetTodoTasksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetTodoTasksResponse
         */
        public PremiumGetTodoTasksResponse PremiumGetTodoTasksWithOptions(PremiumGetTodoTasksRequest request, PremiumGetTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateBefore))
            {
                query["createBefore"] = request.CreateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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

        /**
         * @summary 查询审批中心待处理任务列表(OA高级版专享接口)
         *
         * @param request PremiumGetTodoTasksRequest
         * @param headers PremiumGetTodoTasksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumGetTodoTasksResponse
         */
        public async Task<PremiumGetTodoTasksResponse> PremiumGetTodoTasksWithOptionsAsync(PremiumGetTodoTasksRequest request, PremiumGetTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateBefore))
            {
                query["createBefore"] = request.CreateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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

        /**
         * @summary 查询审批中心待处理任务列表(OA高级版专享接口)
         *
         * @param request PremiumGetTodoTasksRequest
         * @return PremiumGetTodoTasksResponse
         */
        public PremiumGetTodoTasksResponse PremiumGetTodoTasks(PremiumGetTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetTodoTasksHeaders headers = new PremiumGetTodoTasksHeaders();
            return PremiumGetTodoTasksWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询审批中心待处理任务列表(OA高级版专享接口)
         *
         * @param request PremiumGetTodoTasksRequest
         * @return PremiumGetTodoTasksResponse
         */
        public async Task<PremiumGetTodoTasksResponse> PremiumGetTodoTasksAsync(PremiumGetTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumGetTodoTasksHeaders headers = new PremiumGetTodoTasksHeaders();
            return await PremiumGetTodoTasksWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建或更新分组(高级版专享接口)
         *
         * @param request PremiumInsertOrUpdateDirRequest
         * @param headers PremiumInsertOrUpdateDirHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumInsertOrUpdateDirResponse
         */
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

        /**
         * @summary 创建或更新分组(高级版专享接口)
         *
         * @param request PremiumInsertOrUpdateDirRequest
         * @param headers PremiumInsertOrUpdateDirHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumInsertOrUpdateDirResponse
         */
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

        /**
         * @summary 创建或更新分组(高级版专享接口)
         *
         * @param request PremiumInsertOrUpdateDirRequest
         * @return PremiumInsertOrUpdateDirResponse
         */
        public PremiumInsertOrUpdateDirResponse PremiumInsertOrUpdateDir(PremiumInsertOrUpdateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumInsertOrUpdateDirHeaders headers = new PremiumInsertOrUpdateDirHeaders();
            return PremiumInsertOrUpdateDirWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建或更新分组(高级版专享接口)
         *
         * @param request PremiumInsertOrUpdateDirRequest
         * @return PremiumInsertOrUpdateDirResponse
         */
        public async Task<PremiumInsertOrUpdateDirResponse> PremiumInsertOrUpdateDirAsync(PremiumInsertOrUpdateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumInsertOrUpdateDirHeaders headers = new PremiumInsertOrUpdateDirHeaders();
            return await PremiumInsertOrUpdateDirWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 流程转交待处理任务查询(高级版专享接口)
         *
         * @param request PremiumQueryTodoTasksByManagerRequest
         * @param headers PremiumQueryTodoTasksByManagerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumQueryTodoTasksByManagerResponse
         */
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

        /**
         * @summary 流程转交待处理任务查询(高级版专享接口)
         *
         * @param request PremiumQueryTodoTasksByManagerRequest
         * @param headers PremiumQueryTodoTasksByManagerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumQueryTodoTasksByManagerResponse
         */
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

        /**
         * @summary 流程转交待处理任务查询(高级版专享接口)
         *
         * @param request PremiumQueryTodoTasksByManagerRequest
         * @return PremiumQueryTodoTasksByManagerResponse
         */
        public PremiumQueryTodoTasksByManagerResponse PremiumQueryTodoTasksByManager(PremiumQueryTodoTasksByManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumQueryTodoTasksByManagerHeaders headers = new PremiumQueryTodoTasksByManagerHeaders();
            return PremiumQueryTodoTasksByManagerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 流程转交待处理任务查询(高级版专享接口)
         *
         * @param request PremiumQueryTodoTasksByManagerRequest
         * @return PremiumQueryTodoTasksByManagerResponse
         */
        public async Task<PremiumQueryTodoTasksByManagerResponse> PremiumQueryTodoTasksByManagerAsync(PremiumQueryTodoTasksByManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumQueryTodoTasksByManagerHeaders headers = new PremiumQueryTodoTasksByManagerHeaders();
            return await PremiumQueryTodoTasksByManagerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量流程审批任务转交(高级版专享接口)
         *
         * @param request PremiumRedirectTasksByManagerRequest
         * @param headers PremiumRedirectTasksByManagerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumRedirectTasksByManagerResponse
         */
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

        /**
         * @summary 批量流程审批任务转交(高级版专享接口)
         *
         * @param request PremiumRedirectTasksByManagerRequest
         * @param headers PremiumRedirectTasksByManagerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumRedirectTasksByManagerResponse
         */
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

        /**
         * @summary 批量流程审批任务转交(高级版专享接口)
         *
         * @param request PremiumRedirectTasksByManagerRequest
         * @return PremiumRedirectTasksByManagerResponse
         */
        public PremiumRedirectTasksByManagerResponse PremiumRedirectTasksByManager(PremiumRedirectTasksByManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumRedirectTasksByManagerHeaders headers = new PremiumRedirectTasksByManagerHeaders();
            return PremiumRedirectTasksByManagerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量流程审批任务转交(高级版专享接口)
         *
         * @param request PremiumRedirectTasksByManagerRequest
         * @return PremiumRedirectTasksByManagerResponse
         */
        public async Task<PremiumRedirectTasksByManagerResponse> PremiumRedirectTasksByManagerAsync(PremiumRedirectTasksByManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumRedirectTasksByManagerHeaders headers = new PremiumRedirectTasksByManagerHeaders();
            return await PremiumRedirectTasksByManagerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建或更新流程中心外部集成模板(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedProcessRequest
         * @param headers PremiumSaveIntegratedProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumSaveIntegratedProcessResponse
         */
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

        /**
         * @summary 创建或更新流程中心外部集成模板(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedProcessRequest
         * @param headers PremiumSaveIntegratedProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumSaveIntegratedProcessResponse
         */
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

        /**
         * @summary 创建或更新流程中心外部集成模板(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedProcessRequest
         * @return PremiumSaveIntegratedProcessResponse
         */
        public PremiumSaveIntegratedProcessResponse PremiumSaveIntegratedProcess(PremiumSaveIntegratedProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedProcessHeaders headers = new PremiumSaveIntegratedProcessHeaders();
            return PremiumSaveIntegratedProcessWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建或更新流程中心外部集成模板(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedProcessRequest
         * @return PremiumSaveIntegratedProcessResponse
         */
        public async Task<PremiumSaveIntegratedProcessResponse> PremiumSaveIntegratedProcessAsync(PremiumSaveIntegratedProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedProcessHeaders headers = new PremiumSaveIntegratedProcessHeaders();
            return await PremiumSaveIntegratedProcessWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建流程中心外部集成实例(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedProcessInstanceRequest
         * @param headers PremiumSaveIntegratedProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumSaveIntegratedProcessInstanceResponse
         */
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

        /**
         * @summary 创建流程中心外部集成实例(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedProcessInstanceRequest
         * @param headers PremiumSaveIntegratedProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumSaveIntegratedProcessInstanceResponse
         */
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

        /**
         * @summary 创建流程中心外部集成实例(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedProcessInstanceRequest
         * @return PremiumSaveIntegratedProcessInstanceResponse
         */
        public PremiumSaveIntegratedProcessInstanceResponse PremiumSaveIntegratedProcessInstance(PremiumSaveIntegratedProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedProcessInstanceHeaders headers = new PremiumSaveIntegratedProcessInstanceHeaders();
            return PremiumSaveIntegratedProcessInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建流程中心外部集成实例(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedProcessInstanceRequest
         * @return PremiumSaveIntegratedProcessInstanceResponse
         */
        public async Task<PremiumSaveIntegratedProcessInstanceResponse> PremiumSaveIntegratedProcessInstanceAsync(PremiumSaveIntegratedProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedProcessInstanceHeaders headers = new PremiumSaveIntegratedProcessInstanceHeaders();
            return await PremiumSaveIntegratedProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建流程中心外部集成待处理任务(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedTaskRequest
         * @param headers PremiumSaveIntegratedTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumSaveIntegratedTaskResponse
         */
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

        /**
         * @summary 创建流程中心外部集成待处理任务(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedTaskRequest
         * @param headers PremiumSaveIntegratedTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PremiumSaveIntegratedTaskResponse
         */
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

        /**
         * @summary 创建流程中心外部集成待处理任务(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedTaskRequest
         * @return PremiumSaveIntegratedTaskResponse
         */
        public PremiumSaveIntegratedTaskResponse PremiumSaveIntegratedTask(PremiumSaveIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedTaskHeaders headers = new PremiumSaveIntegratedTaskHeaders();
            return PremiumSaveIntegratedTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建流程中心外部集成待处理任务(高级版专享接口)
         *
         * @param request PremiumSaveIntegratedTaskRequest
         * @return PremiumSaveIntegratedTaskResponse
         */
        public async Task<PremiumSaveIntegratedTaskResponse> PremiumSaveIntegratedTaskAsync(PremiumSaveIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PremiumSaveIntegratedTaskHeaders headers = new PremiumSaveIntegratedTaskHeaders();
            return await PremiumSaveIntegratedTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 审批流程预测
         *
         * @param request ProcessForecastRequest
         * @param headers ProcessForecastHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ProcessForecastResponse
         */
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

        /**
         * @summary 审批流程预测
         *
         * @param request ProcessForecastRequest
         * @param headers ProcessForecastHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ProcessForecastResponse
         */
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

        /**
         * @summary 审批流程预测
         *
         * @param request ProcessForecastRequest
         * @return ProcessForecastResponse
         */
        public ProcessForecastResponse ProcessForecast(ProcessForecastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessForecastHeaders headers = new ProcessForecastHeaders();
            return ProcessForecastWithOptions(request, headers, runtime);
        }

        /**
         * @summary 审批流程预测
         *
         * @param request ProcessForecastRequest
         * @return ProcessForecastResponse
         */
        public async Task<ProcessForecastResponse> ProcessForecastAsync(ProcessForecastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessForecastHeaders headers = new ProcessForecastHeaders();
            return await ProcessForecastWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据processCode分页获取表单数据
         *
         * @param request QueryAllFormInstancesRequest
         * @param headers QueryAllFormInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllFormInstancesResponse
         */
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

        /**
         * @summary 根据processCode分页获取表单数据
         *
         * @param request QueryAllFormInstancesRequest
         * @param headers QueryAllFormInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllFormInstancesResponse
         */
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

        /**
         * @summary 根据processCode分页获取表单数据
         *
         * @param request QueryAllFormInstancesRequest
         * @return QueryAllFormInstancesResponse
         */
        public QueryAllFormInstancesResponse QueryAllFormInstances(QueryAllFormInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllFormInstancesHeaders headers = new QueryAllFormInstancesHeaders();
            return QueryAllFormInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据processCode分页获取表单数据
         *
         * @param request QueryAllFormInstancesRequest
         * @return QueryAllFormInstancesResponse
         */
        public async Task<QueryAllFormInstancesResponse> QueryAllFormInstancesAsync(QueryAllFormInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllFormInstancesHeaders headers = new QueryAllFormInstancesHeaders();
            return await QueryAllFormInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询审批流程实例
         *
         * @param request QueryAllProcessInstancesRequest
         * @param headers QueryAllProcessInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllProcessInstancesResponse
         */
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

        /**
         * @summary 批量查询审批流程实例
         *
         * @param request QueryAllProcessInstancesRequest
         * @param headers QueryAllProcessInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllProcessInstancesResponse
         */
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

        /**
         * @summary 批量查询审批流程实例
         *
         * @param request QueryAllProcessInstancesRequest
         * @return QueryAllProcessInstancesResponse
         */
        public QueryAllProcessInstancesResponse QueryAllProcessInstances(QueryAllProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllProcessInstancesHeaders headers = new QueryAllProcessInstancesHeaders();
            return QueryAllProcessInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询审批流程实例
         *
         * @param request QueryAllProcessInstancesRequest
         * @return QueryAllProcessInstancesResponse
         */
        public async Task<QueryAllProcessInstancesResponse> QueryAllProcessInstancesAsync(QueryAllProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllProcessInstancesHeaders headers = new QueryAllProcessInstancesHeaders();
            return await QueryAllProcessInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据业务标识查询表单描述信息
         *
         * @param request QueryFormByBizTypeRequest
         * @param headers QueryFormByBizTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFormByBizTypeResponse
         */
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

        /**
         * @summary 根据业务标识查询表单描述信息
         *
         * @param request QueryFormByBizTypeRequest
         * @param headers QueryFormByBizTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFormByBizTypeResponse
         */
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

        /**
         * @summary 根据业务标识查询表单描述信息
         *
         * @param request QueryFormByBizTypeRequest
         * @return QueryFormByBizTypeResponse
         */
        public QueryFormByBizTypeResponse QueryFormByBizType(QueryFormByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormByBizTypeHeaders headers = new QueryFormByBizTypeHeaders();
            return QueryFormByBizTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据业务标识查询表单描述信息
         *
         * @param request QueryFormByBizTypeRequest
         * @return QueryFormByBizTypeResponse
         */
        public async Task<QueryFormByBizTypeResponse> QueryFormByBizTypeAsync(QueryFormByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormByBizTypeHeaders headers = new QueryFormByBizTypeHeaders();
            return await QueryFormByBizTypeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询数据表单
         *
         * @param request QueryFormInstanceRequest
         * @param headers QueryFormInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFormInstanceResponse
         */
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

        /**
         * @summary 查询数据表单
         *
         * @param request QueryFormInstanceRequest
         * @param headers QueryFormInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFormInstanceResponse
         */
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

        /**
         * @summary 查询数据表单
         *
         * @param request QueryFormInstanceRequest
         * @return QueryFormInstanceResponse
         */
        public QueryFormInstanceResponse QueryFormInstance(QueryFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormInstanceHeaders headers = new QueryFormInstanceHeaders();
            return QueryFormInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询数据表单
         *
         * @param request QueryFormInstanceRequest
         * @return QueryFormInstanceResponse
         */
        public async Task<QueryFormInstanceResponse> QueryFormInstanceAsync(QueryFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormInstanceHeaders headers = new QueryFormInstanceHeaders();
            return await QueryFormInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询通过流程中心集成的OA审批任务
         *
         * @param request QueryIntegratedTodoTaskRequest
         * @param headers QueryIntegratedTodoTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryIntegratedTodoTaskResponse
         */
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

        /**
         * @summary 查询通过流程中心集成的OA审批任务
         *
         * @param request QueryIntegratedTodoTaskRequest
         * @param headers QueryIntegratedTodoTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryIntegratedTodoTaskResponse
         */
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

        /**
         * @summary 查询通过流程中心集成的OA审批任务
         *
         * @param request QueryIntegratedTodoTaskRequest
         * @return QueryIntegratedTodoTaskResponse
         */
        public QueryIntegratedTodoTaskResponse QueryIntegratedTodoTask(QueryIntegratedTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryIntegratedTodoTaskHeaders headers = new QueryIntegratedTodoTaskHeaders();
            return QueryIntegratedTodoTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询通过流程中心集成的OA审批任务
         *
         * @param request QueryIntegratedTodoTaskRequest
         * @return QueryIntegratedTodoTaskResponse
         */
        public async Task<QueryIntegratedTodoTaskResponse> QueryIntegratedTodoTaskAsync(QueryIntegratedTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryIntegratedTodoTaskHeaders headers = new QueryIntegratedTodoTaskHeaders();
            return await QueryIntegratedTodoTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据业务标识查询模板
         *
         * @param request QueryProcessByBizCategoryIdRequest
         * @param headers QueryProcessByBizCategoryIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryProcessByBizCategoryIdResponse
         */
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

        /**
         * @summary 根据业务标识查询模板
         *
         * @param request QueryProcessByBizCategoryIdRequest
         * @param headers QueryProcessByBizCategoryIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryProcessByBizCategoryIdResponse
         */
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

        /**
         * @summary 根据业务标识查询模板
         *
         * @param request QueryProcessByBizCategoryIdRequest
         * @return QueryProcessByBizCategoryIdResponse
         */
        public QueryProcessByBizCategoryIdResponse QueryProcessByBizCategoryId(QueryProcessByBizCategoryIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessByBizCategoryIdHeaders headers = new QueryProcessByBizCategoryIdHeaders();
            return QueryProcessByBizCategoryIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据业务标识查询模板
         *
         * @param request QueryProcessByBizCategoryIdRequest
         * @return QueryProcessByBizCategoryIdResponse
         */
        public async Task<QueryProcessByBizCategoryIdResponse> QueryProcessByBizCategoryIdAsync(QueryProcessByBizCategoryIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessByBizCategoryIdHeaders headers = new QueryProcessByBizCategoryIdHeaders();
            return await QueryProcessByBizCategoryIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 蓝凌获取schema和流程信息
         *
         * @param request QuerySchemaAndProcessRequest
         * @param headers QuerySchemaAndProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySchemaAndProcessResponse
         */
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

        /**
         * @summary 蓝凌获取schema和流程信息
         *
         * @param request QuerySchemaAndProcessRequest
         * @param headers QuerySchemaAndProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySchemaAndProcessResponse
         */
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

        /**
         * @summary 蓝凌获取schema和流程信息
         *
         * @param request QuerySchemaAndProcessRequest
         * @return QuerySchemaAndProcessResponse
         */
        public QuerySchemaAndProcessResponse QuerySchemaAndProcess(QuerySchemaAndProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaAndProcessHeaders headers = new QuerySchemaAndProcessHeaders();
            return QuerySchemaAndProcessWithOptions(request, headers, runtime);
        }

        /**
         * @summary 蓝凌获取schema和流程信息
         *
         * @param request QuerySchemaAndProcessRequest
         * @return QuerySchemaAndProcessResponse
         */
        public async Task<QuerySchemaAndProcessResponse> QuerySchemaAndProcessAsync(QuerySchemaAndProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaAndProcessHeaders headers = new QuerySchemaAndProcessHeaders();
            return await QuerySchemaAndProcessWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary  通过 processCode 获取表单 schema 信息
         *
         * @param request QuerySchemaByProcessCodeRequest
         * @param headers QuerySchemaByProcessCodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySchemaByProcessCodeResponse
         */
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

        /**
         * @summary  通过 processCode 获取表单 schema 信息
         *
         * @param request QuerySchemaByProcessCodeRequest
         * @param headers QuerySchemaByProcessCodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySchemaByProcessCodeResponse
         */
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

        /**
         * @summary  通过 processCode 获取表单 schema 信息
         *
         * @param request QuerySchemaByProcessCodeRequest
         * @return QuerySchemaByProcessCodeResponse
         */
        public QuerySchemaByProcessCodeResponse QuerySchemaByProcessCode(QuerySchemaByProcessCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaByProcessCodeHeaders headers = new QuerySchemaByProcessCodeHeaders();
            return QuerySchemaByProcessCodeWithOptions(request, headers, runtime);
        }

        /**
         * @summary  通过 processCode 获取表单 schema 信息
         *
         * @param request QuerySchemaByProcessCodeRequest
         * @return QuerySchemaByProcessCodeResponse
         */
        public async Task<QuerySchemaByProcessCodeResponse> QuerySchemaByProcessCodeAsync(QuerySchemaByProcessCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaByProcessCodeHeaders headers = new QuerySchemaByProcessCodeHeaders();
            return await QuerySchemaByProcessCodeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 转交OA审批任务
         *
         * @param request RedirectWorkflowTaskRequest
         * @param headers RedirectWorkflowTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RedirectWorkflowTaskResponse
         */
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

        /**
         * @summary 转交OA审批任务
         *
         * @param request RedirectWorkflowTaskRequest
         * @param headers RedirectWorkflowTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RedirectWorkflowTaskResponse
         */
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

        /**
         * @summary 转交OA审批任务
         *
         * @param request RedirectWorkflowTaskRequest
         * @return RedirectWorkflowTaskResponse
         */
        public RedirectWorkflowTaskResponse RedirectWorkflowTask(RedirectWorkflowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RedirectWorkflowTaskHeaders headers = new RedirectWorkflowTaskHeaders();
            return RedirectWorkflowTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 转交OA审批任务
         *
         * @param request RedirectWorkflowTaskRequest
         * @return RedirectWorkflowTaskResponse
         */
        public async Task<RedirectWorkflowTaskResponse> RedirectWorkflowTaskAsync(RedirectWorkflowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RedirectWorkflowTaskHeaders headers = new RedirectWorkflowTaskHeaders();
            return await RedirectWorkflowTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建实例
         *
         * @param request SaveIntegratedInstanceRequest
         * @param headers SaveIntegratedInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveIntegratedInstanceResponse
         */
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

        /**
         * @summary 创建实例
         *
         * @param request SaveIntegratedInstanceRequest
         * @param headers SaveIntegratedInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveIntegratedInstanceResponse
         */
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

        /**
         * @summary 创建实例
         *
         * @param request SaveIntegratedInstanceRequest
         * @return SaveIntegratedInstanceResponse
         */
        public SaveIntegratedInstanceResponse SaveIntegratedInstance(SaveIntegratedInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveIntegratedInstanceHeaders headers = new SaveIntegratedInstanceHeaders();
            return SaveIntegratedInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建实例
         *
         * @param request SaveIntegratedInstanceRequest
         * @return SaveIntegratedInstanceResponse
         */
        public async Task<SaveIntegratedInstanceResponse> SaveIntegratedInstanceAsync(SaveIntegratedInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveIntegratedInstanceHeaders headers = new SaveIntegratedInstanceHeaders();
            return await SaveIntegratedInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建或更新审批模板
         *
         * @param request SaveProcessRequest
         * @param headers SaveProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveProcessResponse
         */
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

        /**
         * @summary 创建或更新审批模板
         *
         * @param request SaveProcessRequest
         * @param headers SaveProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveProcessResponse
         */
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

        /**
         * @summary 创建或更新审批模板
         *
         * @param request SaveProcessRequest
         * @return SaveProcessResponse
         */
        public SaveProcessResponse SaveProcess(SaveProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveProcessHeaders headers = new SaveProcessHeaders();
            return SaveProcessWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建或更新审批模板
         *
         * @param request SaveProcessRequest
         * @return SaveProcessResponse
         */
        public async Task<SaveProcessResponse> SaveProcessAsync(SaveProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveProcessHeaders headers = new SaveProcessHeaders();
            return await SaveProcessWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建审批实例
         *
         * @param request StartProcessInstanceRequest
         * @param headers StartProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartProcessInstanceResponse
         */
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

        /**
         * @summary 创建审批实例
         *
         * @param request StartProcessInstanceRequest
         * @param headers StartProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartProcessInstanceResponse
         */
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

        /**
         * @summary 创建审批实例
         *
         * @param request StartProcessInstanceRequest
         * @return StartProcessInstanceResponse
         */
        public StartProcessInstanceResponse StartProcessInstance(StartProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartProcessInstanceHeaders headers = new StartProcessInstanceHeaders();
            return StartProcessInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建审批实例
         *
         * @param request StartProcessInstanceRequest
         * @return StartProcessInstanceResponse
         */
        public async Task<StartProcessInstanceResponse> StartProcessInstanceAsync(StartProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartProcessInstanceHeaders headers = new StartProcessInstanceHeaders();
            return await StartProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 撤销审批实例
         *
         * @param request TerminateProcessInstanceRequest
         * @param headers TerminateProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TerminateProcessInstanceResponse
         */
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

        /**
         * @summary 撤销审批实例
         *
         * @param request TerminateProcessInstanceRequest
         * @param headers TerminateProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TerminateProcessInstanceResponse
         */
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

        /**
         * @summary 撤销审批实例
         *
         * @param request TerminateProcessInstanceRequest
         * @return TerminateProcessInstanceResponse
         */
        public TerminateProcessInstanceResponse TerminateProcessInstance(TerminateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TerminateProcessInstanceHeaders headers = new TerminateProcessInstanceHeaders();
            return TerminateProcessInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 撤销审批实例
         *
         * @param request TerminateProcessInstanceRequest
         * @return TerminateProcessInstanceResponse
         */
        public async Task<TerminateProcessInstanceResponse> TerminateProcessInstanceAsync(TerminateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TerminateProcessInstanceHeaders headers = new TerminateProcessInstanceHeaders();
            return await TerminateProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 流程转交待处理任务查询
         *
         * @param request TodoTasksRequest
         * @param headers TodoTasksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TodoTasksResponse
         */
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

        /**
         * @summary 流程转交待处理任务查询
         *
         * @param request TodoTasksRequest
         * @param headers TodoTasksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TodoTasksResponse
         */
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

        /**
         * @summary 流程转交待处理任务查询
         *
         * @param request TodoTasksRequest
         * @return TodoTasksResponse
         */
        public TodoTasksResponse TodoTasks(TodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TodoTasksHeaders headers = new TodoTasksHeaders();
            return TodoTasksWithOptions(request, headers, runtime);
        }

        /**
         * @summary 流程转交待处理任务查询
         *
         * @param request TodoTasksRequest
         * @return TodoTasksResponse
         */
        public async Task<TodoTasksResponse> TodoTasksAsync(TodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TodoTasksHeaders headers = new TodoTasksHeaders();
            return await TodoTasksWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新流程中心任务状态
         *
         * @param request UpdateIntegratedTaskRequest
         * @param headers UpdateIntegratedTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIntegratedTaskResponse
         */
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

        /**
         * @summary 更新流程中心任务状态
         *
         * @param request UpdateIntegratedTaskRequest
         * @param headers UpdateIntegratedTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIntegratedTaskResponse
         */
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

        /**
         * @summary 更新流程中心任务状态
         *
         * @param request UpdateIntegratedTaskRequest
         * @return UpdateIntegratedTaskResponse
         */
        public UpdateIntegratedTaskResponse UpdateIntegratedTask(UpdateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIntegratedTaskHeaders headers = new UpdateIntegratedTaskHeaders();
            return UpdateIntegratedTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新流程中心任务状态
         *
         * @param request UpdateIntegratedTaskRequest
         * @return UpdateIntegratedTaskResponse
         */
        public async Task<UpdateIntegratedTaskResponse> UpdateIntegratedTaskAsync(UpdateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIntegratedTaskHeaders headers = new UpdateIntegratedTaskHeaders();
            return await UpdateIntegratedTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新实例状态
         *
         * @param request UpdateProcessInstanceRequest
         * @param headers UpdateProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProcessInstanceResponse
         */
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

        /**
         * @summary 更新实例状态
         *
         * @param request UpdateProcessInstanceRequest
         * @param headers UpdateProcessInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProcessInstanceResponse
         */
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

        /**
         * @summary 更新实例状态
         *
         * @param request UpdateProcessInstanceRequest
         * @return UpdateProcessInstanceResponse
         */
        public UpdateProcessInstanceResponse UpdateProcessInstance(UpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProcessInstanceHeaders headers = new UpdateProcessInstanceHeaders();
            return UpdateProcessInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新实例状态
         *
         * @param request UpdateProcessInstanceRequest
         * @return UpdateProcessInstanceResponse
         */
        public async Task<UpdateProcessInstanceResponse> UpdateProcessInstanceAsync(UpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProcessInstanceHeaders headers = new UpdateProcessInstanceHeaders();
            return await UpdateProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

    }
}
