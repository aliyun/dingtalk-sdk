<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetUuidByIdOrUrlRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example NVQ0MmFhZDAyYmRkYjM4Yw
     *
     * @var string
     */
    public $idOrUrl;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'idOrUrl' => 'idOrUrl',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->idOrUrl) {
            $res['idOrUrl'] = $this->idOrUrl;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUuidByIdOrUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['idOrUrl'])) {
            $model->idOrUrl = $map['idOrUrl'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
