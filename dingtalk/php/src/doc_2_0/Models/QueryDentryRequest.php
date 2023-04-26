<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryDentryRequest extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $includeSpace;

    /**
     * @example abcd
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'includeSpace' => 'includeSpace',
        'operatorId'   => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->includeSpace) {
            $res['includeSpace'] = $this->includeSpace;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryDentryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['includeSpace'])) {
            $model->includeSpace = $map['includeSpace'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
