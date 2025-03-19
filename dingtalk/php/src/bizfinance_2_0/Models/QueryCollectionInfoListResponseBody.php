<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCollectionInfoListResponseBody\collectionInfoList;
use AlibabaCloud\Tea\Model;

class QueryCollectionInfoListResponseBody extends Model
{
    /**
     * @var collectionInfoList[]
     */
    public $collectionInfoList;
    protected $_name = [
        'collectionInfoList' => 'collectionInfoList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->collectionInfoList) {
            $res['collectionInfoList'] = [];
            if (null !== $this->collectionInfoList && \is_array($this->collectionInfoList)) {
                $n = 0;
                foreach ($this->collectionInfoList as $item) {
                    $res['collectionInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCollectionInfoListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['collectionInfoList'])) {
            if (!empty($map['collectionInfoList'])) {
                $model->collectionInfoList = [];
                $n = 0;
                foreach ($map['collectionInfoList'] as $item) {
                    $model->collectionInfoList[$n++] = null !== $item ? collectionInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
