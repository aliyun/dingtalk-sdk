<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelCategoryUpdateRequest;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelCategoryUpdateRequest\categoryVo\categories;
use AlibabaCloud\Tea\Model;

class categoryVo extends Model
{
    /**
     * @var categories[]
     */
    public $categories;
    protected $_name = [
        'categories' => 'categories',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->categories) {
            $res['categories'] = [];
            if (null !== $this->categories && \is_array($this->categories)) {
                $n = 0;
                foreach ($this->categories as $item) {
                    $res['categories'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return categoryVo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categories'])) {
            if (!empty($map['categories'])) {
                $model->categories = [];
                $n = 0;
                foreach ($map['categories'] as $item) {
                    $model->categories[$n++] = null !== $item ? categories::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
