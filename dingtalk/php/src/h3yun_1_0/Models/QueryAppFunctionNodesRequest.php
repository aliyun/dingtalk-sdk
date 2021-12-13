<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAppFunctionNodesRequest extends Model
{
    /**
     * @description 应用编码
     *
     * @var string
     */
    public $appCode;
    protected $_name = [
        'appCode' => 'appCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appCode) {
            $res['appCode'] = $this->appCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAppFunctionNodesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appCode'])) {
            $model->appCode = $map['appCode'];
        }

        return $model;
    }
}
