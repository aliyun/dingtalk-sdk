<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DeleteCommentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DeleteCommentResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetActiveUserSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetActiveUserSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAllLabelableDeptsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAllLabelableDeptsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCalenderSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCalenderSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConferenceDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConferenceDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDingReportDeptSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDingReportDeptSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDingReportDeptSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedDeptSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedDeptSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedDeptSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGeneralFormCreatedDeptSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGeneralFormCreatedDeptSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGeneralFormCreatedDeptSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGeneralFormCreatedSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGeneralFormCreatedSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetInActiveUserListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetInActiveUserListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetInActiveUserListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOaOperatorLogListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOaOperatorLogListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOaOperatorLogListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPartnerTypeByParentIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPartnerTypeByParentIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublisherSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublisherSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublisherSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserAppVersionSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserAppVersionSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserAppVersionSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppAvailableVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppAvailableVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppAvailableVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppHistoryVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppHistoryVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppHistoryVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RollbackMiniAppVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RollbackMiniAppVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RollbackMiniAppVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendAppDingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendAppDingRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendAppDingResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetDeptPartnerTypeAndNumHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetDeptPartnerTypeAndNumRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetDeptPartnerTypeAndNumResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateMiniAppVersionStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateMiniAppVersionStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateMiniAppVersionStatusResponse;
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
     * @param string $conferenceId
     *
     * @return GetConferenceDetailResponse
     */
    public function getConferenceDetail($conferenceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConferenceDetailHeaders([]);

        return $this->getConferenceDetailWithOptions($conferenceId, $headers, $runtime);
    }

    /**
     * @param string                     $conferenceId
     * @param GetConferenceDetailHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetConferenceDetailResponse
     */
    public function getConferenceDetailWithOptions($conferenceId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetConferenceDetailResponse::fromMap($this->doROARequest('GetConferenceDetail', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/conferences/' . $conferenceId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                          $dataId
     * @param GetUserAppVersionSummaryRequest $request
     *
     * @return GetUserAppVersionSummaryResponse
     */
    public function getUserAppVersionSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserAppVersionSummaryHeaders([]);

        return $this->getUserAppVersionSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param string                          $dataId
     * @param GetUserAppVersionSummaryRequest $request
     * @param GetUserAppVersionSummaryHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetUserAppVersionSummaryResponse
     */
    public function getUserAppVersionSummaryWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetUserAppVersionSummaryResponse::fromMap($this->doROARequest('GetUserAppVersionSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/appVersion/org/' . $dataId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $publisherId
     * @param string $commentId
     *
     * @return DeleteCommentResponse
     */
    public function deleteComment($publisherId, $commentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCommentHeaders([]);

        return $this->deleteCommentWithOptions($publisherId, $commentId, $headers, $runtime);
    }

    /**
     * @param string               $publisherId
     * @param string               $commentId
     * @param DeleteCommentHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DeleteCommentResponse
     */
    public function deleteCommentWithOptions($publisherId, $commentId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DeleteCommentResponse::fromMap($this->doROARequest('DeleteComment', 'exclusive_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/exclusive/publishers/' . $publisherId . '/comments/' . $commentId . '', 'boolean', $req, $runtime));
    }

    /**
     * @param ListMiniAppHistoryVersionRequest $request
     *
     * @return ListMiniAppHistoryVersionResponse
     */
    public function listMiniAppHistoryVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMiniAppHistoryVersionHeaders([]);

        return $this->listMiniAppHistoryVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListMiniAppHistoryVersionRequest $request
     * @param ListMiniAppHistoryVersionHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return ListMiniAppHistoryVersionResponse
     */
    public function listMiniAppHistoryVersionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            @$query['miniAppId'] = $request->miniAppId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListMiniAppHistoryVersionResponse::fromMap($this->doROARequest('ListMiniAppHistoryVersion', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/miniApps/versions/historyLists', 'json', $req, $runtime));
    }

    /**
     * @param string                          $dataId
     * @param GetDocCreatedDeptSummaryRequest $request
     *
     * @return GetDocCreatedDeptSummaryResponse
     */
    public function getDocCreatedDeptSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDocCreatedDeptSummaryHeaders([]);

        return $this->getDocCreatedDeptSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param string                          $dataId
     * @param GetDocCreatedDeptSummaryRequest $request
     * @param GetDocCreatedDeptSummaryHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetDocCreatedDeptSummaryResponse
     */
    public function getDocCreatedDeptSummaryWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetDocCreatedDeptSummaryResponse::fromMap($this->doROARequest('GetDocCreatedDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/doc/dept/' . $dataId . '', 'json', $req, $runtime));
    }

    /**
     * @param CreateTrustedDeviceRequest $request
     *
     * @return CreateTrustedDeviceResponse
     */
    public function createTrustedDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTrustedDeviceHeaders([]);

        return $this->createTrustedDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateTrustedDeviceRequest $request
     * @param CreateTrustedDeviceHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return CreateTrustedDeviceResponse
     */
    public function createTrustedDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->platform)) {
            @$body['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->macAddress)) {
            @$body['macAddress'] = $request->macAddress;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateTrustedDeviceResponse::fromMap($this->doROARequest('CreateTrustedDevice', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/trustedDevices', 'json', $req, $runtime));
    }

    /**
     * @param string $parentId
     *
     * @return GetPartnerTypeByParentIdResponse
     */
    public function getPartnerTypeByParentId($parentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPartnerTypeByParentIdHeaders([]);

        return $this->getPartnerTypeByParentIdWithOptions($parentId, $headers, $runtime);
    }

    /**
     * @param string                          $parentId
     * @param GetPartnerTypeByParentIdHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetPartnerTypeByParentIdResponse
     */
    public function getPartnerTypeByParentIdWithOptions($parentId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetPartnerTypeByParentIdResponse::fromMap($this->doROARequest('GetPartnerTypeByParentId', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/partnerLabels/' . $parentId . '', 'json', $req, $runtime));
    }

    /**
     * @param SetDeptPartnerTypeAndNumRequest $request
     *
     * @return SetDeptPartnerTypeAndNumResponse
     */
    public function setDeptPartnerTypeAndNum($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetDeptPartnerTypeAndNumHeaders([]);

        return $this->setDeptPartnerTypeAndNumWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SetDeptPartnerTypeAndNumRequest $request
     * @param SetDeptPartnerTypeAndNumHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return SetDeptPartnerTypeAndNumResponse
     */
    public function setDeptPartnerTypeAndNumWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            @$body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->partnerNum)) {
            @$body['partnerNum'] = $request->partnerNum;
        }
        if (!Utils::isUnset($request->labelIds)) {
            @$body['labelIds'] = $request->labelIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SetDeptPartnerTypeAndNumResponse::fromMap($this->doROARequest('SetDeptPartnerTypeAndNum', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/partnerDepartments', 'none', $req, $runtime));
    }

    /**
     * @param string $dataId
     *
     * @return GetActiveUserSummaryResponse
     */
    public function getActiveUserSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActiveUserSummaryHeaders([]);

        return $this->getActiveUserSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @param string                      $dataId
     * @param GetActiveUserSummaryHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetActiveUserSummaryResponse
     */
    public function getActiveUserSummaryWithOptions($dataId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetActiveUserSummaryResponse::fromMap($this->doROARequest('GetActiveUserSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/dau/org/' . $dataId . '', 'json', $req, $runtime));
    }

    /**
     * @param GetOaOperatorLogListRequest $request
     *
     * @return GetOaOperatorLogListResponse
     */
    public function getOaOperatorLogList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOaOperatorLogListHeaders([]);

        return $this->getOaOperatorLogListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOaOperatorLogListRequest $request
     * @param GetOaOperatorLogListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetOaOperatorLogListResponse
     */
    public function getOaOperatorLogListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->categoryList)) {
            @$body['categoryList'] = $request->categoryList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetOaOperatorLogListResponse::fromMap($this->doROARequest('GetOaOperatorLogList', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/oaOperatorLogs/query', 'json', $req, $runtime));
    }

    /**
     * @param RollbackMiniAppVersionRequest $request
     *
     * @return RollbackMiniAppVersionResponse
     */
    public function rollbackMiniAppVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RollbackMiniAppVersionHeaders([]);

        return $this->rollbackMiniAppVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RollbackMiniAppVersionRequest $request
     * @param RollbackMiniAppVersionHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return RollbackMiniAppVersionResponse
     */
    public function rollbackMiniAppVersionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            @$body['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->rollbackVersion)) {
            @$body['rollbackVersion'] = $request->rollbackVersion;
        }
        if (!Utils::isUnset($request->targetVersion)) {
            @$body['targetVersion'] = $request->targetVersion;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            @$body['miniAppId'] = $request->miniAppId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RollbackMiniAppVersionResponse::fromMap($this->doROARequest('RollbackMiniAppVersion', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/miniApps/versions/rollback', 'json', $req, $runtime));
    }

    /**
     * @param string                                  $dataId
     * @param GetGeneralFormCreatedDeptSummaryRequest $request
     *
     * @return GetGeneralFormCreatedDeptSummaryResponse
     */
    public function getGeneralFormCreatedDeptSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGeneralFormCreatedDeptSummaryHeaders([]);

        return $this->getGeneralFormCreatedDeptSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param string                                  $dataId
     * @param GetGeneralFormCreatedDeptSummaryRequest $request
     * @param GetGeneralFormCreatedDeptSummaryHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return GetGeneralFormCreatedDeptSummaryResponse
     */
    public function getGeneralFormCreatedDeptSummaryWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetGeneralFormCreatedDeptSummaryResponse::fromMap($this->doROARequest('GetGeneralFormCreatedDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/generalForm/dept/' . $dataId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $dataId
     *
     * @return GetCalenderSummaryResponse
     */
    public function getCalenderSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCalenderSummaryHeaders([]);

        return $this->getCalenderSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @param string                    $dataId
     * @param GetCalenderSummaryHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetCalenderSummaryResponse
     */
    public function getCalenderSummaryWithOptions($dataId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetCalenderSummaryResponse::fromMap($this->doROARequest('GetCalenderSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/calendar/org/' . $dataId . '', 'json', $req, $runtime));
    }

    /**
     * @return GetAllLabelableDeptsResponse
     */
    public function getAllLabelableDepts()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllLabelableDeptsHeaders([]);

        return $this->getAllLabelableDeptsWithOptions($headers, $runtime);
    }

    /**
     * @param GetAllLabelableDeptsHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetAllLabelableDeptsResponse
     */
    public function getAllLabelableDeptsWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetAllLabelableDeptsResponse::fromMap($this->doROARequest('GetAllLabelableDepts', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/partnerDepartments', 'json', $req, $runtime));
    }

    /**
     * @param string                     $dataId
     * @param GetPublisherSummaryRequest $request
     *
     * @return GetPublisherSummaryResponse
     */
    public function getPublisherSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPublisherSummaryHeaders([]);

        return $this->getPublisherSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $dataId
     * @param GetPublisherSummaryRequest $request
     * @param GetPublisherSummaryHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetPublisherSummaryResponse
     */
    public function getPublisherSummaryWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetPublisherSummaryResponse::fromMap($this->doROARequest('GetPublisherSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/publisher/' . $dataId . '', 'json', $req, $runtime));
    }

    /**
     * @param UpdateMiniAppVersionStatusRequest $request
     *
     * @return UpdateMiniAppVersionStatusResponse
     */
    public function updateMiniAppVersionStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMiniAppVersionStatusHeaders([]);

        return $this->updateMiniAppVersionStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateMiniAppVersionStatusRequest $request
     * @param UpdateMiniAppVersionStatusHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return UpdateMiniAppVersionStatusResponse
     */
    public function updateMiniAppVersionStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->versionType)) {
            @$body['versionType'] = $request->versionType;
        }
        if (!Utils::isUnset($request->version)) {
            @$body['version'] = $request->version;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            @$body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            @$body['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateMiniAppVersionStatusResponse::fromMap($this->doROARequest('UpdateMiniAppVersionStatus', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/miniApps/versions/versionStatus', 'json', $req, $runtime));
    }

    /**
     * @param string $dataId
     *
     * @return GetGeneralFormCreatedSummaryResponse
     */
    public function getGeneralFormCreatedSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGeneralFormCreatedSummaryHeaders([]);

        return $this->getGeneralFormCreatedSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @param string                              $dataId
     * @param GetGeneralFormCreatedSummaryHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return GetGeneralFormCreatedSummaryResponse
     */
    public function getGeneralFormCreatedSummaryWithOptions($dataId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetGeneralFormCreatedSummaryResponse::fromMap($this->doROARequest('GetGeneralFormCreatedSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/generalForm/org/' . $dataId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $dataId
     *
     * @return GetDocCreatedSummaryResponse
     */
    public function getDocCreatedSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDocCreatedSummaryHeaders([]);

        return $this->getDocCreatedSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @param string                      $dataId
     * @param GetDocCreatedSummaryHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetDocCreatedSummaryResponse
     */
    public function getDocCreatedSummaryWithOptions($dataId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetDocCreatedSummaryResponse::fromMap($this->doROARequest('GetDocCreatedSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/doc/org/' . $dataId . '', 'json', $req, $runtime));
    }

    /**
     * @param SendAppDingRequest $request
     *
     * @return SendAppDingResponse
     */
    public function sendAppDing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendAppDingHeaders([]);

        return $this->sendAppDingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendAppDingRequest $request
     * @param SendAppDingHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return SendAppDingResponse
     */
    public function sendAppDingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userids)) {
            @$body['userids'] = $request->userids;
        }
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SendAppDingResponse::fromMap($this->doROARequest('SendAppDing', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/appDings/send', 'none', $req, $runtime));
    }

    /**
     * @param string                          $dataId
     * @param GetDingReportDeptSummaryRequest $request
     *
     * @return GetDingReportDeptSummaryResponse
     */
    public function getDingReportDeptSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDingReportDeptSummaryHeaders([]);

        return $this->getDingReportDeptSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param string                          $dataId
     * @param GetDingReportDeptSummaryRequest $request
     * @param GetDingReportDeptSummaryHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetDingReportDeptSummaryResponse
     */
    public function getDingReportDeptSummaryWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetDingReportDeptSummaryResponse::fromMap($this->doROARequest('GetDingReportDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/report/dept/' . $dataId . '', 'json', $req, $runtime));
    }

    /**
     * @param GetInActiveUserListRequest $request
     *
     * @return GetInActiveUserListResponse
     */
    public function getInActiveUserList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInActiveUserListHeaders([]);

        return $this->getInActiveUserListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetInActiveUserListRequest $request
     * @param GetInActiveUserListHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetInActiveUserListResponse
     */
    public function getInActiveUserListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->statDate)) {
            @$body['statDate'] = $request->statDate;
        }
        if (!Utils::isUnset($request->serviceId)) {
            @$body['serviceId'] = $request->serviceId;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->deptIds)) {
            @$body['deptIds'] = $request->deptIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetInActiveUserListResponse::fromMap($this->doROARequest('GetInActiveUserList', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/inactives/users/query', 'json', $req, $runtime));
    }

    /**
     * @param GetTrustDeviceListRequest $request
     *
     * @return GetTrustDeviceListResponse
     */
    public function getTrustDeviceList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTrustDeviceListHeaders([]);

        return $this->getTrustDeviceListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTrustDeviceListRequest $request
     * @param GetTrustDeviceListHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetTrustDeviceListResponse
     */
    public function getTrustDeviceListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetTrustDeviceListResponse::fromMap($this->doROARequest('GetTrustDeviceList', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/trustedDevices/query', 'json', $req, $runtime));
    }

    /**
     * @param ListMiniAppAvailableVersionRequest $request
     *
     * @return ListMiniAppAvailableVersionResponse
     */
    public function listMiniAppAvailableVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMiniAppAvailableVersionHeaders([]);

        return $this->listMiniAppAvailableVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListMiniAppAvailableVersionRequest $request
     * @param ListMiniAppAvailableVersionHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return ListMiniAppAvailableVersionResponse
     */
    public function listMiniAppAvailableVersionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->versionTypeSet)) {
            @$body['versionTypeSet'] = $request->versionTypeSet;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            @$body['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            @$body['miniAppId'] = $request->miniAppId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ListMiniAppAvailableVersionResponse::fromMap($this->doROARequest('ListMiniAppAvailableVersion', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/miniApps/versions/availableLists', 'json', $req, $runtime));
    }

    /**
     * @param SearchOrgInnerGroupInfoRequest $request
     *
     * @return SearchOrgInnerGroupInfoResponse
     */
    public function searchOrgInnerGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchOrgInnerGroupInfoHeaders([]);

        return $this->searchOrgInnerGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchOrgInnerGroupInfoRequest $request
     * @param SearchOrgInnerGroupInfoHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return SearchOrgInnerGroupInfoResponse
     */
    public function searchOrgInnerGroupInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->groupMembersCountEnd)) {
            @$query['groupMembersCountEnd'] = $request->groupMembersCountEnd;
        }
        if (!Utils::isUnset($request->syncToDingpan)) {
            @$query['syncToDingpan'] = $request->syncToDingpan;
        }
        if (!Utils::isUnset($request->groupOwner)) {
            @$query['groupOwner'] = $request->groupOwner;
        }
        if (!Utils::isUnset($request->createTimeEnd)) {
            @$query['createTimeEnd'] = $request->createTimeEnd;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->createTimeStart)) {
            @$query['createTimeStart'] = $request->createTimeStart;
        }
        if (!Utils::isUnset($request->uuid)) {
            @$query['uuid'] = $request->uuid;
        }
        if (!Utils::isUnset($request->groupMembersCountStart)) {
            @$query['groupMembersCountStart'] = $request->groupMembersCountStart;
        }
        if (!Utils::isUnset($request->lastActiveTimeEnd)) {
            @$query['lastActiveTimeEnd'] = $request->lastActiveTimeEnd;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            @$query['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->groupName)) {
            @$query['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->pageStart)) {
            @$query['pageStart'] = $request->pageStart;
        }
        if (!Utils::isUnset($request->lastActiveTimeStart)) {
            @$query['lastActiveTimeStart'] = $request->lastActiveTimeStart;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return SearchOrgInnerGroupInfoResponse::fromMap($this->doROARequest('SearchOrgInnerGroupInfo', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/securities/orgGroupInfos', 'json', $req, $runtime));
    }

    /**
     * @param GetGroupActiveInfoRequest $request
     *
     * @return GetGroupActiveInfoResponse
     */
    public function getGroupActiveInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGroupActiveInfoHeaders([]);

        return $this->getGroupActiveInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetGroupActiveInfoRequest $request
     * @param GetGroupActiveInfoHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetGroupActiveInfoResponse
     */
    public function getGroupActiveInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
        }
        if (!Utils::isUnset($request->dingGroupId)) {
            @$query['dingGroupId'] = $request->dingGroupId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetGroupActiveInfoResponse::fromMap($this->doROARequest('GetGroupActiveInfo', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/activeGroups', 'json', $req, $runtime));
    }

    /**
     * @param string                $publisherId
     * @param GetCommentListRequest $request
     *
     * @return GetCommentListResponse
     */
    public function getCommentList($publisherId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCommentListHeaders([]);

        return $this->getCommentListWithOptions($publisherId, $request, $headers, $runtime);
    }

    /**
     * @param string                $publisherId
     * @param GetCommentListRequest $request
     * @param GetCommentListHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetCommentListResponse
     */
    public function getCommentListWithOptions($publisherId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetCommentListResponse::fromMap($this->doROARequest('GetCommentList', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/publishers/' . $publisherId . '/comments/list', 'json', $req, $runtime));
    }
}
