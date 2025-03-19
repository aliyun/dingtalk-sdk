<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryFlashMinutesSummaryResponseBody\flashMinutesSummary;
use AlibabaCloud\Tea\Model;

class QueryFlashMinutesSummaryResponseBody extends Model
{
    /**
     * @var flashMinutesSummary
     */
    public $flashMinutesSummary;
    protected $_name = [
        'flashMinutesSummary' => 'flashMinutesSummary',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->flashMinutesSummary) {
            $res['flashMinutesSummary'] = null !== $this->flashMinutesSummary ? $this->flashMinutesSummary->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryFlashMinutesSummaryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['flashMinutesSummary'])) {
            $model->flashMinutesSummary = flashMinutesSummary::fromMap($map['flashMinutesSummary']);
        }

        return $model;
    }
}
