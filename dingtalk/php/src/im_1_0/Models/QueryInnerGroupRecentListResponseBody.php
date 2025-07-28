<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryInnerGroupRecentListResponseBody\groupInfos;
use AlibabaCloud\Tea\Model;

class QueryInnerGroupRecentListResponseBody extends Model
{
    /**
     * @var groupInfos[]
     */
    public $groupInfos;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'groupInfos' => 'groupInfos',
        'success' => 'success',
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
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryInnerGroupRecentListResponseBody
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
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
