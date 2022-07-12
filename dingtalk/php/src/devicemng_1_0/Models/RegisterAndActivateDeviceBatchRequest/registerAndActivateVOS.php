<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceBatchRequest;

use AlibabaCloud\Tea\Model;

class registerAndActivateVOS extends Model
{
    /**
     * @var string
     */
    public $deviceCallbackUrl;

    /**
     * @description 设备分类（0：设备，1 : 助手）
     *
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
    public $groupUuid;

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
        'deviceCallbackUrl' => 'deviceCallbackUrl',
        'deviceCategory'    => 'deviceCategory',
        'deviceCode'        => 'deviceCode',
        'deviceDetailUrl'   => 'deviceDetailUrl',
        'deviceName'        => 'deviceName',
        'groupUuid'         => 'groupUuid',
        'introduction'      => 'introduction',
        'roleUuid'          => 'roleUuid',
        'typeUuid'          => 'typeUuid',
        'userIds'           => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceCallbackUrl) {
            $res['deviceCallbackUrl'] = $this->deviceCallbackUrl;
        }
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
        if (null !== $this->groupUuid) {
            $res['groupUuid'] = $this->groupUuid;
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
     * @return registerAndActivateVOS
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceCallbackUrl'])) {
            $model->deviceCallbackUrl = $map['deviceCallbackUrl'];
        }
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
        if (isset($map['groupUuid'])) {
            $model->groupUuid = $map['groupUuid'];
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
