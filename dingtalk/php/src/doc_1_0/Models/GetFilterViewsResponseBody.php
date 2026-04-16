<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetFilterViewsResponseBody\filterViews;
use AlibabaCloud\Tea\Model;

class GetFilterViewsResponseBody extends Model
{
    /**
     * @var filterViews[]
     */
    public $filterViews;
    protected $_name = [
        'filterViews' => 'filterViews',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->filterViews) {
            $res['filterViews'] = [];
            if (null !== $this->filterViews && \is_array($this->filterViews)) {
                $n = 0;
                foreach ($this->filterViews as $item) {
                    $res['filterViews'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFilterViewsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['filterViews'])) {
            if (!empty($map['filterViews'])) {
                $model->filterViews = [];
                $n = 0;
                foreach ($map['filterViews'] as $item) {
                    $model->filterViews[$n++] = null !== $item ? filterViews::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
