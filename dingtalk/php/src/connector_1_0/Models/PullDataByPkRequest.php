<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\Tea\Model;

class PullDataByPkRequest extends Model
{
    /**
     * @description 数据的主键字段值。
     *
     * @var string
     */
    public $primaryKey;

    /**
     * @description 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
     *
     * @var string
     */
    public $appId;
    protected $_name = [
        'primaryKey' => 'primaryKey',
        'appId'      => 'appId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->primaryKey) {
            $res['primaryKey'] = $this->primaryKey;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
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
        if (isset($map['primaryKey'])) {
            $model->primaryKey = $map['primaryKey'];
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }

        return $model;
    }
}
