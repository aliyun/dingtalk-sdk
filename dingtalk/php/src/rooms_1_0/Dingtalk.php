<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceIpByCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceIpByCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceIpByCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDevicePropertiesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDevicePropertiesRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDevicePropertiesResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupListRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupListResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomListRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomListResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomResponse;
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
     * @param CreateMeetingRoomRequest $request
     *
     * @return CreateMeetingRoomResponse
     */
    public function createMeetingRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMeetingRoomHeaders([]);

        return $this->createMeetingRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateMeetingRoomRequest $request
     * @param CreateMeetingRoomHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CreateMeetingRoomResponse
     */
    public function createMeetingRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupId)) {
            @$body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->isvRoomId)) {
            @$body['isvRoomId'] = $request->isvRoomId;
        }
        if (!Utils::isUnset($request->roomCapacity)) {
            @$body['roomCapacity'] = $request->roomCapacity;
        }
        if (!Utils::isUnset($request->roomLabelIds)) {
            @$body['roomLabelIds'] = $request->roomLabelIds;
        }
        if (!Utils::isUnset($request->roomLocation)) {
            @$body['roomLocation'] = $request->roomLocation;
        }
        if (!Utils::isUnset($request->roomName)) {
            @$body['roomName'] = $request->roomName;
        }
        if (!Utils::isUnset($request->roomPicture)) {
            @$body['roomPicture'] = $request->roomPicture;
        }
        if (!Utils::isUnset($request->roomStatus)) {
            @$body['roomStatus'] = $request->roomStatus;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return CreateMeetingRoomResponse::fromMap($this->doROARequest('CreateMeetingRoom', 'rooms_1.0', 'HTTP', 'POST', 'AK', '/v1.0/rooms/meetingrooms', 'json', $req, $runtime));
    }

    /**
     * @param CreateMeetingRoomGroupRequest $request
     *
     * @return CreateMeetingRoomGroupResponse
     */
    public function createMeetingRoomGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMeetingRoomGroupHeaders([]);

        return $this->createMeetingRoomGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateMeetingRoomGroupRequest $request
     * @param CreateMeetingRoomGroupHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CreateMeetingRoomGroupResponse
     */
    public function createMeetingRoomGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupName)) {
            @$body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->parentGroupId)) {
            @$body['parentGroupId'] = $request->parentGroupId;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return CreateMeetingRoomGroupResponse::fromMap($this->doROARequest('CreateMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'POST', 'AK', '/v1.0/rooms/groups', 'json', $req, $runtime));
    }

    /**
     * @param string                   $roomId
     * @param DeleteMeetingRoomRequest $request
     *
     * @return DeleteMeetingRoomResponse
     */
    public function deleteMeetingRoom($roomId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteMeetingRoomHeaders([]);

        return $this->deleteMeetingRoomWithOptions($roomId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $roomId
     * @param DeleteMeetingRoomRequest $request
     * @param DeleteMeetingRoomHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return DeleteMeetingRoomResponse
     */
    public function deleteMeetingRoomWithOptions($roomId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $roomId = OpenApiUtilClient::getEncodeParam($roomId);
        $query  = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return DeleteMeetingRoomResponse::fromMap($this->doROARequest('DeleteMeetingRoom', 'rooms_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/rooms/meetingRooms/' . $roomId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                        $groupId
     * @param DeleteMeetingRoomGroupRequest $request
     *
     * @return DeleteMeetingRoomGroupResponse
     */
    public function deleteMeetingRoomGroup($groupId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteMeetingRoomGroupHeaders([]);

        return $this->deleteMeetingRoomGroupWithOptions($groupId, $request, $headers, $runtime);
    }

    /**
     * @param string                        $groupId
     * @param DeleteMeetingRoomGroupRequest $request
     * @param DeleteMeetingRoomGroupHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return DeleteMeetingRoomGroupResponse
     */
    public function deleteMeetingRoomGroupWithOptions($groupId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $groupId = OpenApiUtilClient::getEncodeParam($groupId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return DeleteMeetingRoomGroupResponse::fromMap($this->doROARequest('DeleteMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/rooms/groups/' . $groupId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                     $shareCode
     * @param QueryDeviceIpByCodeRequest $request
     *
     * @return QueryDeviceIpByCodeResponse
     */
    public function queryDeviceIpByCode($shareCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceIpByCodeHeaders([]);

        return $this->queryDeviceIpByCodeWithOptions($shareCode, $request, $headers, $runtime);
    }

    /**
     * @param string                     $shareCode
     * @param QueryDeviceIpByCodeRequest $request
     * @param QueryDeviceIpByCodeHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryDeviceIpByCodeResponse
     */
    public function queryDeviceIpByCodeWithOptions($shareCode, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $shareCode = OpenApiUtilClient::getEncodeParam($shareCode);
        $query     = [];
        if (!Utils::isUnset($request->deviceSn)) {
            @$query['deviceSn'] = $request->deviceSn;
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

        return QueryDeviceIpByCodeResponse::fromMap($this->doROARequest('QueryDeviceIpByCode', 'rooms_1.0', 'HTTP', 'GET', 'AK', '/v1.0/rooms/devices/shareCodes/' . $shareCode . '', 'json', $req, $runtime));
    }

    /**
     * @param QueryDevicePropertiesRequest $request
     *
     * @return QueryDevicePropertiesResponse
     */
    public function queryDeviceProperties($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDevicePropertiesHeaders([]);

        return $this->queryDevicePropertiesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDevicePropertiesRequest $request
     * @param QueryDevicePropertiesHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryDevicePropertiesResponse
     */
    public function queryDevicePropertiesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deviceId)) {
            @$query['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->deviceUnionId)) {
            @$query['deviceUnionId'] = $request->deviceUnionId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            @$query['operatorUnionId'] = $request->operatorUnionId;
        }
        $body = [];
        if (!Utils::isUnset($request->propertyNames)) {
            @$body['propertyNames'] = $request->propertyNames;
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

        return QueryDevicePropertiesResponse::fromMap($this->doROARequest('QueryDeviceProperties', 'rooms_1.0', 'HTTP', 'POST', 'AK', '/v1.0/rooms/devices/properties/query', 'json', $req, $runtime));
    }

    /**
     * @param string                  $roomId
     * @param QueryMeetingRoomRequest $request
     *
     * @return QueryMeetingRoomResponse
     */
    public function queryMeetingRoom($roomId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMeetingRoomHeaders([]);

        return $this->queryMeetingRoomWithOptions($roomId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $roomId
     * @param QueryMeetingRoomRequest $request
     * @param QueryMeetingRoomHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryMeetingRoomResponse
     */
    public function queryMeetingRoomWithOptions($roomId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $roomId = OpenApiUtilClient::getEncodeParam($roomId);
        $query  = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return QueryMeetingRoomResponse::fromMap($this->doROARequest('QueryMeetingRoom', 'rooms_1.0', 'HTTP', 'GET', 'AK', '/v1.0/rooms/meetingRooms/' . $roomId . '', 'json', $req, $runtime));
    }

    /**
     * @param QueryMeetingRoomDeviceRequest $request
     *
     * @return QueryMeetingRoomDeviceResponse
     */
    public function queryMeetingRoomDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMeetingRoomDeviceHeaders([]);

        return $this->queryMeetingRoomDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryMeetingRoomDeviceRequest $request
     * @param QueryMeetingRoomDeviceHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryMeetingRoomDeviceResponse
     */
    public function queryMeetingRoomDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deviceId)) {
            @$query['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->deviceUnionId)) {
            @$query['deviceUnionId'] = $request->deviceUnionId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            @$query['operatorUnionId'] = $request->operatorUnionId;
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

        return QueryMeetingRoomDeviceResponse::fromMap($this->doROARequest('QueryMeetingRoomDevice', 'rooms_1.0', 'HTTP', 'GET', 'AK', '/v1.0/rooms/devices', 'json', $req, $runtime));
    }

    /**
     * @param string                       $groupId
     * @param QueryMeetingRoomGroupRequest $request
     *
     * @return QueryMeetingRoomGroupResponse
     */
    public function queryMeetingRoomGroup($groupId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMeetingRoomGroupHeaders([]);

        return $this->queryMeetingRoomGroupWithOptions($groupId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $groupId
     * @param QueryMeetingRoomGroupRequest $request
     * @param QueryMeetingRoomGroupHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryMeetingRoomGroupResponse
     */
    public function queryMeetingRoomGroupWithOptions($groupId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $groupId = OpenApiUtilClient::getEncodeParam($groupId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return QueryMeetingRoomGroupResponse::fromMap($this->doROARequest('QueryMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'GET', 'AK', '/v1.0/rooms/groups/' . $groupId . '', 'json', $req, $runtime));
    }

    /**
     * @param QueryMeetingRoomGroupListRequest $request
     *
     * @return QueryMeetingRoomGroupListResponse
     */
    public function queryMeetingRoomGroupList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMeetingRoomGroupListHeaders([]);

        return $this->queryMeetingRoomGroupListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryMeetingRoomGroupListRequest $request
     * @param QueryMeetingRoomGroupListHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryMeetingRoomGroupListResponse
     */
    public function queryMeetingRoomGroupListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return QueryMeetingRoomGroupListResponse::fromMap($this->doROARequest('QueryMeetingRoomGroupList', 'rooms_1.0', 'HTTP', 'GET', 'AK', '/v1.0/rooms/groupLists', 'json', $req, $runtime));
    }

    /**
     * @param QueryMeetingRoomListRequest $request
     *
     * @return QueryMeetingRoomListResponse
     */
    public function queryMeetingRoomList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMeetingRoomListHeaders([]);

        return $this->queryMeetingRoomListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryMeetingRoomListRequest $request
     * @param QueryMeetingRoomListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryMeetingRoomListResponse
     */
    public function queryMeetingRoomListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return QueryMeetingRoomListResponse::fromMap($this->doROARequest('QueryMeetingRoomList', 'rooms_1.0', 'HTTP', 'GET', 'AK', '/v1.0/rooms/meetingRoomLists', 'json', $req, $runtime));
    }

    /**
     * @param UpdateMeetingRoomRequest $request
     *
     * @return UpdateMeetingRoomResponse
     */
    public function updateMeetingRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMeetingRoomHeaders([]);

        return $this->updateMeetingRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateMeetingRoomRequest $request
     * @param UpdateMeetingRoomHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return UpdateMeetingRoomResponse
     */
    public function updateMeetingRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupId)) {
            @$body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->isvRoomId)) {
            @$body['isvRoomId'] = $request->isvRoomId;
        }
        if (!Utils::isUnset($request->roomCapacity)) {
            @$body['roomCapacity'] = $request->roomCapacity;
        }
        if (!Utils::isUnset($request->roomId)) {
            @$body['roomId'] = $request->roomId;
        }
        if (!Utils::isUnset($request->roomLabelIds)) {
            @$body['roomLabelIds'] = $request->roomLabelIds;
        }
        if (!Utils::isUnset($request->roomLocation)) {
            @$body['roomLocation'] = $request->roomLocation;
        }
        if (!Utils::isUnset($request->roomName)) {
            @$body['roomName'] = $request->roomName;
        }
        if (!Utils::isUnset($request->roomPicture)) {
            @$body['roomPicture'] = $request->roomPicture;
        }
        if (!Utils::isUnset($request->roomStatus)) {
            @$body['roomStatus'] = $request->roomStatus;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return UpdateMeetingRoomResponse::fromMap($this->doROARequest('UpdateMeetingRoom', 'rooms_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/rooms/meetingRooms', 'json', $req, $runtime));
    }

    /**
     * @param UpdateMeetingRoomGroupRequest $request
     *
     * @return UpdateMeetingRoomGroupResponse
     */
    public function updateMeetingRoomGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMeetingRoomGroupHeaders([]);

        return $this->updateMeetingRoomGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateMeetingRoomGroupRequest $request
     * @param UpdateMeetingRoomGroupHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return UpdateMeetingRoomGroupResponse
     */
    public function updateMeetingRoomGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupId)) {
            @$body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->groupName)) {
            @$body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return UpdateMeetingRoomGroupResponse::fromMap($this->doROARequest('UpdateMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/rooms/groups', 'json', $req, $runtime));
    }
}
