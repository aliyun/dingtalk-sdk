<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateDeviceCustomTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateDeviceCustomTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateDeviceCustomTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteDeviceCustomTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteDeviceCustomTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteDeviceCustomTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateListResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\RemoveSuperUserMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\RemoveSuperUserMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\RemoveSuperUserMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\SetSuperUserMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\SetSuperUserMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\SetSuperUserMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateDeviceCustomTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateDeviceCustomTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateDeviceCustomTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param CreateDeviceCustomTemplateRequest $request
     * @param CreateDeviceCustomTemplateHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return CreateDeviceCustomTemplateResponse
     */
    public function createDeviceCustomTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bgImgList)) {
            $body['bgImgList'] = $request->bgImgList;
        }
        if (!Utils::isUnset($request->bgType)) {
            $body['bgType'] = $request->bgType;
        }
        if (!Utils::isUnset($request->bgUrl)) {
            $body['bgUrl'] = $request->bgUrl;
        }
        if (!Utils::isUnset($request->customDoc)) {
            $body['customDoc'] = $request->customDoc;
        }
        if (!Utils::isUnset($request->desensitizeUserName)) {
            $body['desensitizeUserName'] = $request->desensitizeUserName;
        }
        if (!Utils::isUnset($request->deviceUnionIds)) {
            $body['deviceUnionIds'] = $request->deviceUnionIds;
        }
        if (!Utils::isUnset($request->groupIds)) {
            $body['groupIds'] = $request->groupIds;
        }
        if (!Utils::isUnset($request->hideServerCodeWhenProjecting)) {
            $body['hideServerCodeWhenProjecting'] = $request->hideServerCodeWhenProjecting;
        }
        if (!Utils::isUnset($request->instruction)) {
            $body['instruction'] = $request->instruction;
        }
        if (!Utils::isUnset($request->isPicTop)) {
            $body['isPicTop'] = $request->isPicTop;
        }
        if (!Utils::isUnset($request->logo)) {
            $body['logo'] = $request->logo;
        }
        if (!Utils::isUnset($request->orgName)) {
            $body['orgName'] = $request->orgName;
        }
        if (!Utils::isUnset($request->picturePlayInterval)) {
            $body['picturePlayInterval'] = $request->picturePlayInterval;
        }
        if (!Utils::isUnset($request->roomIds)) {
            $body['roomIds'] = $request->roomIds;
        }
        if (!Utils::isUnset($request->showCalendarCard)) {
            $body['showCalendarCard'] = $request->showCalendarCard;
        }
        if (!Utils::isUnset($request->showCalendarTitle)) {
            $body['showCalendarTitle'] = $request->showCalendarTitle;
        }
        if (!Utils::isUnset($request->showFunctionCard)) {
            $body['showFunctionCard'] = $request->showFunctionCard;
        }
        if (!Utils::isUnset($request->templateName)) {
            $body['templateName'] = $request->templateName;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateDeviceCustomTemplate',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/devices/screens/templates',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateDeviceCustomTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateDeviceCustomTemplateRequest $request
     *
     * @return CreateDeviceCustomTemplateResponse
     */
    public function createDeviceCustomTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDeviceCustomTemplateHeaders([]);

        return $this->createDeviceCustomTemplateWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->enableCycleReservation)) {
            $body['enableCycleReservation'] = $request->enableCycleReservation;
        }
        if (!Utils::isUnset($request->groupId)) {
            $body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->isvRoomId)) {
            $body['isvRoomId'] = $request->isvRoomId;
        }
        if (!Utils::isUnset($request->reservationAuthority)) {
            $body['reservationAuthority'] = $request->reservationAuthority;
        }
        if (!Utils::isUnset($request->roomCapacity)) {
            $body['roomCapacity'] = $request->roomCapacity;
        }
        if (!Utils::isUnset($request->roomLabelIds)) {
            $body['roomLabelIds'] = $request->roomLabelIds;
        }
        if (!Utils::isUnset($request->roomLocation)) {
            $body['roomLocation'] = $request->roomLocation;
        }
        if (!Utils::isUnset($request->roomName)) {
            $body['roomName'] = $request->roomName;
        }
        if (!Utils::isUnset($request->roomPicture)) {
            $body['roomPicture'] = $request->roomPicture;
        }
        if (!Utils::isUnset($request->roomStatus)) {
            $body['roomStatus'] = $request->roomStatus;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateMeetingRoom',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/meetingrooms',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->parentGroupId)) {
            $body['parentGroupId'] = $request->parentGroupId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateMeetingRoomGroup',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/groups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateMeetingRoomGroupResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param DeleteDeviceCustomTemplateRequest $request
     * @param DeleteDeviceCustomTemplateHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return DeleteDeviceCustomTemplateResponse
     */
    public function deleteDeviceCustomTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DeleteDeviceCustomTemplate',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/devices/screens/templates/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteDeviceCustomTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteDeviceCustomTemplateRequest $request
     *
     * @return DeleteDeviceCustomTemplateResponse
     */
    public function deleteDeviceCustomTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDeviceCustomTemplateHeaders([]);

        return $this->deleteDeviceCustomTemplateWithOptions($request, $headers, $runtime);
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
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteMeetingRoom',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/meetingRooms/' . $roomId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
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
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteMeetingRoomGroup',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/groups/' . $groupId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteMeetingRoomGroupResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param string                           $templateId
     * @param QueryDeviceCustomTemplateHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryDeviceCustomTemplateResponse
     */
    public function queryDeviceCustomTemplateWithOptions($templateId, $headers, $runtime)
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
            'action'      => 'QueryDeviceCustomTemplate',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/devices/screens/templates/' . $templateId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDeviceCustomTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $templateId
     *
     * @return QueryDeviceCustomTemplateResponse
     */
    public function queryDeviceCustomTemplate($templateId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceCustomTemplateHeaders([]);

        return $this->queryDeviceCustomTemplateWithOptions($templateId, $headers, $runtime);
    }

    /**
     * @param QueryDeviceCustomTemplateListHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return QueryDeviceCustomTemplateListResponse
     */
    public function queryDeviceCustomTemplateListWithOptions($headers, $runtime)
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
            'action'      => 'QueryDeviceCustomTemplateList',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/devices/screens/templateLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDeviceCustomTemplateListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return QueryDeviceCustomTemplateListResponse
     */
    public function queryDeviceCustomTemplateList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceCustomTemplateListHeaders([]);

        return $this->queryDeviceCustomTemplateListWithOptions($headers, $runtime);
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
        $query = [];
        if (!Utils::isUnset($request->deviceSn)) {
            $query['deviceSn'] = $request->deviceSn;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryDeviceIpByCode',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/devices/shareCodes/' . $shareCode . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDeviceIpByCodeResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->deviceUnionId)) {
            $query['deviceUnionId'] = $request->deviceUnionId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $query['operatorUnionId'] = $request->operatorUnionId;
        }
        $body = [];
        if (!Utils::isUnset($request->propertyNames)) {
            $body['propertyNames'] = $request->propertyNames;
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'QueryDeviceProperties',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/devices/properties/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDevicePropertiesResponse::fromMap($this->execute($params, $req, $runtime));
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
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryMeetingRoom',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/meetingRooms/' . $roomId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->deviceUnionId)) {
            $query['deviceUnionId'] = $request->deviceUnionId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $query['operatorUnionId'] = $request->operatorUnionId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryMeetingRoomDevice',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/devices',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMeetingRoomDeviceResponse::fromMap($this->execute($params, $req, $runtime));
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
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryMeetingRoomGroup',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/groups/' . $groupId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMeetingRoomGroupResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['unionId'] = $request->unionId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryMeetingRoomGroupList',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/groupLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMeetingRoomGroupListResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryMeetingRoomList',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/meetingRoomLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMeetingRoomListResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param RemoveSuperUserMeetingRoomRequest $request
     * @param RemoveSuperUserMeetingRoomHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return RemoveSuperUserMeetingRoomResponse
     */
    public function removeSuperUserMeetingRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->roomId)) {
            $query['roomId'] = $request->roomId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'RemoveSuperUserMeetingRoom',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/meetingRooms/superUsers/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RemoveSuperUserMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RemoveSuperUserMeetingRoomRequest $request
     *
     * @return RemoveSuperUserMeetingRoomResponse
     */
    public function removeSuperUserMeetingRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveSuperUserMeetingRoomHeaders([]);

        return $this->removeSuperUserMeetingRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SetSuperUserMeetingRoomRequest $request
     * @param SetSuperUserMeetingRoomHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return SetSuperUserMeetingRoomResponse
     */
    public function setSuperUserMeetingRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIdWhiteList)) {
            $body['deptIdWhiteList'] = $request->deptIdWhiteList;
        }
        if (!Utils::isUnset($request->roomId)) {
            $body['roomId'] = $request->roomId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->userIdWhiteList)) {
            $body['userIdWhiteList'] = $request->userIdWhiteList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SetSuperUserMeetingRoom',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/meetingRooms/superUsers/set',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetSuperUserMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SetSuperUserMeetingRoomRequest $request
     *
     * @return SetSuperUserMeetingRoomResponse
     */
    public function setSuperUserMeetingRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetSuperUserMeetingRoomHeaders([]);

        return $this->setSuperUserMeetingRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateDeviceCustomTemplateRequest $request
     * @param UpdateDeviceCustomTemplateHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return UpdateDeviceCustomTemplateResponse
     */
    public function updateDeviceCustomTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bgImgList)) {
            $body['bgImgList'] = $request->bgImgList;
        }
        if (!Utils::isUnset($request->bgType)) {
            $body['bgType'] = $request->bgType;
        }
        if (!Utils::isUnset($request->bgUrl)) {
            $body['bgUrl'] = $request->bgUrl;
        }
        if (!Utils::isUnset($request->customDoc)) {
            $body['customDoc'] = $request->customDoc;
        }
        if (!Utils::isUnset($request->desensitizeUserName)) {
            $body['desensitizeUserName'] = $request->desensitizeUserName;
        }
        if (!Utils::isUnset($request->deviceUnionIds)) {
            $body['deviceUnionIds'] = $request->deviceUnionIds;
        }
        if (!Utils::isUnset($request->groupIds)) {
            $body['groupIds'] = $request->groupIds;
        }
        if (!Utils::isUnset($request->hideServerCodeWhenProjecting)) {
            $body['hideServerCodeWhenProjecting'] = $request->hideServerCodeWhenProjecting;
        }
        if (!Utils::isUnset($request->instruction)) {
            $body['instruction'] = $request->instruction;
        }
        if (!Utils::isUnset($request->isPicTop)) {
            $body['isPicTop'] = $request->isPicTop;
        }
        if (!Utils::isUnset($request->logo)) {
            $body['logo'] = $request->logo;
        }
        if (!Utils::isUnset($request->orgName)) {
            $body['orgName'] = $request->orgName;
        }
        if (!Utils::isUnset($request->picturePlayInterval)) {
            $body['picturePlayInterval'] = $request->picturePlayInterval;
        }
        if (!Utils::isUnset($request->roomIds)) {
            $body['roomIds'] = $request->roomIds;
        }
        if (!Utils::isUnset($request->showCalendarCard)) {
            $body['showCalendarCard'] = $request->showCalendarCard;
        }
        if (!Utils::isUnset($request->showCalendarTitle)) {
            $body['showCalendarTitle'] = $request->showCalendarTitle;
        }
        if (!Utils::isUnset($request->showFunctionCard)) {
            $body['showFunctionCard'] = $request->showFunctionCard;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->templateName)) {
            $body['templateName'] = $request->templateName;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateDeviceCustomTemplate',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/devices/screens/templates',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateDeviceCustomTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateDeviceCustomTemplateRequest $request
     *
     * @return UpdateDeviceCustomTemplateResponse
     */
    public function updateDeviceCustomTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateDeviceCustomTemplateHeaders([]);

        return $this->updateDeviceCustomTemplateWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->enableCycleReservation)) {
            $body['enableCycleReservation'] = $request->enableCycleReservation;
        }
        if (!Utils::isUnset($request->groupId)) {
            $body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->isvRoomId)) {
            $body['isvRoomId'] = $request->isvRoomId;
        }
        if (!Utils::isUnset($request->reservationAuthority)) {
            $body['reservationAuthority'] = $request->reservationAuthority;
        }
        if (!Utils::isUnset($request->roomCapacity)) {
            $body['roomCapacity'] = $request->roomCapacity;
        }
        if (!Utils::isUnset($request->roomId)) {
            $body['roomId'] = $request->roomId;
        }
        if (!Utils::isUnset($request->roomLabelIds)) {
            $body['roomLabelIds'] = $request->roomLabelIds;
        }
        if (!Utils::isUnset($request->roomLocation)) {
            $body['roomLocation'] = $request->roomLocation;
        }
        if (!Utils::isUnset($request->roomName)) {
            $body['roomName'] = $request->roomName;
        }
        if (!Utils::isUnset($request->roomPicture)) {
            $body['roomPicture'] = $request->roomPicture;
        }
        if (!Utils::isUnset($request->roomStatus)) {
            $body['roomStatus'] = $request->roomStatus;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateMeetingRoom',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/meetingRooms',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateMeetingRoomGroup',
            'version'     => 'rooms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rooms/groups',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateMeetingRoomGroupResponse::fromMap($this->execute($params, $req, $runtime));
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
}
