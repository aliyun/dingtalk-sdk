<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class RemoveFromOrgSkillRepositoryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $actionId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorUnionId;
    protected $_name = [
        'actionId'        => 'actionId',
        'operatorUnionId' => 'operatorUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionId) {
            $res['actionId'] = $this->actionId;
        }
        if (null !== $this->operatorUnionId) {
            $res['operatorUnionId'] = $this->operatorUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveFromOrgSkillRepositoryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionId'])) {
            $model->actionId = $map['actionId'];
        }
        if (isset($map['operatorUnionId'])) {
            $model->operatorUnionId = $map['operatorUnionId'];
        }

        return $model;
    }
}
