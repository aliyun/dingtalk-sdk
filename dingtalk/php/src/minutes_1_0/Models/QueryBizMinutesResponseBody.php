<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryBizMinutesResponseBody\minutesDetails;
use AlibabaCloud\Tea\Model;

class QueryBizMinutesResponseBody extends Model
{
    /**
     * @var minutesDetails[]
     */
    public $minutesDetails;
    protected $_name = [
        'minutesDetails' => 'minutesDetails',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->minutesDetails) {
            $res['minutesDetails'] = [];
            if (null !== $this->minutesDetails && \is_array($this->minutesDetails)) {
                $n = 0;
                foreach ($this->minutesDetails as $item) {
                    $res['minutesDetails'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBizMinutesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['minutesDetails'])) {
            if (!empty($map['minutesDetails'])) {
                $model->minutesDetails = [];
                $n = 0;
                foreach ($map['minutesDetails'] as $item) {
                    $model->minutesDetails[$n++] = null !== $item ? minutesDetails::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
