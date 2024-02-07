<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceResponseBody\result\controllers;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 1697198045000
     *
     * @var int
     */
    public $activeTime;

    /**
     * @var controllers[]
     */
    public $controllers;

    /**
     * @example "ding994a046bca84545935c2f4657eb6378f"
     *
     * @var string
     */
    public $corpId;

    /**
     * @example lPHhSZDLXXXXXXpBlC9lxLwiEiE
     *
     * @var string
     */
    public $creatorUnionId;

    /**
     * @example Smart Camera
     *
     * @var string
     */
    public $devCamera;

    /**
     * @example false
     *
     * @var string
     */
    public $devHdmi;

    /**
     * @example Microphone (2- Built-in Audio)
     *
     * @var string
     */
    public $devMic;

    /**
     * @example false
     *
     * @var string
     */
    public $devMirror;

    /**
     * @example 127.0.0.10
     *
     * @var string
     */
    public $devNetIp;

    /**
     * @example net_wired
     *
     * @var string
     */
    public $devNetType;

    /**
     * @example Speaker (2- Built-in Audio)
     *
     * @var string
     */
    public $devVoice;

    /**
     * @example d4:aa:ee:e8:4d:55
     *
     * @var string
     */
    public $devWifiMac;

    /**
     * @example d4:3a:ee:aa:45:85
     *
     * @var string
     */
    public $devWireMac;

    /**
     * @example 1234
     *
     * @var string
     */
    public $deviceId;

    /**
     * @example "14:85:7f:e5:f3:f3"
     *
     * @var string
     */
    public $deviceMac;

    /**
     * @example winbox
     *
     * @var string
     */
    public $deviceModel;

    /**
     * @example 钉钉会议设备_xxxx
     *
     * @var string
     */
    public $deviceName;

    /**
     * @example 1204
     *
     * @var int
     */
    public $deviceServiceId;

    /**
     * @example "02caa8169c80f74a2d375093a6107016"
     *
     * @var string
     */
    public $deviceSn;

    /**
     * @example 空闲：idle  投屏中：projection   会议响铃中：conf_incoming   会议中：conf_running   使用白板中：white_board   离线: offline
     *
     * @var string
     */
    public $deviceStatus;

    /**
     * @example 视频会议设备:"touyingyi"   设备控制器:"meetingaccessory"
     *
     * @var string
     */
    public $deviceType;

    /**
     * @example "lmvUrRkpboRrSMtgsiS9V3AiEiE"
     *
     * @var string
     */
    public $deviceUnionId;

    /**
     * @example LMVXXX.20XX0818
     *
     * @var string
     */
    public $firmwareVersion;

    /**
     * @example "7263defed6b361fedf0fe6a3b578b96e808b09d6ca6282ed"
     *
     * @var string
     */
    public $openRoomId;

    /**
     * @example 测试会议室
     *
     * @var string
     */
    public $roomName;

    /**
     * @example 123456
     *
     * @var string
     */
    public $shareCode;

    /**
     * @example sip13492
     *
     * @var string
     */
    public $sipAccountName;

    /**
     * @example 7.14.1
     *
     * @var string
     */
    public $softwareVersion;
    protected $_name = [
        'activeTime'      => 'activeTime',
        'controllers'     => 'controllers',
        'corpId'          => 'corpId',
        'creatorUnionId'  => 'creatorUnionId',
        'devCamera'       => 'devCamera',
        'devHdmi'         => 'devHdmi',
        'devMic'          => 'devMic',
        'devMirror'       => 'devMirror',
        'devNetIp'        => 'devNetIp',
        'devNetType'      => 'devNetType',
        'devVoice'        => 'devVoice',
        'devWifiMac'      => 'devWifiMac',
        'devWireMac'      => 'devWireMac',
        'deviceId'        => 'deviceId',
        'deviceMac'       => 'deviceMac',
        'deviceModel'     => 'deviceModel',
        'deviceName'      => 'deviceName',
        'deviceServiceId' => 'deviceServiceId',
        'deviceSn'        => 'deviceSn',
        'deviceStatus'    => 'deviceStatus',
        'deviceType'      => 'deviceType',
        'deviceUnionId'   => 'deviceUnionId',
        'firmwareVersion' => 'firmwareVersion',
        'openRoomId'      => 'openRoomId',
        'roomName'        => 'roomName',
        'shareCode'       => 'shareCode',
        'sipAccountName'  => 'sipAccountName',
        'softwareVersion' => 'softwareVersion',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activeTime) {
            $res['activeTime'] = $this->activeTime;
        }
        if (null !== $this->controllers) {
            $res['controllers'] = [];
            if (null !== $this->controllers && \is_array($this->controllers)) {
                $n = 0;
                foreach ($this->controllers as $item) {
                    $res['controllers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->devCamera) {
            $res['devCamera'] = $this->devCamera;
        }
        if (null !== $this->devHdmi) {
            $res['devHdmi'] = $this->devHdmi;
        }
        if (null !== $this->devMic) {
            $res['devMic'] = $this->devMic;
        }
        if (null !== $this->devMirror) {
            $res['devMirror'] = $this->devMirror;
        }
        if (null !== $this->devNetIp) {
            $res['devNetIp'] = $this->devNetIp;
        }
        if (null !== $this->devNetType) {
            $res['devNetType'] = $this->devNetType;
        }
        if (null !== $this->devVoice) {
            $res['devVoice'] = $this->devVoice;
        }
        if (null !== $this->devWifiMac) {
            $res['devWifiMac'] = $this->devWifiMac;
        }
        if (null !== $this->devWireMac) {
            $res['devWireMac'] = $this->devWireMac;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->deviceMac) {
            $res['deviceMac'] = $this->deviceMac;
        }
        if (null !== $this->deviceModel) {
            $res['deviceModel'] = $this->deviceModel;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->deviceServiceId) {
            $res['deviceServiceId'] = $this->deviceServiceId;
        }
        if (null !== $this->deviceSn) {
            $res['deviceSn'] = $this->deviceSn;
        }
        if (null !== $this->deviceStatus) {
            $res['deviceStatus'] = $this->deviceStatus;
        }
        if (null !== $this->deviceType) {
            $res['deviceType'] = $this->deviceType;
        }
        if (null !== $this->deviceUnionId) {
            $res['deviceUnionId'] = $this->deviceUnionId;
        }
        if (null !== $this->firmwareVersion) {
            $res['firmwareVersion'] = $this->firmwareVersion;
        }
        if (null !== $this->openRoomId) {
            $res['openRoomId'] = $this->openRoomId;
        }
        if (null !== $this->roomName) {
            $res['roomName'] = $this->roomName;
        }
        if (null !== $this->shareCode) {
            $res['shareCode'] = $this->shareCode;
        }
        if (null !== $this->sipAccountName) {
            $res['sipAccountName'] = $this->sipAccountName;
        }
        if (null !== $this->softwareVersion) {
            $res['softwareVersion'] = $this->softwareVersion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activeTime'])) {
            $model->activeTime = $map['activeTime'];
        }
        if (isset($map['controllers'])) {
            if (!empty($map['controllers'])) {
                $model->controllers = [];
                $n                  = 0;
                foreach ($map['controllers'] as $item) {
                    $model->controllers[$n++] = null !== $item ? controllers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['devCamera'])) {
            $model->devCamera = $map['devCamera'];
        }
        if (isset($map['devHdmi'])) {
            $model->devHdmi = $map['devHdmi'];
        }
        if (isset($map['devMic'])) {
            $model->devMic = $map['devMic'];
        }
        if (isset($map['devMirror'])) {
            $model->devMirror = $map['devMirror'];
        }
        if (isset($map['devNetIp'])) {
            $model->devNetIp = $map['devNetIp'];
        }
        if (isset($map['devNetType'])) {
            $model->devNetType = $map['devNetType'];
        }
        if (isset($map['devVoice'])) {
            $model->devVoice = $map['devVoice'];
        }
        if (isset($map['devWifiMac'])) {
            $model->devWifiMac = $map['devWifiMac'];
        }
        if (isset($map['devWireMac'])) {
            $model->devWireMac = $map['devWireMac'];
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['deviceMac'])) {
            $model->deviceMac = $map['deviceMac'];
        }
        if (isset($map['deviceModel'])) {
            $model->deviceModel = $map['deviceModel'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['deviceServiceId'])) {
            $model->deviceServiceId = $map['deviceServiceId'];
        }
        if (isset($map['deviceSn'])) {
            $model->deviceSn = $map['deviceSn'];
        }
        if (isset($map['deviceStatus'])) {
            $model->deviceStatus = $map['deviceStatus'];
        }
        if (isset($map['deviceType'])) {
            $model->deviceType = $map['deviceType'];
        }
        if (isset($map['deviceUnionId'])) {
            $model->deviceUnionId = $map['deviceUnionId'];
        }
        if (isset($map['firmwareVersion'])) {
            $model->firmwareVersion = $map['firmwareVersion'];
        }
        if (isset($map['openRoomId'])) {
            $model->openRoomId = $map['openRoomId'];
        }
        if (isset($map['roomName'])) {
            $model->roomName = $map['roomName'];
        }
        if (isset($map['shareCode'])) {
            $model->shareCode = $map['shareCode'];
        }
        if (isset($map['sipAccountName'])) {
            $model->sipAccountName = $map['sipAccountName'];
        }
        if (isset($map['softwareVersion'])) {
            $model->softwareVersion = $map['softwareVersion'];
        }

        return $model;
    }
}
