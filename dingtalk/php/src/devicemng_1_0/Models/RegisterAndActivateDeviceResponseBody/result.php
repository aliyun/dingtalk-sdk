<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $deviceCategory;

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
    public $deviceUuid;

    /**
     * @var string
     */
    public $introduction;

    /**
     * @var string
     */
    public $roleUuid;

    /**
     * @var string
     */
    public $typeUuid;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'deviceCategory'  => 'deviceCategory',
        'deviceCode'      => 'deviceCode',
        'deviceDetailUrl' => 'deviceDetailUrl',
        'deviceName'      => 'deviceName',
        'deviceUuid'      => 'deviceUuid',
        'introduction'    => 'introduction',
        'roleUuid'        => 'roleUuid',
        'typeUuid'        => 'typeUuid',
        'userIds'         => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceCategory) {
            $res['deviceCategory'] = $this->deviceCategory;
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
        if (null !== $this->deviceUuid) {
            $res['deviceUuid'] = $this->deviceUuid;
        }
        if (null !== $this->introduction) {
            $res['introduction'] = $this->introduction;
        }
        if (null !== $this->roleUuid) {
            $res['roleUuid'] = $this->roleUuid;
        }
        if (null !== $this->typeUuid) {
            $res['typeUuid'] = $this->typeUuid;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
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
        if (isset($map['deviceCategory'])) {
            $model->deviceCategory = $map['deviceCategory'];
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
        if (isset($map['deviceUuid'])) {
            $model->deviceUuid = $map['deviceUuid'];
        }
        if (isset($map['introduction'])) {
            $model->introduction = $map['introduction'];
        }
        if (isset($map['roleUuid'])) {
            $model->roleUuid = $map['roleUuid'];
        }
        if (isset($map['typeUuid'])) {
            $model->typeUuid = $map['typeUuid'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
