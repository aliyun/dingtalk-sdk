<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryExternalAuthControlledSheetsResponseBody\sheets;
use AlibabaCloud\Tea\Model;

class QueryExternalAuthControlledSheetsResponseBody extends Model
{
    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var sheets[]
     */
    public $sheets;
    protected $_name = [
        'hasMore' => 'hasMore',
        'nextToken' => 'nextToken',
        'sheets' => 'sheets',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->sheets) {
            $res['sheets'] = [];
            if (null !== $this->sheets && \is_array($this->sheets)) {
                $n = 0;
                foreach ($this->sheets as $item) {
                    $res['sheets'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryExternalAuthControlledSheetsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['sheets'])) {
            if (!empty($map['sheets'])) {
                $model->sheets = [];
                $n = 0;
                foreach ($map['sheets'] as $item) {
                    $model->sheets[$n++] = null !== $item ? sheets::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
