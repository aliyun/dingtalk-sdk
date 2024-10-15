// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0
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
        /// <para>批量创建表单业务对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchInsertBizObjectRequest
        /// </param>
        /// <param name="headers">
        /// BatchInsertBizObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchInsertBizObjectResponse
        /// </returns>
        public BatchInsertBizObjectResponse BatchInsertBizObjectWithOptions(BatchInsertBizObjectRequest request, BatchInsertBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJsonArray))
            {
                body["bizObjectJsonArray"] = request.BizObjectJsonArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDraft))
            {
                body["isDraft"] = request.IsDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchInsertBizObject",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchInsertBizObjectResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建表单业务对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchInsertBizObjectRequest
        /// </param>
        /// <param name="headers">
        /// BatchInsertBizObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchInsertBizObjectResponse
        /// </returns>
        public async Task<BatchInsertBizObjectResponse> BatchInsertBizObjectWithOptionsAsync(BatchInsertBizObjectRequest request, BatchInsertBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJsonArray))
            {
                body["bizObjectJsonArray"] = request.BizObjectJsonArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDraft))
            {
                body["isDraft"] = request.IsDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchInsertBizObject",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchInsertBizObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建表单业务对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchInsertBizObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchInsertBizObjectResponse
        /// </returns>
        public BatchInsertBizObjectResponse BatchInsertBizObject(BatchInsertBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchInsertBizObjectHeaders headers = new BatchInsertBizObjectHeaders();
            return BatchInsertBizObjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建表单业务对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchInsertBizObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchInsertBizObjectResponse
        /// </returns>
        public async Task<BatchInsertBizObjectResponse> BatchInsertBizObjectAsync(BatchInsertBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchInsertBizObjectHeaders headers = new BatchInsertBizObjectHeaders();
            return await BatchInsertBizObjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// CancelProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelProcessInstanceResponse
        /// </returns>
        public CancelProcessInstanceResponse CancelProcessInstanceWithOptions(CancelProcessInstanceRequest request, CancelProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CancelProcessInstance",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/processes/instances/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelProcessInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// CancelProcessInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelProcessInstanceResponse
        /// </returns>
        public async Task<CancelProcessInstanceResponse> CancelProcessInstanceWithOptionsAsync(CancelProcessInstanceRequest request, CancelProcessInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CancelProcessInstance",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/processes/instances/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelProcessInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelProcessInstanceResponse
        /// </returns>
        public CancelProcessInstanceResponse CancelProcessInstance(CancelProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelProcessInstanceHeaders headers = new CancelProcessInstanceHeaders();
            return CancelProcessInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelProcessInstanceResponse
        /// </returns>
        public async Task<CancelProcessInstanceResponse> CancelProcessInstanceAsync(CancelProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelProcessInstanceHeaders headers = new CancelProcessInstanceHeaders();
            return await CancelProcessInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建单条表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizObjectRequest
        /// </param>
        /// <param name="headers">
        /// CreateBizObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBizObjectResponse
        /// </returns>
        public CreateBizObjectResponse CreateBizObjectWithOptions(CreateBizObjectRequest request, CreateBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJson))
            {
                body["bizObjectJson"] = request.BizObjectJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDraft))
            {
                body["isDraft"] = request.IsDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBizObject",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBizObjectResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建单条表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizObjectRequest
        /// </param>
        /// <param name="headers">
        /// CreateBizObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBizObjectResponse
        /// </returns>
        public async Task<CreateBizObjectResponse> CreateBizObjectWithOptionsAsync(CreateBizObjectRequest request, CreateBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJson))
            {
                body["bizObjectJson"] = request.BizObjectJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDraft))
            {
                body["isDraft"] = request.IsDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBizObject",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBizObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建单条表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBizObjectResponse
        /// </returns>
        public CreateBizObjectResponse CreateBizObject(CreateBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBizObjectHeaders headers = new CreateBizObjectHeaders();
            return CreateBizObjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建单条表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBizObjectResponse
        /// </returns>
        public async Task<CreateBizObjectResponse> CreateBizObjectAsync(CreateBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBizObjectHeaders headers = new CreateBizObjectHeaders();
            return await CreateBizObjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProcessesInstanceRequest
        /// </param>
        /// <param name="headers">
        /// CreateProcessesInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessesInstanceResponse
        /// </returns>
        public CreateProcessesInstanceResponse CreateProcessesInstanceWithOptions(CreateProcessesInstanceRequest request, CreateProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                body["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProcessesInstance",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/processes/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProcessesInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProcessesInstanceRequest
        /// </param>
        /// <param name="headers">
        /// CreateProcessesInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessesInstanceResponse
        /// </returns>
        public async Task<CreateProcessesInstanceResponse> CreateProcessesInstanceWithOptionsAsync(CreateProcessesInstanceRequest request, CreateProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                body["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProcessesInstance",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/processes/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProcessesInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProcessesInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessesInstanceResponse
        /// </returns>
        public CreateProcessesInstanceResponse CreateProcessesInstance(CreateProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProcessesInstanceHeaders headers = new CreateProcessesInstanceHeaders();
            return CreateProcessesInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProcessesInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessesInstanceResponse
        /// </returns>
        public async Task<CreateProcessesInstanceResponse> CreateProcessesInstanceAsync(CreateProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProcessesInstanceHeaders headers = new CreateProcessesInstanceHeaders();
            return await CreateProcessesInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizObjectRequest
        /// </param>
        /// <param name="headers">
        /// DeleteBizObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizObjectResponse
        /// </returns>
        public DeleteBizObjectResponse DeleteBizObjectWithOptions(DeleteBizObjectRequest request, DeleteBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBizObject",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBizObjectResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizObjectRequest
        /// </param>
        /// <param name="headers">
        /// DeleteBizObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizObjectResponse
        /// </returns>
        public async Task<DeleteBizObjectResponse> DeleteBizObjectWithOptionsAsync(DeleteBizObjectRequest request, DeleteBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBizObject",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBizObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizObjectResponse
        /// </returns>
        public DeleteBizObjectResponse DeleteBizObject(DeleteBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteBizObjectHeaders headers = new DeleteBizObjectHeaders();
            return DeleteBizObjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizObjectResponse
        /// </returns>
        public async Task<DeleteBizObjectResponse> DeleteBizObjectAsync(DeleteBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteBizObjectHeaders headers = new DeleteBizObjectHeaders();
            return await DeleteBizObjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProcessesInstanceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteProcessesInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProcessesInstanceResponse
        /// </returns>
        public DeleteProcessesInstanceResponse DeleteProcessesInstanceWithOptions(DeleteProcessesInstanceRequest request, DeleteProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoUpdateBizObject))
            {
                query["isAutoUpdateBizObject"] = request.IsAutoUpdateBizObject;
            }
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
                Action = "DeleteProcessesInstance",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/processes/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProcessesInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProcessesInstanceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteProcessesInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProcessesInstanceResponse
        /// </returns>
        public async Task<DeleteProcessesInstanceResponse> DeleteProcessesInstanceWithOptionsAsync(DeleteProcessesInstanceRequest request, DeleteProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoUpdateBizObject))
            {
                query["isAutoUpdateBizObject"] = request.IsAutoUpdateBizObject;
            }
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
                Action = "DeleteProcessesInstance",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/processes/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProcessesInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProcessesInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProcessesInstanceResponse
        /// </returns>
        public DeleteProcessesInstanceResponse DeleteProcessesInstance(DeleteProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProcessesInstanceHeaders headers = new DeleteProcessesInstanceHeaders();
            return DeleteProcessesInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProcessesInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProcessesInstanceResponse
        /// </returns>
        public async Task<DeleteProcessesInstanceResponse> DeleteProcessesInstanceAsync(DeleteProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProcessesInstanceHeaders headers = new DeleteProcessesInstanceHeaders();
            return await DeleteProcessesInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppsRequest
        /// </param>
        /// <param name="headers">
        /// GetAppsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppsResponse
        /// </returns>
        public GetAppsResponse GetAppsWithOptions(GetAppsRequest request, GetAppsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApps",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/apps/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppsRequest
        /// </param>
        /// <param name="headers">
        /// GetAppsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppsResponse
        /// </returns>
        public async Task<GetAppsResponse> GetAppsWithOptionsAsync(GetAppsRequest request, GetAppsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApps",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/apps/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppsResponse
        /// </returns>
        public GetAppsResponse GetApps(GetAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppsHeaders headers = new GetAppsHeaders();
            return GetAppsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppsResponse
        /// </returns>
        public async Task<GetAppsResponse> GetAppsAsync(GetAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppsHeaders headers = new GetAppsHeaders();
            return await GetAppsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取附件临时免登地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttachmentTemporaryUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetAttachmentTemporaryUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentTemporaryUrlResponse
        /// </returns>
        public GetAttachmentTemporaryUrlResponse GetAttachmentTemporaryUrlWithOptions(GetAttachmentTemporaryUrlRequest request, GetAttachmentTemporaryUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentId))
            {
                query["attachmentId"] = request.AttachmentId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAttachmentTemporaryUrl",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/attachments/temporaryUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachmentTemporaryUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取附件临时免登地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttachmentTemporaryUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetAttachmentTemporaryUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentTemporaryUrlResponse
        /// </returns>
        public async Task<GetAttachmentTemporaryUrlResponse> GetAttachmentTemporaryUrlWithOptionsAsync(GetAttachmentTemporaryUrlRequest request, GetAttachmentTemporaryUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentId))
            {
                query["attachmentId"] = request.AttachmentId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAttachmentTemporaryUrl",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/attachments/temporaryUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachmentTemporaryUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取附件临时免登地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttachmentTemporaryUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentTemporaryUrlResponse
        /// </returns>
        public GetAttachmentTemporaryUrlResponse GetAttachmentTemporaryUrl(GetAttachmentTemporaryUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachmentTemporaryUrlHeaders headers = new GetAttachmentTemporaryUrlHeaders();
            return GetAttachmentTemporaryUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取附件临时免登地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttachmentTemporaryUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentTemporaryUrlResponse
        /// </returns>
        public async Task<GetAttachmentTemporaryUrlResponse> GetAttachmentTemporaryUrlAsync(GetAttachmentTemporaryUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachmentTemporaryUrlHeaders headers = new GetAttachmentTemporaryUrlHeaders();
            return await GetAttachmentTemporaryUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationsRequest
        /// </param>
        /// <param name="headers">
        /// GetOrganizationsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationsResponse
        /// </returns>
        public GetOrganizationsResponse GetOrganizationsWithOptions(GetOrganizationsRequest request, GetOrganizationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOrganizations",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/departments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationsRequest
        /// </param>
        /// <param name="headers">
        /// GetOrganizationsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationsResponse
        /// </returns>
        public async Task<GetOrganizationsResponse> GetOrganizationsWithOptionsAsync(GetOrganizationsRequest request, GetOrganizationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOrganizations",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/departments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationsResponse
        /// </returns>
        public GetOrganizationsResponse GetOrganizations(GetOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationsHeaders headers = new GetOrganizationsHeaders();
            return GetOrganizationsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationsResponse
        /// </returns>
        public async Task<GetOrganizationsResponse> GetOrganizationsAsync(GetOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationsHeaders headers = new GetOrganizationsHeaders();
            return await GetOrganizationsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleUsersRequest
        /// </param>
        /// <param name="headers">
        /// GetRoleUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleUsersResponse
        /// </returns>
        public GetRoleUsersResponse GetRoleUsersWithOptions(GetRoleUsersRequest request, GetRoleUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["roleId"] = request.RoleId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleUsers",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/roles/roleUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleUsersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleUsersRequest
        /// </param>
        /// <param name="headers">
        /// GetRoleUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleUsersResponse
        /// </returns>
        public async Task<GetRoleUsersResponse> GetRoleUsersWithOptionsAsync(GetRoleUsersRequest request, GetRoleUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["roleId"] = request.RoleId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleUsers",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/roles/roleUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRoleUsersResponse
        /// </returns>
        public GetRoleUsersResponse GetRoleUsers(GetRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRoleUsersHeaders headers = new GetRoleUsersHeaders();
            return GetRoleUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRoleUsersResponse
        /// </returns>
        public async Task<GetRoleUsersResponse> GetRoleUsersAsync(GetRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRoleUsersHeaders headers = new GetRoleUsersHeaders();
            return await GetRoleUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色数据</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetRolesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRolesResponse
        /// </returns>
        public GetRolesResponse GetRolesWithOptions(GetRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetRoles",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRolesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色数据</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetRolesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRolesResponse
        /// </returns>
        public async Task<GetRolesResponse> GetRolesWithOptionsAsync(GetRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetRoles",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRolesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色数据</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRolesResponse
        /// </returns>
        public GetRolesResponse GetRoles()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRolesHeaders headers = new GetRolesHeaders();
            return GetRolesWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色数据</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRolesResponse
        /// </returns>
        public async Task<GetRolesResponse> GetRolesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRolesHeaders headers = new GetRolesHeaders();
            return await GetRolesWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetUploadUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUploadUrlResponse
        /// </returns>
        public GetUploadUrlResponse GetUploadUrlWithOptions(GetUploadUrlRequest request, GetUploadUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldName))
            {
                query["fieldName"] = request.FieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOverwrite))
            {
                query["isOverwrite"] = request.IsOverwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadUrl",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/attachments/uploadUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetUploadUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUploadUrlResponse
        /// </returns>
        public async Task<GetUploadUrlResponse> GetUploadUrlWithOptionsAsync(GetUploadUrlRequest request, GetUploadUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldName))
            {
                query["fieldName"] = request.FieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOverwrite))
            {
                query["isOverwrite"] = request.IsOverwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadUrl",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/attachments/uploadUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUploadUrlResponse
        /// </returns>
        public GetUploadUrlResponse GetUploadUrl(GetUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadUrlHeaders headers = new GetUploadUrlHeaders();
            return GetUploadUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUploadUrlResponse
        /// </returns>
        public async Task<GetUploadUrlResponse> GetUploadUrlAsync(GetUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadUrlHeaders headers = new GetUploadUrlHeaders();
            return await GetUploadUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUsersRequest
        /// </param>
        /// <param name="headers">
        /// GetUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUsersResponse
        /// </returns>
        public GetUsersResponse GetUsersWithOptions(GetUsersRequest request, GetUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecursive))
            {
                query["isRecursive"] = request.IsRecursive;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUsers",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUsersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUsersRequest
        /// </param>
        /// <param name="headers">
        /// GetUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUsersResponse
        /// </returns>
        public async Task<GetUsersResponse> GetUsersWithOptionsAsync(GetUsersRequest request, GetUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecursive))
            {
                query["isRecursive"] = request.IsRecursive;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUsers",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUsersResponse
        /// </returns>
        public GetUsersResponse GetUsers(GetUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUsersHeaders headers = new GetUsersHeaders();
            return GetUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUsersResponse
        /// </returns>
        public async Task<GetUsersResponse> GetUsersAsync(GetUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUsersHeaders headers = new GetUsersHeaders();
            return await GetUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单业务字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizFieldsRequest
        /// </param>
        /// <param name="headers">
        /// LoadBizFieldsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadBizFieldsResponse
        /// </returns>
        public LoadBizFieldsResponse LoadBizFieldsWithOptions(LoadBizFieldsRequest request, LoadBizFieldsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadBizFields",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/loadBizFields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadBizFieldsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单业务字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizFieldsRequest
        /// </param>
        /// <param name="headers">
        /// LoadBizFieldsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadBizFieldsResponse
        /// </returns>
        public async Task<LoadBizFieldsResponse> LoadBizFieldsWithOptionsAsync(LoadBizFieldsRequest request, LoadBizFieldsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadBizFields",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/loadBizFields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadBizFieldsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单业务字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadBizFieldsResponse
        /// </returns>
        public LoadBizFieldsResponse LoadBizFields(LoadBizFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizFieldsHeaders headers = new LoadBizFieldsHeaders();
            return LoadBizFieldsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单业务字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadBizFieldsResponse
        /// </returns>
        public async Task<LoadBizFieldsResponse> LoadBizFieldsAsync(LoadBizFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizFieldsHeaders headers = new LoadBizFieldsHeaders();
            return await LoadBizFieldsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单条表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizObjectRequest
        /// </param>
        /// <param name="headers">
        /// LoadBizObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadBizObjectResponse
        /// </returns>
        public LoadBizObjectResponse LoadBizObjectWithOptions(LoadBizObjectRequest request, LoadBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadBizObject",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances/loadInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadBizObjectResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单条表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizObjectRequest
        /// </param>
        /// <param name="headers">
        /// LoadBizObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadBizObjectResponse
        /// </returns>
        public async Task<LoadBizObjectResponse> LoadBizObjectWithOptionsAsync(LoadBizObjectRequest request, LoadBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadBizObject",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances/loadInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadBizObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单条表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadBizObjectResponse
        /// </returns>
        public LoadBizObjectResponse LoadBizObject(LoadBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizObjectHeaders headers = new LoadBizObjectHeaders();
            return LoadBizObjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单条表单业务对象实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadBizObjectResponse
        /// </returns>
        public async Task<LoadBizObjectResponse> LoadBizObjectAsync(LoadBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizObjectHeaders headers = new LoadBizObjectHeaders();
            return await LoadBizObjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizObjectsRequest
        /// </param>
        /// <param name="headers">
        /// LoadBizObjectsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadBizObjectsResponse
        /// </returns>
        public LoadBizObjectsResponse LoadBizObjectsWithOptions(LoadBizObjectsRequest request, LoadBizObjectsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatcherJson))
            {
                body["matcherJson"] = request.MatcherJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFields))
            {
                body["returnFields"] = request.ReturnFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByFields))
            {
                body["sortByFields"] = request.SortByFields;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadBizObjects",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadBizObjectsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizObjectsRequest
        /// </param>
        /// <param name="headers">
        /// LoadBizObjectsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadBizObjectsResponse
        /// </returns>
        public async Task<LoadBizObjectsResponse> LoadBizObjectsWithOptionsAsync(LoadBizObjectsRequest request, LoadBizObjectsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatcherJson))
            {
                body["matcherJson"] = request.MatcherJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFields))
            {
                body["returnFields"] = request.ReturnFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByFields))
            {
                body["sortByFields"] = request.SortByFields;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadBizObjects",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadBizObjectsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizObjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadBizObjectsResponse
        /// </returns>
        public LoadBizObjectsResponse LoadBizObjects(LoadBizObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizObjectsHeaders headers = new LoadBizObjectsHeaders();
            return LoadBizObjectsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoadBizObjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadBizObjectsResponse
        /// </returns>
        public async Task<LoadBizObjectsResponse> LoadBizObjectsAsync(LoadBizObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizObjectsHeaders headers = new LoadBizObjectsHeaders();
            return await LoadBizObjectsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用的功能节点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAppFunctionNodesRequest
        /// </param>
        /// <param name="headers">
        /// QueryAppFunctionNodesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAppFunctionNodesResponse
        /// </returns>
        public QueryAppFunctionNodesResponse QueryAppFunctionNodesWithOptions(QueryAppFunctionNodesRequest request, QueryAppFunctionNodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["appCode"] = request.AppCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAppFunctionNodes",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/apps/functionNodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAppFunctionNodesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用的功能节点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAppFunctionNodesRequest
        /// </param>
        /// <param name="headers">
        /// QueryAppFunctionNodesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAppFunctionNodesResponse
        /// </returns>
        public async Task<QueryAppFunctionNodesResponse> QueryAppFunctionNodesWithOptionsAsync(QueryAppFunctionNodesRequest request, QueryAppFunctionNodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["appCode"] = request.AppCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAppFunctionNodes",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/apps/functionNodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAppFunctionNodesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用的功能节点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAppFunctionNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAppFunctionNodesResponse
        /// </returns>
        public QueryAppFunctionNodesResponse QueryAppFunctionNodes(QueryAppFunctionNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAppFunctionNodesHeaders headers = new QueryAppFunctionNodesHeaders();
            return QueryAppFunctionNodesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用的功能节点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAppFunctionNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAppFunctionNodesResponse
        /// </returns>
        public async Task<QueryAppFunctionNodesResponse> QueryAppFunctionNodesAsync(QueryAppFunctionNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAppFunctionNodesHeaders headers = new QueryAppFunctionNodesHeaders();
            return await QueryAppFunctionNodesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessesInstanceRequest
        /// </param>
        /// <param name="headers">
        /// QueryProcessesInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessesInstanceResponse
        /// </returns>
        public QueryProcessesInstanceResponse QueryProcessesInstanceWithOptions(QueryProcessesInstanceRequest request, QueryProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProcessesInstance",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/processes/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProcessesInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessesInstanceRequest
        /// </param>
        /// <param name="headers">
        /// QueryProcessesInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessesInstanceResponse
        /// </returns>
        public async Task<QueryProcessesInstanceResponse> QueryProcessesInstanceWithOptionsAsync(QueryProcessesInstanceRequest request, QueryProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProcessesInstance",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/processes/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProcessesInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessesInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessesInstanceResponse
        /// </returns>
        public QueryProcessesInstanceResponse QueryProcessesInstance(QueryProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessesInstanceHeaders headers = new QueryProcessesInstanceHeaders();
            return QueryProcessesInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessesInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessesInstanceResponse
        /// </returns>
        public async Task<QueryProcessesInstanceResponse> QueryProcessesInstanceAsync(QueryProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessesInstanceHeaders headers = new QueryProcessesInstanceHeaders();
            return await QueryProcessesInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例节点工作项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessesWorkItemsRequest
        /// </param>
        /// <param name="headers">
        /// QueryProcessesWorkItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessesWorkItemsResponse
        /// </returns>
        public QueryProcessesWorkItemsResponse QueryProcessesWorkItemsWithOptions(QueryProcessesWorkItemsRequest request, QueryProcessesWorkItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryProcessesWorkItems",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/processes/workItems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProcessesWorkItemsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例节点工作项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessesWorkItemsRequest
        /// </param>
        /// <param name="headers">
        /// QueryProcessesWorkItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessesWorkItemsResponse
        /// </returns>
        public async Task<QueryProcessesWorkItemsResponse> QueryProcessesWorkItemsWithOptionsAsync(QueryProcessesWorkItemsRequest request, QueryProcessesWorkItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryProcessesWorkItems",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/processes/workItems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProcessesWorkItemsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例节点工作项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessesWorkItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessesWorkItemsResponse
        /// </returns>
        public QueryProcessesWorkItemsResponse QueryProcessesWorkItems(QueryProcessesWorkItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessesWorkItemsHeaders headers = new QueryProcessesWorkItemsHeaders();
            return QueryProcessesWorkItemsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例节点工作项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProcessesWorkItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProcessesWorkItemsResponse
        /// </returns>
        public async Task<QueryProcessesWorkItemsResponse> QueryProcessesWorkItemsAsync(QueryProcessesWorkItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessesWorkItemsHeaders headers = new QueryProcessesWorkItemsHeaders();
            return await QueryProcessesWorkItemsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改表单业务对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizObjectRequest
        /// </param>
        /// <param name="headers">
        /// UpdateBizObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizObjectResponse
        /// </returns>
        public UpdateBizObjectResponse UpdateBizObjectWithOptions(UpdateBizObjectRequest request, UpdateBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                body["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJson))
            {
                body["bizObjectJson"] = request.BizObjectJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBizObject",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBizObjectResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改表单业务对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizObjectRequest
        /// </param>
        /// <param name="headers">
        /// UpdateBizObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizObjectResponse
        /// </returns>
        public async Task<UpdateBizObjectResponse> UpdateBizObjectWithOptionsAsync(UpdateBizObjectRequest request, UpdateBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                body["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJson))
            {
                body["bizObjectJson"] = request.BizObjectJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBizObject",
                Version = "h3yun_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/h3yun/forms/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBizObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改表单业务对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizObjectResponse
        /// </returns>
        public UpdateBizObjectResponse UpdateBizObject(UpdateBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBizObjectHeaders headers = new UpdateBizObjectHeaders();
            return UpdateBizObjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改表单业务对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizObjectResponse
        /// </returns>
        public async Task<UpdateBizObjectResponse> UpdateBizObjectAsync(UpdateBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBizObjectHeaders headers = new UpdateBizObjectHeaders();
            return await UpdateBizObjectWithOptionsAsync(request, headers, runtime);
        }

    }
}
