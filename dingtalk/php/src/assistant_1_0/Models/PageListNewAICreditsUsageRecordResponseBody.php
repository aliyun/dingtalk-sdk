<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\PageListNewAICreditsUsageRecordResponseBody\dataList;
use AlibabaCloud\Tea\Model;

class PageListNewAICreditsUsageRecordResponseBody extends Model
{
    /**
     * @var dataList[]
     */
    public $dataList;

    /**
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'dataList' => 'dataList',
        'totalCount' => 'totalCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataList) {
            $res['dataList'] = [];
            if (null !== $this->dataList && \is_array($this->dataList)) {
                $n = 0;
                foreach ($this->dataList as $item) {
                    $res['dataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PageListNewAICreditsUsageRecordResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dataList'])) {
            if (!empty($map['dataList'])) {
                $model->dataList = [];
                $n = 0;
                foreach ($map['dataList'] as $item) {
                    $model->dataList[$n++] = null !== $item ? dataList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
