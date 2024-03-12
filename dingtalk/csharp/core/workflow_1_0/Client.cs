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

        public AddApproveDentryAuthResponse AddApproveDentryAuth(AddApproveDentryAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddApproveDentryAuthHeaders headers = new AddApproveDentryAuthHeaders();
            return AddApproveDentryAuthWithOptions(request, headers, runtime);
        }

        public async Task<AddApproveDentryAuthResponse> AddApproveDentryAuthAsync(AddApproveDentryAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddApproveDentryAuthHeaders headers = new AddApproveDentryAuthHeaders();
            return await AddApproveDentryAuthWithOptionsAsync(request, headers, runtime);
        }

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

        public AddProcessInstanceCommentResponse AddProcessInstanceComment(AddProcessInstanceCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProcessInstanceCommentHeaders headers = new AddProcessInstanceCommentHeaders();
            return AddProcessInstanceCommentWithOptions(request, headers, runtime);
        }

        public async Task<AddProcessInstanceCommentResponse> AddProcessInstanceCommentAsync(AddProcessInstanceCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProcessInstanceCommentHeaders headers = new AddProcessInstanceCommentHeaders();
            return await AddProcessInstanceCommentWithOptionsAsync(request, headers, runtime);
        }

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

        public BatchExecuteProcessInstancesResponse BatchExecuteProcessInstances(BatchExecuteProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchExecuteProcessInstancesHeaders headers = new BatchExecuteProcessInstancesHeaders();
            return BatchExecuteProcessInstancesWithOptions(request, headers, runtime);
        }

        public async Task<BatchExecuteProcessInstancesResponse> BatchExecuteProcessInstancesAsync(BatchExecuteProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchExecuteProcessInstancesHeaders headers = new BatchExecuteProcessInstancesHeaders();
            return await BatchExecuteProcessInstancesWithOptionsAsync(request, headers, runtime);
        }

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

        public BatchUpdateProcessInstanceResponse BatchUpdateProcessInstance(BatchUpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateProcessInstanceHeaders headers = new BatchUpdateProcessInstanceHeaders();
            return BatchUpdateProcessInstanceWithOptions(request, headers, runtime);
        }

        public async Task<BatchUpdateProcessInstanceResponse> BatchUpdateProcessInstanceAsync(BatchUpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateProcessInstanceHeaders headers = new BatchUpdateProcessInstanceHeaders();
            return await BatchUpdateProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

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

        public CancelIntegratedTaskResponse CancelIntegratedTask(CancelIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelIntegratedTaskHeaders headers = new CancelIntegratedTaskHeaders();
            return CancelIntegratedTaskWithOptions(request, headers, runtime);
        }

        public async Task<CancelIntegratedTaskResponse> CancelIntegratedTaskAsync(CancelIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelIntegratedTaskHeaders headers = new CancelIntegratedTaskHeaders();
            return await CancelIntegratedTaskWithOptionsAsync(request, headers, runtime);
        }

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

        public CleanProcessDataResponse CleanProcessData(CleanProcessDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CleanProcessDataHeaders headers = new CleanProcessDataHeaders();
            return CleanProcessDataWithOptions(request, headers, runtime);
        }

        public async Task<CleanProcessDataResponse> CleanProcessDataAsync(CleanProcessDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CleanProcessDataHeaders headers = new CleanProcessDataHeaders();
            return await CleanProcessDataWithOptionsAsync(request, headers, runtime);
        }

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

        public CopyProcessResponse CopyProcess(CopyProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyProcessHeaders headers = new CopyProcessHeaders();
            return CopyProcessWithOptions(request, headers, runtime);
        }

        public async Task<CopyProcessResponse> CopyProcessAsync(CopyProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyProcessHeaders headers = new CopyProcessHeaders();
            return await CopyProcessWithOptionsAsync(request, headers, runtime);
        }

        public CreateIntegratedTaskResponse CreateIntegratedTaskWithOptions(CreateIntegratedTaskRequest request, CreateIntegratedTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
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

        public async Task<CreateIntegratedTaskResponse> CreateIntegratedTaskWithOptionsAsync(CreateIntegratedTaskRequest request, CreateIntegratedTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
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

        public CreateIntegratedTaskResponse CreateIntegratedTask(CreateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateIntegratedTaskHeaders headers = new CreateIntegratedTaskHeaders();
            return CreateIntegratedTaskWithOptions(request, headers, runtime);
        }

        public async Task<CreateIntegratedTaskResponse> CreateIntegratedTaskAsync(CreateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateIntegratedTaskHeaders headers = new CreateIntegratedTaskHeaders();
            return await CreateIntegratedTaskWithOptionsAsync(request, headers, runtime);
        }

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

        public DeleteProcessResponse DeleteProcess(DeleteProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProcessHeaders headers = new DeleteProcessHeaders();
            return DeleteProcessWithOptions(request, headers, runtime);
        }

        public async Task<DeleteProcessResponse> DeleteProcessAsync(DeleteProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProcessHeaders headers = new DeleteProcessHeaders();
            return await DeleteProcessWithOptionsAsync(request, headers, runtime);
        }

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

        public ExecuteProcessInstanceResponse ExecuteProcessInstance(ExecuteProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteProcessInstanceHeaders headers = new ExecuteProcessInstanceHeaders();
            return ExecuteProcessInstanceWithOptions(request, headers, runtime);
        }

        public async Task<ExecuteProcessInstanceResponse> ExecuteProcessInstanceAsync(ExecuteProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteProcessInstanceHeaders headers = new ExecuteProcessInstanceHeaders();
            return await ExecuteProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

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

        public FormCreateResponse FormCreate(FormCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FormCreateHeaders headers = new FormCreateHeaders();
            return FormCreateWithOptions(request, headers, runtime);
        }

        public async Task<FormCreateResponse> FormCreateAsync(FormCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FormCreateHeaders headers = new FormCreateHeaders();
            return await FormCreateWithOptionsAsync(request, headers, runtime);
        }

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

        public GetAttachmentSpaceResponse GetAttachmentSpace(GetAttachmentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachmentSpaceHeaders headers = new GetAttachmentSpaceHeaders();
            return GetAttachmentSpaceWithOptions(request, headers, runtime);
        }

        public async Task<GetAttachmentSpaceResponse> GetAttachmentSpaceAsync(GetAttachmentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachmentSpaceHeaders headers = new GetAttachmentSpaceHeaders();
            return await GetAttachmentSpaceWithOptionsAsync(request, headers, runtime);
        }

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

        public GetConditionFormComponentResponse GetConditionFormComponent(GetConditionFormComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConditionFormComponentHeaders headers = new GetConditionFormComponentHeaders();
            return GetConditionFormComponentWithOptions(request, headers, runtime);
        }

        public async Task<GetConditionFormComponentResponse> GetConditionFormComponentAsync(GetConditionFormComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConditionFormComponentHeaders headers = new GetConditionFormComponentHeaders();
            return await GetConditionFormComponentWithOptionsAsync(request, headers, runtime);
        }

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

        public GetCrmProcCodesResponse GetCrmProcCodes()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmProcCodesHeaders headers = new GetCrmProcCodesHeaders();
            return GetCrmProcCodesWithOptions(headers, runtime);
        }

        public async Task<GetCrmProcCodesResponse> GetCrmProcCodesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmProcCodesHeaders headers = new GetCrmProcCodesHeaders();
            return await GetCrmProcCodesWithOptionsAsync(headers, runtime);
        }

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

        public GetManageProcessByStaffIdResponse GetManageProcessByStaffId(GetManageProcessByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetManageProcessByStaffIdHeaders headers = new GetManageProcessByStaffIdHeaders();
            return GetManageProcessByStaffIdWithOptions(request, headers, runtime);
        }

        public async Task<GetManageProcessByStaffIdResponse> GetManageProcessByStaffIdAsync(GetManageProcessByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetManageProcessByStaffIdHeaders headers = new GetManageProcessByStaffIdHeaders();
            return await GetManageProcessByStaffIdWithOptionsAsync(request, headers, runtime);
        }

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

        public GetProcessCodeByNameResponse GetProcessCodeByName(GetProcessCodeByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessCodeByNameHeaders headers = new GetProcessCodeByNameHeaders();
            return GetProcessCodeByNameWithOptions(request, headers, runtime);
        }

        public async Task<GetProcessCodeByNameResponse> GetProcessCodeByNameAsync(GetProcessCodeByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessCodeByNameHeaders headers = new GetProcessCodeByNameHeaders();
            return await GetProcessCodeByNameWithOptionsAsync(request, headers, runtime);
        }

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

        public GetProcessConfigResponse GetProcessConfig(GetProcessConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessConfigHeaders headers = new GetProcessConfigHeaders();
            return GetProcessConfigWithOptions(request, headers, runtime);
        }

        public async Task<GetProcessConfigResponse> GetProcessConfigAsync(GetProcessConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessConfigHeaders headers = new GetProcessConfigHeaders();
            return await GetProcessConfigWithOptionsAsync(request, headers, runtime);
        }

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

        public GetProcessInstanceResponse GetProcessInstance(GetProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessInstanceHeaders headers = new GetProcessInstanceHeaders();
            return GetProcessInstanceWithOptions(request, headers, runtime);
        }

        public async Task<GetProcessInstanceResponse> GetProcessInstanceAsync(GetProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessInstanceHeaders headers = new GetProcessInstanceHeaders();
            return await GetProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

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

        public GetSchemaAndProcessconfigBatchllyResponse GetSchemaAndProcessconfigBatchlly(GetSchemaAndProcessconfigBatchllyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSchemaAndProcessconfigBatchllyHeaders headers = new GetSchemaAndProcessconfigBatchllyHeaders();
            return GetSchemaAndProcessconfigBatchllyWithOptions(request, headers, runtime);
        }

        public async Task<GetSchemaAndProcessconfigBatchllyResponse> GetSchemaAndProcessconfigBatchllyAsync(GetSchemaAndProcessconfigBatchllyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSchemaAndProcessconfigBatchllyHeaders headers = new GetSchemaAndProcessconfigBatchllyHeaders();
            return await GetSchemaAndProcessconfigBatchllyWithOptionsAsync(request, headers, runtime);
        }

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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
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

        public GetSpaceWithDownloadAuthResponse GetSpaceWithDownloadAuth(GetSpaceWithDownloadAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceWithDownloadAuthHeaders headers = new GetSpaceWithDownloadAuthHeaders();
            return GetSpaceWithDownloadAuthWithOptions(request, headers, runtime);
        }

        public async Task<GetSpaceWithDownloadAuthResponse> GetSpaceWithDownloadAuthAsync(GetSpaceWithDownloadAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceWithDownloadAuthHeaders headers = new GetSpaceWithDownloadAuthHeaders();
            return await GetSpaceWithDownloadAuthWithOptionsAsync(request, headers, runtime);
        }

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

        public GetUserTodoTaskSumResponse GetUserTodoTaskSum(GetUserTodoTaskSumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserTodoTaskSumHeaders headers = new GetUserTodoTaskSumHeaders();
            return GetUserTodoTaskSumWithOptions(request, headers, runtime);
        }

        public async Task<GetUserTodoTaskSumResponse> GetUserTodoTaskSumAsync(GetUserTodoTaskSumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserTodoTaskSumHeaders headers = new GetUserTodoTaskSumHeaders();
            return await GetUserTodoTaskSumWithOptionsAsync(request, headers, runtime);
        }

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

        public GrantCspaceAuthorizationResponse GrantCspaceAuthorization(GrantCspaceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantCspaceAuthorizationHeaders headers = new GrantCspaceAuthorizationHeaders();
            return GrantCspaceAuthorizationWithOptions(request, headers, runtime);
        }

        public async Task<GrantCspaceAuthorizationResponse> GrantCspaceAuthorizationAsync(GrantCspaceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantCspaceAuthorizationHeaders headers = new GrantCspaceAuthorizationHeaders();
            return await GrantCspaceAuthorizationWithOptionsAsync(request, headers, runtime);
        }

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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
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

        public GrantProcessInstanceForDownloadFileResponse GrantProcessInstanceForDownloadFile(GrantProcessInstanceForDownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantProcessInstanceForDownloadFileHeaders headers = new GrantProcessInstanceForDownloadFileHeaders();
            return GrantProcessInstanceForDownloadFileWithOptions(request, headers, runtime);
        }

        public async Task<GrantProcessInstanceForDownloadFileResponse> GrantProcessInstanceForDownloadFileAsync(GrantProcessInstanceForDownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantProcessInstanceForDownloadFileHeaders headers = new GrantProcessInstanceForDownloadFileHeaders();
            return await GrantProcessInstanceForDownloadFileWithOptionsAsync(request, headers, runtime);
        }

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

        public InstallAppResponse InstallApp(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallAppHeaders headers = new InstallAppHeaders();
            return InstallAppWithOptions(request, headers, runtime);
        }

        public async Task<InstallAppResponse> InstallAppAsync(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallAppHeaders headers = new InstallAppHeaders();
            return await InstallAppWithOptionsAsync(request, headers, runtime);
        }

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

        public ListProcessInstanceIdsResponse ListProcessInstanceIds(ListProcessInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProcessInstanceIdsHeaders headers = new ListProcessInstanceIdsHeaders();
            return ListProcessInstanceIdsWithOptions(request, headers, runtime);
        }

        public async Task<ListProcessInstanceIdsResponse> ListProcessInstanceIdsAsync(ListProcessInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProcessInstanceIdsHeaders headers = new ListProcessInstanceIdsHeaders();
            return await ListProcessInstanceIdsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListTodoWorkRecordsResponse ListTodoWorkRecords(ListTodoWorkRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTodoWorkRecordsHeaders headers = new ListTodoWorkRecordsHeaders();
            return ListTodoWorkRecordsWithOptions(request, headers, runtime);
        }

        public async Task<ListTodoWorkRecordsResponse> ListTodoWorkRecordsAsync(ListTodoWorkRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTodoWorkRecordsHeaders headers = new ListTodoWorkRecordsHeaders();
            return await ListTodoWorkRecordsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListUserVisibleBpmsProcessesResponse ListUserVisibleBpmsProcesses(ListUserVisibleBpmsProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserVisibleBpmsProcessesHeaders headers = new ListUserVisibleBpmsProcessesHeaders();
            return ListUserVisibleBpmsProcessesWithOptions(request, headers, runtime);
        }

        public async Task<ListUserVisibleBpmsProcessesResponse> ListUserVisibleBpmsProcessesAsync(ListUserVisibleBpmsProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserVisibleBpmsProcessesHeaders headers = new ListUserVisibleBpmsProcessesHeaders();
            return await ListUserVisibleBpmsProcessesWithOptionsAsync(request, headers, runtime);
        }

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

        public PagesExportInstancesResponse PagesExportInstances(PagesExportInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagesExportInstancesHeaders headers = new PagesExportInstancesHeaders();
            return PagesExportInstancesWithOptions(request, headers, runtime);
        }

        public async Task<PagesExportInstancesResponse> PagesExportInstancesAsync(PagesExportInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagesExportInstancesHeaders headers = new PagesExportInstancesHeaders();
            return await PagesExportInstancesWithOptionsAsync(request, headers, runtime);
        }

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

        public ProcessForecastResponse ProcessForecast(ProcessForecastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessForecastHeaders headers = new ProcessForecastHeaders();
            return ProcessForecastWithOptions(request, headers, runtime);
        }

        public async Task<ProcessForecastResponse> ProcessForecastAsync(ProcessForecastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessForecastHeaders headers = new ProcessForecastHeaders();
            return await ProcessForecastWithOptionsAsync(request, headers, runtime);
        }

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

        public QueryAllFormInstancesResponse QueryAllFormInstances(QueryAllFormInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllFormInstancesHeaders headers = new QueryAllFormInstancesHeaders();
            return QueryAllFormInstancesWithOptions(request, headers, runtime);
        }

        public async Task<QueryAllFormInstancesResponse> QueryAllFormInstancesAsync(QueryAllFormInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllFormInstancesHeaders headers = new QueryAllFormInstancesHeaders();
            return await QueryAllFormInstancesWithOptionsAsync(request, headers, runtime);
        }

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

        public QueryAllProcessInstancesResponse QueryAllProcessInstances(QueryAllProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllProcessInstancesHeaders headers = new QueryAllProcessInstancesHeaders();
            return QueryAllProcessInstancesWithOptions(request, headers, runtime);
        }

        public async Task<QueryAllProcessInstancesResponse> QueryAllProcessInstancesAsync(QueryAllProcessInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllProcessInstancesHeaders headers = new QueryAllProcessInstancesHeaders();
            return await QueryAllProcessInstancesWithOptionsAsync(request, headers, runtime);
        }

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

        public QueryFormByBizTypeResponse QueryFormByBizType(QueryFormByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormByBizTypeHeaders headers = new QueryFormByBizTypeHeaders();
            return QueryFormByBizTypeWithOptions(request, headers, runtime);
        }

        public async Task<QueryFormByBizTypeResponse> QueryFormByBizTypeAsync(QueryFormByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormByBizTypeHeaders headers = new QueryFormByBizTypeHeaders();
            return await QueryFormByBizTypeWithOptionsAsync(request, headers, runtime);
        }

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

        public QueryFormInstanceResponse QueryFormInstance(QueryFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormInstanceHeaders headers = new QueryFormInstanceHeaders();
            return QueryFormInstanceWithOptions(request, headers, runtime);
        }

        public async Task<QueryFormInstanceResponse> QueryFormInstanceAsync(QueryFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFormInstanceHeaders headers = new QueryFormInstanceHeaders();
            return await QueryFormInstanceWithOptionsAsync(request, headers, runtime);
        }

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

        public QueryIntegratedTodoTaskResponse QueryIntegratedTodoTask(QueryIntegratedTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryIntegratedTodoTaskHeaders headers = new QueryIntegratedTodoTaskHeaders();
            return QueryIntegratedTodoTaskWithOptions(request, headers, runtime);
        }

        public async Task<QueryIntegratedTodoTaskResponse> QueryIntegratedTodoTaskAsync(QueryIntegratedTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryIntegratedTodoTaskHeaders headers = new QueryIntegratedTodoTaskHeaders();
            return await QueryIntegratedTodoTaskWithOptionsAsync(request, headers, runtime);
        }

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

        public QueryProcessByBizCategoryIdResponse QueryProcessByBizCategoryId(QueryProcessByBizCategoryIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessByBizCategoryIdHeaders headers = new QueryProcessByBizCategoryIdHeaders();
            return QueryProcessByBizCategoryIdWithOptions(request, headers, runtime);
        }

        public async Task<QueryProcessByBizCategoryIdResponse> QueryProcessByBizCategoryIdAsync(QueryProcessByBizCategoryIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessByBizCategoryIdHeaders headers = new QueryProcessByBizCategoryIdHeaders();
            return await QueryProcessByBizCategoryIdWithOptionsAsync(request, headers, runtime);
        }

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

        public QuerySchemaAndProcessResponse QuerySchemaAndProcess(QuerySchemaAndProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaAndProcessHeaders headers = new QuerySchemaAndProcessHeaders();
            return QuerySchemaAndProcessWithOptions(request, headers, runtime);
        }

        public async Task<QuerySchemaAndProcessResponse> QuerySchemaAndProcessAsync(QuerySchemaAndProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaAndProcessHeaders headers = new QuerySchemaAndProcessHeaders();
            return await QuerySchemaAndProcessWithOptionsAsync(request, headers, runtime);
        }

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

        public QuerySchemaByProcessCodeResponse QuerySchemaByProcessCode(QuerySchemaByProcessCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaByProcessCodeHeaders headers = new QuerySchemaByProcessCodeHeaders();
            return QuerySchemaByProcessCodeWithOptions(request, headers, runtime);
        }

        public async Task<QuerySchemaByProcessCodeResponse> QuerySchemaByProcessCodeAsync(QuerySchemaByProcessCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySchemaByProcessCodeHeaders headers = new QuerySchemaByProcessCodeHeaders();
            return await QuerySchemaByProcessCodeWithOptionsAsync(request, headers, runtime);
        }

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

        public RedirectWorkflowTaskResponse RedirectWorkflowTask(RedirectWorkflowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RedirectWorkflowTaskHeaders headers = new RedirectWorkflowTaskHeaders();
            return RedirectWorkflowTaskWithOptions(request, headers, runtime);
        }

        public async Task<RedirectWorkflowTaskResponse> RedirectWorkflowTaskAsync(RedirectWorkflowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RedirectWorkflowTaskHeaders headers = new RedirectWorkflowTaskHeaders();
            return await RedirectWorkflowTaskWithOptionsAsync(request, headers, runtime);
        }

        public SaveIntegratedInstanceResponse SaveIntegratedInstanceWithOptions(SaveIntegratedInstanceRequest request, SaveIntegratedInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public async Task<SaveIntegratedInstanceResponse> SaveIntegratedInstanceWithOptionsAsync(SaveIntegratedInstanceRequest request, SaveIntegratedInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public SaveIntegratedInstanceResponse SaveIntegratedInstance(SaveIntegratedInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveIntegratedInstanceHeaders headers = new SaveIntegratedInstanceHeaders();
            return SaveIntegratedInstanceWithOptions(request, headers, runtime);
        }

        public async Task<SaveIntegratedInstanceResponse> SaveIntegratedInstanceAsync(SaveIntegratedInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveIntegratedInstanceHeaders headers = new SaveIntegratedInstanceHeaders();
            return await SaveIntegratedInstanceWithOptionsAsync(request, headers, runtime);
        }

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

        public SaveProcessResponse SaveProcess(SaveProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveProcessHeaders headers = new SaveProcessHeaders();
            return SaveProcessWithOptions(request, headers, runtime);
        }

        public async Task<SaveProcessResponse> SaveProcessAsync(SaveProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveProcessHeaders headers = new SaveProcessHeaders();
            return await SaveProcessWithOptionsAsync(request, headers, runtime);
        }

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

        public StartProcessInstanceResponse StartProcessInstance(StartProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartProcessInstanceHeaders headers = new StartProcessInstanceHeaders();
            return StartProcessInstanceWithOptions(request, headers, runtime);
        }

        public async Task<StartProcessInstanceResponse> StartProcessInstanceAsync(StartProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartProcessInstanceHeaders headers = new StartProcessInstanceHeaders();
            return await StartProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

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

        public TerminateProcessInstanceResponse TerminateProcessInstance(TerminateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TerminateProcessInstanceHeaders headers = new TerminateProcessInstanceHeaders();
            return TerminateProcessInstanceWithOptions(request, headers, runtime);
        }

        public async Task<TerminateProcessInstanceResponse> TerminateProcessInstanceAsync(TerminateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TerminateProcessInstanceHeaders headers = new TerminateProcessInstanceHeaders();
            return await TerminateProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

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

        public UpdateIntegratedTaskResponse UpdateIntegratedTask(UpdateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIntegratedTaskHeaders headers = new UpdateIntegratedTaskHeaders();
            return UpdateIntegratedTaskWithOptions(request, headers, runtime);
        }

        public async Task<UpdateIntegratedTaskResponse> UpdateIntegratedTaskAsync(UpdateIntegratedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIntegratedTaskHeaders headers = new UpdateIntegratedTaskHeaders();
            return await UpdateIntegratedTaskWithOptionsAsync(request, headers, runtime);
        }

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

        public UpdateProcessInstanceResponse UpdateProcessInstance(UpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProcessInstanceHeaders headers = new UpdateProcessInstanceHeaders();
            return UpdateProcessInstanceWithOptions(request, headers, runtime);
        }

        public async Task<UpdateProcessInstanceResponse> UpdateProcessInstanceAsync(UpdateProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProcessInstanceHeaders headers = new UpdateProcessInstanceHeaders();
            return await UpdateProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

    }
}
