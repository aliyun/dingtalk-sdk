<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListActivateDevicesResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $bizExt;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $deviceCallbackUrl;

    /**
     * @var string
     */
    public $deviceCode;

    /**
     * @var string
     */
    public $deviceDetailUrl;

    /**
     * @var string
     */
    public $deviceName;

    /**
     * @var string
     */
    public $groupUuid;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var string
     */
    public $introduction;

    /**
     * @var string
     */
    public $typeUuid;

    /**
     * @var string
     */
    public $uuid;
    protected $_name = [
        'bizExt'            => 'bizExt',
        'corpId'            => 'corpId',
        'deviceCallbackUrl' => 'deviceCallbackUrl',
        'deviceCode'        => 'deviceCode',
        'deviceDetailUrl'   => 'deviceDetailUrl',
        'deviceName'        => 'deviceName',
        'groupUuid'         => 'groupUuid',
        'icon'              => 'icon',
        'introduction'      => 'introduction',
        'typeUuid'          => 'typeUuid',
        'uuid'              => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizExt) {
            $res['bizExt'] = $this->bizExt;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deviceCallbackUrl) {
            $res['deviceCallbackUrl'] = $this->deviceCallbackUrl;
        }
        if (null !== $this->deviceCode) {
            $res['deviceCode'] = $this->deviceCode;
        }
        if (null !== $this->deviceDetailUrl) {
            $res['deviceDetailUrl'] = $this->deviceDetailUrl;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->groupUuid) {
            $res['groupUuid'] = $this->groupUuid;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->introduction) {
            $res['introduction'] = $this->introduction;
        }
        if (null !== $this->typeUuid) {
            $res['typeUuid'] = $this->typeUuid;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
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
        if (isset($map['bizExt'])) {
            $model->bizExt = $map['bizExt'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deviceCallbackUrl'])) {
            $model->deviceCallbackUrl = $map['deviceCallbackUrl'];
        }
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }
        if (isset($map['deviceDetailUrl'])) {
            $model->deviceDetailUrl = $map['deviceDetailUrl'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['groupUuid'])) {
            $model->groupUuid = $map['groupUuid'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['introduction'])) {
            $model->introduction = $map['introduction'];
        }
        if (isset($map['typeUuid'])) {
            $model->typeUuid = $map['typeUuid'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
