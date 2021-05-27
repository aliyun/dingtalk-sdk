<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\ListWorkBenchGroupResponseBody;

use AlibabaCloud\Tea\Model;

class groupList extends Model
{
    /**
     * @description 分组名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 分组id
     *
     * @var string
     */
    public $componentId;
    protected $_name = [
        'name'        => 'name',
        'componentId' => 'componentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->componentId) {
            $res['componentId'] = $this->componentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['componentId'])) {
            $model->componentId = $map['componentId'];
        }

        return $model;
    }
}
