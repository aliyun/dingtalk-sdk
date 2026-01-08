<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelCategoryTreeResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var mixed[][]
     */
    public $children;

    /**
     * @var string
     */
    public $code;

    /**
     * @var int
     */
    public $currentLabelNum;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $pcode;

    /**
     * @var int
     */
    public $sortSize;

    /**
     * @var int
     */
    public $totalLabelNum;
    protected $_name = [
        'children' => 'children',
        'code' => 'code',
        'currentLabelNum' => 'currentLabelNum',
        'name' => 'name',
        'pcode' => 'pcode',
        'sortSize' => 'sortSize',
        'totalLabelNum' => 'totalLabelNum',
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
        if (null !== $this->currentLabelNum) {
            $res['currentLabelNum'] = $this->currentLabelNum;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pcode) {
            $res['pcode'] = $this->pcode;
        }
        if (null !== $this->sortSize) {
            $res['sortSize'] = $this->sortSize;
        }
        if (null !== $this->totalLabelNum) {
            $res['totalLabelNum'] = $this->totalLabelNum;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
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
        if (isset($map['currentLabelNum'])) {
            $model->currentLabelNum = $map['currentLabelNum'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pcode'])) {
            $model->pcode = $map['pcode'];
        }
        if (isset($map['sortSize'])) {
            $model->sortSize = $map['sortSize'];
        }
        if (isset($map['totalLabelNum'])) {
            $model->totalLabelNum = $map['totalLabelNum'];
        }

        return $model;
    }
}
