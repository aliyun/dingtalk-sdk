<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyDeletePartnerTypeRequest extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $labelId;
    protected $_name = [
        'labelId' => 'labelId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->labelId) {
            $res['labelId'] = $this->labelId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SupplyDeletePartnerTypeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['labelId'])) {
            $model->labelId = $map['labelId'];
        }

        return $model;
    }
}
