<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class DingTalkSecurityCheckRequest extends Model
{
    /**
     * @description 客户端版本号
     *
     * @var string
     */
    public $clientVer;

    /**
     * @description 客户端平台类型(iOS,Android)
     *
     * @var string
     */
    public $platform;

    /**
     * @description 客户端平台平台版本
     *
     * @var string
     */
    public $platformVer;

    /**
     * @description 加密字符
     *
     * @var string
     */
    public $sec;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'clientVer'   => 'clientVer',
        'platform'    => 'platform',
        'platformVer' => 'platformVer',
        'sec'         => 'sec',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

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
