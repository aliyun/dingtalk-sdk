<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveProcessRequest;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveProcessRequest\processFeatureConfig\features;
use AlibabaCloud\Tea\Model;

class processFeatureConfig extends Model
{
    /**
     * @description 配置列表
     *
     * @var features[]
     */
    public $features;
    protected $_name = [
        'features' => 'features',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->features) {
            $res['features'] = [];
            if (null !== $this->features && \is_array($this->features)) {
                $n = 0;
                foreach ($this->features as $item) {
                    $res['features'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return processFeatureConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['features'])) {
            if (!empty($map['features'])) {
                $model->features = [];
                $n               = 0;
                foreach ($map['features'] as $item) {
                    $model->features[$n++] = null !== $item ? features::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
