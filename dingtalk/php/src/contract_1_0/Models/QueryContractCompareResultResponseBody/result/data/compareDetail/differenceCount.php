<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractCompareResultResponseBody\result\data\compareDetail;

use AlibabaCloud\Tea\Model;

class differenceCount extends Model
{
    /**
     * @var int
     */
    public $add;

    /**
     * @var int
     */
    public $delete;

    /**
     * @var int
     */
    public $replace;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'add'     => 'add',
        'delete'  => 'delete',
        'replace' => 'replace',
        'total'   => 'total',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->add) {
            $res['add'] = $this->add;
        }
        if (null !== $this->delete) {
            $res['delete'] = $this->delete;
        }
        if (null !== $this->replace) {
            $res['replace'] = $this->replace;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return differenceCount
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['add'])) {
            $model->add = $map['add'];
        }
        if (isset($map['delete'])) {
            $model->delete = $map['delete'];
        }
        if (isset($map['replace'])) {
            $model->replace = $map['replace'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
