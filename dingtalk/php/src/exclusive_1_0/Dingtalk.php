<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoResponse;
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
