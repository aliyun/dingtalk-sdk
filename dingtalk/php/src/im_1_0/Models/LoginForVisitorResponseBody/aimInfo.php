<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\LoginForVisitorResponseBody;

use AlibabaCloud\Tea\Model;

class aimInfo extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example app_123456
     *
     * @var string
     */
    public $appId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $appKey;

    /**
     * @description This parameter is required.
     *
     * @example dingtalk_app
     *
     * @var string
     */
    public $appName;
    protected $_name = [
        'appId' => 'appId',
        'appKey' => 'appKey',
        'appName' => 'appName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return aimInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }

        return $model;
    }
}
