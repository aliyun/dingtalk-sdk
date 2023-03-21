<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetNewestInnerGroupsResponseBody\groupInfos;
use AlibabaCloud\Tea\Model;

class GetNewestInnerGroupsResponseBody extends Model
{
    /**
     * @description 群列表
     *
     * @var groupInfos[]
     */
    public $groupInfos;
    protected $_name = [
        'groupInfos' => 'groupInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupInfos) {
            $res['groupInfos'] = [];
            if (null !== $this->groupInfos && \is_array($this->groupInfos)) {
                $n = 0;
                foreach ($this->groupInfos as $item) {
                    $res['groupInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetNewestInnerGroupsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupInfos'])) {
            if (!empty($map['groupInfos'])) {
                $model->groupInfos = [];
                $n                 = 0;
                foreach ($map['groupInfos'] as $item) {
                    $model->groupInfos[$n++] = null !== $item ? groupInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
