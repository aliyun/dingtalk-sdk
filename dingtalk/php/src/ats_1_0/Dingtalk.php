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
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\QueryInterviewsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\QueryInterviewsRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\QueryInterviewsResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ReportMessageStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ReportMessageStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ReportMessageStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncChannelMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncChannelMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncChannelMessageResponse;
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
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param AddApplicationRegFormTemplateRequest $request
     *
     * @return AddApplicationRegFormTemplateResponse
     */
    public function addApplicationRegFormTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddApplicationRegFormTemplateHeaders([]);

        return $this->addApplicationRegFormTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddApplicationRegFormTemplateRequest $request
     * @param AddApplicationRegFormTemplateHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return AddApplicationRegFormTemplateResponse
     */
    public function addApplicationRegFormTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->outerId)) {
            @$body['outerId'] = $request->outerId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddApplicationRegFormTemplateResponse::fromMap($this->doROARequest('AddApplicationRegFormTemplate', 'ats_1.0', 'HTTP', 'POST', 'AK', '/v1.0/ats/flows/applicationRegForms/templates', 'json', $req, $runtime));
    }

    /**
     * @param AddFileRequest $request
     *
     * @return AddFileResponse
     */
    public function addFile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddFileHeaders([]);

        return $this->addFileWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddFileRequest $request
     * @param AddFileHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return AddFileResponse
     */
    public function addFileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->fileName)) {
            @$body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->mediaId)) {
            @$body['mediaId'] = $request->mediaId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddFileResponse::fromMap($this->doROARequest('AddFile', 'ats_1.0', 'HTTP', 'POST', 'AK', '/v1.0/ats/files', 'json', $req, $runtime));
    }

    /**
     * @param AddUserAccountRequest $request
     *
     * @return AddUserAccountResponse
     */
    public function addUserAccount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddUserAccountHeaders([]);

        return $this->addUserAccountWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddUserAccountRequest $request
     * @param AddUserAccountHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return AddUserAccountResponse
     */
    public function addUserAccountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->channelAccountName)) {
            @$body['channelAccountName'] = $request->channelAccountName;
        }
        if (!Utils::isUnset($request->channelUserIdentify)) {
            @$body['channelUserIdentify'] = $request->channelUserIdentify;
        }
        if (!Utils::isUnset($request->phoneNumber)) {
            @$body['phoneNumber'] = $request->phoneNumber;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddUserAccountResponse::fromMap($this->doROARequest('AddUserAccount', 'ats_1.0', 'HTTP', 'POST', 'AK', '/v1.0/ats/channels/users/accounts', 'json', $req, $runtime));
    }

    /**
     * @param CollectRecruitJobDetailRequest $request
     *
     * @return CollectRecruitJobDetailResponse
     */
    public function collectRecruitJobDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollectRecruitJobDetailHeaders([]);

        return $this->collectRecruitJobDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollectRecruitJobDetailRequest $request
     * @param CollectRecruitJobDetailHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CollectRecruitJobDetailResponse
     */
    public function collectRecruitJobDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->channel)) {
            @$body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->jobInfo)) {
            @$body['jobInfo'] = $request->jobInfo;
        }
        if (!Utils::isUnset($request->outCorpId)) {
            @$body['outCorpId'] = $request->outCorpId;
        }
        if (!Utils::isUnset($request->outCorpName)) {
            @$body['outCorpName'] = $request->outCorpName;
        }
        if (!Utils::isUnset($request->recruitUserInfo)) {
            @$body['recruitUserInfo'] = $request->recruitUserInfo;
        }
        if (!Utils::isUnset($request->source)) {
            @$body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->updateTime)) {
            @$body['updateTime'] = $request->updateTime;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CollectRecruitJobDetailResponse::fromMap($this->doROARequest('CollectRecruitJobDetail', 'ats_1.0', 'HTTP', 'POST', 'AK', '/v1.0/ats/channels/jobs/import', 'json', $req, $runtime));
    }

    /**
     * @param CollectResumeDetailRequest $request
     *
     * @return CollectResumeDetailResponse
     */
    public function collectResumeDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollectResumeDetailHeaders([]);

        return $this->collectResumeDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollectResumeDetailRequest $request
     * @param CollectResumeDetailHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return CollectResumeDetailResponse
     */
    public function collectResumeDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->channelCode)) {
            @$body['channelCode'] = $request->channelCode;
        }
        if (!Utils::isUnset($request->channelOuterId)) {
            @$body['channelOuterId'] = $request->channelOuterId;
        }
        if (!Utils::isUnset($request->channelTalentId)) {
            @$body['channelTalentId'] = $request->channelTalentId;
        }
        if (!Utils::isUnset($request->deliverJobId)) {
            @$body['deliverJobId'] = $request->deliverJobId;
        }
        if (!Utils::isUnset($request->optUserId)) {
            @$body['optUserId'] = $request->optUserId;
        }
        if (!Utils::isUnset($request->resumeChannelUrl)) {
            @$body['resumeChannelUrl'] = $request->resumeChannelUrl;
        }
        if (!Utils::isUnset($request->resumeData)) {
            @$body['resumeData'] = $request->resumeData;
        }
        if (!Utils::isUnset($request->resumeFile)) {
            @$body['resumeFile'] = $request->resumeFile;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CollectResumeDetailResponse::fromMap($this->doROARequest('CollectResumeDetail', 'ats_1.0', 'HTTP', 'POST', 'AK', '/v1.0/ats/resumes/details', 'json', $req, $runtime));
    }

    /**
     * @param CollectResumeMailRequest $request
     *
     * @return CollectResumeMailResponse
     */
    public function collectResumeMail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollectResumeMailHeaders([]);

        return $this->collectResumeMailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollectResumeMailRequest $request
     * @param CollectResumeMailHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CollectResumeMailResponse
     */
    public function collectResumeMailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->channelCode)) {
            @$body['channelCode'] = $request->channelCode;
        }
        if (!Utils::isUnset($request->deliverJobId)) {
            @$body['deliverJobId'] = $request->deliverJobId;
        }
        if (!Utils::isUnset($request->fromMailAddress)) {
            @$body['fromMailAddress'] = $request->fromMailAddress;
        }
        if (!Utils::isUnset($request->mailId)) {
            @$body['mailId'] = $request->mailId;
        }
        if (!Utils::isUnset($request->mailTitle)) {
            @$body['mailTitle'] = $request->mailTitle;
        }
        if (!Utils::isUnset($request->optUserId)) {
            @$body['optUserId'] = $request->optUserId;
        }
        if (!Utils::isUnset($request->receiveMailAddress)) {
            @$body['receiveMailAddress'] = $request->receiveMailAddress;
        }
        if (!Utils::isUnset($request->receiveMailType)) {
            @$body['receiveMailType'] = $request->receiveMailType;
        }
        if (!Utils::isUnset($request->receivedTime)) {
            @$body['receivedTime'] = $request->receivedTime;
        }
        if (!Utils::isUnset($request->resumeChannelUrl)) {
            @$body['resumeChannelUrl'] = $request->resumeChannelUrl;
        }
        if (!Utils::isUnset($request->resumeFile)) {
            @$body['resumeFile'] = $request->resumeFile;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CollectResumeMailResponse::fromMap($this->doROARequest('CollectResumeMail', 'ats_1.0', 'HTTP', 'POST', 'AK', '/v1.0/ats/resumes/mails', 'json', $req, $runtime));
    }

    /**
     * @param string               $rightsCode
     * @param ConfirmRightsRequest $request
     *
     * @return ConfirmRightsResponse
     */
    public function confirmRights($rightsCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConfirmRightsHeaders([]);

        return $this->confirmRightsWithOptions($rightsCode, $request, $headers, $runtime);
    }

    /**
     * @param string               $rightsCode
     * @param ConfirmRightsRequest $request
     * @param ConfirmRightsHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ConfirmRightsResponse
     */
    public function confirmRightsWithOptions($rightsCode, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $rightsCode = OpenApiUtilClient::getEncodeParam($rightsCode);
        $query      = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ConfirmRightsResponse::fromMap($this->doROARequest('ConfirmRights', 'ats_1.0', 'HTTP', 'POST', 'AK', '/v1.0/ats/rights/' . $rightsCode . '/confirm', 'json', $req, $runtime));
    }

    /**
     * @param string                    $taskCode
     * @param FinishBeginnerTaskRequest $request
     *
     * @return FinishBeginnerTaskResponse
     */
    public function finishBeginnerTask($taskCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FinishBeginnerTaskHeaders([]);

        return $this->finishBeginnerTaskWithOptions($taskCode, $request, $headers, $runtime);
    }

    /**
     * @param string                    $taskCode
     * @param FinishBeginnerTaskRequest $request
     * @param FinishBeginnerTaskHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return FinishBeginnerTaskResponse
     */
    public function finishBeginnerTaskWithOptions($taskCode, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $taskCode = OpenApiUtilClient::getEncodeParam($taskCode);
        $query    = [];
        if (!Utils::isUnset($request->scope)) {
            @$query['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return FinishBeginnerTaskResponse::fromMap($this->doROARequest('FinishBeginnerTask', 'ats_1.0', 'HTTP', 'POST', 'AK', '/v1.0/ats/beginnerTasks/' . $taskCode . '/finish', 'json', $req, $runtime));
    }

    /**
     * @param string                               $flowId
     * @param GetApplicationRegFormByFlowIdRequest $request
     *
     * @return GetApplicationRegFormByFlowIdResponse
     */
    public function getApplicationRegFormByFlowId($flowId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetApplicationRegFormByFlowIdHeaders([]);

        return $this->getApplicationRegFormByFlowIdWithOptions($flowId, $request, $headers, $runtime);
    }

    /**
     * @param string                               $flowId
     * @param GetApplicationRegFormByFlowIdRequest $request
     * @param GetApplicationRegFormByFlowIdHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return GetApplicationRegFormByFlowIdResponse
     */
    public function getApplicationRegFormByFlowIdWithOptions($flowId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $flowId = OpenApiUtilClient::getEncodeParam($flowId);
        $query  = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetApplicationRegFormByFlowIdResponse::fromMap($this->doROARequest('GetApplicationRegFormByFlowId', 'ats_1.0', 'HTTP', 'GET', 'AK', '/v1.0/ats/flows/' . $flowId . '/applicationRegForms', 'json', $req, $runtime));
    }

    /**
     * @param GetCandidateByPhoneNumberRequest $request
     *
     * @return GetCandidateByPhoneNumberResponse
     */
    public function getCandidateByPhoneNumber($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCandidateByPhoneNumberHeaders([]);

        return $this->getCandidateByPhoneNumberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCandidateByPhoneNumberRequest $request
     * @param GetCandidateByPhoneNumberHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return GetCandidateByPhoneNumberResponse
     */
    public function getCandidateByPhoneNumberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->phoneNumber)) {
            @$query['phoneNumber'] = $request->phoneNumber;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetCandidateByPhoneNumberResponse::fromMap($this->doROARequest('GetCandidateByPhoneNumber', 'ats_1.0', 'HTTP', 'GET', 'AK', '/v1.0/ats/candidates', 'json', $req, $runtime));
    }

    /**
     * @param GetFileUploadInfoRequest $request
     *
     * @return GetFileUploadInfoResponse
     */
    public function getFileUploadInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileUploadInfoHeaders([]);

        return $this->getFileUploadInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFileUploadInfoRequest $request
     * @param GetFileUploadInfoHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetFileUploadInfoResponse
     */
    public function getFileUploadInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->fileName)) {
            @$query['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileSize)) {
            @$query['fileSize'] = $request->fileSize;
        }
        if (!Utils::isUnset($request->md5)) {
            @$query['md5'] = $request->md5;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetFileUploadInfoResponse::fromMap($this->doROARequest('GetFileUploadInfo', 'ats_1.0', 'HTTP', 'GET', 'AK', '/v1.0/ats/files/uploadInfos', 'json', $req, $runtime));
    }

    /**
     * @param GetFlowIdByRelationEntityIdRequest $request
     *
     * @return GetFlowIdByRelationEntityIdResponse
     */
    public function getFlowIdByRelationEntityId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFlowIdByRelationEntityIdHeaders([]);

        return $this->getFlowIdByRelationEntityIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFlowIdByRelationEntityIdRequest $request
     * @param GetFlowIdByRelationEntityIdHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return GetFlowIdByRelationEntityIdResponse
     */
    public function getFlowIdByRelationEntityIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->relationEntity)) {
            @$query['relationEntity'] = $request->relationEntity;
        }
        if (!Utils::isUnset($request->relationEntityId)) {
            @$query['relationEntityId'] = $request->relationEntityId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetFlowIdByRelationEntityIdResponse::fromMap($this->doROARequest('GetFlowIdByRelationEntityId', 'ats_1.0', 'HTTP', 'GET', 'AK', '/v1.0/ats/flows/ids', 'json', $req, $runtime));
    }

    /**
     * @param string            $jobId
     * @param GetJobAuthRequest $request
     *
     * @return GetJobAuthResponse
     */
    public function getJobAuth($jobId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetJobAuthHeaders([]);

        return $this->getJobAuthWithOptions($jobId, $request, $headers, $runtime);
    }

    /**
     * @param string            $jobId
     * @param GetJobAuthRequest $request
     * @param GetJobAuthHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetJobAuthResponse
     */
    public function getJobAuthWithOptions($jobId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $jobId = OpenApiUtilClient::getEncodeParam($jobId);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetJobAuthResponse::fromMap($this->doROARequest('GetJobAuth', 'ats_1.0', 'HTTP', 'GET', 'AK', '/v1.0/ats/auths/jobs/' . $jobId . '', 'json', $req, $runtime));
    }

    /**
     * @param QueryInterviewsRequest $request
     *
     * @return QueryInterviewsResponse
     */
    public function queryInterviews($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryInterviewsHeaders([]);

        return $this->queryInterviewsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryInterviewsRequest $request
     * @param QueryInterviewsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryInterviewsResponse
     */
    public function queryInterviewsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->size)) {
            @$query['size'] = $request->size;
        }
        $body = [];
        if (!Utils::isUnset($request->candidateId)) {
            @$body['candidateId'] = $request->candidateId;
        }
        if (!Utils::isUnset($request->startTimeBeginMillis)) {
            @$body['startTimeBeginMillis'] = $request->startTimeBeginMillis;
        }
        if (!Utils::isUnset($request->startTimeEndMillis)) {
            @$body['startTimeEndMillis'] = $request->startTimeEndMillis;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return QueryInterviewsResponse::fromMap($this->doROARequest('QueryInterviews', 'ats_1.0', 'HTTP', 'POST', 'AK', '/v1.0/ats/interviews/query', 'json', $req, $runtime));
    }

    /**
     * @param ReportMessageStatusRequest $request
     *
     * @return ReportMessageStatusResponse
     */
    public function reportMessageStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReportMessageStatusHeaders([]);

        return $this->reportMessageStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReportMessageStatusRequest $request
     * @param ReportMessageStatusHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ReportMessageStatusResponse
     */
    public function reportMessageStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->channel)) {
            @$body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->errorCode)) {
            @$body['errorCode'] = $request->errorCode;
        }
        if (!Utils::isUnset($request->errorMsg)) {
            @$body['errorMsg'] = $request->errorMsg;
        }
        if (!Utils::isUnset($request->messageId)) {
            @$body['messageId'] = $request->messageId;
        }
        if (!Utils::isUnset($request->receiverUserId)) {
            @$body['receiverUserId'] = $request->receiverUserId;
        }
        if (!Utils::isUnset($request->senderUserId)) {
            @$body['senderUserId'] = $request->senderUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ReportMessageStatusResponse::fromMap($this->doROARequest('ReportMessageStatus', 'ats_1.0', 'HTTP', 'POST', 'AK', '/v1.0/ats/channels/messages/statuses/report', 'json', $req, $runtime));
    }

    /**
     * @param SyncChannelMessageRequest $request
     *
     * @return SyncChannelMessageResponse
     */
    public function syncChannelMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncChannelMessageHeaders([]);

        return $this->syncChannelMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncChannelMessageRequest $request
     * @param SyncChannelMessageHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return SyncChannelMessageResponse
     */
    public function syncChannelMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->channel)) {
            @$body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->createTime)) {
            @$body['createTime'] = $request->createTime;
        }
        if (!Utils::isUnset($request->receiverUserId)) {
            @$body['receiverUserId'] = $request->receiverUserId;
        }
        if (!Utils::isUnset($request->senderUserId)) {
            @$body['senderUserId'] = $request->senderUserId;
        }
        if (!Utils::isUnset($request->uuid)) {
            @$body['uuid'] = $request->uuid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SyncChannelMessageResponse::fromMap($this->doROARequest('SyncChannelMessage', 'ats_1.0', 'HTTP', 'POST', 'AK', '/v1.0/ats/channels/messages/sync', 'json', $req, $runtime));
    }

    /**
     * @param string                          $flowId
     * @param UpdateApplicationRegFormRequest $request
     *
     * @return UpdateApplicationRegFormResponse
     */
    public function updateApplicationRegForm($flowId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateApplicationRegFormHeaders([]);

        return $this->updateApplicationRegFormWithOptions($flowId, $request, $headers, $runtime);
    }

    /**
     * @param string                          $flowId
     * @param UpdateApplicationRegFormRequest $request
     * @param UpdateApplicationRegFormHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return UpdateApplicationRegFormResponse
     */
    public function updateApplicationRegFormWithOptions($flowId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $flowId = OpenApiUtilClient::getEncodeParam($flowId);
        $query  = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->dingPanFile)) {
            @$body['dingPanFile'] = $request->dingPanFile;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateApplicationRegFormResponse::fromMap($this->doROARequest('UpdateApplicationRegForm', 'ats_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/ats/flows/' . $flowId . '/applicationRegForms', 'json', $req, $runtime));
    }

    /**
     * @param string                           $interviewId
     * @param UpdateInterviewSignInInfoRequest $request
     *
     * @return UpdateInterviewSignInInfoResponse
     */
    public function updateInterviewSignInInfo($interviewId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInterviewSignInInfoHeaders([]);

        return $this->updateInterviewSignInInfoWithOptions($interviewId, $request, $headers, $runtime);
    }

    /**
     * @param string                           $interviewId
     * @param UpdateInterviewSignInInfoRequest $request
     * @param UpdateInterviewSignInInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return UpdateInterviewSignInInfoResponse
     */
    public function updateInterviewSignInInfoWithOptions($interviewId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $interviewId = OpenApiUtilClient::getEncodeParam($interviewId);
        $query       = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        $body = [];
        if (!Utils::isUnset($request->signInTimeMillis)) {
            @$body['signInTimeMillis'] = $request->signInTimeMillis;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateInterviewSignInInfoResponse::fromMap($this->doROARequest('UpdateInterviewSignInInfo', 'ats_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/ats/interviews/' . $interviewId . '/signInInfos', 'none', $req, $runtime));
    }

    /**
     * @param UpdateJobDeliverRequest $request
     *
     * @return UpdateJobDeliverResponse
     */
    public function updateJobDeliver($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateJobDeliverHeaders([]);

        return $this->updateJobDeliverWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateJobDeliverRequest $request
     * @param UpdateJobDeliverHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return UpdateJobDeliverResponse
     */
    public function updateJobDeliverWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->jobId)) {
            @$query['jobId'] = $request->jobId;
        }
        $body = [];
        if (!Utils::isUnset($request->channelOuterId)) {
            @$body['channelOuterId'] = $request->channelOuterId;
        }
        if (!Utils::isUnset($request->deliverUserId)) {
            @$body['deliverUserId'] = $request->deliverUserId;
        }
        if (!Utils::isUnset($request->errorCode)) {
            @$body['errorCode'] = $request->errorCode;
        }
        if (!Utils::isUnset($request->errorMsg)) {
            @$body['errorMsg'] = $request->errorMsg;
        }
        if (!Utils::isUnset($request->opTime)) {
            @$body['opTime'] = $request->opTime;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateJobDeliverResponse::fromMap($this->doROARequest('UpdateJobDeliver', 'ats_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/ats/jobs/deliveryStatus', 'json', $req, $runtime));
    }
}
