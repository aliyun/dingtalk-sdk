<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateSpaceRequest\spaceInfoVOList;
use AlibabaCloud\Tea\Model;

class UpdateSpaceRequest extends Model
{
    /**
     * @description 修改后空间信息
     *
     * @var spaceInfoVOList[]
     */
    public $spaceInfoVOList;
    protected $_name = [
        'spaceInfoVOList' => 'spaceInfoVOList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaceInfoVOList) {
            $res['spaceInfoVOList'] = [];
            if (null !== $this->spaceInfoVOList && \is_array($this->spaceInfoVOList)) {
                $n = 0;
                foreach ($this->spaceInfoVOList as $item) {
                    $res['spaceInfoVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateSpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spaceInfoVOList'])) {
            if (!empty($map['spaceInfoVOList'])) {
                $model->spaceInfoVOList = [];
                $n                      = 0;
                foreach ($map['spaceInfoVOList'] as $item) {
                    $model->spaceInfoVOList[$n++] = null !== $item ? spaceInfoVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
