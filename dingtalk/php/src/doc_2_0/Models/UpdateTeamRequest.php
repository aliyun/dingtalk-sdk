<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTeamRequest extends Model
{
    /**
     * @description 小组介绍。和小组名称至少有一个必填。
     *
     * @var string
     */
    public $description;

    /**
     * @description 小组名称。和小组介绍至少有一个必填。
     *
     * @var string
     */
    public $name;

    /**
     * @description 操作人unionId。
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'description' => 'description',
        'name'        => 'name',
        'operatorId'  => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTeamRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
