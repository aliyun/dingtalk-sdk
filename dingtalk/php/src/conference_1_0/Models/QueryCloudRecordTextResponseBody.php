<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordTextResponseBody\paragraphList;
use AlibabaCloud\Tea\Model;

class QueryCloudRecordTextResponseBody extends Model
{
    /**
     * @description 是否有更多
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 段落列表
     *
     * @var paragraphList[]
     */
    public $paragraphList;
    protected $_name = [
        'hasMore'       => 'hasMore',
        'paragraphList' => 'paragraphList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->paragraphList) {
            $res['paragraphList'] = [];
            if (null !== $this->paragraphList && \is_array($this->paragraphList)) {
                $n = 0;
                foreach ($this->paragraphList as $item) {
                    $res['paragraphList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCloudRecordTextResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['paragraphList'])) {
            if (!empty($map['paragraphList'])) {
                $model->paragraphList = [];
                $n                    = 0;
                foreach ($map['paragraphList'] as $item) {
                    $model->paragraphList[$n++] = null !== $item ? paragraphList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
