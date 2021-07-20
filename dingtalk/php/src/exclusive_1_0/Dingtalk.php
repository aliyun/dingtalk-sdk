<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DeleteCommentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DeleteCommentResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoResponse;
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
}
