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
     * @summary 批量发放积分或额度
     *  *
     * @param AssignOrgHoldingToEmpHoldingBatchRequest $request AssignOrgHoldingToEmpHoldingBatchRequest
     * @param AssignOrgHoldingToEmpHoldingBatchHeaders $headers AssignOrgHoldingToEmpHoldingBatchHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return AssignOrgHoldingToEmpHoldingBatchResponse AssignOrgHoldingToEmpHoldingBatchResponse
     */
    public function assignOrgHoldingToEmpHoldingBatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->sendOrgCultureInform)) {
            $body['sendOrgCultureInform'] = $request->sendOrgCultureInform;
        }
        if (!Utils::isUnset($request->singleAmount)) {
            $body['singleAmount'] = $request->singleAmount;
        }
        if (!Utils::isUnset($request->sourceUsage)) {
            $body['sourceUsage'] = $request->sourceUsage;
        }
        if (!Utils::isUnset($request->targetUsage)) {
            $body['targetUsage'] = $request->targetUsage;
        }
        if (!Utils::isUnset($request->targetUserList)) {
            $body['targetUserList'] = $request->targetUserList;
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
            'action' => 'AssignOrgHoldingToEmpHoldingBatch',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/organizations/points/assign',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AssignOrgHoldingToEmpHoldingBatchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量发放积分或额度
     *  *
     * @param AssignOrgHoldingToEmpHoldingBatchRequest $request AssignOrgHoldingToEmpHoldingBatchRequest
     *
     * @return AssignOrgHoldingToEmpHoldingBatchResponse AssignOrgHoldingToEmpHoldingBatchResponse
     */
    public function assignOrgHoldingToEmpHoldingBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AssignOrgHoldingToEmpHoldingBatchHeaders([]);

        return $this->assignOrgHoldingToEmpHoldingBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 扣减员工积分
     *  *
     * @param string                   $userId
     * @param ConsumeUserPointsRequest $request ConsumeUserPointsRequest
     * @param ConsumeUserPointsHeaders $headers ConsumeUserPointsHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return ConsumeUserPointsResponse ConsumeUserPointsResponse
     */
    public function consumeUserPointsWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->amount)) {
            $body['amount'] = $request->amount;
        }
        if (!Utils::isUnset($request->outId)) {
            $body['outId'] = $request->outId;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->usage)) {
            $body['usage'] = $request->usage;
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
            'action' => 'ConsumeUserPoints',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/users/' . $userId . '/points/deduct',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ConsumeUserPointsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 扣减员工积分
     *  *
     * @param string                   $userId
     * @param ConsumeUserPointsRequest $request ConsumeUserPointsRequest
     *
     * @return ConsumeUserPointsResponse ConsumeUserPointsResponse
     */
    public function consumeUserPoints($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConsumeUserPointsHeaders([]);

        return $this->consumeUserPointsWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建荣誉勋章模板
     *  *
     * @param CreateOrgHonorRequest $request CreateOrgHonorRequest
     * @param CreateOrgHonorHeaders $headers CreateOrgHonorHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateOrgHonorResponse CreateOrgHonorResponse
     */
    public function createOrgHonorWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->avatarFrameMediaId)) {
            $body['avatarFrameMediaId'] = $request->avatarFrameMediaId;
        }
        if (!Utils::isUnset($request->defaultBgColor)) {
            $body['defaultBgColor'] = $request->defaultBgColor;
        }
        if (!Utils::isUnset($request->medalDesc)) {
            $body['medalDesc'] = $request->medalDesc;
        }
        if (!Utils::isUnset($request->medalMediaId)) {
            $body['medalMediaId'] = $request->medalMediaId;
        }
        if (!Utils::isUnset($request->medalName)) {
            $body['medalName'] = $request->medalName;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action' => 'CreateOrgHonor',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/honors/templates',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateOrgHonorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建荣誉勋章模板
     *  *
     * @param CreateOrgHonorRequest $request CreateOrgHonorRequest
     *
     * @return CreateOrgHonorResponse CreateOrgHonorResponse
     */
    public function createOrgHonor($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOrgHonorHeaders([]);

        return $this->createOrgHonorWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量扣减积分
     *  *
     * @param DeductionPointBatchRequest $request DeductionPointBatchRequest
     * @param DeductionPointBatchHeaders $headers DeductionPointBatchHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return DeductionPointBatchResponse DeductionPointBatchResponse
     */
    public function deductionPointBatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deductionAmount)) {
            $body['deductionAmount'] = $request->deductionAmount;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->sendOrgCultureInform)) {
            $body['sendOrgCultureInform'] = $request->sendOrgCultureInform;
        }
        if (!Utils::isUnset($request->targetUserList)) {
            $body['targetUserList'] = $request->targetUserList;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action' => 'DeductionPointBatch',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/users/points/deduct',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeductionPointBatchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量扣减积分
     *  *
     * @param DeductionPointBatchRequest $request DeductionPointBatchRequest
     *
     * @return DeductionPointBatchResponse DeductionPointBatchResponse
     */
    public function deductionPointBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeductionPointBatchHeaders([]);

        return $this->deductionPointBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 积分榜单导出
     *  *
     * @param ExportPointOpenRequest $request ExportPointOpenRequest
     * @param ExportPointOpenHeaders $headers ExportPointOpenHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ExportPointOpenResponse ExportPointOpenResponse
     */
    public function exportPointOpenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->exportDate)) {
            $body['exportDate'] = $request->exportDate;
        }
        if (!Utils::isUnset($request->exportType)) {
            $body['exportType'] = $request->exportType;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action' => 'ExportPointOpen',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/users/points/export',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ExportPointOpenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 积分榜单导出
     *  *
     * @param ExportPointOpenRequest $request ExportPointOpenRequest
     *
     * @return ExportPointOpenResponse ExportPointOpenResponse
     */
    public function exportPointOpen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExportPointOpenHeaders([]);

        return $this->exportPointOpenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 授予荣誉 异步执行
     *  *
     * @param string            $honorId
     * @param GrantHonorRequest $request GrantHonorRequest
     * @param GrantHonorHeaders $headers GrantHonorHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GrantHonorResponse GrantHonorResponse
     */
    public function grantHonorWithOptions($honorId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->expirationTime)) {
            $body['expirationTime'] = $request->expirationTime;
        }
        if (!Utils::isUnset($request->grantReason)) {
            $body['grantReason'] = $request->grantReason;
        }
        if (!Utils::isUnset($request->granterName)) {
            $body['granterName'] = $request->granterName;
        }
        if (!Utils::isUnset($request->noticeAnnouncer)) {
            $body['noticeAnnouncer'] = $request->noticeAnnouncer;
        }
        if (!Utils::isUnset($request->noticeSingle)) {
            $body['noticeSingle'] = $request->noticeSingle;
        }
        if (!Utils::isUnset($request->openConversationIds)) {
            $body['openConversationIds'] = $request->openConversationIds;
        }
        if (!Utils::isUnset($request->receiverUserIds)) {
            $body['receiverUserIds'] = $request->receiverUserIds;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GrantHonor',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/honors/' . $honorId . '/grant',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GrantHonorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 授予荣誉 异步执行
     *  *
     * @param string            $honorId
     * @param GrantHonorRequest $request GrantHonorRequest
     *
     * @return GrantHonorResponse GrantHonorResponse
     */
    public function grantHonor($honorId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GrantHonorHeaders([]);

        return $this->grantHonorWithOptions($honorId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询当前企业下可兑换的积分
     *  *
     * @param QueryCorpPointsRequest $request QueryCorpPointsRequest
     * @param QueryCorpPointsHeaders $headers QueryCorpPointsHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCorpPointsResponse QueryCorpPointsResponse
     */
    public function queryCorpPointsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->optUserId)) {
            $query['optUserId'] = $request->optUserId;
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
            'action' => 'QueryCorpPoints',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/organizations/points',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryCorpPointsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询当前企业下可兑换的积分
     *  *
     * @param QueryCorpPointsRequest $request QueryCorpPointsRequest
     *
     * @return QueryCorpPointsResponse QueryCorpPointsResponse
     */
    public function queryCorpPoints($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCorpPointsHeaders([]);

        return $this->queryCorpPointsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询个人积分使用明细
     *  *
     * @param QueryEmpPointDetailsRequest $request QueryEmpPointDetailsRequest
     * @param QueryEmpPointDetailsHeaders $headers QueryEmpPointDetailsHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryEmpPointDetailsResponse QueryEmpPointDetailsResponse
     */
    public function queryEmpPointDetailsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action' => 'QueryEmpPointDetails',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/points/empDetails',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryEmpPointDetailsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询个人积分使用明细
     *  *
     * @param QueryEmpPointDetailsRequest $request QueryEmpPointDetailsRequest
     *
     * @return QueryEmpPointDetailsResponse QueryEmpPointDetailsResponse
     */
    public function queryEmpPointDetails($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEmpPointDetailsHeaders([]);

        return $this->queryEmpPointDetailsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取组织荣誉
     *  *
     * @param QueryOrgHonorsRequest $request QueryOrgHonorsRequest
     * @param QueryOrgHonorsHeaders $headers QueryOrgHonorsHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOrgHonorsResponse QueryOrgHonorsResponse
     */
    public function queryOrgHonorsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
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
            'action' => 'QueryOrgHonors',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/organizations/honors',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryOrgHonorsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取组织荣誉
     *  *
     * @param QueryOrgHonorsRequest $request QueryOrgHonorsRequest
     *
     * @return QueryOrgHonorsResponse QueryOrgHonorsResponse
     */
    public function queryOrgHonors($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgHonorsHeaders([]);

        return $this->queryOrgHonorsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询组织发放扣除积分明细
     *  *
     * @param QueryOrgPointDetailsRequest $request QueryOrgPointDetailsRequest
     * @param QueryOrgPointDetailsHeaders $headers QueryOrgPointDetailsHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOrgPointDetailsResponse QueryOrgPointDetailsResponse
     */
    public function queryOrgPointDetailsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountType)) {
            $query['accountType'] = $request->accountType;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action' => 'QueryOrgPointDetails',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/points/orgDetails',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryOrgPointDetailsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询组织发放扣除积分明细
     *  *
     * @param QueryOrgPointDetailsRequest $request QueryOrgPointDetailsRequest
     *
     * @return QueryOrgPointDetailsResponse QueryOrgPointDetailsResponse
     */
    public function queryOrgPointDetails($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgPointDetailsHeaders([]);

        return $this->queryOrgPointDetailsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询积分自动发放行为规则
     *  *
     * @param QueryPointActionAutoAssignRuleHeaders $headers QueryPointActionAutoAssignRuleHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPointActionAutoAssignRuleResponse QueryPointActionAutoAssignRuleResponse
     */
    public function queryPointActionAutoAssignRuleWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'QueryPointActionAutoAssignRule',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/users/points/actionRules',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryPointActionAutoAssignRuleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询积分自动发放行为规则
     *  *
     * @return QueryPointActionAutoAssignRuleResponse QueryPointActionAutoAssignRuleResponse
     */
    public function queryPointActionAutoAssignRule()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPointActionAutoAssignRuleHeaders([]);

        return $this->queryPointActionAutoAssignRuleWithOptions($headers, $runtime);
    }

    /**
     * @summary 每月自动发放额度查询
     *  *
     * @param QueryPointAutoIssueSettingHeaders $headers QueryPointAutoIssueSettingHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPointAutoIssueSettingResponse QueryPointAutoIssueSettingResponse
     */
    public function queryPointAutoIssueSettingWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'QueryPointAutoIssueSetting',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/users/points',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryPointAutoIssueSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 每月自动发放额度查询
     *  *
     * @return QueryPointAutoIssueSettingResponse QueryPointAutoIssueSettingResponse
     */
    public function queryPointAutoIssueSetting()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPointAutoIssueSettingHeaders([]);

        return $this->queryPointAutoIssueSettingWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询员工已获得的组织荣誉列表
     *  *
     * @param string                 $userId
     * @param QueryUserHonorsRequest $request QueryUserHonorsRequest
     * @param QueryUserHonorsHeaders $headers QueryUserHonorsHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserHonorsResponse QueryUserHonorsResponse
     */
    public function queryUserHonorsWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
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
            'action' => 'QueryUserHonors',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/honors/users/' . $userId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUserHonorsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询员工已获得的组织荣誉列表
     *  *
     * @param string                 $userId
     * @param QueryUserHonorsRequest $request QueryUserHonorsRequest
     *
     * @return QueryUserHonorsResponse QueryUserHonorsResponse
     */
    public function queryUserHonors($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserHonorsHeaders([]);

        return $this->queryUserHonorsWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询员工已获得的积分
     *  *
     * @param string                 $userId
     * @param QueryUserPointsHeaders $headers QueryUserPointsHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserPointsResponse QueryUserPointsResponse
     */
    public function queryUserPointsWithOptions($userId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'QueryUserPoints',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/users/' . $userId . '/points',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUserPointsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询员工已获得的积分
     *  *
     * @param string $userId
     *
     * @return QueryUserPointsResponse QueryUserPointsResponse
     */
    public function queryUserPoints($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserPointsHeaders([]);

        return $this->queryUserPointsWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 撤销员工获得的荣誉勋章
     *  *
     * @param string             $honorId
     * @param RecallHonorRequest $request RecallHonorRequest
     * @param RecallHonorHeaders $headers RecallHonorHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return RecallHonorResponse RecallHonorResponse
     */
    public function recallHonorWithOptions($honorId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action' => 'RecallHonor',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/honors/' . $honorId . '/recall',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RecallHonorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 撤销员工获得的荣誉勋章
     *  *
     * @param string             $honorId
     * @param RecallHonorRequest $request RecallHonorRequest
     *
     * @return RecallHonorResponse RecallHonorResponse
     */
    public function recallHonor($honorId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallHonorHeaders([]);

        return $this->recallHonorWithOptions($honorId, $request, $headers, $runtime);
    }

    /**
     * @summary 每月自动发放额度修改
     *  *
     * @param UpdateAutoIssuePointRequest $request UpdateAutoIssuePointRequest
     * @param UpdateAutoIssuePointHeaders $headers UpdateAutoIssuePointHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateAutoIssuePointResponse UpdateAutoIssuePointResponse
     */
    public function updateAutoIssuePointWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->pointAutoNum)) {
            $body['pointAutoNum'] = $request->pointAutoNum;
        }
        if (!Utils::isUnset($request->pointAutoState)) {
            $body['pointAutoState'] = $request->pointAutoState;
        }
        if (!Utils::isUnset($request->pointAutoTime)) {
            $body['pointAutoTime'] = $request->pointAutoTime;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action' => 'UpdateAutoIssuePoint',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/users/points/set',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateAutoIssuePointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 每月自动发放额度修改
     *  *
     * @param UpdateAutoIssuePointRequest $request UpdateAutoIssuePointRequest
     *
     * @return UpdateAutoIssuePointResponse UpdateAutoIssuePointResponse
     */
    public function updateAutoIssuePoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateAutoIssuePointHeaders([]);

        return $this->updateAutoIssuePointWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改积分系统行为规则
     *  *
     * @param UpdatePointActionAutoAssignRuleRequest $request UpdatePointActionAutoAssignRuleRequest
     * @param UpdatePointActionAutoAssignRuleHeaders $headers UpdatePointActionAutoAssignRuleHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdatePointActionAutoAssignRuleResponse UpdatePointActionAutoAssignRuleResponse
     */
    public function updatePointActionAutoAssignRuleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->updatePointRuleRequestDTOList)) {
            $body['updatePointRuleRequestDTOList'] = $request->updatePointRuleRequestDTOList;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action' => 'UpdatePointActionAutoAssignRule',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/users/points/actionRules',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdatePointActionAutoAssignRuleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改积分系统行为规则
     *  *
     * @param UpdatePointActionAutoAssignRuleRequest $request UpdatePointActionAutoAssignRuleRequest
     *
     * @return UpdatePointActionAutoAssignRuleResponse UpdatePointActionAutoAssignRuleResponse
     */
    public function updatePointActionAutoAssignRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePointActionAutoAssignRuleHeaders([]);

        return $this->updatePointActionAutoAssignRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 佩戴/卸下荣誉勋章
     *  *
     * @param string              $honorId
     * @param WearOrgHonorRequest $request WearOrgHonorRequest
     * @param WearOrgHonorHeaders $headers WearOrgHonorHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return WearOrgHonorResponse WearOrgHonorResponse
     */
    public function wearOrgHonorWithOptions($honorId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->wear)) {
            $body['wear'] = $request->wear;
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
            'action' => 'WearOrgHonor',
            'version' => 'orgCulture_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/orgCulture/honors/' . $honorId . '/wear',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return WearOrgHonorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 佩戴/卸下荣誉勋章
     *  *
     * @param string              $honorId
     * @param WearOrgHonorRequest $request WearOrgHonorRequest
     *
     * @return WearOrgHonorResponse WearOrgHonorResponse
     */
    public function wearOrgHonor($honorId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WearOrgHonorHeaders([]);

        return $this->wearOrgHonorWithOptions($honorId, $request, $headers, $runtime);
    }
}
