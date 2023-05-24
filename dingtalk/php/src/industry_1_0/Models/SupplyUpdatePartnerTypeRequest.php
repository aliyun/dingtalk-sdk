<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyUpdatePartnerTypeRequest extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $labelId;

    /**
     * @example 标签名称
     *
     * @var string
     */
    public $name;

    /**
     * @example 862
     *
     * @var int
     */
    public $superId;
    protected $_name = [
        'labelId' => 'labelId',
        'name'    => 'name',
        'superId' => 'superId',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->superId) {
            $res['superId'] = $this->superId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SupplyUpdatePartnerTypeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['labelId'])) {
            $model->labelId = $map['labelId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['superId'])) {
            $model->superId = $map['superId'];
        }

        return $model;
    }
}
