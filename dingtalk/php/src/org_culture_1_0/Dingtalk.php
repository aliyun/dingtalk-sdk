<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\AssignOrgHoldingToEmpHoldingBatchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\AssignOrgHoldingToEmpHoldingBatchRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\AssignOrgHoldingToEmpHoldingBatchResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\ConsumeUserPointsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\ConsumeUserPointsRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\ConsumeUserPointsResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\CreateOrgHonorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\CreateOrgHonorRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\CreateOrgHonorResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\DeductionPointBatchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\DeductionPointBatchRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\DeductionPointBatchResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\ExportPointOpenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\ExportPointOpenRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\ExportPointOpenResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\GrantHonorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\GrantHonorRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\GrantHonorResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryCorpPointsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryCorpPointsRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryCorpPointsResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryEmpPointDetailsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryEmpPointDetailsRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryEmpPointDetailsResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgHonorsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgHonorsRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgHonorsResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgPointDetailsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgPointDetailsRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgPointDetailsResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryPointActionAutoAssignRuleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryPointActionAutoAssignRuleResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryPointAutoIssueSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryPointAutoIssueSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryUserHonorsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryUserHonorsRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryUserHonorsResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryUserPointsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryUserPointsResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\RecallHonorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\RecallHonorRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\RecallHonorResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\UpdateAutoIssuePointHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\UpdateAutoIssuePointRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\UpdateAutoIssuePointResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\UpdatePointActionAutoAssignRuleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\UpdatePointActionAutoAssignRuleRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\UpdatePointActionAutoAssignRuleResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\WearOrgHonorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\WearOrgHonorRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\WearOrgHonorResponse;
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
     * @param AssignOrgHoldingToEmpHoldingBatchRequest $request
     *
     * @return AssignOrgHoldingToEmpHoldingBatchResponse
     */
    public function assignOrgHoldingToEmpHoldingBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AssignOrgHoldingToEmpHoldingBatchHeaders([]);

        return $this->assignOrgHoldingToEmpHoldingBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AssignOrgHoldingToEmpHoldingBatchRequest $request
     * @param AssignOrgHoldingToEmpHoldingBatchHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return AssignOrgHoldingToEmpHoldingBatchResponse
     */
    public function assignOrgHoldingToEmpHoldingBatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->sendOrgCultureInform)) {
            @$body['sendOrgCultureInform'] = $request->sendOrgCultureInform;
        }
        if (!Utils::isUnset($request->singleAmount)) {
            @$body['singleAmount'] = $request->singleAmount;
        }
        if (!Utils::isUnset($request->sourceUsage)) {
            @$body['sourceUsage'] = $request->sourceUsage;
        }
        if (!Utils::isUnset($request->targetUsage)) {
            @$body['targetUsage'] = $request->targetUsage;
        }
        if (!Utils::isUnset($request->targetUserList)) {
            @$body['targetUserList'] = $request->targetUserList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AssignOrgHoldingToEmpHoldingBatchResponse::fromMap($this->doROARequest('AssignOrgHoldingToEmpHoldingBatch', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', '/v1.0/orgCulture/organizations/points/assign', 'json', $req, $runtime));
    }

    /**
     * @param string                   $userId
     * @param ConsumeUserPointsRequest $request
     *
     * @return ConsumeUserPointsResponse
     */
    public function consumeUserPoints($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConsumeUserPointsHeaders([]);

        return $this->consumeUserPointsWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $userId
     * @param ConsumeUserPointsRequest $request
     * @param ConsumeUserPointsHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return ConsumeUserPointsResponse
     */
    public function consumeUserPointsWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->amount)) {
            @$body['amount'] = $request->amount;
        }
        if (!Utils::isUnset($request->outId)) {
            @$body['outId'] = $request->outId;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->usage)) {
            @$body['usage'] = $request->usage;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ConsumeUserPointsResponse::fromMap($this->doROARequest('ConsumeUserPoints', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', '/v1.0/orgCulture/users/' . $userId . '/points/deduct', 'json', $req, $runtime));
    }

    /**
     * @param CreateOrgHonorRequest $request
     *
     * @return CreateOrgHonorResponse
     */
    public function createOrgHonor($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOrgHonorHeaders([]);

        return $this->createOrgHonorWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateOrgHonorRequest $request
     * @param CreateOrgHonorHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateOrgHonorResponse
     */
    public function createOrgHonorWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->avatarFrameMediaId)) {
            @$body['avatarFrameMediaId'] = $request->avatarFrameMediaId;
        }
        if (!Utils::isUnset($request->defaultBgColor)) {
            @$body['defaultBgColor'] = $request->defaultBgColor;
        }
        if (!Utils::isUnset($request->medalDesc)) {
            @$body['medalDesc'] = $request->medalDesc;
        }
        if (!Utils::isUnset($request->medalMediaId)) {
            @$body['medalMediaId'] = $request->medalMediaId;
        }
        if (!Utils::isUnset($request->medalName)) {
            @$body['medalName'] = $request->medalName;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateOrgHonorResponse::fromMap($this->doROARequest('CreateOrgHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', '/v1.0/orgCulture/honors/templates', 'json', $req, $runtime));
    }

    /**
     * @param DeductionPointBatchRequest $request
     *
     * @return DeductionPointBatchResponse
     */
    public function deductionPointBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeductionPointBatchHeaders([]);

        return $this->deductionPointBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeductionPointBatchRequest $request
     * @param DeductionPointBatchHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return DeductionPointBatchResponse
     */
    public function deductionPointBatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deductionAmount)) {
            @$body['deductionAmount'] = $request->deductionAmount;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->sendOrgCultureInform)) {
            @$body['sendOrgCultureInform'] = $request->sendOrgCultureInform;
        }
        if (!Utils::isUnset($request->targetUserList)) {
            @$body['targetUserList'] = $request->targetUserList;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DeductionPointBatchResponse::fromMap($this->doROARequest('DeductionPointBatch', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', '/v1.0/orgCulture/users/points/deduct', 'json', $req, $runtime));
    }

    /**
     * @param ExportPointOpenRequest $request
     *
     * @return ExportPointOpenResponse
     */
    public function exportPointOpen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExportPointOpenHeaders([]);

        return $this->exportPointOpenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExportPointOpenRequest $request
     * @param ExportPointOpenHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ExportPointOpenResponse
     */
    public function exportPointOpenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->exportDate)) {
            @$body['exportDate'] = $request->exportDate;
        }
        if (!Utils::isUnset($request->exportType)) {
            @$body['exportType'] = $request->exportType;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ExportPointOpenResponse::fromMap($this->doROARequest('ExportPointOpen', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', '/v1.0/orgCulture/users/points/export', 'json', $req, $runtime));
    }

    /**
     * @param string            $honorId
     * @param GrantHonorRequest $request
     *
     * @return GrantHonorResponse
     */
    public function grantHonor($honorId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GrantHonorHeaders([]);

        return $this->grantHonorWithOptions($honorId, $request, $headers, $runtime);
    }

    /**
     * @param string            $honorId
     * @param GrantHonorRequest $request
     * @param GrantHonorHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GrantHonorResponse
     */
    public function grantHonorWithOptions($honorId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $honorId = OpenApiUtilClient::getEncodeParam($honorId);
        $body    = [];
        if (!Utils::isUnset($request->expirationTime)) {
            @$body['expirationTime'] = $request->expirationTime;
        }
        if (!Utils::isUnset($request->grantReason)) {
            @$body['grantReason'] = $request->grantReason;
        }
        if (!Utils::isUnset($request->granterName)) {
            @$body['granterName'] = $request->granterName;
        }
        if (!Utils::isUnset($request->noticeAnnouncer)) {
            @$body['noticeAnnouncer'] = $request->noticeAnnouncer;
        }
        if (!Utils::isUnset($request->noticeSingle)) {
            @$body['noticeSingle'] = $request->noticeSingle;
        }
        if (!Utils::isUnset($request->openConversationIds)) {
            @$body['openConversationIds'] = $request->openConversationIds;
        }
        if (!Utils::isUnset($request->receiverUserIds)) {
            @$body['receiverUserIds'] = $request->receiverUserIds;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GrantHonorResponse::fromMap($this->doROARequest('GrantHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', '/v1.0/orgCulture/honors/' . $honorId . '/grant', 'json', $req, $runtime));
    }

    /**
     * @param QueryCorpPointsRequest $request
     *
     * @return QueryCorpPointsResponse
     */
    public function queryCorpPoints($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCorpPointsHeaders([]);

        return $this->queryCorpPointsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCorpPointsRequest $request
     * @param QueryCorpPointsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryCorpPointsResponse
     */
    public function queryCorpPointsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->optUserId)) {
            @$query['optUserId'] = $request->optUserId;
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

        return QueryCorpPointsResponse::fromMap($this->doROARequest('QueryCorpPoints', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', '/v1.0/orgCulture/organizations/points', 'json', $req, $runtime));
    }

    /**
     * @param QueryEmpPointDetailsRequest $request
     *
     * @return QueryEmpPointDetailsResponse
     */
    public function queryEmpPointDetails($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEmpPointDetailsHeaders([]);

        return $this->queryEmpPointDetailsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryEmpPointDetailsRequest $request
     * @param QueryEmpPointDetailsHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryEmpPointDetailsResponse
     */
    public function queryEmpPointDetailsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
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

        return QueryEmpPointDetailsResponse::fromMap($this->doROARequest('QueryEmpPointDetails', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', '/v1.0/orgCulture/points/empDetails', 'json', $req, $runtime));
    }

    /**
     * @param QueryOrgHonorsRequest $request
     *
     * @return QueryOrgHonorsResponse
     */
    public function queryOrgHonors($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgHonorsHeaders([]);

        return $this->queryOrgHonorsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOrgHonorsRequest $request
     * @param QueryOrgHonorsHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryOrgHonorsResponse
     */
    public function queryOrgHonorsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
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

        return QueryOrgHonorsResponse::fromMap($this->doROARequest('QueryOrgHonors', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', '/v1.0/orgCulture/organizations/honors', 'json', $req, $runtime));
    }

    /**
     * @param QueryOrgPointDetailsRequest $request
     *
     * @return QueryOrgPointDetailsResponse
     */
    public function queryOrgPointDetails($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgPointDetailsHeaders([]);

        return $this->queryOrgPointDetailsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOrgPointDetailsRequest $request
     * @param QueryOrgPointDetailsHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryOrgPointDetailsResponse
     */
    public function queryOrgPointDetailsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountType)) {
            @$query['accountType'] = $request->accountType;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
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

        return QueryOrgPointDetailsResponse::fromMap($this->doROARequest('QueryOrgPointDetails', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', '/v1.0/orgCulture/points/orgDetails', 'json', $req, $runtime));
    }

    /**
     * @return QueryPointActionAutoAssignRuleResponse
     */
    public function queryPointActionAutoAssignRule()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPointActionAutoAssignRuleHeaders([]);

        return $this->queryPointActionAutoAssignRuleWithOptions($headers, $runtime);
    }

    /**
     * @param QueryPointActionAutoAssignRuleHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryPointActionAutoAssignRuleResponse
     */
    public function queryPointActionAutoAssignRuleWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryPointActionAutoAssignRuleResponse::fromMap($this->doROARequest('QueryPointActionAutoAssignRule', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', '/v1.0/orgCulture/users/points/actionRules', 'json', $req, $runtime));
    }

    /**
     * @return QueryPointAutoIssueSettingResponse
     */
    public function queryPointAutoIssueSetting()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPointAutoIssueSettingHeaders([]);

        return $this->queryPointAutoIssueSettingWithOptions($headers, $runtime);
    }

    /**
     * @param QueryPointAutoIssueSettingHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryPointAutoIssueSettingResponse
     */
    public function queryPointAutoIssueSettingWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryPointAutoIssueSettingResponse::fromMap($this->doROARequest('QueryPointAutoIssueSetting', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', '/v1.0/orgCulture/users/points', 'json', $req, $runtime));
    }

    /**
     * @param string                 $userId
     * @param QueryUserHonorsRequest $request
     *
     * @return QueryUserHonorsResponse
     */
    public function queryUserHonors($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserHonorsHeaders([]);

        return $this->queryUserHonorsWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $userId
     * @param QueryUserHonorsRequest $request
     * @param QueryUserHonorsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryUserHonorsResponse
     */
    public function queryUserHonorsWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
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

        return QueryUserHonorsResponse::fromMap($this->doROARequest('QueryUserHonors', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', '/v1.0/orgCulture/honors/users/' . $userId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return QueryUserPointsResponse
     */
    public function queryUserPoints($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserPointsHeaders([]);

        return $this->queryUserPointsWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                 $userId
     * @param QueryUserPointsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryUserPointsResponse
     */
    public function queryUserPointsWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryUserPointsResponse::fromMap($this->doROARequest('QueryUserPoints', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', '/v1.0/orgCulture/users/' . $userId . '/points', 'json', $req, $runtime));
    }

    /**
     * @param string             $honorId
     * @param RecallHonorRequest $request
     *
     * @return RecallHonorResponse
     */
    public function recallHonor($honorId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallHonorHeaders([]);

        return $this->recallHonorWithOptions($honorId, $request, $headers, $runtime);
    }

    /**
     * @param string             $honorId
     * @param RecallHonorRequest $request
     * @param RecallHonorHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return RecallHonorResponse
     */
    public function recallHonorWithOptions($honorId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $honorId = OpenApiUtilClient::getEncodeParam($honorId);
        $body    = [];
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RecallHonorResponse::fromMap($this->doROARequest('RecallHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', '/v1.0/orgCulture/honors/' . $honorId . '/recall', 'json', $req, $runtime));
    }

    /**
     * @param UpdateAutoIssuePointRequest $request
     *
     * @return UpdateAutoIssuePointResponse
     */
    public function updateAutoIssuePoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateAutoIssuePointHeaders([]);

        return $this->updateAutoIssuePointWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateAutoIssuePointRequest $request
     * @param UpdateAutoIssuePointHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateAutoIssuePointResponse
     */
    public function updateAutoIssuePointWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->pointAutoNum)) {
            @$body['pointAutoNum'] = $request->pointAutoNum;
        }
        if (!Utils::isUnset($request->pointAutoState)) {
            @$body['pointAutoState'] = $request->pointAutoState;
        }
        if (!Utils::isUnset($request->pointAutoTime)) {
            @$body['pointAutoTime'] = $request->pointAutoTime;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateAutoIssuePointResponse::fromMap($this->doROARequest('UpdateAutoIssuePoint', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', '/v1.0/orgCulture/users/points/set', 'json', $req, $runtime));
    }

    /**
     * @param UpdatePointActionAutoAssignRuleRequest $request
     *
     * @return UpdatePointActionAutoAssignRuleResponse
     */
    public function updatePointActionAutoAssignRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePointActionAutoAssignRuleHeaders([]);

        return $this->updatePointActionAutoAssignRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdatePointActionAutoAssignRuleRequest $request
     * @param UpdatePointActionAutoAssignRuleHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return UpdatePointActionAutoAssignRuleResponse
     */
    public function updatePointActionAutoAssignRuleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->updatePointRuleRequestDTOList)) {
            @$body['updatePointRuleRequestDTOList'] = $request->updatePointRuleRequestDTOList;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdatePointActionAutoAssignRuleResponse::fromMap($this->doROARequest('UpdatePointActionAutoAssignRule', 'orgCulture_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/orgCulture/users/points/actionRules', 'json', $req, $runtime));
    }

    /**
     * @param string              $honorId
     * @param WearOrgHonorRequest $request
     *
     * @return WearOrgHonorResponse
     */
    public function wearOrgHonor($honorId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WearOrgHonorHeaders([]);

        return $this->wearOrgHonorWithOptions($honorId, $request, $headers, $runtime);
    }

    /**
     * @param string              $honorId
     * @param WearOrgHonorRequest $request
     * @param WearOrgHonorHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return WearOrgHonorResponse
     */
    public function wearOrgHonorWithOptions($honorId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $honorId = OpenApiUtilClient::getEncodeParam($honorId);
        $body    = [];
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->wear)) {
            @$body['wear'] = $request->wear;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return WearOrgHonorResponse::fromMap($this->doROARequest('WearOrgHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', '/v1.0/orgCulture/honors/' . $honorId . '/wear', 'json', $req, $runtime));
    }
}
