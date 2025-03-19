<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\ListAllBizCategoryResponseBody\bizCategories;
use AlibabaCloud\Tea\Model;

class ListAllBizCategoryResponseBody extends Model
{
    /**
     * @var bizCategories[]
     */
    public $bizCategories;
    protected $_name = [
        'bizCategories' => 'bizCategories',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCategories) {
            $res['bizCategories'] = [];
            if (null !== $this->bizCategories && \is_array($this->bizCategories)) {
                $n = 0;
                foreach ($this->bizCategories as $item) {
                    $res['bizCategories'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListAllBizCategoryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCategories'])) {
            if (!empty($map['bizCategories'])) {
                $model->bizCategories = [];
                $n = 0;
                foreach ($map['bizCategories'] as $item) {
                    $model->bizCategories[$n++] = null !== $item ? bizCategories::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
