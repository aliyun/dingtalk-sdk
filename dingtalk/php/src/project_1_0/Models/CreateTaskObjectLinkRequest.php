<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskObjectLinkRequest\linkedData;
use AlibabaCloud\Tea\Model;

class CreateTaskObjectLinkRequest extends Model
{
    /**
     * @description 关联链接对象
     *
     * @var linkedData
     */
    public $linkedData;
    protected $_name = [
        'linkedData' => 'linkedData',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->linkedData) {
            $res['linkedData'] = null !== $this->linkedData ? $this->linkedData->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTaskObjectLinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['linkedData'])) {
            $model->linkedData = linkedData::fromMap($map['linkedData']);
        }

        return $model;
    }
}
