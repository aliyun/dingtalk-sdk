<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class DingTalkSecurityCheckRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 6.3.30
     *
     * @var string
     */
    public $clientVer;

    /**
     * @description This parameter is required.
     *
     * @example iOS
     *
     * @var string
     */
    public $platform;

    /**
     * @description This parameter is required.
     *
     * @example 15
     *
     * @var string
     */
    public $platformVer;

    /**
     * @description This parameter is required.
     *
     * @example {"lbsWuaToken": "lbsWua","ddSec":"ddSec"}
     *
     * @var string
     */
    public $sec;

    /**
     * @description This parameter is required.
     *
     * @example user01
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'clientVer' => 'clientVer',
        'platform' => 'platform',
        'platformVer' => 'platformVer',
        'sec' => 'sec',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->clientVer) {
            $res['clientVer'] = $this->clientVer;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->platformVer) {
            $res['platformVer'] = $this->platformVer;
        }
        if (null !== $this->sec) {
            $res['sec'] = $this->sec;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DingTalkSecurityCheckRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['clientVer'])) {
            $model->clientVer = $map['clientVer'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['platformVer'])) {
            $model->platformVer = $map['platformVer'];
        }
        if (isset($map['sec'])) {
            $model->sec = $map['sec'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
