<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateRelationMetaRequest\relationMetaDTO;
use AlibabaCloud\Tea\Model;

class CreateRelationMetaRequest extends Model
{
    /**
     * @var string
     */
    public $operatorUserId;

    /**
     * @var relationMetaDTO
     */
    public $relationMetaDTO;

    /**
     * @var string
     */
    public $tenant;
    protected $_name = [
        'operatorUserId'  => 'operatorUserId',
        'relationMetaDTO' => 'relationMetaDTO',
        'tenant'          => 'tenant',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->relationMetaDTO) {
            $res['relationMetaDTO'] = null !== $this->relationMetaDTO ? $this->relationMetaDTO->toMap() : null;
        }
        if (null !== $this->tenant) {
            $res['tenant'] = $this->tenant;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateRelationMetaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['relationMetaDTO'])) {
            $model->relationMetaDTO = relationMetaDTO::fromMap($map['relationMetaDTO']);
        }
        if (isset($map['tenant'])) {
            $model->tenant = $map['tenant'];
        }

        return $model;
    }
}
