<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAccessTokenRequest extends Model
{
    /**
     * @description 企业内部微应用agentId。
     *
     * @var int
     */
    public $agentId;

    /**
     * @description 第三方企业应用appId。
     *
     * @var int
     */
    public $appId;
    protected $_name = [
        'agentId' => 'agentId',
        'appId'   => 'appId',
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
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAccessTokenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }

        return $model;
    }
}
