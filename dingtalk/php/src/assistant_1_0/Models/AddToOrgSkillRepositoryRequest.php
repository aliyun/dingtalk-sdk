<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddToOrgSkillRepositoryRequest extends Model
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
    public $actionVersion;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorUnionId;
    protected $_name = [
        'actionId' => 'actionId',
        'actionVersion' => 'actionVersion',
        'operatorUnionId' => 'operatorUnionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionId) {
            $res['actionId'] = $this->actionId;
        }
        if (null !== $this->actionVersion) {
            $res['actionVersion'] = $this->actionVersion;
        }
        if (null !== $this->operatorUnionId) {
            $res['operatorUnionId'] = $this->operatorUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddToOrgSkillRepositoryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionId'])) {
            $model->actionId = $map['actionId'];
        }
        if (isset($map['actionVersion'])) {
            $model->actionVersion = $map['actionVersion'];
        }
        if (isset($map['operatorUnionId'])) {
            $model->operatorUnionId = $map['operatorUnionId'];
        }

        return $model;
    }
}
