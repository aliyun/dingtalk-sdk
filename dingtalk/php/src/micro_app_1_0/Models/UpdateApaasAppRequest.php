<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateApaasAppRequest extends Model
{
    /**
     * @var string
     */
    public $appIcon;

    /**
     * @var string
     */
    public $appName;

    /**
     * @var int
     */
    public $appStatus;

    /**
     * @var string
     */
    public $bizAppId;

    /**
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'appIcon'   => 'appIcon',
        'appName'   => 'appName',
        'appStatus' => 'appStatus',
        'bizAppId'  => 'bizAppId',
        'opUserId'  => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appIcon) {
            $res['appIcon'] = $this->appIcon;
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->appStatus) {
            $res['appStatus'] = $this->appStatus;
        }
        if (null !== $this->bizAppId) {
            $res['bizAppId'] = $this->bizAppId;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
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
        if (isset($map['appIcon'])) {
            $model->appIcon = $map['appIcon'];
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['appStatus'])) {
            $model->appStatus = $map['appStatus'];
        }
        if (isset($map['bizAppId'])) {
            $model->bizAppId = $map['bizAppId'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
