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
    public $tenant;

    /**
     * @var string
     */
    public $operatorUserId;

    /**
     * @var relationMetaDTO
     */
    public $relationMetaDTO;
    protected $_name = [
        'tenant'          => 'tenant',
        'operatorUserId'  => 'operatorUserId',
        'relationMetaDTO' => 'relationMetaDTO',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tenant) {
            $res['tenant'] = $this->tenant;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->relationMetaDTO) {
            $res['relationMetaDTO'] = null !== $this->relationMetaDTO ? $this->relationMetaDTO->toMap() : null;
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
        if (isset($map['tenant'])) {
            $model->tenant = $map['tenant'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['relationMetaDTO'])) {
            $model->relationMetaDTO = relationMetaDTO::fromMap($map['relationMetaDTO']);
        }

        return $model;
    }
}
