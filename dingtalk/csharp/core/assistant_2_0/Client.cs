// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkassistant_2_0.Models;

namespace AlibabaCloud.SDK.Dingtalkassistant_2_0
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
        /// <para>创建AI助理的消息体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAssistantMessageRequest
        /// </param>
        /// <param name="headers">
        /// CreateAssistantMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAssistantMessageResponse
        /// </returns>
        public CreateAssistantMessageResponse CreateAssistantMessageWithOptions(string threadId, CreateAssistantMessageRequest request, CreateAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["role"] = request.Role;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAssistantMessage",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AI助理的消息体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAssistantMessageRequest
        /// </param>
        /// <param name="headers">
        /// CreateAssistantMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAssistantMessageResponse
        /// </returns>
        public async Task<CreateAssistantMessageResponse> CreateAssistantMessageWithOptionsAsync(string threadId, CreateAssistantMessageRequest request, CreateAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["role"] = request.Role;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAssistantMessage",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AI助理的消息体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAssistantMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAssistantMessageResponse
        /// </returns>
        public CreateAssistantMessageResponse CreateAssistantMessage(string threadId, CreateAssistantMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantMessageHeaders headers = new CreateAssistantMessageHeaders();
            return CreateAssistantMessageWithOptions(threadId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AI助理的消息体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAssistantMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAssistantMessageResponse
        /// </returns>
        public async Task<CreateAssistantMessageResponse> CreateAssistantMessageAsync(string threadId, CreateAssistantMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantMessageHeaders headers = new CreateAssistantMessageHeaders();
            return await CreateAssistantMessageWithOptionsAsync(threadId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AI助理的运行任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CreateAssistantRunHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAssistantRunResponse
        /// </returns>
        public CreateAssistantRunResponse CreateAssistantRunWithOptions(string threadId, CreateAssistantRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateAssistantRun",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId + "/runs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantRunResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AI助理的运行任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CreateAssistantRunHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAssistantRunResponse
        /// </returns>
        public async Task<CreateAssistantRunResponse> CreateAssistantRunWithOptionsAsync(string threadId, CreateAssistantRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateAssistantRun",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId + "/runs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantRunResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AI助理的运行任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateAssistantRunResponse
        /// </returns>
        public CreateAssistantRunResponse CreateAssistantRun(string threadId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantRunHeaders headers = new CreateAssistantRunHeaders();
            return CreateAssistantRunWithOptions(threadId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AI助理的运行任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateAssistantRunResponse
        /// </returns>
        public async Task<CreateAssistantRunResponse> CreateAssistantRunAsync(string threadId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantRunHeaders headers = new CreateAssistantRunHeaders();
            return await CreateAssistantRunWithOptionsAsync(threadId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AI助理线程实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CreateAssistantThreadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAssistantThreadResponse
        /// </returns>
        public CreateAssistantThreadResponse CreateAssistantThreadWithOptions(CreateAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateAssistantThread",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantThreadResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AI助理线程实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CreateAssistantThreadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAssistantThreadResponse
        /// </returns>
        public async Task<CreateAssistantThreadResponse> CreateAssistantThreadWithOptionsAsync(CreateAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateAssistantThread",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantThreadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AI助理线程实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateAssistantThreadResponse
        /// </returns>
        public CreateAssistantThreadResponse CreateAssistantThread()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantThreadHeaders headers = new CreateAssistantThreadHeaders();
            return CreateAssistantThreadWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AI助理线程实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateAssistantThreadResponse
        /// </returns>
        public async Task<CreateAssistantThreadResponse> CreateAssistantThreadAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantThreadHeaders headers = new CreateAssistantThreadHeaders();
            return await CreateAssistantThreadWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AI助理的消息体</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteAssistantMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssistantMessageResponse
        /// </returns>
        public DeleteAssistantMessageResponse DeleteAssistantMessageWithOptions(string threadId, string messageId, DeleteAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAssistantMessage",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId + "/messages/" + messageId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssistantMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AI助理的消息体</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteAssistantMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssistantMessageResponse
        /// </returns>
        public async Task<DeleteAssistantMessageResponse> DeleteAssistantMessageWithOptionsAsync(string threadId, string messageId, DeleteAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAssistantMessage",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId + "/messages/" + messageId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssistantMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AI助理的消息体</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAssistantMessageResponse
        /// </returns>
        public DeleteAssistantMessageResponse DeleteAssistantMessage(string threadId, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAssistantMessageHeaders headers = new DeleteAssistantMessageHeaders();
            return DeleteAssistantMessageWithOptions(threadId, messageId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AI助理的消息体</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAssistantMessageResponse
        /// </returns>
        public async Task<DeleteAssistantMessageResponse> DeleteAssistantMessageAsync(string threadId, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAssistantMessageHeaders headers = new DeleteAssistantMessageHeaders();
            return await DeleteAssistantMessageWithOptionsAsync(threadId, messageId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AI助理线程实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteAssistantThreadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssistantThreadResponse
        /// </returns>
        public DeleteAssistantThreadResponse DeleteAssistantThreadWithOptions(string threadId, DeleteAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAssistantThread",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssistantThreadResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AI助理线程实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteAssistantThreadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssistantThreadResponse
        /// </returns>
        public async Task<DeleteAssistantThreadResponse> DeleteAssistantThreadWithOptionsAsync(string threadId, DeleteAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAssistantThread",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssistantThreadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AI助理线程实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAssistantThreadResponse
        /// </returns>
        public DeleteAssistantThreadResponse DeleteAssistantThread(string threadId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAssistantThreadHeaders headers = new DeleteAssistantThreadHeaders();
            return DeleteAssistantThreadWithOptions(threadId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AI助理线程实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAssistantThreadResponse
        /// </returns>
        public async Task<DeleteAssistantThreadResponse> DeleteAssistantThreadAsync(string threadId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAssistantThreadHeaders headers = new DeleteAssistantThreadHeaders();
            return await DeleteAssistantThreadWithOptionsAsync(threadId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AI助理消息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssistantMessageRequest
        /// </param>
        /// <param name="headers">
        /// ListAssistantMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAssistantMessageResponse
        /// </returns>
        public ListAssistantMessageResponse ListAssistantMessageWithOptions(string threadId, ListAssistantMessageRequest request, ListAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["runId"] = request.RunId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAssistantMessage",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssistantMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AI助理消息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssistantMessageRequest
        /// </param>
        /// <param name="headers">
        /// ListAssistantMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAssistantMessageResponse
        /// </returns>
        public async Task<ListAssistantMessageResponse> ListAssistantMessageWithOptionsAsync(string threadId, ListAssistantMessageRequest request, ListAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["runId"] = request.RunId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAssistantMessage",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssistantMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AI助理消息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssistantMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAssistantMessageResponse
        /// </returns>
        public ListAssistantMessageResponse ListAssistantMessage(string threadId, ListAssistantMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAssistantMessageHeaders headers = new ListAssistantMessageHeaders();
            return ListAssistantMessageWithOptions(threadId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AI助理消息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssistantMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAssistantMessageResponse
        /// </returns>
        public async Task<ListAssistantMessageResponse> ListAssistantMessageAsync(string threadId, ListAssistantMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAssistantMessageHeaders headers = new ListAssistantMessageHeaders();
            return await ListAssistantMessageWithOptionsAsync(threadId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AI助理的消息体</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// RetrieveAssistantMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveAssistantMessageResponse
        /// </returns>
        public RetrieveAssistantMessageResponse RetrieveAssistantMessageWithOptions(string threadId, string messageId, RetrieveAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RetrieveAssistantMessage",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId + "/messages/" + messageId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AI助理的消息体</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// RetrieveAssistantMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveAssistantMessageResponse
        /// </returns>
        public async Task<RetrieveAssistantMessageResponse> RetrieveAssistantMessageWithOptionsAsync(string threadId, string messageId, RetrieveAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RetrieveAssistantMessage",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId + "/messages/" + messageId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AI助理的消息体</para>
        /// </summary>
        /// 
        /// <returns>
        /// RetrieveAssistantMessageResponse
        /// </returns>
        public RetrieveAssistantMessageResponse RetrieveAssistantMessage(string threadId, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantMessageHeaders headers = new RetrieveAssistantMessageHeaders();
            return RetrieveAssistantMessageWithOptions(threadId, messageId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AI助理的消息体</para>
        /// </summary>
        /// 
        /// <returns>
        /// RetrieveAssistantMessageResponse
        /// </returns>
        public async Task<RetrieveAssistantMessageResponse> RetrieveAssistantMessageAsync(string threadId, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantMessageHeaders headers = new RetrieveAssistantMessageHeaders();
            return await RetrieveAssistantMessageWithOptionsAsync(threadId, messageId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检索AI助理线程实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// RetrieveAssistantThreadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveAssistantThreadResponse
        /// </returns>
        public RetrieveAssistantThreadResponse RetrieveAssistantThreadWithOptions(string threadId, RetrieveAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RetrieveAssistantThread",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantThreadResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检索AI助理线程实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// RetrieveAssistantThreadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveAssistantThreadResponse
        /// </returns>
        public async Task<RetrieveAssistantThreadResponse> RetrieveAssistantThreadWithOptionsAsync(string threadId, RetrieveAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RetrieveAssistantThread",
                Version = "assistant_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/assistant/threads/" + threadId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantThreadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检索AI助理线程实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// RetrieveAssistantThreadResponse
        /// </returns>
        public RetrieveAssistantThreadResponse RetrieveAssistantThread(string threadId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantThreadHeaders headers = new RetrieveAssistantThreadHeaders();
            return RetrieveAssistantThreadWithOptions(threadId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检索AI助理线程实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// RetrieveAssistantThreadResponse
        /// </returns>
        public async Task<RetrieveAssistantThreadResponse> RetrieveAssistantThreadAsync(string threadId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantThreadHeaders headers = new RetrieveAssistantThreadHeaders();
            return await RetrieveAssistantThreadWithOptionsAsync(threadId, headers, runtime);
        }

    }
}
