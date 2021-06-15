<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateApaasAppRequest extends Model
{
    /**
     * @var string
     */
    public $appName;

    /**
     * @var string
     */
    public $appIcon;

    /**
     * @var int
     */
    public $appStatus;

    /**
     * @var string
     */
    public $opUserId;

    /**
     * @var string
     */
    public $bizAppId;
    protected $_name = [
        'appName'   => 'appName',
        'appIcon'   => 'appIcon',
        'appStatus' => 'appStatus',
        'opUserId'  => 'opUserId',
        'bizAppId'  => 'bizAppId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->appIcon) {
            $res['appIcon'] = $this->appIcon;
        }
        if (null !== $this->appStatus) {
            $res['appStatus'] = $this->appStatus;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->bizAppId) {
            $res['bizAppId'] = $this->bizAppId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateApaasAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['appIcon'])) {
            $model->appIcon = $map['appIcon'];
        }
        if (isset($map['appStatus'])) {
            $model->appStatus = $map['appStatus'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['bizAppId'])) {
            $model->bizAppId = $map['bizAppId'];
        }

        return $model;
    }
}
