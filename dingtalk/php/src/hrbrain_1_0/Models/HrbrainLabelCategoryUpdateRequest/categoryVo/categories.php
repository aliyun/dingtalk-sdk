<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelCategoryUpdateRequest\categoryVo;

use AlibabaCloud\Tea\Model;

class categories extends Model
{
    /**
     * @var mixed[]
     */
    public $children;

    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $pCode;

    /**
     * @var string
     */
    public $sortSize;
    protected $_name = [
        'children' => 'children',
        'code' => 'code',
        'name' => 'name',
        'pCode' => 'pCode',
        'sortSize' => 'sortSize',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->children) {
            $res['children'] = $this->children;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pCode) {
            $res['pCode'] = $this->pCode;
        }
        if (null !== $this->sortSize) {
            $res['sortSize'] = $this->sortSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return categories
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['children'])) {
            if (!empty($map['children'])) {
                $model->children = $map['children'];
            }
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pCode'])) {
            $model->pCode = $map['pCode'];
        }
        if (isset($map['sortSize'])) {
            $model->sortSize = $map['sortSize'];
        }

        return $model;
    }
}
