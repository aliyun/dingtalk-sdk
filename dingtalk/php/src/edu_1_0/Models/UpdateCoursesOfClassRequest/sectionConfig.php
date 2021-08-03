<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest\sectionConfig\sectionModels;
use AlibabaCloud\Tea\Model;

class sectionConfig extends Model
{
    /**
     * @description 节次模型
     *
     * @var sectionModels[]
     */
    public $sectionModels;
    protected $_name = [
        'sectionModels' => 'sectionModels',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sectionModels) {
            $res['sectionModels'] = [];
            if (null !== $this->sectionModels && \is_array($this->sectionModels)) {
                $n = 0;
                foreach ($this->sectionModels as $item) {
                    $res['sectionModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sectionConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sectionModels'])) {
            if (!empty($map['sectionModels'])) {
                $model->sectionModels = [];
                $n                    = 0;
                foreach ($map['sectionModels'] as $item) {
                    $model->sectionModels[$n++] = null !== $item ? sectionModels::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
