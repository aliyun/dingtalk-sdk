<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\AddApplicationRegFormTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\AddApplicationRegFormTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\AddApplicationRegFormTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\AddFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\AddFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\AddFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\AddUserAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\AddUserAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\AddUserAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeMailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeMailRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeMailResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ConfirmRightsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ConfirmRightsRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ConfirmRightsResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\FinishBeginnerTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\FinishBeginnerTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\FinishBeginnerTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetApplicationRegFormByFlowIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetApplicationRegFormByFlowIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetApplicationRegFormByFlowIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetCandidateByPhoneNumberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetCandidateByPhoneNumberRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetCandidateByPhoneNumberResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetFileUploadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetFileUploadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetFileUploadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetFlowIdByRelationEntityIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetFlowIdByRelationEntityIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetFlowIdByRelationEntityIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetJobAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetJobAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetJobAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ImportJobDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ImportJobDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ImportJobDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\QueryCandidatesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\QueryCandidatesRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\QueryCandidatesResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\QueryInterviewsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\QueryInterviewsRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\QueryInterviewsResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ReportMessageStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ReportMessageStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ReportMessageStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncChannelMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncChannelMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncChannelMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateApplicationRegFormHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateApplicationRegFormRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateApplicationRegFormResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateInterviewSignInInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateInterviewSignInInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateInterviewSignInInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateJobDeliverHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateJobDeliverRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateJobDeliverResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 添加应聘登记表模板
     *  *
     * @param AddApplicationRegFormTemplateRequest $request AddApplicationRegFormTemplateRequest
     * @param AddApplicationRegFormTemplateHeaders $headers AddApplicationRegFormTemplateHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return AddApplicationRegFormTemplateResponse AddApplicationRegFormTemplateResponse
     */
    public function addApplicationRegFormTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->outerId)) {
            $body['outerId'] = $request->outerId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddApplicationRegFormTemplate',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/flows/applicationRegForms/templates',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return AddApplicationRegFormTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加应聘登记表模板
     *  *
     * @param AddApplicationRegFormTemplateRequest $request AddApplicationRegFormTemplateRequest
     *
     * @return AddApplicationRegFormTemplateResponse AddApplicationRegFormTemplateResponse
     */
    public function addApplicationRegFormTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddApplicationRegFormTemplateHeaders([]);

        return $this->addApplicationRegFormTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加钉盘文件
     *  *
     * @param AddFileRequest $request AddFileRequest
     * @param AddFileHeaders $headers AddFileHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return AddFileResponse AddFileResponse
     */
    public function addFileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->fileName)) {
            $body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->mediaId)) {
            $body['mediaId'] = $request->mediaId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddFile',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/files',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return AddFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加钉盘文件
     *  *
     * @param AddFileRequest $request AddFileRequest
     *
     * @return AddFileResponse AddFileResponse
     */
    public function addFile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddFileHeaders([]);

        return $this->addFileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加渠道个人账号
     *  *
     * @param AddUserAccountRequest $request AddUserAccountRequest
     * @param AddUserAccountHeaders $headers AddUserAccountHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return AddUserAccountResponse AddUserAccountResponse
     */
    public function addUserAccountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->channelAccountName)) {
            $body['channelAccountName'] = $request->channelAccountName;
        }
        if (!Utils::isUnset($request->channelUserIdentify)) {
            $body['channelUserIdentify'] = $request->channelUserIdentify;
        }
        if (!Utils::isUnset($request->phoneNumber)) {
            $body['phoneNumber'] = $request->phoneNumber;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddUserAccount',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/channels/users/accounts',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddUserAccountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加渠道个人账号
     *  *
     * @param AddUserAccountRequest $request AddUserAccountRequest
     *
     * @return AddUserAccountResponse AddUserAccountResponse
     */
    public function addUserAccount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddUserAccountHeaders([]);

        return $this->addUserAccountWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 渠道招聘职位需求导入
     *  *
     * @param CollectRecruitJobDetailRequest $request CollectRecruitJobDetailRequest
     * @param CollectRecruitJobDetailHeaders $headers CollectRecruitJobDetailHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CollectRecruitJobDetailResponse CollectRecruitJobDetailResponse
     */
    public function collectRecruitJobDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->jobInfo)) {
            $body['jobInfo'] = $request->jobInfo;
        }
        if (!Utils::isUnset($request->outCorpId)) {
            $body['outCorpId'] = $request->outCorpId;
        }
        if (!Utils::isUnset($request->outCorpName)) {
            $body['outCorpName'] = $request->outCorpName;
        }
        if (!Utils::isUnset($request->recruitUserInfo)) {
            $body['recruitUserInfo'] = $request->recruitUserInfo;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->updateTime)) {
            $body['updateTime'] = $request->updateTime;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CollectRecruitJobDetail',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/channels/jobs/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CollectRecruitJobDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 渠道招聘职位需求导入
     *  *
     * @param CollectRecruitJobDetailRequest $request CollectRecruitJobDetailRequest
     *
     * @return CollectRecruitJobDetailResponse CollectRecruitJobDetailResponse
     */
    public function collectRecruitJobDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollectRecruitJobDetailHeaders([]);

        return $this->collectRecruitJobDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 结构化简历信息回流
     *  *
     * @param CollectResumeDetailRequest $request CollectResumeDetailRequest
     * @param CollectResumeDetailHeaders $headers CollectResumeDetailHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CollectResumeDetailResponse CollectResumeDetailResponse
     */
    public function collectResumeDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->channelCode)) {
            $body['channelCode'] = $request->channelCode;
        }
        if (!Utils::isUnset($request->channelOuterId)) {
            $body['channelOuterId'] = $request->channelOuterId;
        }
        if (!Utils::isUnset($request->channelTalentId)) {
            $body['channelTalentId'] = $request->channelTalentId;
        }
        if (!Utils::isUnset($request->deliverJobId)) {
            $body['deliverJobId'] = $request->deliverJobId;
        }
        if (!Utils::isUnset($request->optUserId)) {
            $body['optUserId'] = $request->optUserId;
        }
        if (!Utils::isUnset($request->resumeChannelUrl)) {
            $body['resumeChannelUrl'] = $request->resumeChannelUrl;
        }
        if (!Utils::isUnset($request->resumeData)) {
            $body['resumeData'] = $request->resumeData;
        }
        if (!Utils::isUnset($request->resumeFile)) {
            $body['resumeFile'] = $request->resumeFile;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CollectResumeDetail',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/resumes/details',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CollectResumeDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 结构化简历信息回流
     *  *
     * @param CollectResumeDetailRequest $request CollectResumeDetailRequest
     *
     * @return CollectResumeDetailResponse CollectResumeDetailResponse
     */
    public function collectResumeDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollectResumeDetailHeaders([]);

        return $this->collectResumeDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 邮箱简历回流
     *  *
     * @param CollectResumeMailRequest $request CollectResumeMailRequest
     * @param CollectResumeMailHeaders $headers CollectResumeMailHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CollectResumeMailResponse CollectResumeMailResponse
     */
    public function collectResumeMailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->channelCode)) {
            $body['channelCode'] = $request->channelCode;
        }
        if (!Utils::isUnset($request->deliverJobId)) {
            $body['deliverJobId'] = $request->deliverJobId;
        }
        if (!Utils::isUnset($request->fromMailAddress)) {
            $body['fromMailAddress'] = $request->fromMailAddress;
        }
        if (!Utils::isUnset($request->historyMailImport)) {
            $body['historyMailImport'] = $request->historyMailImport;
        }
        if (!Utils::isUnset($request->mailId)) {
            $body['mailId'] = $request->mailId;
        }
        if (!Utils::isUnset($request->mailTitle)) {
            $body['mailTitle'] = $request->mailTitle;
        }
        if (!Utils::isUnset($request->optUserId)) {
            $body['optUserId'] = $request->optUserId;
        }
        if (!Utils::isUnset($request->receiveMailAddress)) {
            $body['receiveMailAddress'] = $request->receiveMailAddress;
        }
        if (!Utils::isUnset($request->receiveMailType)) {
            $body['receiveMailType'] = $request->receiveMailType;
        }
        if (!Utils::isUnset($request->receivedTime)) {
            $body['receivedTime'] = $request->receivedTime;
        }
        if (!Utils::isUnset($request->resumeChannelUrl)) {
            $body['resumeChannelUrl'] = $request->resumeChannelUrl;
        }
        if (!Utils::isUnset($request->resumeFile)) {
            $body['resumeFile'] = $request->resumeFile;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CollectResumeMail',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/resumes/mails',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CollectResumeMailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 邮箱简历回流
     *  *
     * @param CollectResumeMailRequest $request CollectResumeMailRequest
     *
     * @return CollectResumeMailResponse CollectResumeMailResponse
     */
    public function collectResumeMail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollectResumeMailHeaders([]);

        return $this->collectResumeMailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 确认权益
     *  *
     * @param string               $rightsCode
     * @param ConfirmRightsRequest $request    ConfirmRightsRequest
     * @param ConfirmRightsHeaders $headers    ConfirmRightsHeaders
     * @param RuntimeOptions       $runtime    runtime options for this request RuntimeOptions
     *
     * @return ConfirmRightsResponse ConfirmRightsResponse
     */
    public function confirmRightsWithOptions($rightsCode, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ConfirmRights',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/rights/' . $rightsCode . '/confirm',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ConfirmRightsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 确认权益
     *  *
     * @param string               $rightsCode
     * @param ConfirmRightsRequest $request    ConfirmRightsRequest
     *
     * @return ConfirmRightsResponse ConfirmRightsResponse
     */
    public function confirmRights($rightsCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConfirmRightsHeaders([]);

        return $this->confirmRightsWithOptions($rightsCode, $request, $headers, $runtime);
    }

    /**
     * @summary 完成指定的新手任务
     *  *
     * @param string                    $taskCode
     * @param FinishBeginnerTaskRequest $request  FinishBeginnerTaskRequest
     * @param FinishBeginnerTaskHeaders $headers  FinishBeginnerTaskHeaders
     * @param RuntimeOptions            $runtime  runtime options for this request RuntimeOptions
     *
     * @return FinishBeginnerTaskResponse FinishBeginnerTaskResponse
     */
    public function finishBeginnerTaskWithOptions($taskCode, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->scope)) {
            $query['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'FinishBeginnerTask',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/beginnerTasks/' . $taskCode . '/finish',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return FinishBeginnerTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 完成指定的新手任务
     *  *
     * @param string                    $taskCode
     * @param FinishBeginnerTaskRequest $request  FinishBeginnerTaskRequest
     *
     * @return FinishBeginnerTaskResponse FinishBeginnerTaskResponse
     */
    public function finishBeginnerTask($taskCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FinishBeginnerTaskHeaders([]);

        return $this->finishBeginnerTaskWithOptions($taskCode, $request, $headers, $runtime);
    }

    /**
     * @summary 获取招聘流程关联的应聘登记表信息
     *  *
     * @param string                               $flowId
     * @param GetApplicationRegFormByFlowIdRequest $request GetApplicationRegFormByFlowIdRequest
     * @param GetApplicationRegFormByFlowIdHeaders $headers GetApplicationRegFormByFlowIdHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetApplicationRegFormByFlowIdResponse GetApplicationRegFormByFlowIdResponse
     */
    public function getApplicationRegFormByFlowIdWithOptions($flowId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetApplicationRegFormByFlowId',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/flows/' . $flowId . '/applicationRegForms',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetApplicationRegFormByFlowIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取招聘流程关联的应聘登记表信息
     *  *
     * @param string                               $flowId
     * @param GetApplicationRegFormByFlowIdRequest $request GetApplicationRegFormByFlowIdRequest
     *
     * @return GetApplicationRegFormByFlowIdResponse GetApplicationRegFormByFlowIdResponse
     */
    public function getApplicationRegFormByFlowId($flowId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetApplicationRegFormByFlowIdHeaders([]);

        return $this->getApplicationRegFormByFlowIdWithOptions($flowId, $request, $headers, $runtime);
    }

    /**
     * @summary 根据手机号获取候选人信息
     *  *
     * @param GetCandidateByPhoneNumberRequest $request GetCandidateByPhoneNumberRequest
     * @param GetCandidateByPhoneNumberHeaders $headers GetCandidateByPhoneNumberHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCandidateByPhoneNumberResponse GetCandidateByPhoneNumberResponse
     */
    public function getCandidateByPhoneNumberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->phoneNumber)) {
            $query['phoneNumber'] = $request->phoneNumber;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetCandidateByPhoneNumber',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/candidates',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetCandidateByPhoneNumberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据手机号获取候选人信息
     *  *
     * @param GetCandidateByPhoneNumberRequest $request GetCandidateByPhoneNumberRequest
     *
     * @return GetCandidateByPhoneNumberResponse GetCandidateByPhoneNumberResponse
     */
    public function getCandidateByPhoneNumber($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCandidateByPhoneNumberHeaders([]);

        return $this->getCandidateByPhoneNumberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取钉盘上传文件信息
     *  *
     * @param GetFileUploadInfoRequest $request GetFileUploadInfoRequest
     * @param GetFileUploadInfoHeaders $headers GetFileUploadInfoHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFileUploadInfoResponse GetFileUploadInfoResponse
     */
    public function getFileUploadInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->fileName)) {
            $query['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileSize)) {
            $query['fileSize'] = $request->fileSize;
        }
        if (!Utils::isUnset($request->md5)) {
            $query['md5'] = $request->md5;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetFileUploadInfo',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/files/uploadInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetFileUploadInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取钉盘上传文件信息
     *  *
     * @param GetFileUploadInfoRequest $request GetFileUploadInfoRequest
     *
     * @return GetFileUploadInfoResponse GetFileUploadInfoResponse
     */
    public function getFileUploadInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileUploadInfoHeaders([]);

        return $this->getFileUploadInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据招聘流程关联的实体标识获取招聘流程标识
     *  *
     * @param GetFlowIdByRelationEntityIdRequest $request GetFlowIdByRelationEntityIdRequest
     * @param GetFlowIdByRelationEntityIdHeaders $headers GetFlowIdByRelationEntityIdHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFlowIdByRelationEntityIdResponse GetFlowIdByRelationEntityIdResponse
     */
    public function getFlowIdByRelationEntityIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->relationEntity)) {
            $query['relationEntity'] = $request->relationEntity;
        }
        if (!Utils::isUnset($request->relationEntityId)) {
            $query['relationEntityId'] = $request->relationEntityId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetFlowIdByRelationEntityId',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/flows/ids',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetFlowIdByRelationEntityIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据招聘流程关联的实体标识获取招聘流程标识
     *  *
     * @param GetFlowIdByRelationEntityIdRequest $request GetFlowIdByRelationEntityIdRequest
     *
     * @return GetFlowIdByRelationEntityIdResponse GetFlowIdByRelationEntityIdResponse
     */
    public function getFlowIdByRelationEntityId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFlowIdByRelationEntityIdHeaders([]);

        return $this->getFlowIdByRelationEntityIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取职位信息
     *  *
     * @param string            $jobId
     * @param GetJobAuthRequest $request GetJobAuthRequest
     * @param GetJobAuthHeaders $headers GetJobAuthHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetJobAuthResponse GetJobAuthResponse
     */
    public function getJobAuthWithOptions($jobId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetJobAuth',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/auths/jobs/' . $jobId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetJobAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取职位信息
     *  *
     * @param string            $jobId
     * @param GetJobAuthRequest $request GetJobAuthRequest
     *
     * @return GetJobAuthResponse GetJobAuthResponse
     */
    public function getJobAuth($jobId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetJobAuthHeaders([]);

        return $this->getJobAuthWithOptions($jobId, $request, $headers, $runtime);
    }

    /**
     * @summary 导入外部渠道发布的职位数据
     *  *
     * @param ImportJobDataRequest $request ImportJobDataRequest
     * @param ImportJobDataHeaders $headers ImportJobDataHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return ImportJobDataResponse ImportJobDataResponse
     */
    public function importJobDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'ImportJobData',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/weHire/jobs/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ImportJobDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 导入外部渠道发布的职位数据
     *  *
     * @param ImportJobDataRequest $request ImportJobDataRequest
     *
     * @return ImportJobDataResponse ImportJobDataResponse
     */
    public function importJobData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ImportJobDataHeaders([]);

        return $this->importJobDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询候选人详情列表
     *  *
     * @param QueryCandidatesRequest $request QueryCandidatesRequest
     * @param QueryCandidatesHeaders $headers QueryCandidatesHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCandidatesResponse QueryCandidatesResponse
     */
    public function queryCandidatesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->statId)) {
            $body['statId'] = $request->statId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryCandidates',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/candidates/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryCandidatesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询候选人详情列表
     *  *
     * @param QueryCandidatesRequest $request QueryCandidatesRequest
     *
     * @return QueryCandidatesResponse QueryCandidatesResponse
     */
    public function queryCandidates($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCandidatesHeaders([]);

        return $this->queryCandidatesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询面试列表
     *  *
     * @param QueryInterviewsRequest $request QueryInterviewsRequest
     * @param QueryInterviewsHeaders $headers QueryInterviewsHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryInterviewsResponse QueryInterviewsResponse
     */
    public function queryInterviewsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->size)) {
            $query['size'] = $request->size;
        }
        $body = [];
        if (!Utils::isUnset($request->candidateId)) {
            $body['candidateId'] = $request->candidateId;
        }
        if (!Utils::isUnset($request->startTimeBeginMillis)) {
            $body['startTimeBeginMillis'] = $request->startTimeBeginMillis;
        }
        if (!Utils::isUnset($request->startTimeEndMillis)) {
            $body['startTimeEndMillis'] = $request->startTimeEndMillis;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryInterviews',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/interviews/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryInterviewsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询面试列表
     *  *
     * @param QueryInterviewsRequest $request QueryInterviewsRequest
     *
     * @return QueryInterviewsResponse QueryInterviewsResponse
     */
    public function queryInterviews($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryInterviewsHeaders([]);

        return $this->queryInterviewsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 反馈渠道消息状态
     *  *
     * @param ReportMessageStatusRequest $request ReportMessageStatusRequest
     * @param ReportMessageStatusHeaders $headers ReportMessageStatusHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return ReportMessageStatusResponse ReportMessageStatusResponse
     */
    public function reportMessageStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->errorCode)) {
            $body['errorCode'] = $request->errorCode;
        }
        if (!Utils::isUnset($request->errorMsg)) {
            $body['errorMsg'] = $request->errorMsg;
        }
        if (!Utils::isUnset($request->messageId)) {
            $body['messageId'] = $request->messageId;
        }
        if (!Utils::isUnset($request->receiverUserId)) {
            $body['receiverUserId'] = $request->receiverUserId;
        }
        if (!Utils::isUnset($request->senderUserId)) {
            $body['senderUserId'] = $request->senderUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ReportMessageStatus',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/channels/messages/statuses/report',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ReportMessageStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 反馈渠道消息状态
     *  *
     * @param ReportMessageStatusRequest $request ReportMessageStatusRequest
     *
     * @return ReportMessageStatusResponse ReportMessageStatusResponse
     */
    public function reportMessageStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReportMessageStatusHeaders([]);

        return $this->reportMessageStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 同步渠道IM消息
     *  *
     * @param SyncChannelMessageRequest $request SyncChannelMessageRequest
     * @param SyncChannelMessageHeaders $headers SyncChannelMessageHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return SyncChannelMessageResponse SyncChannelMessageResponse
     */
    public function syncChannelMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->createTime)) {
            $body['createTime'] = $request->createTime;
        }
        if (!Utils::isUnset($request->receiverUserId)) {
            $body['receiverUserId'] = $request->receiverUserId;
        }
        if (!Utils::isUnset($request->senderUserId)) {
            $body['senderUserId'] = $request->senderUserId;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SyncChannelMessage',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/channels/messages/sync',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SyncChannelMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 同步渠道IM消息
     *  *
     * @param SyncChannelMessageRequest $request SyncChannelMessageRequest
     *
     * @return SyncChannelMessageResponse SyncChannelMessageResponse
     */
    public function syncChannelMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncChannelMessageHeaders([]);

        return $this->syncChannelMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary ats系统同步面试信息给AI面试助手
     *  *
     * @param SyncInterviewInfoToAIInterviewAssistantRequest $request SyncInterviewInfoToAIInterviewAssistantRequest
     * @param SyncInterviewInfoToAIInterviewAssistantHeaders $headers SyncInterviewInfoToAIInterviewAssistantHeaders
     * @param RuntimeOptions                                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SyncInterviewInfoToAIInterviewAssistantResponse SyncInterviewInfoToAIInterviewAssistantResponse
     */
    public function syncInterviewInfoToAIInterviewAssistantWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->candidateInfoVOList)) {
            $body['candidateInfoVOList'] = $request->candidateInfoVOList;
        }
        if (!Utils::isUnset($request->conferenceInfoVO)) {
            $body['conferenceInfoVO'] = $request->conferenceInfoVO;
        }
        if (!Utils::isUnset($request->interviewEndTime)) {
            $body['interviewEndTime'] = $request->interviewEndTime;
        }
        if (!Utils::isUnset($request->interviewId)) {
            $body['interviewId'] = $request->interviewId;
        }
        if (!Utils::isUnset($request->interviewStartTime)) {
            $body['interviewStartTime'] = $request->interviewStartTime;
        }
        if (!Utils::isUnset($request->interviewType)) {
            $body['interviewType'] = $request->interviewType;
        }
        if (!Utils::isUnset($request->interviewerInfoVOList)) {
            $body['interviewerInfoVOList'] = $request->interviewerInfoVOList;
        }
        if (!Utils::isUnset($request->isvId)) {
            $body['isvId'] = $request->isvId;
        }
        if (!Utils::isUnset($request->jobContentVO)) {
            $body['jobContentVO'] = $request->jobContentVO;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SyncInterviewInfoToAIInterviewAssistant',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/ai/interview/interviewInfos/sync',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SyncInterviewInfoToAIInterviewAssistantResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary ats系统同步面试信息给AI面试助手
     *  *
     * @param SyncInterviewInfoToAIInterviewAssistantRequest $request SyncInterviewInfoToAIInterviewAssistantRequest
     *
     * @return SyncInterviewInfoToAIInterviewAssistantResponse SyncInterviewInfoToAIInterviewAssistantResponse
     */
    public function syncInterviewInfoToAIInterviewAssistant($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncInterviewInfoToAIInterviewAssistantHeaders([]);

        return $this->syncInterviewInfoToAIInterviewAssistantWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新应聘登记表内容
     *  *
     * @param string                          $flowId
     * @param UpdateApplicationRegFormRequest $request UpdateApplicationRegFormRequest
     * @param UpdateApplicationRegFormHeaders $headers UpdateApplicationRegFormHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateApplicationRegFormResponse UpdateApplicationRegFormResponse
     */
    public function updateApplicationRegFormWithOptions($flowId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->dingPanFile)) {
            $body['dingPanFile'] = $request->dingPanFile;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateApplicationRegForm',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/flows/' . $flowId . '/applicationRegForms',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateApplicationRegFormResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新应聘登记表内容
     *  *
     * @param string                          $flowId
     * @param UpdateApplicationRegFormRequest $request UpdateApplicationRegFormRequest
     *
     * @return UpdateApplicationRegFormResponse UpdateApplicationRegFormResponse
     */
    public function updateApplicationRegForm($flowId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateApplicationRegFormHeaders([]);

        return $this->updateApplicationRegFormWithOptions($flowId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新面试签到信息
     *  *
     * @param string                           $interviewId
     * @param UpdateInterviewSignInInfoRequest $request     UpdateInterviewSignInInfoRequest
     * @param UpdateInterviewSignInInfoHeaders $headers     UpdateInterviewSignInInfoHeaders
     * @param RuntimeOptions                   $runtime     runtime options for this request RuntimeOptions
     *
     * @return UpdateInterviewSignInInfoResponse UpdateInterviewSignInInfoResponse
     */
    public function updateInterviewSignInInfoWithOptions($interviewId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->signInTimeMillis)) {
            $body['signInTimeMillis'] = $request->signInTimeMillis;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateInterviewSignInInfo',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/interviews/' . $interviewId . '/signInInfos',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateInterviewSignInInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新面试签到信息
     *  *
     * @param string                           $interviewId
     * @param UpdateInterviewSignInInfoRequest $request     UpdateInterviewSignInInfoRequest
     *
     * @return UpdateInterviewSignInInfoResponse UpdateInterviewSignInInfoResponse
     */
    public function updateInterviewSignInInfo($interviewId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInterviewSignInInfoHeaders([]);

        return $this->updateInterviewSignInInfoWithOptions($interviewId, $request, $headers, $runtime);
    }

    /**
     * @summary 渠道侧职位发布状态变更回调
     *  *
     * @param UpdateJobDeliverRequest $request UpdateJobDeliverRequest
     * @param UpdateJobDeliverHeaders $headers UpdateJobDeliverHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateJobDeliverResponse UpdateJobDeliverResponse
     */
    public function updateJobDeliverWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->jobId)) {
            $query['jobId'] = $request->jobId;
        }
        $body = [];
        if (!Utils::isUnset($request->channelOuterId)) {
            $body['channelOuterId'] = $request->channelOuterId;
        }
        if (!Utils::isUnset($request->deliverUserId)) {
            $body['deliverUserId'] = $request->deliverUserId;
        }
        if (!Utils::isUnset($request->errorCode)) {
            $body['errorCode'] = $request->errorCode;
        }
        if (!Utils::isUnset($request->errorMsg)) {
            $body['errorMsg'] = $request->errorMsg;
        }
        if (!Utils::isUnset($request->opTime)) {
            $body['opTime'] = $request->opTime;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateJobDeliver',
            'version' => 'ats_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/ats/jobs/deliveryStatus',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateJobDeliverResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 渠道侧职位发布状态变更回调
     *  *
     * @param UpdateJobDeliverRequest $request UpdateJobDeliverRequest
     *
     * @return UpdateJobDeliverResponse UpdateJobDeliverResponse
     */
    public function updateJobDeliver($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateJobDeliverHeaders([]);

        return $this->updateJobDeliverWithOptions($request, $headers, $runtime);
    }
}
