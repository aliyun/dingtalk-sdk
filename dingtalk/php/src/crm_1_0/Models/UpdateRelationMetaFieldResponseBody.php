<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldResponseBody\relationMetaDTO;
use AlibabaCloud\Tea\Model;

class UpdateRelationMetaFieldResponseBody extends Model
{
    /**
     * @var relationMetaDTO
     */
    public $relationMetaDTO;
    protected $_name = [
        'relationMetaDTO' => 'relationMetaDTO',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->relationMetaDTO) {
            $res['relationMetaDTO'] = null !== $this->relationMetaDTO ? $this->relationMetaDTO->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateRelationMetaFieldResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['relationMetaDTO'])) {
            $model->relationMetaDTO = relationMetaDTO::fromMap($map['relationMetaDTO']);
        }

        return $model;
    }
}
