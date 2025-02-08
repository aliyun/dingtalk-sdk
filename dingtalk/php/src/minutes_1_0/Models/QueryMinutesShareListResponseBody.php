<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesShareListResponseBody\minutesDetails;
use AlibabaCloud\Tea\Model;

class QueryMinutesShareListResponseBody extends Model
{
    /**
     * @var bool
     */
    public $hasNext;

    /**
     * @var minutesDetails[]
     */
    public $minutesDetails;

    /**
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'hasNext'        => 'hasNext',
        'minutesDetails' => 'minutesDetails',
        'nextToken'      => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasNext) {
            $res['hasNext'] = $this->hasNext;
        }
        if (null !== $this->minutesDetails) {
            $res['minutesDetails'] = [];
            if (null !== $this->minutesDetails && \is_array($this->minutesDetails)) {
                $n = 0;
                foreach ($this->minutesDetails as $item) {
                    $res['minutesDetails'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return QueryMinutesShareListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasNext'])) {
            $model->hasNext = $map['hasNext'];
        }
        if (isset($map['minutesDetails'])) {
            if (!empty($map['minutesDetails'])) {
                $model->minutesDetails = [];
                $n                     = 0;
                foreach ($map['minutesDetails'] as $item) {
                    $model->minutesDetails[$n++] = null !== $item ? minutesDetails::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
