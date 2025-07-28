<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCidsByBotCodeResponseBody\groupInfos;
use AlibabaCloud\Tea\Model;

class GetCidsByBotCodeResponseBody extends Model
{
    /**
     * @var groupInfos[]
     */
    public $groupInfos;

    /**
     * @var bool
     */
    public $hasMore;
    protected $_name = [
        'groupInfos' => 'groupInfos',
        'hasMore' => 'hasMore',
    ];

    public function validate() {}

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
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCidsByBotCodeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupInfos'])) {
            if (!empty($map['groupInfos'])) {
                $model->groupInfos = [];
                $n = 0;
                foreach ($map['groupInfos'] as $item) {
                    $model->groupInfos[$n++] = null !== $item ? groupInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }

        return $model;
    }
}
