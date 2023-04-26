<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFlowIdByRelationEntityIdRequest extends Model
{
    /**
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @example interview
     *
     * @var string
     */
    public $relationEntity;

    /**
     * @example xxx
     *
     * @var string
     */
    public $relationEntityId;
    protected $_name = [
        'bizCode'          => 'bizCode',
        'relationEntity'   => 'relationEntity',
        'relationEntityId' => 'relationEntityId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->relationEntity) {
            $res['relationEntity'] = $this->relationEntity;
        }
        if (null !== $this->relationEntityId) {
            $res['relationEntityId'] = $this->relationEntityId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFlowIdByRelationEntityIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['relationEntity'])) {
            $model->relationEntity = $map['relationEntity'];
        }
        if (isset($map['relationEntityId'])) {
            $model->relationEntityId = $map['relationEntityId'];
        }

        return $model;
    }
}
