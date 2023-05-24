<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListSubDeptResponseBody\result;

use AlibabaCloud\Tea\Model;

class partnerTypeInfoList extends Model
{
    /**
     * @example 111
     *
     * @var int
     */
    public $id;

    /**
     * @example 11111
     *
     * @var string
     */
    public $name;

    /**
     * @example 1111
     *
     * @var int
     */
    public $superId;

    /**
     * @example 1111
     *
     * @var string
     */
    public $superName;
    protected $_name = [
        'id'        => 'id',
        'name'      => 'name',
        'superId'   => 'superId',
        'superName' => 'superName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->superId) {
            $res['superId'] = $this->superId;
        }
        if (null !== $this->superName) {
            $res['superName'] = $this->superName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return partnerTypeInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['superId'])) {
            $model->superId = $map['superId'];
        }
        if (isset($map['superName'])) {
            $model->superName = $map['superName'];
        }

        return $model;
    }
}
