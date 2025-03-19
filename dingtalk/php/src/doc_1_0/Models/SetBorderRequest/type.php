<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetBorderRequest;

use AlibabaCloud\Tea\Model;

class type extends Model
{
    /**
     * @var bool
     */
    public $bottom;

    /**
     * @var bool
     */
    public $horizontal;

    /**
     * @var bool
     */
    public $left;

    /**
     * @var bool
     */
    public $right;

    /**
     * @var bool
     */
    public $top;

    /**
     * @var bool
     */
    public $vertical;
    protected $_name = [
        'bottom' => 'bottom',
        'horizontal' => 'horizontal',
        'left' => 'left',
        'right' => 'right',
        'top' => 'top',
        'vertical' => 'vertical',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bottom) {
            $res['bottom'] = $this->bottom;
        }
        if (null !== $this->horizontal) {
            $res['horizontal'] = $this->horizontal;
        }
        if (null !== $this->left) {
            $res['left'] = $this->left;
        }
        if (null !== $this->right) {
            $res['right'] = $this->right;
        }
        if (null !== $this->top) {
            $res['top'] = $this->top;
        }
        if (null !== $this->vertical) {
            $res['vertical'] = $this->vertical;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return type
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bottom'])) {
            $model->bottom = $map['bottom'];
        }
        if (isset($map['horizontal'])) {
            $model->horizontal = $map['horizontal'];
        }
        if (isset($map['left'])) {
            $model->left = $map['left'];
        }
        if (isset($map['right'])) {
            $model->right = $map['right'];
        }
        if (isset($map['top'])) {
            $model->top = $map['top'];
        }
        if (isset($map['vertical'])) {
            $model->vertical = $map['vertical'];
        }

        return $model;
    }
}
