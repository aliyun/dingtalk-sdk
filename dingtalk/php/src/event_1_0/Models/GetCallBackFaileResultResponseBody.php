<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\GetCallBackFaileResultResponseBody\failedList;
use AlibabaCloud\Tea\Model;

class GetCallBackFaileResultResponseBody extends Model
{
    /**
     * @var failedList[]
     */
    public $failedList;

    /**
     * @var bool
     */
    public $hasMore;
    protected $_name = [
        'failedList' => 'failedList',
        'hasMore'    => 'hasMore',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->failedList) {
            $res['failedList'] = [];
            if (null !== $this->failedList && \is_array($this->failedList)) {
                $n = 0;
                foreach ($this->failedList as $item) {
                    $res['failedList'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return GetCallBackFaileResultResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failedList'])) {
            if (!empty($map['failedList'])) {
                $model->failedList = [];
                $n                 = 0;
                foreach ($map['failedList'] as $item) {
                    $model->failedList[$n++] = null !== $item ? failedList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }

        return $model;
    }
}
