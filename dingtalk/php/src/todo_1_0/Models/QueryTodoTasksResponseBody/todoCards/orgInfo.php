<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksResponseBody\todoCards;

use AlibabaCloud\Tea\Model;

class orgInfo extends Model
{
    /**
     * @description 组织corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 组织名称
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'corpId' => 'corpId',
        'name'   => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return orgInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
