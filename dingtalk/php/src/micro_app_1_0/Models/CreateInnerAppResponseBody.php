<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateInnerAppResponseBody extends Model
{
    /**
     * @description 应用id
     *
     * @var int
     */
    public $agentId;

    /**
     * @var string
     */
    public $appKey;

    /**
     * @var string
     */
    public $appSecret;
    protected $_name = [
        'agentId'   => 'agentId',
        'appKey'    => 'appKey',
        'appSecret' => 'appSecret',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->appSecret) {
            $res['appSecret'] = $this->appSecret;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateInnerAppResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['appSecret'])) {
            $model->appSecret = $map['appSecret'];
        }

        return $model;
    }
}
