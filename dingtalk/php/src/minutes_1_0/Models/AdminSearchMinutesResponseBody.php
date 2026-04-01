<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\AdminSearchMinutesResponseBody\minutesList;
use AlibabaCloud\Tea\Model;

class AdminSearchMinutesResponseBody extends Model
{
    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var minutesList[]
     */
    public $minutesList;

    /**
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'hasMore' => 'hasMore',
        'minutesList' => 'minutesList',
        'nextToken' => 'nextToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->minutesList) {
            $res['minutesList'] = [];
            if (null !== $this->minutesList && \is_array($this->minutesList)) {
                $n = 0;
                foreach ($this->minutesList as $item) {
                    $res['minutesList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AdminSearchMinutesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['minutesList'])) {
            if (!empty($map['minutesList'])) {
                $model->minutesList = [];
                $n = 0;
                foreach ($map['minutesList'] as $item) {
                    $model->minutesList[$n++] = null !== $item ? minutesList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
