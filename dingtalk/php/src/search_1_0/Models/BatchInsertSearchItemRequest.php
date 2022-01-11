<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\BatchInsertSearchItemRequest\searchItemModels;
use AlibabaCloud\Tea\Model;

class BatchInsertSearchItemRequest extends Model
{
    /**
     * @var searchItemModels[]
     */
    public $searchItemModels;
    protected $_name = [
        'searchItemModels' => 'searchItemModels',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->searchItemModels) {
            $res['searchItemModels'] = [];
            if (null !== $this->searchItemModels && \is_array($this->searchItemModels)) {
                $n = 0;
                foreach ($this->searchItemModels as $item) {
                    $res['searchItemModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchInsertSearchItemRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['searchItemModels'])) {
            if (!empty($map['searchItemModels'])) {
                $model->searchItemModels = [];
                $n                       = 0;
                foreach ($map['searchItemModels'] as $item) {
                    $model->searchItemModels[$n++] = null !== $item ? searchItemModels::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
