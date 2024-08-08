<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelatedViewTabMetaResponseBody\baseViewTabModels;
use AlibabaCloud\Tea\Model;

class GetRelatedViewTabMetaResponseBody extends Model
{
    /**
     * @var baseViewTabModels[]
     */
    public $baseViewTabModels;
    protected $_name = [
        'baseViewTabModels' => 'baseViewTabModels',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->baseViewTabModels) {
            $res['baseViewTabModels'] = [];
            if (null !== $this->baseViewTabModels && \is_array($this->baseViewTabModels)) {
                $n = 0;
                foreach ($this->baseViewTabModels as $item) {
                    $res['baseViewTabModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRelatedViewTabMetaResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['baseViewTabModels'])) {
            if (!empty($map['baseViewTabModels'])) {
                $model->baseViewTabModels = [];
                $n                        = 0;
                foreach ($map['baseViewTabModels'] as $item) {
                    $model->baseViewTabModels[$n++] = null !== $item ? baseViewTabModels::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
