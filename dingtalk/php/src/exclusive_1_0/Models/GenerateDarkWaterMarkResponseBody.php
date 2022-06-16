<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GenerateDarkWaterMarkResponseBody\darkWatermarkVOList;
use AlibabaCloud\Tea\Model;

class GenerateDarkWaterMarkResponseBody extends Model
{
    /**
     * @description 返回码
     *
     * @var darkWatermarkVOList[]
     */
    public $darkWatermarkVOList;
    protected $_name = [
        'darkWatermarkVOList' => 'darkWatermarkVOList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->darkWatermarkVOList) {
            $res['darkWatermarkVOList'] = [];
            if (null !== $this->darkWatermarkVOList && \is_array($this->darkWatermarkVOList)) {
                $n = 0;
                foreach ($this->darkWatermarkVOList as $item) {
                    $res['darkWatermarkVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GenerateDarkWaterMarkResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['darkWatermarkVOList'])) {
            if (!empty($map['darkWatermarkVOList'])) {
                $model->darkWatermarkVOList = [];
                $n                          = 0;
                foreach ($map['darkWatermarkVOList'] as $item) {
                    $model->darkWatermarkVOList[$n++] = null !== $item ? darkWatermarkVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
