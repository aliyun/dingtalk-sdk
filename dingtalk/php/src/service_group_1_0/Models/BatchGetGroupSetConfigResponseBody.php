<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchGetGroupSetConfigResponseBody\groupSetConfigs;
use AlibabaCloud\Tea\Model;

class BatchGetGroupSetConfigResponseBody extends Model
{
    /**
     * @description 群粗配置列表
     *
     * @var groupSetConfigs[]
     */
    public $groupSetConfigs;
    protected $_name = [
        'groupSetConfigs' => 'groupSetConfigs',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupSetConfigs) {
            $res['groupSetConfigs'] = [];
            if (null !== $this->groupSetConfigs && \is_array($this->groupSetConfigs)) {
                $n = 0;
                foreach ($this->groupSetConfigs as $item) {
                    $res['groupSetConfigs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchGetGroupSetConfigResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupSetConfigs'])) {
            if (!empty($map['groupSetConfigs'])) {
                $model->groupSetConfigs = [];
                $n                      = 0;
                foreach ($map['groupSetConfigs'] as $item) {
                    $model->groupSetConfigs[$n++] = null !== $item ? groupSetConfigs::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
