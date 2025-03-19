<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextResponseBody\paragraphList;
use AlibabaCloud\Tea\Model;

class QueryMinutesTextResponseBody extends Model
{
    /**
     * @var bool
     */
    public $hasNext;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var paragraphList[]
     */
    public $paragraphList;
    protected $_name = [
        'hasNext' => 'hasNext',
        'nextToken' => 'nextToken',
        'paragraphList' => 'paragraphList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasNext) {
            $res['hasNext'] = $this->hasNext;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
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
     * @return QueryMinutesTextResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasNext'])) {
            $model->hasNext = $map['hasNext'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['paragraphList'])) {
            if (!empty($map['paragraphList'])) {
                $model->paragraphList = [];
                $n = 0;
                foreach ($map['paragraphList'] as $item) {
                    $model->paragraphList[$n++] = null !== $item ? paragraphList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
