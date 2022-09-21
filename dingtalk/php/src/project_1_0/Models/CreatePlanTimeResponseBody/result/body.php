<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreatePlanTimeResponseBody\result;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description 工时关联的数据id
     *
     * @var string
     */
    public $objectId;
    protected $_name = [
        'objectId' => 'objectId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectId) {
            $res['objectId'] = $this->objectId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectId'])) {
            $model->objectId = $map['objectId'];
        }

        return $model;
    }
}
