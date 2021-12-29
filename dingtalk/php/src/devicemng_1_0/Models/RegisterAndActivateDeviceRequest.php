<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class RegisterAndActivateDeviceRequest extends Model
{
    /**
     * @var string
     */
    public $deviceCode;

    /**
     * @var string
     */
    public $deviceName;

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
    public $dingCorpId;

    /**
     * @var string[]
     */
    public $userIds;

    /**
     * @var string
     */
    public $roleUuid;

    /**
     * @var string
     */
    public $deviceDetailUrl;

    /**
     * @var string
     */
    public $deviceCallbackUrl;
    protected $_name = [
        'deviceCode'        => 'deviceCode',
        'deviceName'        => 'deviceName',
        'introduction'      => 'introduction',
        'typeUuid'          => 'typeUuid',
        'dingCorpId'        => 'dingCorpId',
        'userIds'           => 'userIds',
        'roleUuid'          => 'roleUuid',
        'deviceDetailUrl'   => 'deviceDetailUrl',
        'deviceCallbackUrl' => 'deviceCallbackUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceCode) {
            $res['deviceCode'] = $this->deviceCode;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->introduction) {
            $res['introduction'] = $this->introduction;
        }
        if (null !== $this->typeUuid) {
            $res['typeUuid'] = $this->typeUuid;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }
        if (null !== $this->roleUuid) {
            $res['roleUuid'] = $this->roleUuid;
        }
        if (null !== $this->deviceDetailUrl) {
            $res['deviceDetailUrl'] = $this->deviceDetailUrl;
        }
        if (null !== $this->deviceCallbackUrl) {
            $res['deviceCallbackUrl'] = $this->deviceCallbackUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RegisterAndActivateDeviceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['introduction'])) {
            $model->introduction = $map['introduction'];
        }
        if (isset($map['typeUuid'])) {
            $model->typeUuid = $map['typeUuid'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }
        if (isset($map['roleUuid'])) {
            $model->roleUuid = $map['roleUuid'];
        }
        if (isset($map['deviceDetailUrl'])) {
            $model->deviceDetailUrl = $map['deviceDetailUrl'];
        }
        if (isset($map['deviceCallbackUrl'])) {
            $model->deviceCallbackUrl = $map['deviceCallbackUrl'];
        }

        return $model;
    }
}
