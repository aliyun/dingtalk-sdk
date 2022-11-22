<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\GetCallBackFaileResultResponseBody\failedList;
use AlibabaCloud\Tea\Model;

class GetCallBackFaileResultResponseBody extends Model
{
    /**
     * @description 推送失败的事件列表，一次最多200个。
     *
     * @var failedList[]
     */
    public $failedList;

    /**
     * @description 是否还有推送失败的变更事件，若为true，则表示还有未回调的事件，或传入时间时范围内还有未回调的事件。
     *
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
