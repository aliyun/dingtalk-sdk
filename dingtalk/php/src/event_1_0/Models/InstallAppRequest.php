<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models;

use AlibabaCloud\Tea\Model;

class InstallAppRequest extends Model
{
    /**
     * @var int
     */
    public $appId;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $dingUserId;

    /**
     * @var int
     */
    public $suiteId;
    protected $_name = [
        'appId'      => 'appId',
        'corpId'     => 'corpId',
        'dingUserId' => 'dingUserId',
        'suiteId'    => 'suiteId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }
        if (null !== $this->suiteId) {
            $res['suiteId'] = $this->suiteId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InstallAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }
        if (isset($map['suiteId'])) {
            $model->suiteId = $map['suiteId'];
        }

        return $model;
    }
}
