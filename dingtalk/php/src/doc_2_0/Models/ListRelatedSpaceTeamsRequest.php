<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class ListRelatedSpaceTeamsRequest extends Model
{
    /**
     * @description 操作用户unionId。
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 团队类型。
     * 0-空白团队；1-部门；2-项目组；3-兴趣小组。
     * @var int
     */
    public $type;
    protected $_name = [
        'operatorId' => 'operatorId',
        'type'       => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListRelatedSpaceTeamsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
