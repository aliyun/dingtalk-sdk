<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSpaceIdByTypeResponseBody extends Model
{
    /**
     * @description 部门id
     *
     * @var int
     */
    public $referId;
    protected $_name = [
        'referId' => 'referId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->referId) {
            $res['referId'] = $this->referId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSpaceIdByTypeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['referId'])) {
            $model->referId = $map['referId'];
        }

        return $model;
    }
}
