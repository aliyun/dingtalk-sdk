<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\Tea\Model;

class PullDataByPkRequest extends Model
{
    /**
     * @description 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
     *
     * @var string
     */
    public $appId;

    /**
     * @description 数据的主键字段值。
     *
     * @var string
     */
    public $primaryKey;
    protected $_name = [
        'appId'      => 'appId',
        'primaryKey' => 'primaryKey',
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
        if (null !== $this->primaryKey) {
            $res['primaryKey'] = $this->primaryKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PullDataByPkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['primaryKey'])) {
            $model->primaryKey = $map['primaryKey'];
        }

        return $model;
    }
}
